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
    /// Container for the parameters to the RevokeSecurityGroupEgress operation.
    /// <para>Removes one or more egress rules from a security group for EC2-VPC. The values that you specify in the revoke request (for example,
    /// ports) must match the existing rule's values for the rule to be revoked.</para> <para>Each rule consists of the protocol and the CIDR range
    /// or source security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP
    /// protocol, you must also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as
    /// quickly as possible. However, a small delay might occur.</para>
    /// </summary>
    public partial class RevokeSecurityGroupEgressRequest : AmazonEC2Request
    {
        private string groupId;
        private List<IpPermission> ipPermissions = new List<IpPermission>();


        /// <summary>
        /// The ID of the security group.
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
        /// <p/>
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
    
