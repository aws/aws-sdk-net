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
    /// A returned array object for the <code>Steps</code> response field in the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListInferenceRecommendationsJobSteps.html">ListInferenceRecommendationsJobSteps</a>
    /// API command.
    /// </summary>
    public partial class InferenceRecommendationsJobStep
    {
        private RecommendationJobInferenceBenchmark _inferenceBenchmark;
        private string _jobName;
        private RecommendationJobStatus _status;
        private RecommendationStepType _stepType;

        /// <summary>
        /// Gets and sets the property InferenceBenchmark. 
        /// <para>
        /// The details for a specific benchmark.
        /// </para>
        /// </summary>
        public RecommendationJobInferenceBenchmark InferenceBenchmark
        {
            get { return this._inferenceBenchmark; }
            set { this._inferenceBenchmark = value; }
        }

        // Check to see if InferenceBenchmark property is set
        internal bool IsSetInferenceBenchmark()
        {
            return this._inferenceBenchmark != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the benchmark.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// The type of the subtask.
        /// </para>
        ///  
        /// <para>
        ///  <code>BENCHMARK</code>: Evaluate the performance of your model on different instance
        /// types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationStepType StepType
        {
            get { return this._stepType; }
            set { this._stepType = value; }
        }

        // Check to see if StepType property is set
        internal bool IsSetStepType()
        {
            return this._stepType != null;
        }

    }
}