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
    /// Summary information about a Recovery Plan execution step.
    /// </summary>
    public partial class RecoveryPlanExecutionStepSummary
    {
        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public RecoveryPlanExecutionStepConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Error details if the step failed.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

        /// <summary>
        /// Gets and sets the property RecoveryPlanExecutionStepArn. 
        /// <para>
        /// The ARN of the execution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RecoveryPlanExecutionStepArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPlanExecutionStepArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPlanExecutionStepArn() => this.RecoveryPlanExecutionStepArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the execution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecoveryPlanExecutionStepStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StepIndex.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public int? StepIndex { get; set; }

        /// <summary>
        /// Checks to see if the StepIndex property is set.
        /// </summary>
        internal bool IsSetStepIndex() => this.StepIndex.HasValue;

        /// <summary>
        /// Gets and sets the property StepName.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;
    }
}
