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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListIntentStageMetrics operation.
    /// Retrieves summary metrics for the stages within intents in your bot. The following
    /// fields are required:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>metrics</c> – A list of <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_AnalyticsIntentStageMetric.html">AnalyticsIntentStageMetric</a>
    /// objects. In each object, use the <c>name</c> field to specify the metric to calculate,
    /// the <c>statistic</c> field to specify whether to calculate the <c>Sum</c>, <c>Average</c>,
    /// or <c>Max</c> number, and the <c>order</c> field to specify whether to sort the results
    /// in <c>Ascending</c> or <c>Descending</c> order.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>startDateTime</c> and <c>endDateTime</c> – Define a time range for which you want
    /// to retrieve results.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Of the optional fields, you can organize the results in the following ways:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <c>filters</c> field to filter the results, the <c>groupBy</c> field to specify
    /// categories by which to group the results, and the <c>binBy</c> field to specify time
    /// intervals by which to group the results.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <c>maxResults</c> field to limit the number of results to return in a single
    /// response and the <c>nextToken</c> field to return the next batch of results if the
    /// response does not return the full set of results.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Note that an <c>order</c> field exists in both <c>binBy</c> and <c>metrics</c>. You
    /// can only specify one <c>order</c> in a given request.
    /// </para>
    /// </summary>
    public partial class ListIntentStageMetricsRequest : AmazonLexModelsV2Request
    {
        private List<AnalyticsBinBySpecification> _binBy = AWSConfigs.InitializeCollections ? new List<AnalyticsBinBySpecification>() : null;
        private string _botId;
        private DateTime? _endDateTime;
        private List<AnalyticsIntentStageFilter> _filters = AWSConfigs.InitializeCollections ? new List<AnalyticsIntentStageFilter>() : null;
        private List<AnalyticsIntentStageGroupBySpecification> _groupBy = AWSConfigs.InitializeCollections ? new List<AnalyticsIntentStageGroupBySpecification>() : null;
        private int? _maxResults;
        private List<AnalyticsIntentStageMetric> _metrics = AWSConfigs.InitializeCollections ? new List<AnalyticsIntentStageMetric>() : null;
        private string _nextToken;
        private DateTime? _startDateTime;

        /// <summary>
        /// Gets and sets the property BinBy. 
        /// <para>
        /// A list of objects, each of which contains specifications for organizing the results
        /// by time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AnalyticsBinBySpecification> BinBy
        {
            get { return this._binBy; }
            set { this._binBy = value; }
        }

        // Check to see if BinBy property is set
        internal bool IsSetBinBy()
        {
            return this._binBy != null && (this._binBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier for the bot for which you want to retrieve intent stage metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that marks the end of the range of time for which you want to see
        /// intent stage metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of objects, each of which describes a condition by which you want to filter
        /// the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<AnalyticsIntentStageFilter> Filters
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
        /// A list of objects, each of which specifies how to group the results. You can group
        /// by the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IntentStageName</c> – The name of the intent stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SwitchedToIntent</c> – The intent to which the conversation was switched (if any).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AnalyticsIntentStageGroupBySpecification> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in each page of results. If there are fewer
        /// results than the maximum page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A list of objects, each of which contains a metric you want to list, the statistic
        /// for the metric you want to return, and the method by which to organize the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<AnalyticsIntentStageMetric> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the ListIntentStageMetrics operation contains more results than
        /// specified in the maxResults parameter, a token is returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the returned token in the nextToken parameter of a ListIntentStageMetrics request
        /// to return the next page of results. For a complete set of results, call the ListIntentStageMetrics
        /// operation until the nextToken returned in the response is null.
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
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that marks the beginning of the range of time for which you want
        /// to see intent stage metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

    }
}