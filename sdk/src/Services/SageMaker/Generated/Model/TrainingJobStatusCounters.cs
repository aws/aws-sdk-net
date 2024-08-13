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
    /// The numbers of training jobs launched by a hyperparameter tuning job, categorized
    /// by status.
    /// </summary>
    public partial class TrainingJobStatusCounters
    {
        private int? _completed;
        private int? _inProgress;
        private int? _nonRetryableError;
        private int? _retryableError;
        private int? _stopped;

        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The number of completed training jobs launched by the hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Completed
        {
            get { return this._completed; }
            set { this._completed = value; }
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        /// The number of in-progress training jobs launched by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InProgress
        {
            get { return this._inProgress; }
            set { this._inProgress = value; }
        }

        // Check to see if InProgress property is set
        internal bool IsSetInProgress()
        {
            return this._inProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonRetryableError. 
        /// <para>
        /// The number of training jobs that failed and can't be retried. A failed training job
        /// can't be retried if it failed because a client error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NonRetryableError
        {
            get { return this._nonRetryableError; }
            set { this._nonRetryableError = value; }
        }

        // Check to see if NonRetryableError property is set
        internal bool IsSetNonRetryableError()
        {
            return this._nonRetryableError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryableError. 
        /// <para>
        /// The number of training jobs that failed, but can be retried. A failed training job
        /// can be retried only if it failed because an internal service error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RetryableError
        {
            get { return this._retryableError; }
            set { this._retryableError = value; }
        }

        // Check to see if RetryableError property is set
        internal bool IsSetRetryableError()
        {
            return this._retryableError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The number of training jobs launched by a hyperparameter tuning job that were manually
        /// stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Stopped
        {
            get { return this._stopped; }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }

    }
}