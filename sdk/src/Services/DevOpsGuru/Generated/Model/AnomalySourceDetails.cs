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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Details about the source of the anomalous operational data that triggered the anomaly.
    /// </summary>
    public partial class AnomalySourceDetails
    {
        private List<CloudWatchMetricsDetail> _cloudWatchMetrics = AWSConfigs.InitializeCollections ? new List<CloudWatchMetricsDetail>() : null;
        private List<PerformanceInsightsMetricsDetail> _performanceInsightsMetrics = AWSConfigs.InitializeCollections ? new List<PerformanceInsightsMetricsDetail>() : null;

        /// <summary>
        /// Gets and sets the property CloudWatchMetrics. 
        /// <para>
        /// An array of <c>CloudWatchMetricsDetail</c> objects that contain information about
        /// analyzed CloudWatch metrics that show anomalous behavior. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchMetricsDetail> CloudWatchMetrics
        {
            get { return this._cloudWatchMetrics; }
            set { this._cloudWatchMetrics = value; }
        }

        // Check to see if CloudWatchMetrics property is set
        internal bool IsSetCloudWatchMetrics()
        {
            return this._cloudWatchMetrics != null && (this._cloudWatchMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsMetrics. 
        /// <para>
        /// An array of <c>PerformanceInsightsMetricsDetail</c> objects that contain information
        /// about analyzed Performance Insights metrics that show anomalous behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PerformanceInsightsMetricsDetail> PerformanceInsightsMetrics
        {
            get { return this._performanceInsightsMetrics; }
            set { this._performanceInsightsMetrics = value; }
        }

        // Check to see if PerformanceInsightsMetrics property is set
        internal bool IsSetPerformanceInsightsMetrics()
        {
            return this._performanceInsightsMetrics != null && (this._performanceInsightsMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}