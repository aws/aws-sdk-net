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
    /// The configuration of the alert filters.
    /// </summary>
    public partial class AlertFilters
    {
        private List<DimensionFilter> _dimensionFilterList = AWSConfigs.InitializeCollections ? new List<DimensionFilter>() : null;
        private List<string> _metricList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DimensionFilterList. 
        /// <para>
        /// The list of DimensionFilter objects that are used for dimension-based filtering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<DimensionFilter> DimensionFilterList
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
        /// Gets and sets the property MetricList. 
        /// <para>
        /// The list of measures that you want to get alerts for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> MetricList
        {
            get { return this._metricList; }
            set { this._metricList = value; }
        }

        // Check to see if MetricList property is set
        internal bool IsSetMetricList()
        {
            return this._metricList != null && (this._metricList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}