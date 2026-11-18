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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Provides visibility into the stack instances deployment stage for a single Region,
    /// including per-stack-instance progress counts and a completion percentage for that
    /// Region.
    /// </summary>
    public partial class RegionalStackInstancesDeployment
    {
        /// <summary>
        /// Gets and sets the property CancelledStackInstancesCount. 
        /// <para>
        /// The number of stack instances in this Region that were canceled because the operation
        /// exceeded its failure tolerance or was stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CancelledStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the CancelledStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetCancelledStackInstancesCount() => this.CancelledStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompletedStackInstancesCount. 
        /// <para>
        /// The number of stack instances in this Region that have reached a final state. This
        /// count includes stack instances that succeeded, failed, were skipped, or were canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CompletedStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetCompletedStackInstancesCount() => this.CompletedStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedStackInstancesCount. 
        /// <para>
        /// The number of stack instances that failed to deploy in this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailedStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetFailedStackInstancesCount() => this.FailedStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property PendingStackInstancesCount. 
        /// <para>
        /// The number of stack instances in this Region that have not reached a final state.
        /// This is the total number of stack instances in this Region minus the completed count.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PendingStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetPendingStackInstancesCount() => this.PendingStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property PercentageCompleted. 
        /// <para>
        /// The percentage of stack instances in this Region that have reached a final state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? PercentageCompleted { get; set; }

        /// <summary>
        /// Checks to see if the PercentageCompleted property is set.
        /// </summary>
        internal bool IsSetPercentageCompleted() => this.PercentageCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property SkippedStackInstancesCount. 
        /// <para>
        /// The number of stack instances in this Region that were skipped because role provisioning
        /// failed for their target account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SkippedStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the SkippedStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetSkippedStackInstancesCount() => this.SkippedStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stack instances deployment stage can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c>: The operation does not deploy stack instances, such as a drift
        /// detection operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c>: Stack instances deployment has not started. The operation is
        /// still provisioning roles, has not begun, or failed before this stage was reached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: At least one stack instance has started deploying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: Deployment finished and succeeded for all stack instances that
        /// were not skipped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL_SUCCESS</c>: Deployment finished with a mix of succeeded, failed, and
        /// canceled stack instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: Deployment finished and every stack instance that was not skipped
        /// failed or was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StageStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SucceededStackInstancesCount. 
        /// <para>
        /// The number of stack instances that deployed successfully in this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SucceededStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetSucceededStackInstancesCount() => this.SucceededStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStackInstancesCount. 
        /// <para>
        /// The total number of stack instances targeted by this operation in this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetTotalStackInstancesCount() => this.TotalStackInstancesCount.HasValue;
    }
}
