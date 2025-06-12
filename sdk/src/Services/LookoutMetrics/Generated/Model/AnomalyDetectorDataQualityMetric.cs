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
    /// Aggregated details about the data quality metrics collected for the <c>AnomalyDetectorArn</c>
    /// provided in the <a>GetDataQualityMetrics</a> object.
    /// </summary>
    public partial class AnomalyDetectorDataQualityMetric
    {
        private List<MetricSetDataQualityMetric> _metricSetDataQualityMetricList = AWSConfigs.InitializeCollections ? new List<MetricSetDataQualityMetric>() : null;
        private DateTime? _startTimestamp;

        /// <summary>
        /// Gets and sets the property MetricSetDataQualityMetricList. 
        /// <para>
        /// An array of <c>DataQualityMetricList</c> objects. Each object in the array contains
        /// information about a data quality metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricSetDataQualityMetric> MetricSetDataQualityMetricList
        {
            get { return this._metricSetDataQualityMetricList; }
            set { this._metricSetDataQualityMetricList = value; }
        }

        // Check to see if MetricSetDataQualityMetricList property is set
        internal bool IsSetMetricSetDataQualityMetricList()
        {
            return this._metricSetDataQualityMetricList != null && (this._metricSetDataQualityMetricList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The start time for the data quality metrics collection.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

    }
}