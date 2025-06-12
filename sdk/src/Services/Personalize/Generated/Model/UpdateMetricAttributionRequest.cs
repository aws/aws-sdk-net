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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMetricAttribution operation.
    /// Updates a metric attribution.
    /// </summary>
    public partial class UpdateMetricAttributionRequest : AmazonPersonalizeRequest
    {
        private List<MetricAttribute> _addMetrics = AWSConfigs.InitializeCollections ? new List<MetricAttribute>() : null;
        private string _metricAttributionArn;
        private MetricAttributionOutput _metricsOutputConfig;
        private List<string> _removeMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AddMetrics. 
        /// <para>
        /// Add new metric attributes to the metric attribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<MetricAttribute> AddMetrics
        {
            get { return this._addMetrics; }
            set { this._addMetrics = value; }
        }

        // Check to see if AddMetrics property is set
        internal bool IsSetAddMetrics()
        {
            return this._addMetrics != null && (this._addMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricAttributionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the metric attribution to update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricAttributionArn
        {
            get { return this._metricAttributionArn; }
            set { this._metricAttributionArn = value; }
        }

        // Check to see if MetricAttributionArn property is set
        internal bool IsSetMetricAttributionArn()
        {
            return this._metricAttributionArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsOutputConfig. 
        /// <para>
        /// An output config for the metric attribution.
        /// </para>
        /// </summary>
        public MetricAttributionOutput MetricsOutputConfig
        {
            get { return this._metricsOutputConfig; }
            set { this._metricsOutputConfig = value; }
        }

        // Check to see if MetricsOutputConfig property is set
        internal bool IsSetMetricsOutputConfig()
        {
            return this._metricsOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveMetrics. 
        /// <para>
        /// Remove metric attributes from the metric attribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> RemoveMetrics
        {
            get { return this._removeMetrics; }
            set { this._removeMetrics = value; }
        }

        // Check to see if RemoveMetrics property is set
        internal bool IsSetRemoveMetrics()
        {
            return this._removeMetrics != null && (this._removeMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}