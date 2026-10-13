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
    /// This is the response object from the GetScalingConfigurationRecommendation operation.
    /// </summary>
    public partial class GetScalingConfigurationRecommendationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DynamicScalingConfiguration. 
        /// <para>
        /// An object with the recommended values for you to specify when creating an autoscaling
        /// policy.
        /// </para>
        /// </summary>
        public DynamicScalingConfiguration DynamicScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DynamicScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetDynamicScalingConfiguration() => this.DynamicScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an endpoint benchmarked during a previously completed Inference Recommender
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property InferenceRecommendationsJobName. 
        /// <para>
        /// The name of a previously completed Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InferenceRecommendationsJobName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRecommendationsJobName property is set.
        /// </summary>
        internal bool IsSetInferenceRecommendationsJobName() => this.InferenceRecommendationsJobName != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// An object with a list of metrics that were benchmarked during the previously completed
        /// Inference Recommender job.
        /// </para>
        /// </summary>
        public ScalingPolicyMetric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID of a previously completed inference recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property ScalingPolicyObjective. 
        /// <para>
        /// An object representing the anticipated traffic pattern for an endpoint that you specified
        /// in the request.
        /// </para>
        /// </summary>
        public ScalingPolicyObjective ScalingPolicyObjective { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPolicyObjective property is set.
        /// </summary>
        internal bool IsSetScalingPolicyObjective() => this.ScalingPolicyObjective != null;

        /// <summary>
        /// Gets and sets the property TargetCpuUtilizationPerCore. 
        /// <para>
        /// The percentage of how much utilization you want an instance to use before autoscaling,
        /// which you specified in the request. The default value is 50%.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? TargetCpuUtilizationPerCore { get; set; }

        /// <summary>
        /// Checks to see if the TargetCpuUtilizationPerCore property is set.
        /// </summary>
        internal bool IsSetTargetCpuUtilizationPerCore() => this.TargetCpuUtilizationPerCore.HasValue;
    }
}
