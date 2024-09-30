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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Use this structure to define a metric or metric math expression that you want to use
    /// as for a service level objective. 
    /// 
    ///  
    /// <para>
    /// Each <c>MetricDataQuery</c> in the <c>MetricDataQueries</c> array specifies either
    /// a metric to retrieve, or a metric math expression to be performed on retrieved metrics.
    /// A single <c>MetricDataQueries</c> array can include as many as 20 <c>MetricDataQuery</c>
    /// structures in the array. The 20 structures can include as many as 10 structures that
    /// contain a <c>MetricStat</c> parameter to retrieve a metric, and as many as 10 structures
    /// that contain the <c>Expression</c> parameter to perform a math expression. Of those
    /// <c>Expression</c> structures, exactly one must have true as the value for <c>ReturnData</c>.
    /// The result of this expression used for the SLO.
    /// </para>
    ///  
    /// <para>
    /// For more information about metric math expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html">CloudWatchUse
    /// metric math</a>.
    /// </para>
    ///  
    /// <para>
    /// Within each <c>MetricDataQuery</c> object, you must specify either <c>Expression</c>
    /// or <c>MetricStat</c> but not both.
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
        /// The ID of the account where this metric is located. If you are performing this operation
        /// in a monitoring account, use this to specify which source account to retrieve this
        /// metric from.
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
        /// This field can contain a metric math expression to be performed on the other metrics
        /// that you are retrieving within this <c>MetricDataQueries</c> structure. 
        /// </para>
        ///  
        /// <para>
        /// A math expression can use the <c>Id</c> of the other metrics or queries to refer to
        /// those metrics, and can also use the <c>Id</c> of other expressions to use the result
        /// of those expressions. For more information about metric math expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
        /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Within each <c>MetricDataQuery</c> object, you must specify either <c>Expression</c>
        /// or <c>MetricStat</c> but not both.
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
        /// A short name used to tie this object to the results in the response. This <c>Id</c>
        /// must be unique within a <c>MetricDataQueries</c> array. If you are performing math
        /// expressions on this set of data, this name represents that data and can serve as a
        /// variable in the metric math expression. The valid characters are letters, numbers,
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
        /// expression is shown in a CloudWatch dashboard widget, the label is shown. If <c>Label</c>
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
        /// A metric to be used directly for the SLO, or to be used in the math expression that
        /// will be used for the SLO.
        /// </para>
        ///  
        /// <para>
        /// Within one <c>MetricDataQuery</c> object, you must specify either <c>Expression</c>
        /// or <c>MetricStat</c> but not both.
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
        /// The granularity, in seconds, of the returned data points for this metric. For metrics
        /// with regular resolution, a period can be as short as one minute (60 seconds) and must
        /// be a multiple of 60. For high-resolution metrics that are collected at intervals of
        /// less than one minute, the period can be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution
        /// metrics are those metrics stored by a <c>PutMetricData</c> call that includes a <c>StorageResolution</c>
        /// of 1 second.
        /// </para>
        ///  
        /// <para>
        /// If the <c>StartTime</c> parameter specifies a time stamp that is greater than 3 hours
        /// ago, you must specify the period as follows or no data points in that time range is
        /// returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start time between 3 hours and 15 days ago - Use a multiple of 60 seconds (1 minute).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time between 15 and 63 days ago - Use a multiple of 300 seconds (5 minutes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time greater than 63 days ago - Use a multiple of 3600 seconds (1 hour).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ReturnData. 
        /// <para>
        /// Use this only if you are using a metric math expression for the SLO. Specify <c>true</c>
        /// for <c>ReturnData</c> for only the one expression result to use as the alarm. For
        /// all other metrics and expressions in the same <c>CreateServiceLevelObjective</c> operation,
        /// specify <c>ReturnData</c> as <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnData
        {
            get { return this._returnData; }
            set { this._returnData = value; }
        }

        // Check to see if ReturnData property is set
        internal bool IsSetReturnData()
        {
            return this._returnData.HasValue; 
        }

    }
}