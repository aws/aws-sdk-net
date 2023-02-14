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
    /// A list of recommendations made by Amazon SageMaker Inference Recommender.
    /// </summary>
    public partial class InferenceRecommendation
    {
        private EndpointOutputConfiguration _endpointConfiguration;
        private RecommendationMetrics _metrics;
        private ModelConfiguration _modelConfiguration;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// Defines the endpoint configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics used to decide what recommendation to make.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <para>
        /// Defines the model configuration.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID which uniquely identifies each recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

    }
}