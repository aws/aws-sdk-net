/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail based on resource type.
    /// </summary>
    public partial class ResourceViolation
    {
        /// <summary>
        /// Gets and sets the property AwsEc2InstanceViolation. 
        /// <para>
        /// Violation detail for an EC2 instance.
        /// </para>
        /// </summary>
        public AwsEc2InstanceViolation AwsEc2InstanceViolation { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2InstanceViolation property is set.
        /// </summary>
        internal bool IsSetAwsEc2InstanceViolation() => this.AwsEc2InstanceViolation != null;

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterfaceViolation. 
        /// <para>
        /// Violation detail for a network interface.
        /// </para>
        /// </summary>
        public AwsEc2NetworkInterfaceViolation AwsEc2NetworkInterfaceViolation { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2NetworkInterfaceViolation property is set.
        /// </summary>
        internal bool IsSetAwsEc2NetworkInterfaceViolation() => this.AwsEc2NetworkInterfaceViolation != null;

        /// <summary>
        /// Gets and sets the property AwsVPCSecurityGroupViolation. 
        /// <para>
        /// Violation detail for security groups.
        /// </para>
        /// </summary>
        public AwsVPCSecurityGroupViolation AwsVPCSecurityGroupViolation { get; set; }

        /// <summary>
        /// Checks to see if the AwsVPCSecurityGroupViolation property is set.
        /// </summary>
        internal bool IsSetAwsVPCSecurityGroupViolation() => this.AwsVPCSecurityGroupViolation != null;

        /// <summary>
        /// Gets and sets the property DnsDuplicateRuleGroupViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that a rule group that Firewall
        /// Manager tried to associate with a VPC is already associated with the VPC and can't
        /// be associated again. 
        /// </para>
        /// </summary>
        public DnsDuplicateRuleGroupViolation DnsDuplicateRuleGroupViolation { get; set; }

        /// <summary>
        /// Checks to see if the DnsDuplicateRuleGroupViolation property is set.
        /// </summary>
        internal bool IsSetDnsDuplicateRuleGroupViolation() => this.DnsDuplicateRuleGroupViolation != null;

        /// <summary>
        /// Gets and sets the property DnsRuleGroupLimitExceededViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that the VPC reached the
        /// limit for associated DNS Firewall rule groups. Firewall Manager tried to associate
        /// another rule group with the VPC and failed. 
        /// </para>
        /// </summary>
        public DnsRuleGroupLimitExceededViolation DnsRuleGroupLimitExceededViolation { get; set; }

        /// <summary>
        /// Checks to see if the DnsRuleGroupLimitExceededViolation property is set.
        /// </summary>
        internal bool IsSetDnsRuleGroupLimitExceededViolation() => this.DnsRuleGroupLimitExceededViolation != null;

        /// <summary>
        /// Gets and sets the property DnsRuleGroupPriorityConflictViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that a rule group that Firewall
        /// Manager tried to associate with a VPC has the same priority as a rule group that's
        /// already associated. 
        /// </para>
        /// </summary>
        public DnsRuleGroupPriorityConflictViolation DnsRuleGroupPriorityConflictViolation { get; set; }

        /// <summary>
        /// Checks to see if the DnsRuleGroupPriorityConflictViolation property is set.
        /// </summary>
        internal bool IsSetDnsRuleGroupPriorityConflictViolation() => this.DnsRuleGroupPriorityConflictViolation != null;

        /// <summary>
        /// Gets and sets the property FirewallSubnetIsOutOfScopeViolation. 
        /// <para>
        /// Contains details about the firewall subnet that violates the policy scope.
        /// </para>
        /// </summary>
        public FirewallSubnetIsOutOfScopeViolation FirewallSubnetIsOutOfScopeViolation { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetIsOutOfScopeViolation property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetIsOutOfScopeViolation() => this.FirewallSubnetIsOutOfScopeViolation != null;

        /// <summary>
        /// Gets and sets the property FirewallSubnetMissingVPCEndpointViolation. 
        /// <para>
        /// The violation details for a third-party firewall's VPC endpoint subnet that was deleted.
        /// </para>
        /// </summary>
        public FirewallSubnetMissingVPCEndpointViolation FirewallSubnetMissingVPCEndpointViolation { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetMissingVPCEndpointViolation property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetMissingVPCEndpointViolation() => this.FirewallSubnetMissingVPCEndpointViolation != null;

        /// <summary>
        /// Gets and sets the property InvalidNetworkAclEntriesViolation. 
        /// <para>
        /// Violation detail for the entries in a network ACL resource.
        /// </para>
        /// </summary>
        public InvalidNetworkAclEntriesViolation InvalidNetworkAclEntriesViolation { get; set; }

        /// <summary>
        /// Checks to see if the InvalidNetworkAclEntriesViolation property is set.
        /// </summary>
        internal bool IsSetInvalidNetworkAclEntriesViolation() => this.InvalidNetworkAclEntriesViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallBlackHoleRouteDetectedViolation.
        /// </summary>
        public NetworkFirewallBlackHoleRouteDetectedViolation NetworkFirewallBlackHoleRouteDetectedViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallBlackHoleRouteDetectedViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallBlackHoleRouteDetectedViolation() => this.NetworkFirewallBlackHoleRouteDetectedViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallInternetTrafficNotInspectedViolation. 
        /// <para>
        /// Violation detail for the subnet for which internet traffic hasn't been inspected.
        /// </para>
        /// </summary>
        public NetworkFirewallInternetTrafficNotInspectedViolation NetworkFirewallInternetTrafficNotInspectedViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallInternetTrafficNotInspectedViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallInternetTrafficNotInspectedViolation() => this.NetworkFirewallInternetTrafficNotInspectedViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallInvalidRouteConfigurationViolation. 
        /// <para>
        /// The route configuration is invalid.
        /// </para>
        /// </summary>
        public NetworkFirewallInvalidRouteConfigurationViolation NetworkFirewallInvalidRouteConfigurationViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallInvalidRouteConfigurationViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallInvalidRouteConfigurationViolation() => this.NetworkFirewallInvalidRouteConfigurationViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingExpectedRTViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a subnet is not
        /// associated with the expected Firewall Manager managed route table. 
        /// </para>
        /// </summary>
        public NetworkFirewallMissingExpectedRTViolation NetworkFirewallMissingExpectedRTViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallMissingExpectedRTViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallMissingExpectedRTViolation() => this.NetworkFirewallMissingExpectedRTViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingExpectedRoutesViolation. 
        /// <para>
        /// Expected routes are missing from Network Firewall.
        /// </para>
        /// </summary>
        public NetworkFirewallMissingExpectedRoutesViolation NetworkFirewallMissingExpectedRoutesViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallMissingExpectedRoutesViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallMissingExpectedRoutesViolation() => this.NetworkFirewallMissingExpectedRoutesViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingFirewallViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a subnet has no
        /// Firewall Manager managed firewall in its VPC. 
        /// </para>
        /// </summary>
        public NetworkFirewallMissingFirewallViolation NetworkFirewallMissingFirewallViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallMissingFirewallViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallMissingFirewallViolation() => this.NetworkFirewallMissingFirewallViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingSubnetViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that an Availability
        /// Zone is missing the expected Firewall Manager managed subnet.
        /// </para>
        /// </summary>
        public NetworkFirewallMissingSubnetViolation NetworkFirewallMissingSubnetViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallMissingSubnetViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallMissingSubnetViolation() => this.NetworkFirewallMissingSubnetViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallPolicyModifiedViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a firewall policy
        /// in an individual account has been modified in a way that makes it noncompliant. For
        /// example, the individual account owner might have deleted a rule group, changed the
        /// priority of a stateless rule group, or changed a policy default action.
        /// </para>
        /// </summary>
        public NetworkFirewallPolicyModifiedViolation NetworkFirewallPolicyModifiedViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallPolicyModifiedViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallPolicyModifiedViolation() => this.NetworkFirewallPolicyModifiedViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallUnexpectedFirewallRoutesViolation. 
        /// <para>
        /// There's an unexpected firewall route.
        /// </para>
        /// </summary>
        public NetworkFirewallUnexpectedFirewallRoutesViolation NetworkFirewallUnexpectedFirewallRoutesViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallUnexpectedFirewallRoutesViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallUnexpectedFirewallRoutesViolation() => this.NetworkFirewallUnexpectedFirewallRoutesViolation != null;

        /// <summary>
        /// Gets and sets the property NetworkFirewallUnexpectedGatewayRoutesViolation. 
        /// <para>
        /// There's an unexpected gateway route.
        /// </para>
        /// </summary>
        public NetworkFirewallUnexpectedGatewayRoutesViolation NetworkFirewallUnexpectedGatewayRoutesViolation { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFirewallUnexpectedGatewayRoutesViolation property is set.
        /// </summary>
        internal bool IsSetNetworkFirewallUnexpectedGatewayRoutesViolation() => this.NetworkFirewallUnexpectedGatewayRoutesViolation != null;

        /// <summary>
        /// Gets and sets the property PossibleRemediationActions. 
        /// <para>
        /// A list of possible remediation action lists. Each individual possible remediation
        /// action is a list of individual remediation actions.
        /// </para>
        /// </summary>
        public PossibleRemediationActions PossibleRemediationActions { get; set; }

        /// <summary>
        /// Checks to see if the PossibleRemediationActions property is set.
        /// </summary>
        internal bool IsSetPossibleRemediationActions() => this.PossibleRemediationActions != null;

        /// <summary>
        /// Gets and sets the property RouteHasOutOfScopeEndpointViolation. 
        /// <para>
        /// Contains details about the route endpoint that violates the policy scope.
        /// </para>
        /// </summary>
        public RouteHasOutOfScopeEndpointViolation RouteHasOutOfScopeEndpointViolation { get; set; }

        /// <summary>
        /// Checks to see if the RouteHasOutOfScopeEndpointViolation property is set.
        /// </summary>
        internal bool IsSetRouteHasOutOfScopeEndpointViolation() => this.RouteHasOutOfScopeEndpointViolation != null;

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallMissingExpectedRouteTableViolation. 
        /// <para>
        /// The violation details for a third-party firewall that has the Firewall Manager managed
        /// route table that was associated with the third-party firewall has been deleted.
        /// </para>
        /// </summary>
        public ThirdPartyFirewallMissingExpectedRouteTableViolation ThirdPartyFirewallMissingExpectedRouteTableViolation { get; set; }

        /// <summary>
        /// Checks to see if the ThirdPartyFirewallMissingExpectedRouteTableViolation property is set.
        /// </summary>
        internal bool IsSetThirdPartyFirewallMissingExpectedRouteTableViolation() => this.ThirdPartyFirewallMissingExpectedRouteTableViolation != null;

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallMissingFirewallViolation. 
        /// <para>
        /// The violation details for a third-party firewall that's been deleted.
        /// </para>
        /// </summary>
        public ThirdPartyFirewallMissingFirewallViolation ThirdPartyFirewallMissingFirewallViolation { get; set; }

        /// <summary>
        /// Checks to see if the ThirdPartyFirewallMissingFirewallViolation property is set.
        /// </summary>
        internal bool IsSetThirdPartyFirewallMissingFirewallViolation() => this.ThirdPartyFirewallMissingFirewallViolation != null;

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallMissingSubnetViolation. 
        /// <para>
        /// The violation details for a third-party firewall's subnet that's been deleted.
        /// </para>
        /// </summary>
        public ThirdPartyFirewallMissingSubnetViolation ThirdPartyFirewallMissingSubnetViolation { get; set; }

        /// <summary>
        /// Checks to see if the ThirdPartyFirewallMissingSubnetViolation property is set.
        /// </summary>
        internal bool IsSetThirdPartyFirewallMissingSubnetViolation() => this.ThirdPartyFirewallMissingSubnetViolation != null;

        /// <summary>
        /// Gets and sets the property WebACLHasIncompatibleConfigurationViolation. 
        /// <para>
        /// The violation details for a web ACL whose configuration is incompatible with the Firewall
        /// Manager policy. 
        /// </para>
        /// </summary>
        public WebACLHasIncompatibleConfigurationViolation WebACLHasIncompatibleConfigurationViolation { get; set; }

        /// <summary>
        /// Checks to see if the WebACLHasIncompatibleConfigurationViolation property is set.
        /// </summary>
        internal bool IsSetWebACLHasIncompatibleConfigurationViolation() => this.WebACLHasIncompatibleConfigurationViolation != null;

        /// <summary>
        /// Gets and sets the property WebACLHasOutOfScopeResourcesViolation. 
        /// <para>
        /// The violation details for a web ACL that's associated with at least one resource that's
        /// out of scope of the Firewall Manager policy. 
        /// </para>
        /// </summary>
        public WebACLHasOutOfScopeResourcesViolation WebACLHasOutOfScopeResourcesViolation { get; set; }

        /// <summary>
        /// Checks to see if the WebACLHasOutOfScopeResourcesViolation property is set.
        /// </summary>
        internal bool IsSetWebACLHasOutOfScopeResourcesViolation() => this.WebACLHasOutOfScopeResourcesViolation != null;
    }
}
