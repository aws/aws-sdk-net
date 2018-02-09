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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
    /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
    /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSecurityGroupsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _groupIds = new List<string>();
        private List<string> _groupNames = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. If using multiple filters for rules, the results include security
        /// groups for which any combination of rules - not necessarily a single rule - match
        /// all filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>description</code> - The description of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.cidr</code> - An IPv4 CIDR block for an outbound security
        /// group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.from-port</code> - For an outbound rule, the start of
        /// port range for the TCP and UDP protocols, or an ICMP type number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.group-id</code> - The ID of a security group that has
        /// been referenced in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.group-name</code> - The name of a security group that
        /// has been referenced in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.ipv6-cidr</code> - An IPv6 CIDR block for an outbound
        /// security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.prefix-list-id</code> - The ID (prefix) of the AWS service
        /// to which a security group rule allows outbound access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.protocol</code> - The IP protocol for an outbound security
        /// group rule (<code>tcp</code> | <code>udp</code> | <code>icmp</code> or a protocol
        /// number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.to-port</code> - For an outbound rule, the end of port
        /// range for the TCP and UDP protocols, or an ICMP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>egress.ip-permission.user-id</code> - The ID of an AWS account that has been
        /// referenced in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-id</code> - The ID of the security group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-name</code> - The name of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.cidr</code> - An IPv4 CIDR block for an inbound security group
        /// rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.from-port</code> - For an inbound rule, the start of port range
        /// for the TCP and UDP protocols, or an ICMP type number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.group-id</code> - The ID of a security group that has been referenced
        /// in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.group-name</code> - The name of a security group that has been
        /// referenced in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.ipv6-cidr</code> - An IPv6 CIDR block for an inbound security
        /// group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.prefix-list-id</code> - The ID (prefix) of the AWS service from
        /// which a security group rule allows inbound access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.protocol</code> - The IP protocol for an inbound security group
        /// rule (<code>tcp</code> | <code>udp</code> | <code>icmp</code> or a protocol number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.to-port</code> - For an inbound rule, the end of port range for
        /// the TCP and UDP protocols, or an ICMP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-permission.user-id</code> - The ID of an AWS account that has been referenced
        /// in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The AWS account ID of the owner of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-value</code> - The value of a tag assigned to the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC specified when the security group was created.
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
        /// One or more security group IDs. Required for security groups in a nondefault VPC.
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
        /// [EC2-Classic and default VPC only] One or more security group names. You can specify
        /// either the security group name or the security group ID. For security groups in a
        /// nondefault VPC, use the <code>group-name</code> filter to describe security groups
        /// by name.
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

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another request with the returned <code>NextToken</code> value. This
        /// value can be between 5 and 1000. If this parameter is not specified, then all results
        /// are returned.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}