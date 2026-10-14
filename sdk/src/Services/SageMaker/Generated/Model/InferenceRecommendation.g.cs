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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of recommendations made by Amazon SageMaker Inference Recommender.
    /// </summary>
    public partial class InferenceRecommendation
    {
        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// Defines the endpoint configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointOutputConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvocationEndTime. 
        /// <para>
        /// A timestamp that shows when the benchmark completed.
        /// </para>
        /// </summary>
        public DateTime? InvocationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the InvocationEndTime property is set.
        /// </summary>
        internal bool IsSetInvocationEndTime() => this.InvocationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InvocationStartTime. 
        /// <para>
        /// A timestamp that shows when the benchmark started.
        /// </para>
        /// </summary>
        public DateTime? InvocationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the InvocationStartTime property is set.
        /// </summary>
        internal bool IsSetInvocationStartTime() => this.InvocationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics used to decide what recommendation to make.
        /// </para>
        /// </summary>
        public RecommendationMetrics Metrics { get; set; }

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null;

        /// <summary>
        /// Gets and sets the property ModelConfiguration. 
        /// <para>
        /// Defines the model configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelConfiguration ModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfiguration property is set.
        /// </summary>
        internal bool IsSetModelConfiguration() => this.ModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID which uniquely identifies each recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;
    }
}
