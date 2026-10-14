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
    /// The numbers of training jobs launched by a hyperparameter tuning job, categorized
    /// by status.
    /// </summary>
    public partial class TrainingJobStatusCounters
    {
        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The number of completed training jobs launched by the hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Completed { get; set; }

        /// <summary>
        /// Checks to see if the Completed property is set.
        /// </summary>
        internal bool IsSetCompleted() => this.Completed.HasValue;

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        /// The number of in-progress training jobs launched by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InProgress { get; set; }

        /// <summary>
        /// Checks to see if the InProgress property is set.
        /// </summary>
        internal bool IsSetInProgress() => this.InProgress.HasValue;

        /// <summary>
        /// Gets and sets the property NonRetryableError. 
        /// <para>
        /// The number of training jobs that failed and can't be retried. A failed training job
        /// can't be retried if it failed because a client error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NonRetryableError { get; set; }

        /// <summary>
        /// Checks to see if the NonRetryableError property is set.
        /// </summary>
        internal bool IsSetNonRetryableError() => this.NonRetryableError.HasValue;

        /// <summary>
        /// Gets and sets the property RetryableError. 
        /// <para>
        /// The number of training jobs that failed, but can be retried. A failed training job
        /// can be retried only if it failed because an internal service error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RetryableError { get; set; }

        /// <summary>
        /// Checks to see if the RetryableError property is set.
        /// </summary>
        internal bool IsSetRetryableError() => this.RetryableError.HasValue;

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The number of training jobs launched by a hyperparameter tuning job that were manually
        /// stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Stopped { get; set; }

        /// <summary>
        /// Checks to see if the Stopped property is set.
        /// </summary>
        internal bool IsSetStopped() => this.Stopped.HasValue;
    }
}
