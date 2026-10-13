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
    /// A returned array object for the <c>Steps</c> response field in the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListInferenceRecommendationsJobSteps.html">ListInferenceRecommendationsJobSteps</a>
    /// API command.
    /// </summary>
    public partial class InferenceRecommendationsJobStep
    {
        /// <summary>
        /// Gets and sets the property InferenceBenchmark. 
        /// <para>
        /// The details for a specific benchmark.
        /// </para>
        /// </summary>
        public RecommendationJobInferenceBenchmark InferenceBenchmark { get; set; }

        /// <summary>
        /// Checks to see if the InferenceBenchmark property is set.
        /// </summary>
        internal bool IsSetInferenceBenchmark() => this.InferenceBenchmark != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the benchmark.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// The type of the subtask.
        /// </para>
        ///  
        /// <para>
        ///  <c>BENCHMARK</c>: Evaluate the performance of your model on different instance types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationStepType StepType { get; set; }

        /// <summary>
        /// Checks to see if the StepType property is set.
        /// </summary>
        internal bool IsSetStepType() => this.StepType != null;
    }
}
