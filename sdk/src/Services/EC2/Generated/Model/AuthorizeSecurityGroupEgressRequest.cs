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
    /// Container for the parameters to the AuthorizeSecurityGroupEgress operation.
    /// [VPC only] Adds the specified egress rules to a security group for use with a VPC.
    /// 
    ///  
    /// <para>
    /// An outbound rule permits instances to send traffic to the specified IPv4 or IPv6 CIDR
    /// address ranges, or to the instances associated with the specified destination security
    /// groups.
    /// </para>
    ///  
    /// <para>
    /// You specify a protocol for each rule (for example, TCP). For the TCP and UDP protocols,
    /// you must also specify the destination port or port range. For the ICMP protocol, you
    /// must also specify the ICMP type and code. You can use -1 for the type or code to mean
    /// all types or all codes.
    /// </para>
    ///  
    /// <para>
    /// Rule changes are propagated to affected instances as quickly as possible. However,
    /// a small delay might occur.
    /// </para>
    ///  
    /// <para>
    /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
    /// VPC Limits</a>.
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