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
    /// Container for the parameters to the AuthorizeSecurityGroupEgress operation.
    /// <para> This action applies only to security groups in a VPC; it's not supported for EC2 security groups. For information about Amazon
    /// Virtual Private Cloud and VPC security groups, go to the Amazon Virtual Private Cloud User Guide. </para> <para> The action adds one or more
    /// egress rules to a VPC security group. Specifically, this permits instances in a security group to send traffic to either one or more
    /// destination CIDR IP address ranges, or to one or more destination security groups in the same VPC. </para> <para> Each rule consists of the
    /// protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP and UDP protocols, you must also specify the destination port
    /// or port range. For the ICMP protocol, you must also specify the ICMP type and code. You can use <c>-1</c> as a wildcard for the ICMP type or
    /// code. </para> <para> Rule changes are propagated to instances within the security group as quickly as possible. However, a small delay might
    /// occur. </para> <para> <b>Important:</b> For VPC security groups: You can have up to 50 rules total per group (covering both ingress and
    /// egress). </para>
    /// </summary>
    public partial class AuthorizeSecurityGroupEgressRequest : AmazonEC2Request
    {
        private string groupId;
        private List<IpPermission> ipPermissions = new List<IpPermission>();


        /// <summary>
        /// ID of the VPC security group to modify.
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
        /// List of IP permissions to authorize on the specified security group. Specifying permissions through IP permissions is the preferred way of
        /// authorizing permissions since it offers more flexibility and control.
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
    
