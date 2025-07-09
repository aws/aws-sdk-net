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
    /// Contains details for an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Session</a>
    /// in the <i>Multi-party approval User Guide</i>
    /// </summary>
    public partial class ListSessionsResponseSession
    {
        private ActionCompletionStrategy _actionCompletionStrategy;
        private string _actionName;
        private string _approvalTeamArn;
        private string _approvalTeamName;
        private DateTime? _completionTime;
        private string _description;
        private DateTime? _expirationTime;
        private DateTime? _initiationTime;
        private string _protectedResourceArn;
        private string _requesterAccountId;
        private string _requesterPrincipalArn;
        private string _requesterRegion;
        private string _requesterServicePrincipal;
        private string _sessionArn;
        private SessionStatus _status;
        private SessionStatusCode _statusCode;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ActionCompletionStrategy. 
        /// <para>
        /// Strategy for executing the protected operation. <c>AUTO_COMPLETION_UPON_APPROVAL</c>
        /// means the operation is executed automatically using the requester's permissions, if
        /// approved.
        /// </para>
        /// </summary>
        public ActionCompletionStrategy ActionCompletionStrategy
        {
            get { return this._actionCompletionStrategy; }
            set { this._actionCompletionStrategy = value; }
        }

        // Check to see if ActionCompletionStrategy property is set
        internal bool IsSetActionCompletionStrategy()
        {
            return this._actionCompletionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// Name of the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalTeamArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ApprovalTeamArn
        {
            get { return this._approvalTeamArn; }
            set { this._approvalTeamArn = value; }
        }

        // Check to see if ApprovalTeamArn property is set
        internal bool IsSetApprovalTeamArn()
        {
            return this._approvalTeamArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalTeamName. 
        /// <para>
        /// Name of the approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ApprovalTeamName
        {
            get { return this._approvalTeamName; }
            set { this._approvalTeamName = value; }
        }

        // Check to see if ApprovalTeamName property is set
        internal bool IsSetApprovalTeamName()
        {
            return this._approvalTeamName != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Timestamp when the session was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// Timestamp when the session was expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitiationTime. 
        /// <para>
        /// Timestamp when the session was initiated.
        /// </para>
        /// </summary>
        public DateTime? InitiationTime
        {
            get { return this._initiationTime; }
            set { this._initiationTime = value; }
        }

        // Check to see if InitiationTime property is set
        internal bool IsSetInitiationTime()
        {
            return this._initiationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtectedResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ProtectedResourceArn
        {
            get { return this._protectedResourceArn; }
            set { this._protectedResourceArn = value; }
        }

        // Check to see if ProtectedResourceArn property is set
        internal bool IsSetProtectedResourceArn()
        {
            return this._protectedResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterAccountId. 
        /// <para>
        /// ID for the account that made the operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public string RequesterAccountId
        {
            get { return this._requesterAccountId; }
            set { this._requesterAccountId = value; }
        }

        // Check to see if RequesterAccountId property is set
        internal bool IsSetRequesterAccountId()
        {
            return this._requesterAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterPrincipalArn. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/intro-structure.html#intro-structure-request">IAM
        /// principal</a> that made the operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string RequesterPrincipalArn
        {
            get { return this._requesterPrincipalArn; }
            set { this._requesterPrincipalArn = value; }
        }

        // Check to see if RequesterPrincipalArn property is set
        internal bool IsSetRequesterPrincipalArn()
        {
            return this._requesterPrincipalArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterRegion. 
        /// <para>
        /// Amazon Web Services Region where the operation request originated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string RequesterRegion
        {
            get { return this._requesterRegion; }
            set { this._requesterRegion = value; }
        }

        // Check to see if RequesterRegion property is set
        internal bool IsSetRequesterRegion()
        {
            return this._requesterRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterServicePrincipal. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">Service
        /// principal</a> for the service associated with the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RequesterServicePrincipal
        {
            get { return this._requesterServicePrincipal; }
            set { this._requesterServicePrincipal = value; }
        }

        // Check to see if RequesterServicePrincipal property is set
        internal bool IsSetRequesterServicePrincipal()
        {
            return this._requesterServicePrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the protected operation. For example, if the operation is <c>PENDING</c>.
        /// </para>
        /// </summary>
        public SessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code of the session.
        /// </para>
        /// </summary>
        public SessionStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}