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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// An approval decision supplied when resuming a paused agent execution. When an agent
    /// execution pauses to request approval for an elevated action, SendMessage streams an
    /// approval request carrying interrupt identifiers. This structure carries the decision
    /// back to the service — which paused tool invocation is being resumed, the opaque interrupt
    /// identifier that resumes it, the identifier of the approval request being resolved,
    /// optional display text of the control the user chose, and the action taken (APPROVED
    /// or REJECTED) — so the service can resume the paused execution. All members are optional
    /// on the wire; service-side validation is applied against the populated subset.
    /// </summary>
    public partial class ApprovalAction
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken on the approval request — APPROVED or REJECTED.
        /// </para>
        /// </summary>
        public ApprovalActionType Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ApprovalId. 
        /// <para>
        /// Identifier of the approval request being resolved.
        /// </para>
        /// </summary>
        public string ApprovalId { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalId property is set.
        /// </summary>
        internal bool IsSetApprovalId() => this.ApprovalId != null;

        /// <summary>
        /// Gets and sets the property ButtonText. 
        /// <para>
        /// Optional display text of the UI control the user chose (for example, "Approve Exact",
        /// "Approve Broader", or "Reject"), provided as auxiliary decision context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Checks to see if the ButtonText property is set.
        /// </summary>
        internal bool IsSetButtonText() => this.ButtonText != null;

        /// <summary>
        /// Gets and sets the property InterruptId. 
        /// <para>
        /// An opaque resume identifier issued by the service when an agent execution pauses for
        /// approval. Provide it when resuming so the service can resume the correct paused execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InterruptId { get; set; }

        /// <summary>
        /// Checks to see if the InterruptId property is set.
        /// </summary>
        internal bool IsSetInterruptId() => this.InterruptId != null;

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// Identifier of the specific paused tool invocation that requested approval. Correlates
        /// the approval decision back to the paused invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ToolUseId { get; set; }

        /// <summary>
        /// Checks to see if the ToolUseId property is set.
        /// </summary>
        internal bool IsSetToolUseId() => this.ToolUseId != null;
    }
}
