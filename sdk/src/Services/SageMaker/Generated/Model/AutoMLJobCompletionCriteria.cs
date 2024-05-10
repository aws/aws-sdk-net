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
    /// How long a job is allowed to run, or how many candidates a job is allowed to generate.
    /// </summary>
    public partial class AutoMLJobCompletionCriteria
    {
        private int? _maxAutoMLJobRuntimeInSeconds;
        private int? _maxCandidates;
        private int? _maxRuntimePerTrainingJobInSeconds;

        /// <summary>
        /// Gets and sets the property MaxAutoMLJobRuntimeInSeconds. 
        /// <para>
        /// The maximum runtime, in seconds, an AutoML job has to complete.
        /// </para>
        ///  
        /// <para>
        /// If an AutoML job exceeds the maximum runtime, the job is stopped automatically and
        /// its processing is ended gracefully. The AutoML job identifies the best model whose
        /// training was completed and marks it as the best-performing model. Any unfinished steps
        /// of the job, such as automatic one-click Autopilot model deployment, are not completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxAutoMLJobRuntimeInSeconds
        {
            get { return this._maxAutoMLJobRuntimeInSeconds; }
            set { this._maxAutoMLJobRuntimeInSeconds = value; }
        }

        // Check to see if MaxAutoMLJobRuntimeInSeconds property is set
        internal bool IsSetMaxAutoMLJobRuntimeInSeconds()
        {
            return this._maxAutoMLJobRuntimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCandidates. 
        /// <para>
        /// The maximum number of times a training job is allowed to run.
        /// </para>
        ///  
        /// <para>
        /// For text and image classification, time-series forecasting, as well as text generation
        /// (LLMs fine-tuning) problem types, the supported value is 1. For tabular problem types,
        /// the maximum value is 750.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public int? MaxCandidates
        {
            get { return this._maxCandidates; }
            set { this._maxCandidates = value; }
        }

        // Check to see if MaxCandidates property is set
        internal bool IsSetMaxCandidates()
        {
            return this._maxCandidates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRuntimePerTrainingJobInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that each training job executed inside hyperparameter
        /// tuning is allowed to run as part of a hyperparameter tuning job. For more information,
        /// see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StoppingCondition.html">StoppingCondition</a>
        /// used by the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateHyperParameterTuningJob.html">CreateHyperParameterTuningJob</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For job V2s (jobs created by calling <c>CreateAutoMLJobV2</c>), this field controls
        /// the runtime of the job candidate.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TextClassificationJobConfig.html">TextGenerationJobConfig</a>
        /// problem types, the maximum time defaults to 72 hours (259200 seconds).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxRuntimePerTrainingJobInSeconds
        {
            get { return this._maxRuntimePerTrainingJobInSeconds; }
            set { this._maxRuntimePerTrainingJobInSeconds = value; }
        }

        // Check to see if MaxRuntimePerTrainingJobInSeconds property is set
        internal bool IsSetMaxRuntimePerTrainingJobInSeconds()
        {
            return this._maxRuntimePerTrainingJobInSeconds.HasValue; 
        }

    }
}