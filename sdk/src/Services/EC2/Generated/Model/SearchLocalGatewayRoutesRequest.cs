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
    /// Container for the parameters to the SearchLocalGatewayRoutes operation.
    /// Searches for routes in the specified local gateway route table.
    /// </summary>
    public partial class SearchLocalGatewayRoutesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private string _localGatewayRouteTableId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>prefix-list-id</code> - The ID of the prefix list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.exact-match</code> - The exact match of the specified filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.longest-prefix-match</code> - The longest prefix that matches
        /// the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.subnet-of-match</code> - The routes with a subnet that match the
        /// specified CIDR filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.supernet-of-match</code> - The routes with a CIDR that encompass
        /// the CIDR filter. For example, if you have 10.0.1.0/29 and 10.0.1.0/31 routes in your
        /// route table and you specify <code>supernet-of-match</code> as 10.0.1.0/30, then the
        /// result returns 10.0.1.0/29.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The route type.
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
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        /// The ID of the local gateway route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocalGatewayRouteTableId
        {
            get { return this._localGatewayRouteTableId; }
            set { this._localGatewayRouteTableId = value; }
        }

        // Check to see if LocalGatewayRouteTableId property is set
        internal bool IsSetLocalGatewayRouteTableId()
        {
            return this._localGatewayRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
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
        /// The token for the next page of results.
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