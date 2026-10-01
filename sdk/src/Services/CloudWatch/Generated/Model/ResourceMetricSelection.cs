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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Specifies which metrics Amazon CloudWatch collects for a resource metrics configuration.
    /// Include this in a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_CreateResourceMetricsConfiguration.html">CreateResourceMetricsConfiguration</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UpdateResourceMetricsConfiguration.html">UpdateResourceMetricsConfiguration</a>
    /// request to limit collection to a specific set of metrics. If you omit metric selections,
    /// Amazon CloudWatch collects all available detailed metrics for the resource.
    /// </summary>
    public partial class ResourceMetricSelection
    {
        private List<string> _includeMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IncludeMetrics. 
        /// <para>
        /// The names of the metrics to collect for the resource. Amazon CloudWatch collects only
        /// the metrics that you list here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<string> IncludeMetrics
        {
            get { return this._includeMetrics; }
            set { this._includeMetrics = value; }
        }

        // Check to see if IncludeMetrics property is set
        internal bool IsSetIncludeMetrics()
        {
            return this._includeMetrics != null && (this._includeMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}