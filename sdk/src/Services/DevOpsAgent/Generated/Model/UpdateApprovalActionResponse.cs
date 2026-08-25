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
    /// Response structure for UpdateApprovalAction. Reports the post-submission lifecycle
    /// status of the approval request and, when applicable, the absolute expiry timestamp.
    /// The status is a lifecycle state distinct from the action verb — an APPROVED submission
    /// transitions the request to APPROVED status (live, redeemable); a REJECTED submission
    /// transitions it to REJECTED status (terminal).
    /// </summary>
    public partial class UpdateApprovalActionResponse : AmazonWebServiceResponse
    {
        private string _approvalId;
        private DateTime? _expiresAt;
        private ApprovalStatus _status;

        /// <summary>
        /// Gets and sets the property ApprovalId. 
        /// <para>
        /// Identifier of the approval request that was resolved. Echoed back so the client can
        /// correlate the response with the request.
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
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// Absolute timestamp at which the approval expires. Set when status is APPROVED (computed
        /// as the submission time plus ttlSeconds); absent when status is REJECTED.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Lifecycle status of the approval request immediately after submission. Expected post-submission
        /// states are APPROVED (when the action is APPROVED) or REJECTED (when the action is
        /// REJECTED); PENDING is not returned from this operation, and REVOKED and REDEEMED are
        /// reachable only via subsequent reads.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApprovalStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}