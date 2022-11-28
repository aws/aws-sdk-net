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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure is used in both <code>GetMetricData</code> and <code>PutMetricAlarm</code>.
    /// The supported use of this structure is different for those two operations.
    /// 
    ///  
    /// <para>
    /// When used in <code>GetMetricData</code>, it indicates the metric data to return, and
    /// whether this call is just retrieving a batch set of data for one metric, or is performing
    /// a Metrics Insights query or a math expression. A single <code>GetMetricData</code>
    /// call can include up to 500 <code>MetricDataQuery</code> structures.
    /// </para>
    ///  
    /// <para>
    /// When used in <code>PutMetricAlarm</code>, it enables you to create an alarm based
    /// on a metric math expression. Each <code>MetricDataQuery</code> in the array specifies
    /// either a metric to retrieve, or a math expression to be performed on retrieved metrics.
    /// A single <code>PutMetricAlarm</code> call can include up to 20 <code>MetricDataQuery</code>
    /// structures in the array. The 20 structures can include as many as 10 structures that
    /// contain a <code>MetricStat</code> parameter to retrieve a metric, and as many as 10
    /// structures that contain the <code>Expression</code> parameter to perform a math expression.
    /// Of those <code>Expression</code> structures, one must have <code>true</code> as the
    /// value for <code>ReturnData</code>. The result of this expression is the value the
    /// alarm watches.
    /// </para>
    ///  
    /// <para>
    /// Any expression used in a <code>PutMetricAlarm</code> operation must return a single
    /// time series. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
    /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Some of the parameters of this structure also have different uses whether you are
    /// using this structure in a <code>GetMetricData</code> operation or a <code>PutMetricAlarm</code>
    /// operation. These differences are explained in the following parameter list.
    /// </para>
    /// </summary>
    public partial class MetricDataQuery
    {
        private string _accountId;
        private string _expression;
        private string _id;
        private string _label;
        private MetricStat _metricStat;
        private int? _period;
        private bool? _returnData;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account where the metrics are located.
        /// </para>
        ///  
        /// <para>
        /// If you are performing a <code>GetMetricData</code> operation in a monitoring account,
        /// use this to specify which account to retrieve this metric from.
        /// </para>
        ///  
        /// <para>
        /// If you are performing a <code>PutMetricAlarm</code> operation, use this to specify
        /// which account contains the metric that the alarm is watching.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// This field can contain either a Metrics Insights query, or a metric math expression
        /// to be performed on the returned data. For more information about Metrics Insights
        /// queries, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch-metrics-insights-querylanguage">Metrics
        /// Insights query components and syntax</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A math expression can use the <code>Id</code> of the other metrics or queries to refer
        /// to those metrics, and can also use the <code>Id</code> of other expressions to use
        /// the result of those expressions. For more information about metric math expressions,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
        /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Within each MetricDataQuery object, you must specify either <code>Expression</code>
        /// or <code>MetricStat</code> but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A short name used to tie this object to the results in the response. This name must
        /// be unique within a single call to <code>GetMetricData</code>. If you are performing
        /// math expressions on this set of data, this name represents that data and can serve
        /// as a variable in the mathematical expression. The valid characters are letters, numbers,
        /// and underscore. The first character must be a lowercase letter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A human-readable label for this metric or expression. This is especially useful if
        /// this is an expression, so that you know what the value represents. If the metric or
        /// expression is shown in a CloudWatch dashboard widget, the label is shown. If Label
        /// is omitted, CloudWatch generates a default.
        /// </para>
        ///  
        /// <para>
        /// You can put dynamic expressions into a label, so that it is more descriptive. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/graph-dynamic-labels.html">Using
        /// Dynamic Labels</a>.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property MetricStat. 
        /// <para>
        /// The metric to be returned, along with statistics, period, and units. Use this parameter
        /// only if this object is retrieving a metric and not performing a math expression on
        /// returned data.
        /// </para>
        ///  
        /// <para>
        /// Within one MetricDataQuery object, you must specify either <code>Expression</code>
        /// or <code>MetricStat</code> but not both.
        /// </para>
        /// </summary>
        public MetricStat MetricStat
        {
            get { return this._metricStat; }
            set { this._metricStat = value; }
        }

        // Check to see if MetricStat property is set
        internal bool IsSetMetricStat()
        {
            return this._metricStat != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points. For metrics with regular
        /// resolution, a period can be as short as one minute (60 seconds) and must be a multiple
        /// of 60. For high-resolution metrics that are collected at intervals of less than one
        /// minute, the period can be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution
        /// metrics are those metrics stored by a <code>PutMetricData</code> operation that includes
        /// a <code>StorageResolution of 1 second</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ReturnData. 
        /// <para>
        /// When used in <code>GetMetricData</code>, this option indicates whether to return the
        /// timestamps and raw data values of this metric. If you are performing this call just
        /// to do math expressions and do not also need the raw data returned, you can specify
        /// <code>false</code>. If you omit this, the default of <code>true</code> is used.
        /// </para>
        ///  
        /// <para>
        /// When used in <code>PutMetricAlarm</code>, specify <code>true</code> for the one expression
        /// result to use as the alarm. For all other metrics and expressions in the same <code>PutMetricAlarm</code>
        /// operation, specify <code>ReturnData</code> as False.
        /// </para>
        /// </summary>
        public bool ReturnData
        {
            get { return this._returnData.GetValueOrDefault(); }
            set { this._returnData = value; }
        }

        // Check to see if ReturnData property is set
        internal bool IsSetReturnData()
        {
            return this._returnData.HasValue; 
        }

    }
}