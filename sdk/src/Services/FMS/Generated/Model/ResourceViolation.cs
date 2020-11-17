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
        private NetworkFirewallMissingExpectedRTViolation _networkFirewallMissingExpectedRTViolation;
        private NetworkFirewallMissingFirewallViolation _networkFirewallMissingFirewallViolation;
        private NetworkFirewallMissingSubnetViolation _networkFirewallMissingSubnetViolation;
        private NetworkFirewallPolicyModifiedViolation _networkFirewallPolicyModifiedViolation;

        /// <summary>
        /// Gets and sets the property AwsEc2InstanceViolation. 
        /// <para>
        /// Violation details for an EC2 instance.
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
        /// Violation details for network interface.
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
        /// Violation details for security groups.
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

    }
}