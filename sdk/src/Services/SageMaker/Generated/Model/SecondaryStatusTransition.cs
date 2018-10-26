/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An array element of <a>DescribeTrainingJobResponse$SecondaryStatusTransitions</a>.
    /// It provides additional details about a status that the training job has transitioned
    /// through. A training job can be in one of several states, for example, starting, downloading,
    /// training, or uploading. Within each state, there are a number of intermediate states.
    /// For example, within the starting state, Amazon SageMaker could be starting the training
    /// job or launching the ML instances. These transitional states are referred to as the
    /// job's secondary status.
    /// </summary>
    public partial class SecondaryStatusTransition
    {
        private DateTime? _endTime;
        private DateTime? _startTime;
        private SecondaryStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that shows when the training job transitioned out of this secondary status
        /// state into another secondary status state or when the training job has ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that shows when the training job transitioned to the current secondary
        /// status state.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains a secondary status information from a training job.
        /// </para>
        ///  
        /// <para>
        /// Status might be one of the following secondary statuses:
        /// </para>
        ///  <dl> <dt>InProgress</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Starting</code> - Starting the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Downloading</code> - An optional stage for algorithms that support <code>File</code>
        /// training input mode. It indicates that data is being downloaded to the ML storage
        /// volumes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Training</code> - Training is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Uploading</code> - Training is complete and the model artifacts are being uploaded
        /// to the S3 location.
        /// </para>
        ///  </li> </ul> </dd> <dt>Completed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Completed</code> - The training job has completed.
        /// </para>
        ///  </li> </ul> </dd> <dt>Failed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Failed</code> - The training job has failed. The reason for the failure is
        /// returned in the <code>FailureReason</code> field of <code>DescribeTrainingJobResponse</code>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopped</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>MaxRuntimeExceeded</code> - The job stopped because it exceeded the maximum
        /// allowed runtime.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stopped</code> - The training job has stopped.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopping</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Stopping</code> - Stopping the training job.
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// We no longer support the following secondary statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LaunchingMLInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PreparingTrainingStack</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DownloadingTrainingImage</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SecondaryStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the progress within a secondary status. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker provides secondary statuses and status messages that apply to each
        /// of them:
        /// </para>
        ///  <dl> <dt>Starting</dt> <dd> <ul> <li> 
        /// <para>
        /// Starting the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launching requested ML instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Insufficient capacity error from EC2 while launching instances, retrying!
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launched instance was unhealthy, replacing it!
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Preparing the instances for training.
        /// </para>
        ///  </li> </ul> </dd> <dt>Training</dt> <dd> <ul> <li> 
        /// <para>
        /// Downloading the training image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Training image download completed. Training in progress.
        /// </para>
        ///  </li> </ul> </dd> </dl> <important> 
        /// <para>
        /// Status messages are subject to change. Therefore, we recommend not including them
        /// in code that programmatically initiates actions. For examples, don't use status messages
        /// in if statements.
        /// </para>
        ///  </important> 
        /// <para>
        /// To have an overview of your training job's progress, view <code>TrainingJobStatus</code>
        /// and <code>SecondaryStatus</code> in <a>DescribeTrainingJobResponse</a>, and <code>StatusMessage</code>
        /// together. For example, at the start of a training job, you might see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TrainingJobStatus</code> - InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SecondaryStatus</code> - Training
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StatusMessage</code> - Downloading the training image
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}