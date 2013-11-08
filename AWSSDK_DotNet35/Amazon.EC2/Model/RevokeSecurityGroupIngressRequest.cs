/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the RevokeSecurityGroupIngress operation.
    /// <para> The RevokeSecurityGroupIngress operation revokes permissions from a security group. The permissions used to revoke must be specified
    /// using the same values used to grant the permissions. </para> <para> Permissions are specified by IP protocol (TCP, UDP, or ICMP), the source
    /// of the request (by IP range or an Amazon EC2 user-group pair), the source and destination port ranges (for TCP and UDP), and the ICMP codes
    /// and types (for ICMP). </para> <para> Permission changes are quickly propagated to instances within the security group. However, depending on
    /// the number of instances in the group, a small delay might occur. </para>
    /// </summary>
    public partial class RevokeSecurityGroupIngressRequest : AmazonEC2Request
    {
        private string groupName;
        private string groupId;
        private List<IpPermission> ipPermissions = new List<IpPermission>();


        /// <summary>
        /// Name of the standard (EC2) security group to modify. The group must belong to your account. Can be used instead of GroupID for standard
        /// (EC2) security groups.
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }

        /// <summary>
        /// ID of the standard (EC2) or VPC security group to modify. The group must belong to your account. Required for VPC security groups; can be
        /// used instead of GroupName for standard (EC2) security groups.
        ///  
        /// </summary>
        public string GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this.groupId != null;
        }

        /// <summary>
        /// List of IP permissions to revoke on the specified security group. For an IP permission to be removed, it must exactly match one of the IP
        /// permissions you specify in this list. Specifying permissions through IP permissions is the preferred way of revoking permissions since it
        /// offers more flexibility and control.
        ///  
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this.ipPermissions; }
            set { this.ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this.ipPermissions.Count > 0;
        }

    }
}
    
