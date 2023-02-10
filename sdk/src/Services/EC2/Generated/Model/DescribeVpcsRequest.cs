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
    /// Container for the parameters to the DescribeVpcs operation.
    /// Describes one or more of your VPCs.
    /// </summary>
    public partial class DescribeVpcsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _vpcIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>cidr</code> - The primary IPv4 CIDR block of the VPC. The CIDR block you specify
        /// must exactly match the VPC's CIDR block for information to be returned for the VPC.
        /// Must contain the slash followed by one or two digits (for example, <code>/28</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.cidr-block</code> - An IPv4 CIDR block associated with
        /// the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.association-id</code> - The association ID for an IPv4
        /// CIDR block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.state</code> - The state of an IPv4 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dhcp-options-id</code> - The ID of a set of DHCP options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.ipv6-cidr-block</code> - An IPv6 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.ipv6-pool</code> - The ID of the IPv6 address pool
        /// from which the IPv6 CIDR block is allocated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.association-id</code> - The association ID for
        /// an IPv6 CIDR block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.state</code> - The state of an IPv6 CIDR block
        /// associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>is-default</code> - Indicates whether the VPC is the default VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the Amazon Web Services account that owns the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the VPC (<code>pending</code> | <code>available</code>).
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
        ///  <code>vpc-id</code> - The ID of the VPC.
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

        /// <summary>
        /// Gets and sets the property VpcIds. 
        /// <para>
        /// One or more VPC IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your VPCs.
        /// </para>
        /// </summary>
        public List<string> VpcIds
        {
            get { return this._vpcIds; }
            set { this._vpcIds = value; }
        }

        // Check to see if VpcIds property is set
        internal bool IsSetVpcIds()
        {
            return this._vpcIds != null && this._vpcIds.Count > 0; 
        }

    }
}