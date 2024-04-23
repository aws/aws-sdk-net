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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the ListFindingAggregations operation.
    /// Lists aggregated finding data for your environment based on specific criteria.
    /// </summary>
    public partial class ListFindingAggregationsRequest : AmazonInspector2Request
    {
        private List<StringFilter> _accountIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private AggregationRequest _aggregationRequest;
        private AggregationType _aggregationType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs to retrieve finding aggregation data for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregationRequest. 
        /// <para>
        /// Details of the aggregation request that is used to filter your aggregation results.
        /// </para>
        /// </summary>
        public AggregationRequest AggregationRequest
        {
            get { return this._aggregationRequest; }
            set { this._aggregationRequest = value; }
        }

        // Check to see if AggregationRequest property is set
        internal bool IsSetAggregationRequest()
        {
            return this._aggregationRequest != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        /// The type of the aggregation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregationType AggregationType
        {
            get { return this._aggregationType; }
            set { this._aggregationType = value; }
        }

        // Check to see if AggregationType property is set
        internal bool IsSetAggregationType()
        {
            return this._aggregationType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results the response can return. If your request would return
        /// more than the maximum the response will return a <c>nextToken</c> value, use this
        /// value when you call the action again to get the remaining results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. If your response
        /// returns more than the <c>maxResults</c> maximum value it will also return a <c>nextToken</c>
        /// value. For subsequent calls, use the <c>nextToken</c> value returned from the previous
        /// request to continue listing results after the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
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