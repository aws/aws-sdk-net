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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for an approver.
    /// </summary>
    public partial class GetApprovalTeamResponseApprover
    {
        private string _approverId;
        private ApproverLastActivity _lastActivity;
        private DateTime? _lastActivityTime;
        private List<MfaMethod> _mfaMethods = AWSConfigs.InitializeCollections ? new List<MfaMethod>() : null;
        private string _pendingBaselineSessionArn;
        private string _primaryIdentityId;
        private string _primaryIdentitySourceArn;
        private IdentityStatus _primaryIdentityStatus;
        private DateTime? _responseTime;

        /// <summary>
        /// Gets and sets the property ApproverId. 
        /// <para>
        /// ID for the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ApproverId
        {
            get { return this._approverId; }
            set { this._approverId = value; }
        }

        // Check to see if ApproverId property is set
        internal bool IsSetApproverId()
        {
            return this._approverId != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivity. 
        /// <para>
        /// Last Activity performed by the approver.
        /// </para>
        /// </summary>
        public ApproverLastActivity LastActivity
        {
            get { return this._lastActivity; }
            set { this._lastActivity = value; }
        }

        // Check to see if LastActivity property is set
        internal bool IsSetLastActivity()
        {
            return this._lastActivity != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivityTime. 
        /// <para>
        /// Timestamp when the approver last responded to an operation or invitation request.
        /// </para>
        /// </summary>
        public DateTime LastActivityTime
        {
            get { return this._lastActivityTime.GetValueOrDefault(); }
            set { this._lastActivityTime = value; }
        }

        // Check to see if LastActivityTime property is set
        internal bool IsSetLastActivityTime()
        {
            return this._lastActivityTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MfaMethods. 
        /// <para>
        /// Multi-factor authentication configuration for the approver
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<MfaMethod> MfaMethods
        {
            get { return this._mfaMethods; }
            set { this._mfaMethods = value; }
        }

        // Check to see if MfaMethods property is set
        internal bool IsSetMfaMethods()
        {
            return this._mfaMethods != null && (this._mfaMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PendingBaselineSessionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the pending baseline session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PendingBaselineSessionArn
        {
            get { return this._pendingBaselineSessionArn; }
            set { this._pendingBaselineSessionArn = value; }
        }

        // Check to see if PendingBaselineSessionArn property is set
        internal bool IsSetPendingBaselineSessionArn()
        {
            return this._pendingBaselineSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryIdentityId. 
        /// <para>
        /// ID for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PrimaryIdentityId
        {
            get { return this._primaryIdentityId; }
            set { this._primaryIdentityId = value; }
        }

        // Check to see if PrimaryIdentityId property is set
        internal bool IsSetPrimaryIdentityId()
        {
            return this._primaryIdentityId != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryIdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source. The identity source manages the
        /// user authentication for approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string PrimaryIdentitySourceArn
        {
            get { return this._primaryIdentitySourceArn; }
            set { this._primaryIdentitySourceArn = value; }
        }

        // Check to see if PrimaryIdentitySourceArn property is set
        internal bool IsSetPrimaryIdentitySourceArn()
        {
            return this._primaryIdentitySourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryIdentityStatus. 
        /// <para>
        /// Status for the identity source. For example, if an approver has accepted a team invitation
        /// with a user authentication method managed by the identity source.
        /// </para>
        /// </summary>
        public IdentityStatus PrimaryIdentityStatus
        {
            get { return this._primaryIdentityStatus; }
            set { this._primaryIdentityStatus = value; }
        }

        // Check to see if PrimaryIdentityStatus property is set
        internal bool IsSetPrimaryIdentityStatus()
        {
            return this._primaryIdentityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// Timestamp when the approver responded to an approval team invitation.
        /// </para>
        /// </summary>
        public DateTime ResponseTime
        {
            get { return this._responseTime.GetValueOrDefault(); }
            set { this._responseTime = value; }
        }

        // Check to see if ResponseTime property is set
        internal bool IsSetResponseTime()
        {
            return this._responseTime.HasValue; 
        }

    }
}