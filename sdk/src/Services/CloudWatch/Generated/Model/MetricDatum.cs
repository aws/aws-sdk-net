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
    /// The <code>MetricDatum</code> data type encapsulates the information sent with <a>PutMetricData</a>
    /// to either create a new metric or add new values to be aggregated into an existing
    /// metric.
    /// </summary>
    public partial class MetricDatum
    {
        private List<Dimension> _dimensions = new List<Dimension>();
        private string _metricName;
        private StatisticSet _statisticValues;
        private DateTime? _timestamp;
        private StandardUnit _unit;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  A list of dimensions associated with the metric. Note, when using the Dimensions
        /// value in a query, you need to append .member.N to it (e.g., Dimensions.member.N).
        /// 
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the metric. 
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticValues. 
        /// <para>
        ///  A set of statistical values describing the metric. 
        /// </para>
        /// </summary>
        public StatisticSet StatisticValues
        {
            get { return this._statisticValues; }
            set { this._statisticValues = value; }
        }

        // Check to see if StatisticValues property is set
        internal bool IsSetStatisticValues()
        {
            return this._statisticValues != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  The time stamp used for the metric in ISO 8601 Universal Coordinated Time (UTC) format.
        /// If not specified, the default value is set to the time the metric data was received.
        /// 
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of the metric. 
        /// </para>
        /// </summary>
        public StandardUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value for the metric. 
        /// </para>
        ///  <important>Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// Amazon CloudWatch rejects values that are either too small or too large. Values must
        /// be in the range of 8.515920e-109 to 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base
        /// 2). In addition, special values (e.g., NaN, +Infinity, -Infinity) are not supported.
        /// </important>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}