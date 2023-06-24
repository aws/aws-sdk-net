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
    /// Container for the parameters to the DescribeVpcEndpointConnections operation.
    /// Describes the VPC endpoint connections to your VPC endpoint services, including any
    /// endpoints that are pending your acceptance.
    /// </summary>
    public partial class DescribeVpcEndpointConnectionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ip-address-type</code> - The IP address type (<code>ipv4</code> | <code>ipv6</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>service-id</code> - The ID of the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-endpoint-owner</code> - The ID of the Amazon Web Services account ID that
        /// owns the endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-endpoint-state</code> - The state of the endpoint (<code>pendingAcceptance</code>
        /// | <code>pending</code> | <code>available</code> | <code>deleting</code> | <code>deleted</code>
        /// | <code>rejected</code> | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-endpoint-id</code> - The ID of the endpoint.
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
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results of the initial request can be seen by sending another request with the returned
        /// <code>NextToken</code> value. This value can be between 5 and 1,000; if <code>MaxResults</code>
        /// is given a value larger than 1,000, only 1,000 results are returned.
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
        /// The token to retrieve the next page of results.
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