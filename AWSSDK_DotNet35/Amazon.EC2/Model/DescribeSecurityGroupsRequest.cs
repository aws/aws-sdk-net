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
    /// Container for the parameters to the DescribeSecurityGroups operation.
    /// Describes one or more of your security groups.
    /// 
    ///  
    /// <para>
    /// A security group is for use with instances either in the EC2-Classic platform or in
    /// a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
    /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>
    /// and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
    /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSecurityGroupsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _groupIds = new List<string>();
        private List<string> _groupNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>description</code> - The description of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>group-id</code> - The ID of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>group-name</code> - The name of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.cidr</code> - A CIDR range that has been granted permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.from-port</code> - The start of port range for the TCP and UDP
        /// protocols, or an ICMP type number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.group-id</code> - The ID of a security group that has been granted
        /// permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.group-name</code> - The name of a security group that has been
        /// granted permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.protocol</code> - The IP protocol for the permission (<code>tcp</code>
        /// | <code>udp</code> | <code>icmp</code> or a protocol number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.to-port</code> - The end of port range for the TCP and UDP protocols,
        /// or an ICMP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ip-permission.user-id</code> - The ID of an AWS account that has been granted
        /// permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-id</code> - The AWS account ID of the owner of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-id</code> - The ID of the VPC specified when the security group was created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupIds. 
        /// <para>
        /// One or more security group IDs. Required for nondefault VPCs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your security groups.
        /// </para>
        /// </summary>
        public List<string> GroupIds
        {
            get { return this._groupIds; }
            set { this._groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this._groupIds != null && this._groupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// [EC2-Classic, default VPC] One or more security group names. You can specify either
        /// the security group name or the security group ID.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your security groups.
        /// </para>
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && this._groupNames.Count > 0; 
        }

    }
}