/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeSecurityGroupEgress operation.
    /// Adds one or more egress rules to a security group for use with a VPC. Specifically,
    /// this action permits instances to send traffic to one or more destination CIDR IP address
    /// ranges, or to one or more destination security groups for the same VPC.
    /// 
    ///  <important> 
    /// <para>
    /// You can have up to 50 rules per security group (covering both ingress and egress rules).
    /// </para>
    ///  </important> 
    /// <para>
    /// A security group is for use with instances either in the EC2-Classic platform or in
    /// a specific VPC. This action doesn't apply to security groups for use in EC2-Classic.
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
    /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Each rule consists of the protocol (for example, TCP), plus either a CIDR range or
    /// a source group. For the TCP and UDP protocols, you must also specify the destination
    /// port or port range. For the ICMP protocol, you must also specify the ICMP type and
    /// code. You can use -1 for the type or code to mean all types or all codes.
    /// </para>
    ///  
    /// <para>
    /// Rule changes are propagated to affected instances as quickly as possible. However,
    /// a small delay might occur.
    /// </para>
    /// </summary>
    public partial class AuthorizeSecurityGroupEgressRequest : AmazonEC2Request
    {
        private string _groupId;
        private List<IpPermission> _ipPermissions = new List<IpPermission>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
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
        /// A set of IP permissions. You can't specify a destination security group and a CIDR
        /// IP address range.
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