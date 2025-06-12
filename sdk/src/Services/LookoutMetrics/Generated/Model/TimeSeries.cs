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
    /// Details about a metric. A metric is an aggregation of the values of a measure for
    /// a dimension value, such as <i>availability</i> in the <i>us-east-1</i> Region.
    /// </summary>
    public partial class TimeSeries
    {
        private List<DimensionNameValue> _dimensionList = AWSConfigs.InitializeCollections ? new List<DimensionNameValue>() : null;
        private List<double> _metricValueList = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private string _timeSeriesId;

        /// <summary>
        /// Gets and sets the property DimensionList. 
        /// <para>
        /// The dimensions of the metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DimensionNameValue> DimensionList
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
        /// Gets and sets the property MetricValueList. 
        /// <para>
        /// The values for the metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> MetricValueList
        {
            get { return this._metricValueList; }
            set { this._metricValueList = value; }
        }

        // Check to see if MetricValueList property is set
        internal bool IsSetMetricValueList()
        {
            return this._metricValueList != null && (this._metricValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=520)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

    }
}