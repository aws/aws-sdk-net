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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetricSet operation.
    /// </summary>
    public partial class DescribeMetricSetResponse : AmazonWebServiceResponse
    {
        private string _anomalyDetectorArn;
        private DateTime? _creationTime;
        private List<MetricSetDimensionFilter> _dimensionFilterList = AWSConfigs.InitializeCollections ? new List<MetricSetDimensionFilter>() : null;
        private List<string> _dimensionList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastModificationTime;
        private List<Metric> _metricList = AWSConfigs.InitializeCollections ? new List<Metric>() : null;
        private string _metricSetArn;
        private string _metricSetDescription;
        private Frequency _metricSetFrequency;
        private string _metricSetName;
        private MetricSource _metricSource;
        private int? _offset;
        private TimestampColumn _timestampColumn;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector that contains the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DimensionFilterList. 
        /// <para>
        /// The dimensions and their values that were used to filter the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricSetDimensionFilter> DimensionFilterList
        {
            get { return this._dimensionFilterList; }
            set { this._dimensionFilterList = value; }
        }

        // Check to see if DimensionFilterList property is set
        internal bool IsSetDimensionFilterList()
        {
            return this._dimensionFilterList != null && (this._dimensionFilterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DimensionList. 
        /// <para>
        /// A list of the dimensions chosen for analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._dimensionList != null && (this._dimensionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time at which the dataset was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricList. 
        /// <para>
        /// A list of the metrics defined by the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Metric> MetricList
        {
            get { return this._metricList; }
            set { this._metricList = value; }
        }

        // Check to see if MetricList property is set
        internal bool IsSetMetricList()
        {
            return this._metricList != null && (this._metricList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricSetArn. 
        /// <para>
        /// The ARN of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricSetArn
        {
            get { return this._metricSetArn; }
            set { this._metricSetArn = value; }
        }

        // Check to see if MetricSetArn property is set
        internal bool IsSetMetricSetArn()
        {
            return this._metricSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetDescription. 
        /// <para>
        /// The dataset's description.
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
        /// The interval at which the data will be analyzed for anomalies.
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
        [AWSProperty(Min=1, Max=63)]
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
        /// Contains information about the dataset's source data.
        /// </para>
        /// </summary>
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
        public int? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
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
        /// The time zone in which the dataset's data was recorded.
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