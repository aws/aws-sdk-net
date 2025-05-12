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
    /// Container for the parameters to the GetScalingConfigurationRecommendation operation.
    /// Starts an Amazon SageMaker Inference Recommender autoscaling recommendation job. Returns
    /// recommendations for autoscaling policies that you can apply to your SageMaker endpoint.
    /// </summary>
    public partial class GetScalingConfigurationRecommendationRequest : AmazonSageMakerRequest
    {
        private string _endpointName;
        private string _inferenceRecommendationsJobName;
        private string _recommendationId;
        private ScalingPolicyObjective _scalingPolicyObjective;
        private int? _targetCpuUtilizationPerCore;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an endpoint benchmarked during a previously completed inference recommendation
        /// job. This name should come from one of the recommendations returned by the job specified
        /// in the <c>InferenceRecommendationsJobName</c> field.
        /// </para>
        ///  
        /// <para>
        /// Specify either this field or the <c>RecommendationId</c> field.
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID of a previously completed inference recommendation. This ID
        /// should come from one of the recommendations returned by the job specified in the <c>InferenceRecommendationsJobName</c>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// Specify either this field or the <c>EndpointName</c> field.
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
        /// An object where you specify the anticipated traffic pattern for an endpoint.
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
        /// The percentage of how much utilization you want an instance to use before autoscaling.
        /// The default value is 50%.
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