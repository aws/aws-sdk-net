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
    /// Specifies a limit to how long a job can run. When the job reaches the time limit,
    /// SageMaker ends the job. Use this API to cap costs.
    /// 
    ///  
    /// <para>
    /// To stop a training job, SageMaker sends the algorithm the <c>SIGTERM</c> signal, which
    /// delays job termination for 120 seconds. Algorithms can use this 120-second window
    /// to save the model artifacts, so the results of training are not lost. 
    /// </para>
    ///  
    /// <para>
    /// The training algorithms provided by SageMaker automatically save the intermediate
    /// results of a model training job when possible. This attempt to save artifacts is only
    /// a best effort case as model might not be in a state from which it can be saved. For
    /// example, if training has just started, the model might not be ready to save. When
    /// saved, this intermediate data is a valid model artifact. You can use it to create
    /// a model with <c>CreateModel</c>.
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
        private int? _maxPendingTimeInSeconds;
        private int? _maxRuntimeInSeconds;
        private int? _maxWaitTimeInSeconds;

        /// <summary>
        /// Gets and sets the property MaxPendingTimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a training or compilation job can be
        /// pending before it is stopped.
        /// </para>
        ///  <note> 
        /// <para>
        /// When working with training jobs that use capacity from <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/reserve-capacity-with-training-plans.html">training
        /// plans</a>, not all <c>Pending</c> job states count against the <c>MaxPendingTimeInSeconds</c>
        /// limit. The following scenarios do not increment the <c>MaxPendingTimeInSeconds</c>
        /// counter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The plan is in a <c>Scheduled</c> state: Jobs queued (in <c>Pending</c> status) before
        /// a plan's start date (waiting for scheduled start time)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between capacity reservations: Jobs temporarily back to <c>Pending</c> status between
        /// two capacity reservation periods
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>MaxPendingTimeInSeconds</c> only increments when jobs are actively waiting for
        /// capacity in an <c>Active</c> plan.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=7200, Max=2419200)]
        public int? MaxPendingTimeInSeconds
        {
            get { return this._maxPendingTimeInSeconds; }
            set { this._maxPendingTimeInSeconds = value; }
        }

        // Check to see if MaxPendingTimeInSeconds property is set
        internal bool IsSetMaxPendingTimeInSeconds()
        {
            return this._maxPendingTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRuntimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a training or compilation job can run
        /// before it is stopped.
        /// </para>
        ///  
        /// <para>
        /// For compilation jobs, if the job does not complete during this time, a <c>TimeOut</c>
        /// error is generated. We recommend starting with 900 seconds and increasing as necessary
        /// based on your model.
        /// </para>
        ///  
        /// <para>
        /// For all other jobs, if the job does not complete during this time, SageMaker ends
        /// the job. When <c>RetryStrategy</c> is specified in the job request, <c>MaxRuntimeInSeconds</c>
        /// specifies the maximum time for all of the attempts in total, not each individual attempt.
        /// The default value is 1 day. The maximum value is 28 days.
        /// </para>
        ///  
        /// <para>
        /// The maximum time that a <c>TrainingJob</c> can run in total, including any time spent
        /// publishing metrics or archiving and uploading models after it has been stopped, is
        /// 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxRuntimeInSeconds
        {
            get { return this._maxRuntimeInSeconds; }
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
        /// job can run. It must be equal to or greater than <c>MaxRuntimeInSeconds</c>. If the
        /// job does not complete during this time, SageMaker ends the job.
        /// </para>
        ///  
        /// <para>
        /// When <c>RetryStrategy</c> is specified in the job request, <c>MaxWaitTimeInSeconds</c>
        /// specifies the maximum time for all of the attempts in total, not each individual attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxWaitTimeInSeconds
        {
            get { return this._maxWaitTimeInSeconds; }
            set { this._maxWaitTimeInSeconds = value; }
        }

        // Check to see if MaxWaitTimeInSeconds property is set
        internal bool IsSetMaxWaitTimeInSeconds()
        {
            return this._maxWaitTimeInSeconds.HasValue; 
        }

    }
}