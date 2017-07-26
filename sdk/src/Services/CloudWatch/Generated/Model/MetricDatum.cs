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
    /// Encapsulates the information sent to either create a metric or add new values to be
    /// aggregated into an existing metric.
    /// </summary>
    public partial class MetricDatum
    {
        private List<Dimension> _dimensions = new List<Dimension>();
        private string _metricName;
        private StatisticSet _statisticValues;
        private int? _storageResolution;
        private DateTime? _timestamp;
        private StandardUnit _unit;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions associated with the metric.
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
        /// The name of the metric.
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
        /// The statistical values for the metric.
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
        /// Gets and sets the property StorageResolution. 
        /// <para>
        /// Valid values are 1 and 60. Setting this to 1 specifies this metric as a high-resolution
        /// metric, so that CloudWatch stores the metric with sub-minute resolution down to one
        /// second. Setting this to 60 specifies this metric as a regular-resolution metric, which
        /// CloudWatch stores at 1-minute resolution. Currently, high resolution is available
        /// only for custom metrics. For more information about high-resolution metrics, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html#high-resolution-metrics">High-Resolution
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This field is optional, if you do not specify it the default of 60 is used.
        /// </para>
        /// </summary>
        public int StorageResolution
        {
            get { return this._storageResolution.GetValueOrDefault(); }
            set { this._storageResolution = value; }
        }

        // Check to see if StorageResolution property is set
        internal bool IsSetStorageResolution()
        {
            return this._storageResolution.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time the metric data was received, expressed as the number of milliseconds since
        /// Jan 1, 1970 00:00:00 UTC.
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
        /// The unit of the metric.
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
        /// The value for the metric.
        /// </para>
        ///  
        /// <para>
        /// Although the parameter accepts numbers of type Double, CloudWatch rejects values that
        /// are either too small or too large. Values must be in the range of 8.515920e-109 to
        /// 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base 2). In addition, special values (for
        /// example, NaN, +Infinity, -Infinity) are not supported.
        /// </para>
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