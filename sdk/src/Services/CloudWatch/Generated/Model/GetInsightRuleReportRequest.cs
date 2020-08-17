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
    ///  <code>UniqueContributors</code> -- the number of unique contributors for each data
    /// point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>MaxContributorValue</code> -- the value of the top contributor for each data
    /// point. The identity of the contributor might change for each data point in the graph.
    /// </para>
    ///  
    /// <para>
    /// If this rule aggregates by COUNT, the top contributor for each data point is the contributor
    /// with the most occurrences in that period. If the rule aggregates by SUM, the top contributor
    /// is the contributor with the highest sum in the log field specified by the rule's <code>Value</code>,
    /// during that period.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SampleCount</code> -- the number of data points matched by the rule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Sum</code> -- the sum of the values from all contributors during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Minimum</code> -- the minimum value from a single observation during the time
    /// period represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Maximum</code> -- the maximum value from a single observation during the time
    /// period represented by that data point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Average</code> -- the average value from all contributors during the time period
    /// represented by that data point.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetInsightRuleReportRequest : AmazonCloudWatchRequest
    {
        private DateTime? _endTime;
        private int? _maxContributorCount;
        private List<string> _metrics = new List<string>();
        private string _orderBy;
        private int? _period;
        private string _ruleName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the data to use in the report. When used in a raw HTTP Query API,
        /// it is formatted as <code>yyyy-MM-dd'T'HH:mm:ss</code>. For example, <code>2019-07-01T23:59:59</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        public int MaxContributorCount
        {
            get { return this._maxContributorCount.GetValueOrDefault(); }
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
        ///  <code>UniqueContributors</code> -- the number of unique contributors for each data
        /// point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaxContributorValue</code> -- the value of the top contributor for each data
        /// point. The identity of the contributor might change for each data point in the graph.
        /// </para>
        ///  
        /// <para>
        /// If this rule aggregates by COUNT, the top contributor for each data point is the contributor
        /// with the most occurrences in that period. If the rule aggregates by SUM, the top contributor
        /// is the contributor with the highest sum in the log field specified by the rule's <code>Value</code>,
        /// during that period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SampleCount</code> -- the number of data points matched by the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Sum</code> -- the sum of the values from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Minimum</code> -- the minimum value from a single observation during the time
        /// period represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> -- the maximum value from a single observation during the time
        /// period represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Average</code> -- the average value from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Determines what statistic to use to rank the contributors. Valid values are SUM and
        /// MAXIMUM.
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
        /// The period, in seconds, to use for the statistics in the <code>InsightRuleMetricDatapoint</code>
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
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
        /// it is formatted as <code>yyyy-MM-dd'T'HH:mm:ss</code>. For example, <code>2019-07-01T23:59:59</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}