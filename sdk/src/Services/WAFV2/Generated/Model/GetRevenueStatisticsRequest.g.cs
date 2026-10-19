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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevenueStatistics operation. Retrieves ranked
    /// monetization statistics. Use the <c>StatisticType</c> parameter to specify the ranking:
    /// <c>TOP_SOURCES_BY_REVENUE</c> for top sources by revenue, or <c>TOP_PATHS_BY_REVENUE</c>
    /// for top content paths by revenue. This operation is only available for <c>CLOUDFRONT</c>
    /// scope. The maximum supported time window is 90 days. When no <c>CurrencyMode</c> filter
    /// is provided, results default to <c>REAL</c>. To retrieve test data, include a <c>CurrencyMode</c>
    /// filter with the value <c>TEST</c>.
    /// </summary>
    public partial class GetRevenueStatisticsRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency for the revenue amounts in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters to narrow the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<MonetizationFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<MonetizationFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimension to group results by: <c>NAME</c>, <c>CATEGORY</c>, <c>INTENT</c>, <c>ORGANIZATION</c>,
        /// or <c>WEBACL</c>. Required when <c>StatisticType</c> is <c>TOP_SOURCES_BY_REVENUE</c>.
        /// Not required for <c>TOP_PATHS_BY_REVENUE</c>, where results are grouped by content
        /// path. If <c>StatisticType</c> is <c>TOP_SOURCES_BY_REVENUE</c> and <c>GroupBy</c>
        /// is omitted, the request is rejected with a <c>WAFInvalidParameterException</c>.
        /// </para>
        /// </summary>
        public GroupByType GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you get a paginated response, this marker indicates that additional results are
        /// available. Use it in a subsequent request to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a Amazon CloudFront distribution (<c>CLOUDFRONT</c>)
        /// or for a regional application (<c>REGIONAL</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort results by: <c>REVENUE</c>, <c>PERCENTAGE</c>, or <c>NAME</c>.
        /// </para>
        /// </summary>
        public RankingSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order: <c>ASC</c> for ascending or <c>DESC</c> for descending.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatisticType. 
        /// <para>
        ///  <c>TOP_SOURCES_BY_REVENUE</c> ranks revenue from AI bot traffic, grouped by the dimension
        /// you specify in the <c>GroupBy</c> parameter (<c>NAME</c>, <c>CATEGORY</c>, <c>INTENT</c>,
        /// <c>ORGANIZATION</c>, or <c>WEBACL</c>); <c>GroupBy</c> is required for this statistic
        /// type. <c>TOP_PATHS_BY_REVENUE</c> ranks revenue by path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RankingStatisticType StatisticType { get; set; }

        /// <summary>
        /// Checks to see if the StatisticType property is set.
        /// </summary>
        internal bool IsSetStatisticType() => this.StatisticType != null;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The time range for the query. Specify start and end timestamps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;
    }
}
