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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies an action that Batch will take after the job has remained at the head of
    /// the queue in the specified state for longer than the specified time.
    /// </summary>
    public partial class JobStateTimeLimitAction
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take when a job is at the head of the job queue in the specified state
        /// for the specified period of time. For job queues connected to a <c>ECS</c>, <c>FARGATE</c>
        /// or <c>EKS</c> compute environment, the only supported value is <c>CANCEL</c>, which
        /// will cancel the job. For job queues connected to a <c>SAGEMAKER_TRAINING</c> service
        /// environment, the only supported value is <c>TERMINATE</c>, which will terminate the
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStateTimeLimitActionsAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property MaxTimeSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, that must pass with the job in the specified
        /// state before the action is taken. The minimum value is 600 (10 minutes) and the maximum
        /// value is 86,400 (24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxTimeSeconds property is set.
        /// </summary>
        internal bool IsSetMaxTimeSeconds() => this.MaxTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason to log for the action being taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job needed to trigger the action. The only supported value is <c>RUNNABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStateTimeLimitActionsState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
