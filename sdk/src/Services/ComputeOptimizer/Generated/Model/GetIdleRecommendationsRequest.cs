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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdleRecommendations operation.
    /// Returns idle resource recommendations. Compute Optimizer generates recommendations
    /// for idle resources that meet a specific set of requirements. For more information,
    /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Resource
    /// requirements</a> in the <i>Compute Optimizer User Guide</i>
    /// </summary>
    public partial class GetIdleRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<IdleRecommendationFilter> _filters = AWSConfigs.InitializeCollections ? new List<IdleRecommendationFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private OrderBy _orderBy;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// Return the idle resource recommendations to the specified Amazon Web Services account
        /// IDs.
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account or the delegated administrator of an organization,
        /// use this parameter to return the idle resource recommendations to specific member
        /// accounts.
        /// </para>
        ///  
        /// <para>
        /// You can only specify one account ID per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountIds
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects to specify a filter that returns a more specific list of idle
        /// resource recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdleRecommendationFilter> Filters
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
        /// The maximum number of idle resource recommendations to return with a single request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another request with the returned <c>nextToken</c>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The token to advance to the next page of idle resource recommendations.
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
        /// The order to sort the idle resource recommendations.
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

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARN that identifies the idle resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}