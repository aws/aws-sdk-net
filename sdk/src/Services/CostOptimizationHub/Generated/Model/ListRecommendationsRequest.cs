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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecommendations operation.
    /// Returns a list of recommendations.
    /// </summary>
    public partial class ListRecommendationsRequest : AmazonCostOptimizationHubRequest
    {
        private Filter _filter;
        private bool? _includeAllRecommendations;
        private int? _maxResults;
        private string _nextToken;
        private OrderBy _orderBy;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The constraints that you want all returned recommendations to match.
        /// </para>
        /// </summary>
        public Filter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAllRecommendations. 
        /// <para>
        /// List of all recommendations for a resource, or a single recommendation if de-duped
        /// by <c>resourceId</c>.
        /// </para>
        /// </summary>
        public bool? IncludeAllRecommendations
        {
            get { return this._includeAllRecommendations; }
            set { this._includeAllRecommendations = value; }
        }

        // Check to see if IncludeAllRecommendations property is set
        internal bool IsSetIncludeAllRecommendations()
        {
            return this._includeAllRecommendations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendations that are returned for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// The token to retrieve the next set of results.
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
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// The ordering of recommendations by a dimension.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}