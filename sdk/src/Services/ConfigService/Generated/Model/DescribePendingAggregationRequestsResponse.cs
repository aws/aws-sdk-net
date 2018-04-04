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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the DescribePendingAggregationRequests operation.
    /// </summary>
    public partial class DescribePendingAggregationRequestsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PendingAggregationRequest> _pendingAggregationRequests = new List<PendingAggregationRequest>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response.
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
        /// Gets and sets the property PendingAggregationRequests. 
        /// <para>
        /// Returns a PendingAggregationRequests object.
        /// </para>
        /// </summary>
        public List<PendingAggregationRequest> PendingAggregationRequests
        {
            get { return this._pendingAggregationRequests; }
            set { this._pendingAggregationRequests = value; }
        }

        // Check to see if PendingAggregationRequests property is set
        internal bool IsSetPendingAggregationRequests()
        {
            return this._pendingAggregationRequests != null && this._pendingAggregationRequests.Count > 0; 
        }

    }
}