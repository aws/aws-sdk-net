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
    /// Container for the parameters to the UpdateApprovalAction operation.
    /// Updates an approval request with the terminal decision (APPROVED or REJECTED). A single
    /// operation handles both verbs via the action enum.
    /// </summary>
    public partial class UpdateApprovalActionRequest : AmazonDevOpsAgentRequest
    {
        private ApprovalActionType _action;
        private string _agentSpaceId;
        private string _approvalId;
        private ApprovalPattern _finalPattern;
        private string _reason;
        private bool? _singleUse;
        private int? _ttlSeconds;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on the approval request — APPROVED or REJECTED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The agent space identifier — multi-tenant workspace scope. Bound from the request
        /// URI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalId. 
        /// <para>
        /// Identifier of the approval request being resolved. A UUID. Bound from the request
        /// URI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FinalPattern. 
        /// <para>
        /// The finalized pattern (tool + argumentPins) that scopes the approval. Required when
        /// `action` is APPROVED; must be absent when `action` is REJECTED. The pattern narrows,
        /// and must not widen, the invocation originally requested by the agent. This cross-field
        /// invariant is enforced by service-side validation.
        /// </para>
        /// </summary>
        public ApprovalPattern FinalPattern
        {
            get { return this._finalPattern; }
            set { this._finalPattern = value; }
        }

        // Check to see if FinalPattern property is set
        internal bool IsSetFinalPattern()
        {
            return this._finalPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Optional free-text rationale for the decision. Permitted when `action` is REJECTED;
        /// ignored when `action` is APPROVED.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property SingleUse. 
        /// <para>
        /// Whether the approved action backs a single executed tool call (true) or is reusable
        /// within ttlSeconds (false). Required when `action` is APPROVED; must be absent when
        /// `action` is REJECTED. When true, ttlSeconds must be absent (the redemption window
        /// collapses to the single use). When false, ttlSeconds is required and bounds the reuse
        /// window. Cross-field invariants are enforced by service-side validation.
        /// </para>
        /// </summary>
        public bool? SingleUse
        {
            get { return this._singleUse; }
            set { this._singleUse = value; }
        }

        // Check to see if SingleUse property is set
        internal bool IsSetSingleUse()
        {
            return this._singleUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TtlSeconds. 
        /// <para>
        /// Approval lifetime in seconds, starting from when the decision is submitted. Required
        /// when `action` is APPROVED AND `singleUse` is false; must be absent when `action` is
        /// REJECTED or when `singleUse` is true (a single-use approval backs one executed action
        /// and the redemption window collapses). Cross-field invariants are enforced by service-side
        /// validation; the @range bound here is the operation-boundary check that always applies
        /// (a maximum of 4 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=14400)]
        public int? TtlSeconds
        {
            get { return this._ttlSeconds; }
            set { this._ttlSeconds = value; }
        }

        // Check to see if TtlSeconds property is set
        internal bool IsSetTtlSeconds()
        {
            return this._ttlSeconds.HasValue; 
        }

    }
}