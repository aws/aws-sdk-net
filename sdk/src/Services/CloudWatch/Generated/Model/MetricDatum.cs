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
    /// Encapsulates the information sent to either create a metric or add new values to be
    /// aggregated into an existing metric.
    /// </summary>
    public partial class MetricDatum
    {
        private List<double> _counts = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private string _metricName;
        private StatisticSet _statisticValues;
        private int? _storageResolution;
        private DateTime? _timestamp;
        private StandardUnit _unit;
        private double? _value;
        private List<double> _values = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property Counts. 
        /// <para>
        /// Array of numbers that is used along with the <c>Values</c> array. Each number in the
        /// <c>Count</c> array is the number of times the corresponding value in the <c>Values</c>
        /// array occurred during the period. 
        /// </para>
        ///  
        /// <para>
        /// If you omit the <c>Counts</c> array, the default of 1 is used as the value for each
        /// count. If you include a <c>Counts</c> array, it must include the same amount of values
        /// as the <c>Values</c> array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Counts
        {
            get { return this._counts; }
            set { this._counts = value; }
        }

        // Check to see if Counts property is set
        internal bool IsSetCounts()
        {
            return this._counts != null && (this._counts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions associated with the metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html#high-resolution-metrics">High-Resolution
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This field is optional, if you do not specify it the default of 60 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? StorageResolution
        {
            get { return this._storageResolution; }
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
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
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
        /// When you are using a <c>Put</c> operation, this defines what unit you want to use
        /// when storing the metric.
        /// </para>
        ///  
        /// <para>
        /// In a <c>Get</c> operation, this displays the unit that is used for the metric.
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
        /// are either too small or too large. Values must be in the range of -2^360 to 2^360.
        /// In addition, special values (for example, NaN, +Infinity, -Infinity) are not supported.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Array of numbers representing the values for the metric during the period. Each unique
        /// value is listed just once in this array, and the corresponding number in the <c>Counts</c>
        /// array specifies the number of times that value occurred during the period. You can
        /// include up to 150 unique values in each <c>PutMetricData</c> action that specifies
        /// a <c>Values</c> array.
        /// </para>
        ///  
        /// <para>
        /// Although the <c>Values</c> array accepts numbers of type <c>Double</c>, CloudWatch
        /// rejects values that are either too small or too large. Values must be in the range
        /// of -2^360 to 2^360. In addition, special values (for example, NaN, +Infinity, -Infinity)
        /// are not supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}