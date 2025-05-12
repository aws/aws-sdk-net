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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the GetScalingConfigurationRecommendation operation.
    /// </summary>
    public partial class GetScalingConfigurationRecommendationResponse : AmazonWebServiceResponse
    {
        private DynamicScalingConfiguration _dynamicScalingConfiguration;
        private string _endpointName;
        private string _inferenceRecommendationsJobName;
        private ScalingPolicyMetric _metric;
        private string _recommendationId;
        private ScalingPolicyObjective _scalingPolicyObjective;
        private int? _targetCpuUtilizationPerCore;

        /// <summary>
        /// Gets and sets the property DynamicScalingConfiguration. 
        /// <para>
        /// An object with the recommended values for you to specify when creating an autoscaling
        /// policy.
        /// </para>
        /// </summary>
        public DynamicScalingConfiguration DynamicScalingConfiguration
        {
            get { return this._dynamicScalingConfiguration; }
            set { this._dynamicScalingConfiguration = value; }
        }

        // Check to see if DynamicScalingConfiguration property is set
        internal bool IsSetDynamicScalingConfiguration()
        {
            return this._dynamicScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an endpoint benchmarked during a previously completed Inference Recommender
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceRecommendationsJobName. 
        /// <para>
        /// The name of a previously completed Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string InferenceRecommendationsJobName
        {
            get { return this._inferenceRecommendationsJobName; }
            set { this._inferenceRecommendationsJobName = value; }
        }

        // Check to see if InferenceRecommendationsJobName property is set
        internal bool IsSetInferenceRecommendationsJobName()
        {
            return this._inferenceRecommendationsJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// An object with a list of metrics that were benchmarked during the previously completed
        /// Inference Recommender job.
        /// </para>
        /// </summary>
        public ScalingPolicyMetric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID of a previously completed inference recommendation.
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

        /// <summary>
        /// Gets and sets the property ScalingPolicyObjective. 
        /// <para>
        /// An object representing the anticipated traffic pattern for an endpoint that you specified
        /// in the request.
        /// </para>
        /// </summary>
        public ScalingPolicyObjective ScalingPolicyObjective
        {
            get { return this._scalingPolicyObjective; }
            set { this._scalingPolicyObjective = value; }
        }

        // Check to see if ScalingPolicyObjective property is set
        internal bool IsSetScalingPolicyObjective()
        {
            return this._scalingPolicyObjective != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCpuUtilizationPerCore. 
        /// <para>
        /// The percentage of how much utilization you want an instance to use before autoscaling,
        /// which you specified in the request. The default value is 50%.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? TargetCpuUtilizationPerCore
        {
            get { return this._targetCpuUtilizationPerCore; }
            set { this._targetCpuUtilizationPerCore = value; }
        }

        // Check to see if TargetCpuUtilizationPerCore property is set
        internal bool IsSetTargetCpuUtilizationPerCore()
        {
            return this._targetCpuUtilizationPerCore.HasValue; 
        }

    }
}