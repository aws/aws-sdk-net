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
    /// Container for the parameters to the DescribeNetworkAcls operation.
    /// Describes one or more of your network ACLs.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
    /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeNetworkAclsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private List<string> _networkAclIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>association.association-id</code> - The ID of an association ID for the ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.network-acl-id</code> - The ID of the network ACL involved in the
        /// association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.subnet-id</code> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default</code> - Indicates whether the ACL is the default network ACL for the
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.cidr</code> - The IPv4 CIDR range specified in the entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.icmp.code</code> - The ICMP code specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.icmp.type</code> - The ICMP type specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.ipv6-cidr</code> - The IPv6 CIDR range specified in the entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.port-range.from</code> - The start of the port range specified in the
        /// entry. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.port-range.to</code> - The end of the port range specified in the entry.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.protocol</code> - The protocol specified in the entry (<code>tcp</code>
        /// | <code>udp</code> | <code>icmp</code> or a protocol number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.rule-action</code> - Allows or denies the matching traffic (<code>allow</code>
        /// | <code>deny</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.egress</code> - A Boolean that indicates the type of rule. Specify <code>true</code>
        /// for egress rules, or <code>false</code> for ingress rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>entry.rule-number</code> - The number of an entry (in other words, rule) in
        /// the set of ACL entries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-acl-id</code> - The ID of the network ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the Amazon Web Services account that owns the network
        /// ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC for the network ACL.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// Gets and sets the property NetworkAclIds. 
        /// <para>
        /// One or more network ACL IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your network ACLs.
        /// </para>
        /// </summary>
        public List<string> NetworkAclIds
        {
            get { return this._networkAclIds; }
            set { this._networkAclIds = value; }
        }

        // Check to see if NetworkAclIds property is set
        internal bool IsSetNetworkAclIds()
        {
            return this._networkAclIds != null && this._networkAclIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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