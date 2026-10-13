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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Workflow run statistics provides statistics about the workflow run.
    /// </summary>
    public partial class WorkflowRunStatistics
    {
        /// <summary>
        /// Gets and sets the property ErroredActions. 
        /// <para>
        /// Indicates the count of job runs in the ERROR state in the workflow run.
        /// </para>
        /// </summary>
        public int? ErroredActions { get; set; }

        /// <summary>
        /// Checks to see if the ErroredActions property is set.
        /// </summary>
        internal bool IsSetErroredActions() => this.ErroredActions.HasValue;

        /// <summary>
        /// Gets and sets the property FailedActions. 
        /// <para>
        /// Total number of Actions that have failed.
        /// </para>
        /// </summary>
        public int? FailedActions { get; set; }

        /// <summary>
        /// Checks to see if the FailedActions property is set.
        /// </summary>
        internal bool IsSetFailedActions() => this.FailedActions.HasValue;

        /// <summary>
        /// Gets and sets the property RunningActions. 
        /// <para>
        /// Total number Actions in running state.
        /// </para>
        /// </summary>
        public int? RunningActions { get; set; }

        /// <summary>
        /// Checks to see if the RunningActions property is set.
        /// </summary>
        internal bool IsSetRunningActions() => this.RunningActions.HasValue;

        /// <summary>
        /// Gets and sets the property StoppedActions. 
        /// <para>
        /// Total number of Actions that have stopped.
        /// </para>
        /// </summary>
        public int? StoppedActions { get; set; }

        /// <summary>
        /// Checks to see if the StoppedActions property is set.
        /// </summary>
        internal bool IsSetStoppedActions() => this.StoppedActions.HasValue;

        /// <summary>
        /// Gets and sets the property SucceededActions. 
        /// <para>
        /// Total number of Actions that have succeeded.
        /// </para>
        /// </summary>
        public int? SucceededActions { get; set; }

        /// <summary>
        /// Checks to see if the SucceededActions property is set.
        /// </summary>
        internal bool IsSetSucceededActions() => this.SucceededActions.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutActions. 
        /// <para>
        /// Total number of Actions that timed out.
        /// </para>
        /// </summary>
        public int? TimeoutActions { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutActions property is set.
        /// </summary>
        internal bool IsSetTimeoutActions() => this.TimeoutActions.HasValue;

        /// <summary>
        /// Gets and sets the property TotalActions. 
        /// <para>
        /// Total number of Actions in the workflow run.
        /// </para>
        /// </summary>
        public int? TotalActions { get; set; }

        /// <summary>
        /// Checks to see if the TotalActions property is set.
        /// </summary>
        internal bool IsSetTotalActions() => this.TotalActions.HasValue;

        /// <summary>
        /// Gets and sets the property WaitingActions. 
        /// <para>
        /// Indicates the count of job runs in WAITING state in the workflow run.
        /// </para>
        /// </summary>
        public int? WaitingActions { get; set; }

        /// <summary>
        /// Checks to see if the WaitingActions property is set.
        /// </summary>
        internal bool IsSetWaitingActions() => this.WaitingActions.HasValue;
    }
}
