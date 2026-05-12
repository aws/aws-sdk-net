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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Identifies the metric source for SLOs on resources other than Application Signals
    /// services.
    /// </summary>
    public partial class MetricSource
    {
        private Dictionary<string, string> _metricSourceAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _metricSourceKeyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property MetricSourceAttributes. 
        /// <para>
        /// Additional attributes for the metric source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public Dictionary<string, string> MetricSourceAttributes
        {
            get { return this._metricSourceAttributes; }
            set { this._metricSourceAttributes = value; }
        }

        // Check to see if MetricSourceAttributes property is set
        internal bool IsSetMetricSourceAttributes()
        {
            return this._metricSourceAttributes != null && (this._metricSourceAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricSourceKeyAttributes. 
        /// <para>
        /// Key attributes that identify the metric source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> MetricSourceKeyAttributes
        {
            get { return this._metricSourceKeyAttributes; }
            set { this._metricSourceKeyAttributes = value; }
        }

        // Check to see if MetricSourceKeyAttributes property is set
        internal bool IsSetMetricSourceKeyAttributes()
        {
            return this._metricSourceKeyAttributes != null && (this._metricSourceKeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}