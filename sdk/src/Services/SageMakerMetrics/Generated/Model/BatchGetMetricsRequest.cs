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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
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
namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetMetrics operation.
    /// Used to retrieve training metrics from SageMaker.
    /// </summary>
    public partial class BatchGetMetricsRequest : AmazonSageMakerMetricsRequest
    {
        private List<MetricQuery> _metricQueries = AWSConfigs.InitializeCollections ? new List<MetricQuery>() : null;

        /// <summary>
        /// Gets and sets the property MetricQueries. 
        /// <para>
        /// Queries made to retrieve training metrics from SageMaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<MetricQuery> MetricQueries
        {
            get { return this._metricQueries; }
            set { this._metricQueries = value; }
        }

        // Check to see if MetricQueries property is set
        internal bool IsSetMetricQueries()
        {
            return this._metricQueries != null && (this._metricQueries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}