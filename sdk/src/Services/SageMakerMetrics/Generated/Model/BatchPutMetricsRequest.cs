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

namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutMetrics operation.
    /// Used to ingest training metrics into SageMaker. These metrics can be visualized in
    /// SageMaker Studio and retrieved with the <code>GetMetrics</code> API.
    /// </summary>
    public partial class BatchPutMetricsRequest : AmazonSageMakerMetricsRequest
    {
        private List<RawMetricData> _metricData = new List<RawMetricData>();
        private string _trialComponentName;

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        /// A list of raw metric values to put.
        /// </para>
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
            return this._metricData != null && this._metricData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the Trial Component to associate with the metrics.
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