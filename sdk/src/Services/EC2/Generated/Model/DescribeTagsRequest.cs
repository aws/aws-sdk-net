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
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeTagsRequest() { }

        /// <summary>
        /// Instantiates DescribeTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="filters">The filters. <ul> <li>  <c>key</c> - The tag key. </li> <li>  <c>resource-id</c> - The ID of the resource. </li> <li>  <c>resource-type</c> - The resource type (<c>customer-gateway</c> | <c>dedicated-host</c> | <c>dhcp-options</c> | <c>elastic-ip</c> | <c>fleet</c> | <c>fpga-image</c> | <c>host-reservation</c> | <c>image</c> | <c>instance</c> | <c>internet-gateway</c> | <c>key-pair</c> | <c>launch-template</c> | <c>natgateway</c> | <c>network-acl</c> | <c>network-interface</c> | <c>placement-group</c> | <c>reserved-instances</c> | <c>route-table</c> | <c>security-group</c> | <c>snapshot</c> | <c>spot-instances-request</c> | <c>subnet</c> | <c>volume</c> | <c>vpc</c> | <c>vpc-endpoint</c> | <c>vpc-endpoint-service</c> | <c>vpc-peering-connection</c> | <c>vpn-connection</c> | <c>vpn-gateway</c>). </li> <li>  <c>tag</c>:&lt;key&gt; - The key/value combination of the tag. For example, specify "tag:Owner" for the filter name and "TeamA" for the filter value to find resources with the tag "Owner=TeamA". </li> <li>  <c>value</c> - The tag value. </li> </ul></param>
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
        ///  <c>key</c> - The tag key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-id</c> - The ID of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-type</c> - The resource type (<c>customer-gateway</c> | <c>dedicated-host</c>
        /// | <c>dhcp-options</c> | <c>elastic-ip</c> | <c>fleet</c> | <c>fpga-image</c> | <c>host-reservation</c>
        /// | <c>image</c> | <c>instance</c> | <c>internet-gateway</c> | <c>key-pair</c> | <c>launch-template</c>
        /// | <c>natgateway</c> | <c>network-acl</c> | <c>network-interface</c> | <c>placement-group</c>
        /// | <c>reserved-instances</c> | <c>route-table</c> | <c>security-group</c> | <c>snapshot</c>
        /// | <c>spot-instances-request</c> | <c>subnet</c> | <c>volume</c> | <c>vpc</c> | <c>vpc-endpoint</c>
        /// | <c>vpc-endpoint-service</c> | <c>vpc-peering-connection</c> | <c>vpn-connection</c>
        /// | <c>vpn-gateway</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of the tag. For example, specify
        /// "tag:Owner" for the filter name and "TeamA" for the filter value to find resources
        /// with the tag "Owner=TeamA".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>value</c> - The tag value.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
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