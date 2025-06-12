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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHosts operation.
    /// Describes the specified Dedicated Hosts or all your Dedicated Hosts.
    /// 
    ///  
    /// <para>
    /// The results describe only the Dedicated Hosts in the Region you're currently using.
    /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
    /// have recently been released are listed with the state <c>released</c>.
    /// </para>
    /// </summary>
    public partial class DescribeHostsRequest : AmazonEC2Request
    {
        private List<Filter> _filter = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _hostIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto-placement</c> - Whether auto-placement is enabled or disabled (<c>on</c>
        /// | <c>off</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone of the host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client-token</c> - The idempotency token that you provided when you allocated
        /// the host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>host-reservation-id</c> - The ID of the reservation assigned to this host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type size that the Dedicated Host is configured
        /// to support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The allocation state of the Dedicated Host (<c>available</c> | <c>under-assessment</c>
        /// | <c>permanent-failure</c> | <c>released</c> | <c>released-permanent-failure</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && (this._filter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts. The IDs are used for targeted instance launches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HostIds
        {
            get { return this._hostIds; }
            set { this._hostIds = value; }
        }

        // Check to see if HostIds property is set
        internal bool IsSetHostIds()
        {
            return this._hostIds != null && (this._hostIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <c>nextToken</c>
        /// value. This value can be between 5 and 500. If <c>maxResults</c> is given a larger
        /// value than 500, you receive an error.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter and the host IDs parameter in the same request.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The token to use to retrieve the next page of results.
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