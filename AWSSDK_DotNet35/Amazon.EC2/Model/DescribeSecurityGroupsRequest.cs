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
    /// Container for the parameters to the DescribeSecurityGroups operation.
    /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
    /// platform or in a specific VPC. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security Groups</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security
    /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeSecurityGroupsRequest : AmazonEC2Request
    {
        private List<string> groupNames = new List<string>();
        private List<string> groupIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// [EC2-Classic, default VPC] One or more security group names. Default: Describes all your security groups.
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }

        /// <summary>
        /// One or more security group IDs. Default: Describes all your security groups.
        ///  
        /// </summary>
        public List<string> GroupIds
        {
            get { return this.groupIds; }
            set { this.groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this.groupIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>description</c> - The description of the security group. </li> <li> <c>group-id</c> - The ID of the
        /// security group. </li> <li> <c>group-name</c> - The name of the security group. </li> <li> <c>ip-permission.cidr</c> - A CIDR range that has
        /// been granted permission. </li> <li> <c>ip-permission.from-port</c> - The start of port range for the TCP and UDP protocols, or an ICMP type
        /// number. </li> <li> <c>ip-permission.group-name</c> - The name of a security group that has been granted permission. </li> <li>
        /// <c>ip-permission.protocol</c> - The IP protocol for the permission (<c>tcp</c> | <c>udp</c> | <c>icmp</c> or a protocol number). </li> <li>
        /// <c>ip-permission.to-port</c> - The end of port range for the TCP and UDP protocols, or an ICMP code. </li> <li> <c>ip-permission.user-id</c>
        /// - The ID of an AWS account that has been granted permission. </li> <li> <c>owner-id</c> - The AWS account ID of the owner of the security
        /// group. </li> <li> <c>tag-key</c> - The key of a tag assigned to the security group. </li> <li> <c>tag-value</c> - The value of a tag
        /// assigned to the security group. </li> <li> <c>vpc-id</c> - The ID of the VPC specified when the security group was created. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
