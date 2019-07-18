---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/set-azloadbalancerinboundnatrule
schema: 2.0.0
---

# Set-AzLoadBalancerInboundNatRule

## SYNOPSIS
Creates or updates a load balancer inbound nat rule.

## SYNTAX

### Update1 (Default)
```
Set-AzLoadBalancerInboundNatRule -LoadBalancerName <String> -Name <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-InboundNatRuleParameter <IInboundNatRule>] [-DefaultProfile <PSObject>] [-AsJob]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Set-AzLoadBalancerInboundNatRule -LoadBalancerName <String> -Name <String> -ResourceGroupName <String>
 -SubscriptionId <String> -InboundNatRuleName <String>
 [-ApplicationGatewayBackendAddressPool <IApplicationGatewayBackendAddressPool[]>]
 [-ApplicationSecurityGroup <IApplicationSecurityGroup[]>] [-BackendIPConfigurationEtag <String>]
 [-BackendIPConfigurationId <String>] [-BackendIPConfigurationName <String>]
 [-BackendIPConfigurationPropertiesProvisioningState <String>] [-BackendPort <Int32>] [-EnableFloatingIP]
 [-Etag <String>] [-FrontendIPConfigurationId <String>] [-FrontendPort <Int32>] [-Id <String>]
 [-IdleTimeoutInMinutes <Int32>] [-LoadBalancerBackendAddressPool <IBackendAddressPool[]>]
 [-LoadBalancerInboundNatRule <IInboundNatRule[]>] [-Primary] [-PrivateIPAddress <String>]
 [-PrivateIPAddressVersion <IPVersion>] [-PrivateIPAllocationMethod <IPAllocationMethod>]
 [-Protocol <TransportProtocol>] [-ProvisioningState <String>] [-PublicIPAddress <IPublicIPAddress>]
 [-Subnet <ISubnet>] [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a load balancer inbound nat rule.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ApplicationGatewayBackendAddressPool
The reference of ApplicationGatewayBackendAddressPool resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IApplicationGatewayBackendAddressPool[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApplicationSecurityGroup
Application security groups in which the IP configuration is included.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IApplicationSecurityGroup[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendIPConfigurationEtag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendIPConfigurationId
Resource ID.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendIPConfigurationName
The name of the resource that is unique within a resource group.
This name can be used to access the resource.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendIPConfigurationPropertiesProvisioningState
The provisioning state of the network interface IP configuration.
Possible values are: 'Updating', 'Deleting', and 'Failed'.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendPort
The port used for the internal endpoint.
Acceptable values range from 1 to 65535.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EnableFloatingIP
Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group.
This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
This setting can't be changed after you create the endpoint.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Etag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FrontendIPConfigurationId
Resource ID.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FrontendPort
The port for the external endpoint.
Port numbers for each rule must be unique within the Load Balancer.
Acceptable values range from 1 to 65534.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IdleTimeoutInMinutes
The timeout for the TCP idle connection.
The value can be set between 4 and 30 minutes.
The default value is 4 minutes.
This element is only used when the protocol is set to TCP.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InboundNatRuleName
The name of the inbound nat rule.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InboundNatRuleParameter
Inbound NAT rule of the load balancer.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatRule
Parameter Sets: Update1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LoadBalancerBackendAddressPool
The reference of LoadBalancerBackendAddressPool resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IBackendAddressPool[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LoadBalancerInboundNatRule
A list of references of LoadBalancerInboundNatRules.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatRule[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LoadBalancerName
The name of the load balancer.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the inbound nat rule.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Primary
Gets whether this is a primary customer address on the network interface.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PrivateIPAddress
Private IP address of the IP configuration.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PrivateIPAddressVersion
Available from Api-Version 2016-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6.
Default is taken as IPv4.
Possible values are: 'IPv4' and 'IPv6'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IPVersion
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PrivateIPAllocationMethod
Defines how a private IP address is assigned.
Possible values are: 'Static' and 'Dynamic'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IPAllocationMethod
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Protocol
The transport protocol for the endpoint.
Possible values are 'Udp' or 'Tcp' or 'All'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.TransportProtocol
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
Gets the provisioning state of the public IP resource.
Possible values are: 'Updating', 'Deleting', and 'Failed'.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublicIPAddress
Public IP address bound to the IP configuration.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IPublicIPAddress
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Subnet
Subnet bound to the IP configuration.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ISubnet
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatRule

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatRule

## ALIASES

## RELATED LINKS
