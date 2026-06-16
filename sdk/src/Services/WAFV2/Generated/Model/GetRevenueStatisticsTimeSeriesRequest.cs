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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
    /// Container for the parameters to the GetRevenueStatisticsTimeSeries operation.
    /// Retrieves time series data for monetization revenue. Returns data points aggregated
    /// at the specified interval for the given time window. This operation is only available
    /// for <c>CLOUDFRONT</c> scope. The maximum supported time window is 90 days. When no
    /// <c>CurrencyMode</c> filter is provided, results default to <c>REAL</c>. To retrieve
    /// test data, include a <c>CurrencyMode</c> filter with the value <c>TEST</c>.
    /// </summary>
    public partial class GetRevenueStatisticsTimeSeriesRequest : AmazonWAFV2Request
    {
        private Currency _currency;
        private List<MonetizationFilter> _filters = AWSConfigs.InitializeCollections ? new List<MonetizationFilter>() : null;
        private GroupByType _groupBy;
        private IntervalType _interval;
        private int? _limit;
        private string _nextMarker;
        private Scope _scope;
        private TimeSeriesStatisticType _statisticType;
        private TimeWindow _timeWindow;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency for the amounts in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Currency Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters to narrow the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<MonetizationFilter> Filters
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
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimension to group results by.
        /// </para>
        /// </summary>
        public GroupByType GroupBy
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
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval for aggregating data points: <c>MINUTELY</c>, <c>FIVE_MINUTELY</c>,
        /// <c>HOURLY</c>, or <c>DAILY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntervalType Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of data points to return. Minimum: 1. Maximum: 10000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you get a paginated response, this marker indicates that additional results are
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a Amazon CloudFront distribution (<c>CLOUDFRONT</c>)
        /// or for a regional application (<c>REGIONAL</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticType. 
        /// <para>
        /// The type of time series data to retrieve: <c>DATE_HISTOGRAM</c> for revenue over time,
        /// or <c>PAYMENT_TRAFFIC</c> for payment traffic patterns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeSeriesStatisticType StatisticType
        {
            get { return this._statisticType; }
            set { this._statisticType = value; }
        }

        // Check to see if StatisticType property is set
        internal bool IsSetStatisticType()
        {
            return this._statisticType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The time range for the query. Specify start and end timestamps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeWindow TimeWindow
        {
            get { return this._timeWindow; }
            set { this._timeWindow = value; }
        }

        // Check to see if TimeWindow property is set
        internal bool IsSetTimeWindow()
        {
            return this._timeWindow != null;
        }

    }
}