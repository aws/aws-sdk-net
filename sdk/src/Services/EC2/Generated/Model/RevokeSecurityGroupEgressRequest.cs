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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeSecurityGroupEgress operation.
    /// Removes the specified outbound (egress) rules from the specified security group.
    /// 
    ///  
    /// <para>
    /// You can specify rules using either rule IDs or security group rule properties. If
    /// you use rule properties, the values that you specify (for example, ports) must match
    /// the existing rule's values exactly. Each rule has a protocol, from and to ports, and
    /// destination (CIDR range, security group, or prefix list). For the TCP and UDP protocols,
    /// you must also specify the destination port or range of ports. For the ICMP protocol,
    /// you must also specify the ICMP type and code. If the security group rule has a description,
    /// you do not need to specify the description to revoke the rule.
    /// </para>
    ///  
    /// <para>
    /// For a default VPC, if the values you specify do not match the existing rule's values,
    /// no error is returned, and the output describes the security group rules that were
    /// not revoked.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services recommends that you describe the security group to verify that
    /// the rules were removed.
    /// </para>
    ///  
    /// <para>
    /// Rule changes are propagated to instances within the security group as quickly as possible.
    /// However, a small delay might occur.
    /// </para>
    /// </summary>
    public partial class RevokeSecurityGroupEgressRequest : AmazonEC2Request
    {
        private string _groupId;
        private List<IpPermission> _ipPermissions = new List<IpPermission>();
        private List<string> _securityGroupRuleIds = new List<string>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// The sets of IP permissions. You can't specify a destination security group and a CIDR
        /// IP address range in the same set of permissions.
        /// </para>
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this._ipPermissions; }
            set { this._ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this._ipPermissions != null && this._ipPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleIds. 
        /// <para>
        /// The IDs of the security group rules.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupRuleIds
        {
            get { return this._securityGroupRuleIds; }
            set { this._securityGroupRuleIds = value; }
        }

        // Check to see if SecurityGroupRuleIds property is set
        internal bool IsSetSecurityGroupRuleIds()
        {
            return this._securityGroupRuleIds != null && this._securityGroupRuleIds.Count > 0; 
        }

    }
}