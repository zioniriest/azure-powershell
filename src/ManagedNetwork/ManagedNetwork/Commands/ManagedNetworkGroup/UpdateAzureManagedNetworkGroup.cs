﻿using System.Management.Automation;
using Microsoft.Azure.Commands.ManagedNetwork.Common;
using Microsoft.Azure.Commands.ManagedNetwork.Helpers;
using Microsoft.Azure.Management.ManagedNetwork;
using System.Linq;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.ManagedNetwork.Models;
using System.Collections.Generic;
using Microsoft.Azure.Commands.ManagedNetwork.Models;
using System.Resources;
using System.Collections;
using System;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.ManagedNetwork
{
    /// <summary>
    /// New Azure InputObject Command-let
    /// </summary>
    [Cmdlet(VerbsData.Update, "AzManagedNetworkGroup", SupportsShouldProcess = true)]
    [OutputType(typeof(PSManagedNetwork))]
    public class UpdateAzureManagedNetworkGroup : AzureManagedNetworkCmdletBase
    {
        /// <summary>
        /// Gets or sets The Resource Group name
        /// </summary>
        [Parameter(Position = 0,
            Mandatory = true,
            HelpMessage = Constants.ResourceGroupNameHelp,
            ParameterSetName = Constants.NameParameterSet)]
        [ValidateNotNullOrEmpty]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(Position = 1,
            Mandatory = true,
            HelpMessage = Constants.ManagedNetworkNameHelp,
            ParameterSetName = Constants.NameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string ManagedNetworkName { get; set; }

        [Parameter(Position = 1,
            Mandatory = true,
            HelpMessage = Constants.ManagedNetworkGroupNameHelp,
            ParameterSetName = Constants.NameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource ID
        /// </summary>
        [Parameter(Mandatory = true,
            HelpMessage = Constants.ResourceIdNameHelp,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.ResourceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource ID
        /// </summary>
        [Parameter(Mandatory = true,
            HelpMessage = Constants.ResourceIdNameHelp,
            ValueFromPipeline = true,
            ParameterSetName = Constants.InputObjectParameterSet)]
        [ValidateNotNullOrEmpty]
        public PSManagedNetworkGroup InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Azure ManagedNetwork Scope management group ids.")]
        public List<string> ManagementGroupIds { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Azure ManagedNetwork Scope subscription ids.")]
        public List<string> SubscriptionIds { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Azure ManagedNetwork Scope virtual network ids.")]
        public List<string> VirtualNetworkIds { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Azure ManagedNetwork Scope subnet ids.")]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        ///     The AsJob parameter to run in the background.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = Constants.ForceHelp)]
        public SwitchParameter Force { get; set; }

        /// <summary>
        ///     The AsJob parameter to run in the background.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = Constants.AsJobHelp)]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            if (string.Equals(
                this.ParameterSetName,
                Constants.ResourceIdParameterSet))
            {
                var resourceIdentifier = new ResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.ManagedNetworkName = resourceIdentifier.ParentResource;
                this.Name = resourceIdentifier.ResourceName;
            }
            else if (string.Equals(
                    this.ParameterSetName,
                    Constants.InputObjectParameterSet))
            {
                var resourceIdentifier = new ResourceIdentifier(this.InputObject.Id);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.ManagedNetworkName = resourceIdentifier.ParentResource;
                this.Name = resourceIdentifier.ResourceName;

                this.ManagementGroupIds = this.ManagementGroupIds ?? this.InputObject.ManagementGroups.Select(resource => resource.Id).ToList();
                this.SubscriptionIds = this.SubscriptionIds ?? this.InputObject.Subscriptions.Select(resource => resource.Id).ToList();
                this.VirtualNetworkIds = this.VirtualNetworkIds ?? this.InputObject.VirtualNetworks.Select(resource => resource.Id).ToList();
                this.SubnetIds = this.SubnetIds ?? this.InputObject.Subnets.Select(resource => resource.Id).ToList();
            }

            var present = IsManagedNetworkPeeringPolicyPresent(ResourceGroupName, ManagedNetworkName, Name);
            if(!present)
            {
                throw new Exception(string.Format(Constants.ManagedNetworkGroupDoesNotExist, this.Name, this.ManagedNetworkName, this.ResourceGroupName));
            }
            ConfirmAction(
                Force.IsPresent,
                string.Format(Constants.ConfirmOverwriteResource, Name),
                Constants.UpdatingResource,
                Name,
                () =>
                {
                    PSManagedNetworkGroup managedNetworkGroup = UpdateManagedNetworkGroup();
                    WriteObject(managedNetworkGroup);
                },
                () => present);
        }

        private PSManagedNetworkGroup UpdateManagedNetworkGroup()
        {
            var sdkManagedNetworkGroup = this.ManagedNetworkManagementClient.ManagedNetworkGroups.Get(this.ResourceGroupName, this.ManagedNetworkName, this.Name);
            var psManagedNetworkGroup = ManagedNetworkResourceManagerProfile.Mapper.Map<PSManagedNetworkGroup>(sdkManagedNetworkGroup);

            if (this.ManagementGroupIds != null)
            {
                psManagedNetworkGroup.ManagementGroups = this.ManagementGroupIds.Select(id => new PSResourceId() { Id = id }).ToList();
            }

            if (this.SubscriptionIds != null)
            {
                psManagedNetworkGroup.Subscriptions = this.SubscriptionIds.Select(id => new PSResourceId() { Id = id }).ToList();
            }

            if (this.VirtualNetworkIds != null)
            {
                psManagedNetworkGroup.VirtualNetworks = this.VirtualNetworkIds.Select(id => new PSResourceId() { Id = id }).ToList();
            }

            if (this.SubscriptionIds != null)
            {
                psManagedNetworkGroup.Subnets = this.SubnetIds.Select(id => new PSResourceId() { Id = id }).ToList();
            }

            sdkManagedNetworkGroup = ManagedNetworkResourceManagerProfile.Mapper.Map<ManagedNetworkGroup>(psManagedNetworkGroup);
            var putSdkResponse = this.ManagedNetworkManagementClient.ManagedNetworkGroups.CreateOrUpdate(sdkManagedNetworkGroup, this.ResourceGroupName, this.ManagedNetworkName, this.Name);
            var putPSResponse = ManagedNetworkResourceManagerProfile.Mapper.Map<PSManagedNetworkGroup>(putSdkResponse);
            return putPSResponse;
        }
    }
}
