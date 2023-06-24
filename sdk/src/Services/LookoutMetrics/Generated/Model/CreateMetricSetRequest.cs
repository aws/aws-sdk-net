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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMetricSet operation.
    /// Creates a dataset.
    /// </summary>
    public partial class CreateMetricSetRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private List<MetricSetDimensionFilter> _dimensionFilterList = new List<MetricSetDimensionFilter>();
        private List<string> _dimensionList = new List<string>();
        private List<Metric> _metricList = new List<Metric>();
        private string _metricSetDescription;
        private Frequency _metricSetFrequency;
        private string _metricSetName;
        private MetricSource _metricSource;
        private int? _offset;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TimestampColumn _timestampColumn;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector that will use the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionFilterList. 
        /// <para>
        /// A list of filters that specify which data is kept for anomaly detection.
        /// </para>
        /// </summary>
        public List<MetricSetDimensionFilter> DimensionFilterList
        {
            get { return this._dimensionFilterList; }
            set { this._dimensionFilterList = value; }
        }

        // Check to see if DimensionFilterList property is set
        internal bool IsSetDimensionFilterList()
        {
            return this._dimensionFilterList != null && this._dimensionFilterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DimensionList. 
        /// <para>
        /// A list of the fields you want to treat as dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> DimensionList
        {
            get { return this._dimensionList; }
            set { this._dimensionList = value; }
        }

        // Check to see if DimensionList property is set
        internal bool IsSetDimensionList()
        {
            return this._dimensionList != null && this._dimensionList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricList. 
        /// <para>
        /// A list of metrics that the dataset will contain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<Metric> MetricList
        {
            get { return this._metricList; }
            set { this._metricList = value; }
        }

        // Check to see if MetricList property is set
        internal bool IsSetMetricList()
        {
            return this._metricList != null && this._metricList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricSetDescription. 
        /// <para>
        /// A description of the dataset you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetricSetDescription
        {
            get { return this._metricSetDescription; }
            set { this._metricSetDescription = value; }
        }

        // Check to see if MetricSetDescription property is set
        internal bool IsSetMetricSetDescription()
        {
            return this._metricSetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetFrequency. 
        /// <para>
        /// The frequency with which the source data will be analyzed for anomalies.
        /// </para>
        /// </summary>
        public Frequency MetricSetFrequency
        {
            get { return this._metricSetFrequency; }
            set { this._metricSetFrequency = value; }
        }

        // Check to see if MetricSetFrequency property is set
        internal bool IsSetMetricSetFrequency()
        {
            return this._metricSetFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MetricSetName
        {
            get { return this._metricSetName; }
            set { this._metricSetName = value; }
        }

        // Check to see if MetricSetName property is set
        internal bool IsSetMetricSetName()
        {
            return this._metricSetName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSource. 
        /// <para>
        /// Contains information about how the source data should be interpreted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricSource MetricSource
        {
            get { return this._metricSource; }
            set { this._metricSource = value; }
        }

        // Check to see if MetricSource property is set
        internal bool IsSetMetricSource()
        {
            return this._metricSource != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// After an interval ends, the amount of seconds that the detector waits before importing
        /// data. Offset is only supported for S3, Redshift, Athena and datasources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=432000)]
        public int Offset
        {
            get { return this._offset.GetValueOrDefault(); }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to apply to the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimestampColumn. 
        /// <para>
        /// Contains information about the column used for tracking time in your source data.
        /// </para>
        /// </summary>
        public TimestampColumn TimestampColumn
        {
            get { return this._timestampColumn; }
            set { this._timestampColumn = value; }
        }

        // Check to see if TimestampColumn property is set
        internal bool IsSetTimestampColumn()
        {
            return this._timestampColumn != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone in which your source data was recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Max=60)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}