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
    /// Specifies a limit to how long a model training job or model compilation job can run.
    /// It also specifies how long a managed spot training job has to complete. When the job
    /// reaches the time limit, SageMaker ends the training or compilation job. Use this API
    /// to cap model training costs.
    /// 
    ///  
    /// <para>
    /// To stop a training job, SageMaker sends the algorithm the <code>SIGTERM</code> signal,
    /// which delays job termination for 120 seconds. Algorithms can use this 120-second window
    /// to save the model artifacts, so the results of training are not lost. 
    /// </para>
    ///  
    /// <para>
    /// The training algorithms provided by SageMaker automatically save the intermediate
    /// results of a model training job when possible. This attempt to save artifacts is only
    /// a best effort case as model might not be in a state from which it can be saved. For
    /// example, if training has just started, the model might not be ready to save. When
    /// saved, this intermediate data is a valid model artifact. You can use it to create
    /// a model with <code>CreateModel</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The Neural Topic Model (NTM) currently does not support saving intermediate model
    /// artifacts. When training NTMs, make sure that the maximum runtime is sufficient for
    /// the training job to complete.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StoppingCondition
    {
        private int? _maxRuntimeInSeconds;
        private int? _maxWaitTimeInSeconds;

        /// <summary>
        /// Gets and sets the property MaxRuntimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a training or compilation job can run
        /// before it is stopped.
        /// </para>
        ///  
        /// <para>
        /// For compilation jobs, if the job does not complete during this time, a <code>TimeOut</code>
        /// error is generated. We recommend starting with 900 seconds and increasing as necessary
        /// based on your model.
        /// </para>
        ///  
        /// <para>
        /// For all other jobs, if the job does not complete during this time, SageMaker ends
        /// the job. When <code>RetryStrategy</code> is specified in the job request, <code>MaxRuntimeInSeconds</code>
        /// specifies the maximum time for all of the attempts in total, not each individual attempt.
        /// The default value is 1 day. The maximum value is 28 days.
        /// </para>
        ///  
        /// <para>
        /// The maximum time that a <code>TrainingJob</code> can run in total, including any time
        /// spent publishing metrics or archiving and uploading models after it has been stopped,
        /// is 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxRuntimeInSeconds
        {
            get { return this._maxRuntimeInSeconds.GetValueOrDefault(); }
            set { this._maxRuntimeInSeconds = value; }
        }

        // Check to see if MaxRuntimeInSeconds property is set
        internal bool IsSetMaxRuntimeInSeconds()
        {
            return this._maxRuntimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWaitTimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a managed Spot training job has to complete.
        /// It is the amount of time spent waiting for Spot capacity plus the amount of time the
        /// job can run. It must be equal to or greater than <code>MaxRuntimeInSeconds</code>.
        /// If the job does not complete during this time, SageMaker ends the job.
        /// </para>
        ///  
        /// <para>
        /// When <code>RetryStrategy</code> is specified in the job request, <code>MaxWaitTimeInSeconds</code>
        /// specifies the maximum time for all of the attempts in total, not each individual attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxWaitTimeInSeconds
        {
            get { return this._maxWaitTimeInSeconds.GetValueOrDefault(); }
            set { this._maxWaitTimeInSeconds = value; }
        }

        // Check to see if MaxWaitTimeInSeconds property is set
        internal bool IsSetMaxWaitTimeInSeconds()
        {
            return this._maxWaitTimeInSeconds.HasValue; 
        }

    }
}