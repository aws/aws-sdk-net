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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure indicates the metric data to return, and whether this call is just
    /// retrieving a batch set of data for one metric, or is performing a math expression
    /// on metric data. A single <code>GetMetricData</code> call can include up to 100 <code>MetricDataQuery</code>
    /// structures.
    /// </summary>
    public partial class MetricDataQuery
    {
        private string _expression;
        private string _id;
        private string _label;
        private MetricStat _metricStat;
        private bool? _returnData;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The math expression to be performed on the returned data, if this structure is performing
        /// a math expression. For more information about metric math expressions, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
        /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Within one MetricDataQuery structure, you must specify either <code>Expression</code>
        /// or <code>MetricStat</code> but not both.
        /// </para>
        /// </summary>
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
        /// A short name used to tie this structure to the results in the response. This name
        /// must be unique within a single call to <code>GetMetricData</code>. If you are performing
        /// math expressions on this set of data, this name represents that data and can serve
        /// as a variable in the mathematical expression. The valid characters are letters, numbers,
        /// and underscore. The first character must be a lowercase letter.
        /// </para>
        /// </summary>
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
        /// only if this structure is performing a data retrieval and not performing a math expression
        /// on the returned data.
        /// </para>
        ///  
        /// <para>
        /// Within one MetricDataQuery structure, you must specify either <code>Expression</code>
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
        /// Gets and sets the property ReturnData. 
        /// <para>
        /// Indicates whether to return the time stamps and raw data values of this metric. If
        /// you are performing this call just to do math expressions and do not also need the
        /// raw data returned, you can specify <code>False</code>. If you omit this, the default
        /// of <code>True</code> is used.
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