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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Represents a collection of cost drivers and their associated metrics for cost comparison
    /// analysis.
    /// </summary>
    public partial class CostComparisonDriver
    {
        private List<CostDriver> _costDrivers = AWSConfigs.InitializeCollections ? new List<CostDriver>() : null;
        private Expression _costSelector;
        private Dictionary<string, ComparisonMetricValue> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, ComparisonMetricValue>() : null;

        /// <summary>
        /// Gets and sets the property CostDrivers. 
        /// <para>
        /// An array of cost drivers, each representing a cost difference between the baseline
        /// and comparison time periods. Each entry also includes a metric delta (for example,
        /// usage change) that contributed to the cost variance, along with the identifier and
        /// type of change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CostDriver> CostDrivers
        {
            get { return this._costDrivers; }
            set { this._costDrivers = value; }
        }

        // Check to see if CostDrivers property is set
        internal bool IsSetCostDrivers()
        {
            return this._costDrivers != null && (this._costDrivers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CostSelector.
        /// </summary>
        public Expression CostSelector
        {
            get { return this._costSelector; }
            set { this._costSelector = value; }
        }

        // Check to see if CostSelector property is set
        internal bool IsSetCostSelector()
        {
            return this._costSelector != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A mapping of metric names to their comparison values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComparisonMetricValue> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}