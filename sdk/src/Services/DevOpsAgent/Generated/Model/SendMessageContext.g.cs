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
    /// Context object for additional message metadata
    /// </summary>
    public partial class SendMessageContext
    {
        /// <summary>
        /// Gets and sets the property ApprovalAction. 
        /// <para>
        /// An approval decision supplied when resuming a paused agent execution. When an agent
        /// execution pauses to request approval for an elevated action, SendMessage streams an
        /// approval request carrying interrupt identifiers. To resume the paused execution, call
        /// SendMessage again with `userActionResponse` set to `"APPROVAL_ACTION"` and this member
        /// populated with those identifiers and the decision (APPROVED or REJECTED). Optional;
        /// omit it for messages that are not resuming an approval.
        /// </para>
        /// </summary>
        public ApprovalAction ApprovalAction { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalAction property is set.
        /// </summary>
        internal bool IsSetApprovalAction() => this.ApprovalAction != null;

        /// <summary>
        /// Gets and sets the property CurrentPage. 
        /// <para>
        /// The current page or view the user is on
        /// </para>
        /// </summary>
        public string CurrentPage { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPage property is set.
        /// </summary>
        internal bool IsSetCurrentPage() => this.CurrentPage != null;

        /// <summary>
        /// Gets and sets the property LastMessage. 
        /// <para>
        /// The ID of the last message in the conversation
        /// </para>
        /// </summary>
        public string LastMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastMessage property is set.
        /// </summary>
        internal bool IsSetLastMessage() => this.LastMessage != null;

        /// <summary>
        /// Gets and sets the property UserActionResponse. 
        /// <para>
        /// Response to a UI prompt (not a text conversation message). Set this to the sentinel
        /// value `"APPROVAL_ACTION"` when the request is resuming a paused execution after an
        /// approval decision; in that case the structured decision is provided on the sibling
        /// `approvalAction` member. Preserved as a String for backward compatibility: clients
        /// that predate the typed approval field may still encode UI-prompt responses as JSON
        /// in this field.
        /// </para>
        /// </summary>
        public string UserActionResponse { get; set; }

        /// <summary>
        /// Checks to see if the UserActionResponse property is set.
        /// </summary>
        internal bool IsSetUserActionResponse() => this.UserActionResponse != null;
    }
}
