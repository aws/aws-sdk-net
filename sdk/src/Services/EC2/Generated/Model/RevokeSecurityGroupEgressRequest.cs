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
    /// [VPC only] Removes the specified egress rules from a security group for EC2-VPC. This
    /// action does not apply to security groups for use in EC2-Classic. To remove a rule,
    /// the values that you specify (for example, ports) must match the existing rule's values
    /// exactly.
    /// 
    ///  <note> 
    /// <para>
    /// [Default VPC] If the values you specify do not match the existing rule's values, no
    /// error is returned, and the output describes the security group rules that were not
    /// revoked. 
    /// </para>
    ///  
    /// <para>
    /// AWS recommends that you use <a>DescribeSecurityGroups</a> to verify that the rule
    /// has been removed.
    /// </para>
    ///  </note> 
    /// <para>
    /// Each rule consists of the protocol and the IPv4 or IPv6 CIDR range or source security
    /// group. For the TCP and UDP protocols, you must also specify the destination port or
    /// range of ports. For the ICMP protocol, you must also specify the ICMP type and code.
    /// If the security group rule has a description, you do not have to specify the description
    /// to revoke the rule.
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

    }
}