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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Summary information about a Recovery Plan execution.
    /// </summary>
    public partial class RecoveryPlanExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Error details if the execution failed.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The execution mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecoveryPlanExecutionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property RecoveryPlanArn. 
        /// <para>
        /// The ARN of the Recovery Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RecoveryPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPlanArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPlanArn() => this.RecoveryPlanArn != null;

        /// <summary>
        /// Gets and sets the property RecoveryPlanExecutionArn. 
        /// <para>
        /// The ARN of the Recovery Plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RecoveryPlanExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPlanExecutionArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPlanExecutionArn() => this.RecoveryPlanExecutionArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 32)]
        public string StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The execution status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecoveryPlanExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
