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
    /// Container for the parameters to the DescribeTags operation.
    /// Describes the specified tags for your EC2 resources.
    /// 
    ///  
    /// <para>
    /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeTagsRequest() { }

        /// <summary>
        /// Instantiates DescribeTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="filters">The filters. <ul> <li>  <code>key</code> - The tag key. </li> <li>  <code>resource-id</code> - The ID of the resource. </li> <li>  <code>resource-type</code> - The resource type (<code>customer-gateway</code> | <code>dedicated-host</code> | <code>dhcp-options</code> | <code>elastic-ip</code> | <code>fleet</code> | <code>fpga-image</code> | <code>host-reservation</code> | <code>image</code> | <code>instance</code> | <code>internet-gateway</code> | <code>key-pair</code> | <code>launch-template</code> | <code>natgateway</code> | <code>network-acl</code> | <code>network-interface</code> | <code>placement-group</code> | <code>reserved-instances</code> | <code>route-table</code> | <code>security-group</code> | <code>snapshot</code> | <code>spot-instances-request</code> | <code>subnet</code> | <code>volume</code> | <code>vpc</code> | <code>vpc-endpoint</code> | <code>vpc-endpoint-service</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code> | <code>vpn-gateway</code>). </li> <li>  <code>tag</code>:&lt;key&gt; - The key/value combination of the tag. For example, specify "tag:Owner" for the filter name and "TeamA" for the filter value to find resources with the tag "Owner=TeamA". </li> <li>  <code>value</code> - The tag value. </li> </ul></param>
        public DescribeTagsRequest(List<Filter> filters)
        {
            _filters = filters;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>key</code> - The tag key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resource-id</code> - The ID of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resource-type</code> - The resource type (<code>customer-gateway</code> | <code>dedicated-host</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip</code> | <code>fleet</code> | <code>fpga-image</code>
        /// | <code>host-reservation</code> | <code>image</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>key-pair</code> | <code>launch-template</code> | <code>natgateway</code> |
        /// <code>network-acl</code> | <code>network-interface</code> | <code>placement-group</code>
        /// | <code>reserved-instances</code> | <code>route-table</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>spot-instances-request</code> | <code>subnet</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-endpoint</code> | <code>vpc-endpoint-service</code>
        /// | <code>vpc-peering-connection</code> | <code>vpn-connection</code> | <code>vpn-gateway</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of the tag. For example,
        /// specify "tag:Owner" for the filter name and "TeamA" for the filter value to find resources
        /// with the tag "Owner=TeamA".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>value</code> - The tag value.
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
        /// The maximum number of items to return for this request. This value can be between
        /// 5 and 1000. To get the next page of items, make another request with the token returned
        /// in the output. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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