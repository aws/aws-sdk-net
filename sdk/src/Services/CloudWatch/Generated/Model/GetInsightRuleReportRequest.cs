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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetInsightRuleReport operation.
    /// This operation returns the time series data collected by a Contributor Insights rule.
    /// The data includes the identity and number of contributors to the log group.
    /// 
    ///  
    /// <para>
    /// You can also optionally return one or more statistics about each data point in the
    /// time series. These statistics can include the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>UniqueContributors</c> -- the number of unique contributors for each data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MaxContributorValue</c> -- the value of the top contributor for each data point.
    /// The identity of the contributor might change for each data point in the graph.
    /// </para>
    ///  
    /// <para>
    /// If this rule aggregates by COUNT, the top contributor for each data point is the contributor
    /// with the most occurrences in that period. If the rule aggregates by SUM, the top contributor
    /// is the contributor with the highest sum in the log field specified by the rule's <c>Value</c>,
    /// during that period.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SampleCount</c> -- the number of data points matched by the rule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Sum</c> -- the sum of the values from all contributors during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Minimum</c> -- the minimum value from a single observation during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Maximum</c> -- the maximum value from a single observation during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Average</c> -- the average value from all contributors during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetInsightRuleReportRequest : AmazonCloudWatchRequest
    {
        private DateTime? _endTime;
        private int? _maxContributorCount;
        private List<string> _metrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _orderBy;
        private int? _period;
        private string _ruleName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the data to use in the report. When used in a raw HTTP Query API,
        /// it is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxContributorCount. 
        /// <para>
        /// The maximum number of contributors to include in the report. The range is 1 to 100.
        /// If you omit this, the default of 10 is used.
        /// </para>
        /// </summary>
        public int? MaxContributorCount
        {
            get { return this._maxContributorCount; }
            set { this._maxContributorCount = value; }
        }

        // Check to see if MaxContributorCount property is set
        internal bool IsSetMaxContributorCount()
        {
            return this._maxContributorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Specifies which metrics to use for aggregation of contributor values for the report.
        /// You can specify one or more of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UniqueContributors</c> -- the number of unique contributors for each data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxContributorValue</c> -- the value of the top contributor for each data point.
        /// The identity of the contributor might change for each data point in the graph.
        /// </para>
        ///  
        /// <para>
        /// If this rule aggregates by COUNT, the top contributor for each data point is the contributor
        /// with the most occurrences in that period. If the rule aggregates by SUM, the top contributor
        /// is the contributor with the highest sum in the log field specified by the rule's <c>Value</c>,
        /// during that period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SampleCount</c> -- the number of data points matched by the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sum</c> -- the sum of the values from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Minimum</c> -- the minimum value from a single observation during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Maximum</c> -- the maximum value from a single observation during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> -- the average value from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Metrics
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
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Determines what statistic to use to rank the contributors. Valid values are <c>Sum</c>
        /// and <c>Maximum</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string OrderBy
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
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, to use for the statistics in the <c>InsightRuleMetricDatapoint</c>
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule that you want to see data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the data to use in the report. When used in a raw HTTP Query API,
        /// it is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}