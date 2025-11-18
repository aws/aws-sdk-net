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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a delegation request, including its status, permissions,
    /// and associated metadata.
    /// </summary>
    public partial class DelegationRequest
    {
        private string _approverId;
        private DateTime? _createDate;
        private string _delegationRequestId;
        private string _description;
        private string _notes;
        private bool? _onlySendByOwner;
        private string _ownerAccountId;
        private string _ownerId;
        private string _permissionPolicy;
        private DelegationPermission _permissions;
        private string _redirectUrl;
        private string _rejectionReason;
        private string _requestMessage;
        private string _requestorId;
        private string _requestorName;
        private List<string> _rolePermissionRestrictionArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _sessionDuration;
        private StateType _state;
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property ApproverId.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Creation date (timestamp) of this delegation request.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier for the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=128)]
        public string DelegationRequestId
        {
            get { return this._delegationRequestId; }
            set { this._delegationRequestId = value; }
        }

        // Check to see if DelegationRequestId property is set
        internal bool IsSetDelegationRequestId()
        {
            return this._delegationRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the delegation request. This is a message that is provided by the Amazon
        /// Web Services partner that filed the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property Notes. 
        /// <para>
        /// Notes added to this delegation request, if this request was updated via the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateDelegationRequest.html">UpdateDelegationRequest</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property OnlySendByOwner. 
        /// <para>
        /// A flag indicating whether the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SendDelegationToken.html">SendDelegationToken</a>
        /// must be called by the owner of this delegation request. This is set by the requesting
        /// partner.
        /// </para>
        /// </summary>
        public bool OnlySendByOwner
        {
            get { return this._onlySendByOwner.GetValueOrDefault(); }
            set { this._onlySendByOwner = value; }
        }

        // Check to see if OnlySendByOwner property is set
        internal bool IsSetOnlySendByOwner()
        {
            return this._onlySendByOwner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Amazon Web Services account ID of the owner of the delegation request.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// ARN of the owner of this delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionPolicy. 
        /// <para>
        /// JSON content of the associated permission policy of this delegation request.
        /// </para>
        /// </summary>
        public string PermissionPolicy
        {
            get { return this._permissionPolicy; }
            set { this._permissionPolicy = value; }
        }

        // Check to see if PermissionPolicy property is set
        internal bool IsSetPermissionPolicy()
        {
            return this._permissionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions.
        /// </summary>
        public DelegationPermission Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// A URL to be redirected to once the delegation request is approved. Partners provide
        /// this URL when creating the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RedirectUrl
        {
            get { return this._redirectUrl; }
            set { this._redirectUrl = value; }
        }

        // Check to see if RedirectUrl property is set
        internal bool IsSetRedirectUrl()
        {
            return this._redirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// Reasons for rejecting this delegation request, if this request was rejected. See also
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RejectDelegationRequest.html">RejectDelegationRequest</a>
        /// API documentation. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMessage. 
        /// <para>
        /// A custom message that is added to the delegation request by the partner.
        /// </para>
        ///  
        /// <para>
        /// This element is different from the <c>Description</c> element such that this is a
        /// request specific message injected by the partner. The <c>Description</c> is typically
        /// a generic explanation of what the delegation request is targeted to do.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string RequestMessage
        {
            get { return this._requestMessage; }
            set { this._requestMessage = value; }
        }

        // Check to see if RequestMessage property is set
        internal bool IsSetRequestMessage()
        {
            return this._requestMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RequestorId. 
        /// <para>
        /// Identity of the requestor of this delegation request. This will be an Amazon Web Services
        /// account ID.
        /// </para>
        /// </summary>
        public string RequestorId
        {
            get { return this._requestorId; }
            set { this._requestorId = value; }
        }

        // Check to see if RequestorId property is set
        internal bool IsSetRequestorId()
        {
            return this._requestorId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestorName. 
        /// <para>
        /// A friendly name of the requestor.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string RequestorName
        {
            get { return this._requestorName; }
            set { this._requestorName = value; }
        }

        // Check to see if RequestorName property is set
        internal bool IsSetRequestorName()
        {
            return this._requestorName != null;
        }

        /// <summary>
        /// Gets and sets the property RolePermissionRestrictionArns. 
        /// <para>
        /// If the <c>PermissionPolicy</c> includes role creation permissions, this element will
        /// include the list of permissions boundary policies associated with the role creation.
        /// See <a href="IAM/latest/UserGuide/access_policies_boundaries.html">Permissions boundaries
        /// for IAM entities</a> for more details about IAM permission boundaries. 
        /// </para>
        /// </summary>
        public List<string> RolePermissionRestrictionArns
        {
            get { return this._rolePermissionRestrictionArns; }
            set { this._rolePermissionRestrictionArns = value; }
        }

        // Check to see if RolePermissionRestrictionArns property is set
        internal bool IsSetRolePermissionRestrictionArns()
        {
            return this._rolePermissionRestrictionArns != null && (this._rolePermissionRestrictionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The life-time of the requested session credential.
        /// </para>
        /// </summary>
        [AWSProperty(Min=300, Max=43200)]
        public int SessionDuration
        {
            get { return this._sessionDuration.GetValueOrDefault(); }
            set { this._sessionDuration = value; }
        }

        // Check to see if SessionDuration property is set
        internal bool IsSetSessionDuration()
        {
            return this._sessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of this delegation request.
        /// </para>
        ///  
        /// <para>
        /// See the <a href="IAM/latest/UserGuide/temporary-delegation-building-integration.html">Understanding
        /// the Request Lifecycle</a> for an explanation of how these states are transitioned.
        /// </para>
        /// </summary>
        public StateType State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// Last updated timestamp of the request.
        /// </para>
        /// </summary>
        public DateTime UpdatedTime
        {
            get { return this._updatedTime.GetValueOrDefault(); }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}