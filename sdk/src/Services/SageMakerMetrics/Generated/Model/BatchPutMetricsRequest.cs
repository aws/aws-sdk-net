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
    /// Container for the parameters to the BatchPutMetrics operation.
    /// Used to ingest training metrics into SageMaker. These metrics can be visualized in
    /// SageMaker Studio.
    /// </summary>
    public partial class BatchPutMetricsRequest : AmazonSageMakerMetricsRequest
    {
        private List<RawMetricData> _metricData = AWSConfigs.InitializeCollections ? new List<RawMetricData>() : null;
        private string _trialComponentName;

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        /// A list of raw metric values to put.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<RawMetricData> MetricData
        {
            get { return this._metricData; }
            set { this._metricData = value; }
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this._metricData != null && (this._metricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the Trial Component to associate with the metrics. The Trial Component
        /// name must be entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string TrialComponentName
        {
            get { return this._trialComponentName; }
            set { this._trialComponentName = value; }
        }

        // Check to see if TrialComponentName property is set
        internal bool IsSetTrialComponentName()
        {
            return this._trialComponentName != null;
        }

    }
}