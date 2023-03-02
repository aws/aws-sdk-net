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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The details for a specific benchmark from an Inference Recommender job.
    /// </summary>
    public partial class RecommendationJobInferenceBenchmark
    {
        private EndpointOutputConfiguration _endpointConfiguration;
        private InferenceMetrics _endpointMetrics;
        private string _failureReason;
        private RecommendationMetrics _metrics;
        private ModelConfiguration _modelConfiguration;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration.
        /// </summary>
        public EndpointOutputConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointMetrics.
        /// </summary>
        public InferenceMetrics EndpointMetrics
        {
            get { return this._endpointMetrics; }
            set { this._endpointMetrics = value; }
        }

        // Check to see if EndpointMetrics property is set
        internal bool IsSetEndpointMetrics()
        {
            return this._endpointMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why a benchmark failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics.
        /// </summary>
        public RecommendationMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelConfiguration ModelConfiguration
        {
            get { return this._modelConfiguration; }
            set { this._modelConfiguration = value; }
        }

        // Check to see if ModelConfiguration property is set
        internal bool IsSetModelConfiguration()
        {
            return this._modelConfiguration != null;
        }

    }
}