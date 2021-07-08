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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail based on resource type.
    /// </summary>
    public partial class ResourceViolation
    {
        private AwsEc2InstanceViolation _awsEc2InstanceViolation;
        private AwsEc2NetworkInterfaceViolation _awsEc2NetworkInterfaceViolation;
        private AwsVPCSecurityGroupViolation _awsVPCSecurityGroupViolation;
        private DnsDuplicateRuleGroupViolation _dnsDuplicateRuleGroupViolation;
        private DnsRuleGroupLimitExceededViolation _dnsRuleGroupLimitExceededViolation;
        private DnsRuleGroupPriorityConflictViolation _dnsRuleGroupPriorityConflictViolation;
        private NetworkFirewallBlackHoleRouteDetectedViolation _networkFirewallBlackHoleRouteDetectedViolation;
        private NetworkFirewallInternetTrafficNotInspectedViolation _networkFirewallInternetTrafficNotInspectedViolation;
        private NetworkFirewallInvalidRouteConfigurationViolation _networkFirewallInvalidRouteConfigurationViolation;
        private NetworkFirewallMissingExpectedRoutesViolation _networkFirewallMissingExpectedRoutesViolation;
        private NetworkFirewallMissingExpectedRTViolation _networkFirewallMissingExpectedRTViolation;
        private NetworkFirewallMissingFirewallViolation _networkFirewallMissingFirewallViolation;
        private NetworkFirewallMissingSubnetViolation _networkFirewallMissingSubnetViolation;
        private NetworkFirewallPolicyModifiedViolation _networkFirewallPolicyModifiedViolation;
        private NetworkFirewallUnexpectedFirewallRoutesViolation _networkFirewallUnexpectedFirewallRoutesViolation;
        private NetworkFirewallUnexpectedGatewayRoutesViolation _networkFirewallUnexpectedGatewayRoutesViolation;
        private PossibleRemediationActions _possibleRemediationActions;

        /// <summary>
        /// Gets and sets the property AwsEc2InstanceViolation. 
        /// <para>
        /// Violation detail for an EC2 instance.
        /// </para>
        /// </summary>
        public AwsEc2InstanceViolation AwsEc2InstanceViolation
        {
            get { return this._awsEc2InstanceViolation; }
            set { this._awsEc2InstanceViolation = value; }
        }

        // Check to see if AwsEc2InstanceViolation property is set
        internal bool IsSetAwsEc2InstanceViolation()
        {
            return this._awsEc2InstanceViolation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterfaceViolation. 
        /// <para>
        /// Violation detail for a network interface.
        /// </para>
        /// </summary>
        public AwsEc2NetworkInterfaceViolation AwsEc2NetworkInterfaceViolation
        {
            get { return this._awsEc2NetworkInterfaceViolation; }
            set { this._awsEc2NetworkInterfaceViolation = value; }
        }

        // Check to see if AwsEc2NetworkInterfaceViolation property is set
        internal bool IsSetAwsEc2NetworkInterfaceViolation()
        {
            return this._awsEc2NetworkInterfaceViolation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsVPCSecurityGroupViolation. 
        /// <para>
        /// Violation detail for security groups.
        /// </para>
        /// </summary>
        public AwsVPCSecurityGroupViolation AwsVPCSecurityGroupViolation
        {
            get { return this._awsVPCSecurityGroupViolation; }
            set { this._awsVPCSecurityGroupViolation = value; }
        }

        // Check to see if AwsVPCSecurityGroupViolation property is set
        internal bool IsSetAwsVPCSecurityGroupViolation()
        {
            return this._awsVPCSecurityGroupViolation != null;
        }

        /// <summary>
        /// Gets and sets the property DnsDuplicateRuleGroupViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that a rule group that Firewall
        /// Manager tried to associate with a VPC is already associated with the VPC and can't
        /// be associated again. 
        /// </para>
        /// </summary>
        public DnsDuplicateRuleGroupViolation DnsDuplicateRuleGroupViolation
        {
            get { return this._dnsDuplicateRuleGroupViolation; }
            set { this._dnsDuplicateRuleGroupViolation = value; }
        }

        // Check to see if DnsDuplicateRuleGroupViolation property is set
        internal bool IsSetDnsDuplicateRuleGroupViolation()
        {
            return this._dnsDuplicateRuleGroupViolation != null;
        }

        /// <summary>
        /// Gets and sets the property DnsRuleGroupLimitExceededViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that the VPC reached the
        /// limit for associated DNS Firewall rule groups. Firewall Manager tried to associate
        /// another rule group with the VPC and failed. 
        /// </para>
        /// </summary>
        public DnsRuleGroupLimitExceededViolation DnsRuleGroupLimitExceededViolation
        {
            get { return this._dnsRuleGroupLimitExceededViolation; }
            set { this._dnsRuleGroupLimitExceededViolation = value; }
        }

        // Check to see if DnsRuleGroupLimitExceededViolation property is set
        internal bool IsSetDnsRuleGroupLimitExceededViolation()
        {
            return this._dnsRuleGroupLimitExceededViolation != null;
        }

        /// <summary>
        /// Gets and sets the property DnsRuleGroupPriorityConflictViolation. 
        /// <para>
        /// Violation detail for a DNS Firewall policy that indicates that a rule group that Firewall
        /// Manager tried to associate with a VPC has the same priority as a rule group that's
        /// already associated. 
        /// </para>
        /// </summary>
        public DnsRuleGroupPriorityConflictViolation DnsRuleGroupPriorityConflictViolation
        {
            get { return this._dnsRuleGroupPriorityConflictViolation; }
            set { this._dnsRuleGroupPriorityConflictViolation = value; }
        }

        // Check to see if DnsRuleGroupPriorityConflictViolation property is set
        internal bool IsSetDnsRuleGroupPriorityConflictViolation()
        {
            return this._dnsRuleGroupPriorityConflictViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallBlackHoleRouteDetectedViolation.
        /// </summary>
        public NetworkFirewallBlackHoleRouteDetectedViolation NetworkFirewallBlackHoleRouteDetectedViolation
        {
            get { return this._networkFirewallBlackHoleRouteDetectedViolation; }
            set { this._networkFirewallBlackHoleRouteDetectedViolation = value; }
        }

        // Check to see if NetworkFirewallBlackHoleRouteDetectedViolation property is set
        internal bool IsSetNetworkFirewallBlackHoleRouteDetectedViolation()
        {
            return this._networkFirewallBlackHoleRouteDetectedViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallInternetTrafficNotInspectedViolation. 
        /// <para>
        /// Violation detail for the subnet for which internet traffic hasn't been inspected.
        /// </para>
        /// </summary>
        public NetworkFirewallInternetTrafficNotInspectedViolation NetworkFirewallInternetTrafficNotInspectedViolation
        {
            get { return this._networkFirewallInternetTrafficNotInspectedViolation; }
            set { this._networkFirewallInternetTrafficNotInspectedViolation = value; }
        }

        // Check to see if NetworkFirewallInternetTrafficNotInspectedViolation property is set
        internal bool IsSetNetworkFirewallInternetTrafficNotInspectedViolation()
        {
            return this._networkFirewallInternetTrafficNotInspectedViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallInvalidRouteConfigurationViolation. 
        /// <para>
        /// The route configuration is invalid.
        /// </para>
        /// </summary>
        public NetworkFirewallInvalidRouteConfigurationViolation NetworkFirewallInvalidRouteConfigurationViolation
        {
            get { return this._networkFirewallInvalidRouteConfigurationViolation; }
            set { this._networkFirewallInvalidRouteConfigurationViolation = value; }
        }

        // Check to see if NetworkFirewallInvalidRouteConfigurationViolation property is set
        internal bool IsSetNetworkFirewallInvalidRouteConfigurationViolation()
        {
            return this._networkFirewallInvalidRouteConfigurationViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingExpectedRoutesViolation. 
        /// <para>
        /// Expected routes are missing from Network Firewall.
        /// </para>
        /// </summary>
        public NetworkFirewallMissingExpectedRoutesViolation NetworkFirewallMissingExpectedRoutesViolation
        {
            get { return this._networkFirewallMissingExpectedRoutesViolation; }
            set { this._networkFirewallMissingExpectedRoutesViolation = value; }
        }

        // Check to see if NetworkFirewallMissingExpectedRoutesViolation property is set
        internal bool IsSetNetworkFirewallMissingExpectedRoutesViolation()
        {
            return this._networkFirewallMissingExpectedRoutesViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingExpectedRTViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a subnet is not
        /// associated with the expected Firewall Manager managed route table. 
        /// </para>
        /// </summary>
        public NetworkFirewallMissingExpectedRTViolation NetworkFirewallMissingExpectedRTViolation
        {
            get { return this._networkFirewallMissingExpectedRTViolation; }
            set { this._networkFirewallMissingExpectedRTViolation = value; }
        }

        // Check to see if NetworkFirewallMissingExpectedRTViolation property is set
        internal bool IsSetNetworkFirewallMissingExpectedRTViolation()
        {
            return this._networkFirewallMissingExpectedRTViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingFirewallViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a subnet has no
        /// Firewall Manager managed firewall in its VPC. 
        /// </para>
        /// </summary>
        public NetworkFirewallMissingFirewallViolation NetworkFirewallMissingFirewallViolation
        {
            get { return this._networkFirewallMissingFirewallViolation; }
            set { this._networkFirewallMissingFirewallViolation = value; }
        }

        // Check to see if NetworkFirewallMissingFirewallViolation property is set
        internal bool IsSetNetworkFirewallMissingFirewallViolation()
        {
            return this._networkFirewallMissingFirewallViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallMissingSubnetViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that an Availability
        /// Zone is missing the expected Firewall Manager managed subnet.
        /// </para>
        /// </summary>
        public NetworkFirewallMissingSubnetViolation NetworkFirewallMissingSubnetViolation
        {
            get { return this._networkFirewallMissingSubnetViolation; }
            set { this._networkFirewallMissingSubnetViolation = value; }
        }

        // Check to see if NetworkFirewallMissingSubnetViolation property is set
        internal bool IsSetNetworkFirewallMissingSubnetViolation()
        {
            return this._networkFirewallMissingSubnetViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallPolicyModifiedViolation. 
        /// <para>
        /// Violation detail for an Network Firewall policy that indicates that a firewall policy
        /// in an individual account has been modified in a way that makes it noncompliant. For
        /// example, the individual account owner might have deleted a rule group, changed the
        /// priority of a stateless rule group, or changed a policy default action.
        /// </para>
        /// </summary>
        public NetworkFirewallPolicyModifiedViolation NetworkFirewallPolicyModifiedViolation
        {
            get { return this._networkFirewallPolicyModifiedViolation; }
            set { this._networkFirewallPolicyModifiedViolation = value; }
        }

        // Check to see if NetworkFirewallPolicyModifiedViolation property is set
        internal bool IsSetNetworkFirewallPolicyModifiedViolation()
        {
            return this._networkFirewallPolicyModifiedViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallUnexpectedFirewallRoutesViolation. 
        /// <para>
        /// There's an unexpected firewall route.
        /// </para>
        /// </summary>
        public NetworkFirewallUnexpectedFirewallRoutesViolation NetworkFirewallUnexpectedFirewallRoutesViolation
        {
            get { return this._networkFirewallUnexpectedFirewallRoutesViolation; }
            set { this._networkFirewallUnexpectedFirewallRoutesViolation = value; }
        }

        // Check to see if NetworkFirewallUnexpectedFirewallRoutesViolation property is set
        internal bool IsSetNetworkFirewallUnexpectedFirewallRoutesViolation()
        {
            return this._networkFirewallUnexpectedFirewallRoutesViolation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFirewallUnexpectedGatewayRoutesViolation. 
        /// <para>
        /// There's an unexpected gateway route.
        /// </para>
        /// </summary>
        public NetworkFirewallUnexpectedGatewayRoutesViolation NetworkFirewallUnexpectedGatewayRoutesViolation
        {
            get { return this._networkFirewallUnexpectedGatewayRoutesViolation; }
            set { this._networkFirewallUnexpectedGatewayRoutesViolation = value; }
        }

        // Check to see if NetworkFirewallUnexpectedGatewayRoutesViolation property is set
        internal bool IsSetNetworkFirewallUnexpectedGatewayRoutesViolation()
        {
            return this._networkFirewallUnexpectedGatewayRoutesViolation != null;
        }

        /// <summary>
        /// Gets and sets the property PossibleRemediationActions. 
        /// <para>
        /// A list of possible remediation action lists. Each individual possible remediation
        /// action is a list of individual remediation actions.
        /// </para>
        /// </summary>
        public PossibleRemediationActions PossibleRemediationActions
        {
            get { return this._possibleRemediationActions; }
            set { this._possibleRemediationActions = value; }
        }

        // Check to see if PossibleRemediationActions property is set
        internal bool IsSetPossibleRemediationActions()
        {
            return this._possibleRemediationActions != null;
        }

    }
}