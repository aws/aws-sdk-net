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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private ApprovalActionType _action;
        private string _approvalId;
        private string _buttonText;
        private string _interruptId;
        private string _toolUseId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken on the approval request — APPROVED or REJECTED.
        /// </para>
        /// </summary>
        public ApprovalActionType Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalId. 
        /// <para>
        /// Identifier of the approval request being resolved.
        /// </para>
        /// </summary>
        public string ApprovalId
        {
            get { return this._approvalId; }
            set { this._approvalId = value; }
        }

        // Check to see if ApprovalId property is set
        internal bool IsSetApprovalId()
        {
            return this._approvalId != null;
        }

        /// <summary>
        /// Gets and sets the property ButtonText. 
        /// <para>
        /// Optional display text of the UI control the user chose (for example, "Approve Exact",
        /// "Approve Broader", or "Reject"), provided as auxiliary decision context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ButtonText
        {
            get { return this._buttonText; }
            set { this._buttonText = value; }
        }

        // Check to see if ButtonText property is set
        internal bool IsSetButtonText()
        {
            return this._buttonText != null;
        }

        /// <summary>
        /// Gets and sets the property InterruptId. 
        /// <para>
        /// An opaque resume identifier issued by the service when an agent execution pauses for
        /// approval. Provide it when resuming so the service can resume the correct paused execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InterruptId
        {
            get { return this._interruptId; }
            set { this._interruptId = value; }
        }

        // Check to see if InterruptId property is set
        internal bool IsSetInterruptId()
        {
            return this._interruptId != null;
        }

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// Identifier of the specific paused tool invocation that requested approval. Correlates
        /// the approval decision back to the paused invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ToolUseId
        {
            get { return this._toolUseId; }
            set { this._toolUseId = value; }
        }

        // Check to see if ToolUseId property is set
        internal bool IsSetToolUseId()
        {
            return this._toolUseId != null;
        }

    }
}