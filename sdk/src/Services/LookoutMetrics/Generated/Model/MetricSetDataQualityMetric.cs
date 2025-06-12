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
    /// An array of <c>DataQualityMetric</c> objects that describes one or more data quality
    /// metrics.
    /// </summary>
    public partial class MetricSetDataQualityMetric
    {
        private List<DataQualityMetric> _dataQualityMetricList = AWSConfigs.InitializeCollections ? new List<DataQualityMetric>() : null;
        private string _metricSetArn;

        /// <summary>
        /// Gets and sets the property DataQualityMetricList. 
        /// <para>
        /// The array of data quality metrics contained in the data quality metric set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataQualityMetric> DataQualityMetricList
        {
            get { return this._dataQualityMetricList; }
            set { this._dataQualityMetricList = value; }
        }

        // Check to see if DataQualityMetricList property is set
        internal bool IsSetDataQualityMetricList()
        {
            return this._dataQualityMetricList != null && (this._dataQualityMetricList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data quality metric array.
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

    }
}