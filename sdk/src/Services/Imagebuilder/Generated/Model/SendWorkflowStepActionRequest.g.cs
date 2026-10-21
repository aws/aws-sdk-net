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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the SendWorkflowStepAction operation. Sends an action
    /// to a workflow step that has paused at a <c>WaitForAction</c> step, so that image creation
    /// can continue. To find the steps that are waiting for an action, call <a>ListWaitingWorkflowSteps</a>.
    /// </summary>
    public partial class SendWorkflowStepActionRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on the paused workflow step. <c>RESUME</c> completes the waiting
        /// step, and the workflow continues. <c>STOP</c> fails the step, and the step's <c>onFailure</c>
        /// setting determines whether the workflow continues or aborts. The workflow step must
        /// be in a waiting state to accept an action. The request fails if the step has already
        /// timed out or been actioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowStepActionType Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version associated with the workflow
        /// step execution. This value must match the image that owns the waiting step. If the
        /// ARN does not correspond to the image running the workflow, then the request fails
        /// with a validation error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the action. This value is stored with the step execution record and
        /// is accessible in subsequent workflow steps via step output references.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// Uniquely identifies the waiting workflow step that you send the action to. To get
        /// this identifier, call <a>ListWaitingWorkflowSteps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;
    }
}
