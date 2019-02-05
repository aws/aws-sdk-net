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
    /// Container for the parameters to the DescribeTransitGatewayRouteTables operation.
    /// Describes one or more transit gateway route tables. By default, all transit gateway
    /// route tables are described. Alternatively, you can filter the results.
    /// </summary>
    public partial class DescribeTransitGatewayRouteTablesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _transitGatewayRouteTableIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>default-association-route-table</code> - Indicates whether this is the default
        /// association route table for the transit gateway (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-propagation-route-table</code> - Indicates whether this is the default
        /// propagation route table for the transit gateway (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the attachment (<code>available</code> | <code>deleted</code>
        /// | <code>deleting</code> | <code>failed</code> | <code>modifying</code> | <code>pendingAcceptance</code>
        /// | <code>pending</code> | <code>rollingBack</code> | <code>rejected</code> | <code>rejecting</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-id</code> - The ID of the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-table-id</code> - The ID of the transit gateway route
        /// table.
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

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableIds. 
        /// <para>
        /// The IDs of the transit gateway route tables.
        /// </para>
        /// </summary>
        public List<string> TransitGatewayRouteTableIds
        {
            get { return this._transitGatewayRouteTableIds; }
            set { this._transitGatewayRouteTableIds = value; }
        }

        // Check to see if TransitGatewayRouteTableIds property is set
        internal bool IsSetTransitGatewayRouteTableIds()
        {
            return this._transitGatewayRouteTableIds != null && this._transitGatewayRouteTableIds.Count > 0; 
        }

    }
}