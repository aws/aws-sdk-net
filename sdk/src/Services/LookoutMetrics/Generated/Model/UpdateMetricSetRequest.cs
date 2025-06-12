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
    /// Container for the parameters to the UpdateMetricSet operation.
    /// Updates a dataset.
    /// </summary>
    public partial class UpdateMetricSetRequest : AmazonLookoutMetricsRequest
    {
        private List<MetricSetDimensionFilter> _dimensionFilterList = AWSConfigs.InitializeCollections ? new List<MetricSetDimensionFilter>() : null;
        private List<string> _dimensionList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Metric> _metricList = AWSConfigs.InitializeCollections ? new List<Metric>() : null;
        private string _metricSetArn;
        private string _metricSetDescription;
        private Frequency _metricSetFrequency;
        private MetricSource _metricSource;
        private int? _offset;
        private TimestampColumn _timestampColumn;

        /// <summary>
        /// Gets and sets the property DimensionFilterList. 
        /// <para>
        /// Describes a list of filters for choosing specific dimensions and specific values.
        /// Each filter consists of the dimension and one of its values that you want to include.
        /// When multiple dimensions or values are specified, the dimensions are joined with an
        /// AND operation and the values are joined with an OR operation.
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
        /// The dimension list.
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
        /// Gets and sets the property MetricList. 
        /// <para>
        /// The metric list.
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
        /// The ARN of the dataset to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// The dataset's interval.
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
        /// Gets and sets the property MetricSource.
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
        /// The timestamp column.
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

    }
}