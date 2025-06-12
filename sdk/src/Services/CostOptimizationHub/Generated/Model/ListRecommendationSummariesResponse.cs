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
    /// This is the response object from the ListRecommendationSummaries operation.
    /// </summary>
    public partial class ListRecommendationSummariesResponse : AmazonWebServiceResponse
    {
        private string _currencyCode;
        private double? _estimatedTotalDedupedSavings;
        private string _groupBy;
        private List<RecommendationSummary> _items = AWSConfigs.InitializeCollections ? new List<RecommendationSummary>() : null;
        private SummaryMetricsResult _metrics;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for the recommendation.
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedTotalDedupedSavings. 
        /// <para>
        /// The total overall savings for the aggregated view.
        /// </para>
        /// </summary>
        public double? EstimatedTotalDedupedSavings
        {
            get { return this._estimatedTotalDedupedSavings; }
            set { this._estimatedTotalDedupedSavings = value; }
        }

        // Check to see if EstimatedTotalDedupedSavings property is set
        internal bool IsSetEstimatedTotalDedupedSavings()
        {
            return this._estimatedTotalDedupedSavings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimension used to group the recommendations by.
        /// </para>
        /// </summary>
        public string GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A list of all savings recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationSummary> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The results or descriptions for the additional metrics, based on whether the metrics
        /// were or were not requested.
        /// </para>
        /// </summary>
        public SummaryMetricsResult Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
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

    }
}