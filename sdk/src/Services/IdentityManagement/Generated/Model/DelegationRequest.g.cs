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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a delegation request, including its status, permissions,
    /// and associated metadata.
    /// </summary>
    public partial class DelegationRequest
    {
        /// <summary>
        /// Gets and sets the property ApproverId.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ApproverId { get; set; }

        /// <summary>
        /// Checks to see if the ApproverId property is set.
        /// </summary>
        internal bool IsSetApproverId() => this.ApproverId != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Creation date (timestamp) of this delegation request.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier for the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 128)]
        public string DelegationRequestId { get; set; }

        /// <summary>
        /// Checks to see if the DelegationRequestId property is set.
        /// </summary>
        internal bool IsSetDelegationRequestId() => this.DelegationRequestId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the delegation request. This is a message that is provided by the Amazon
        /// Web Services partner that filed the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The expiry time of this delegation request
        /// </para>
        ///  
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/temporary-delegation-building-integration.html#temporary-delegation-request-lifecycle">Understanding
        /// the Request Lifecycle</a> for details on the life time of a delegation request at
        /// each state.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// Notes added to this delegation request, if this request was updated via the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateDelegationRequest.html">UpdateDelegationRequest</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property OnlySendByOwner. 
        /// <para>
        /// A flag indicating whether the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SendDelegationToken.html">SendDelegationToken</a>
        /// must be called by the owner of this delegation request. This is set by the requesting
        /// partner.
        /// </para>
        /// </summary>
        public bool? OnlySendByOwner { get; set; }

        /// <summary>
        /// Checks to see if the OnlySendByOwner property is set.
        /// </summary>
        internal bool IsSetOnlySendByOwner() => this.OnlySendByOwner.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Amazon Web Services account ID of the owner of the delegation request.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// ARN of the owner of this delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PermissionPolicy. 
        /// <para>
        /// JSON content of the associated permission policy of this delegation request.
        /// </para>
        /// </summary>
        public string PermissionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PermissionPolicy property is set.
        /// </summary>
        internal bool IsSetPermissionPolicy() => this.PermissionPolicy != null;

        /// <summary>
        /// Gets and sets the property Permissions.
        /// </summary>
        public DelegationPermission Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// A URL to be redirected to once the delegation request is approved. Partners provide
        /// this URL when creating the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// Reasons for rejecting this delegation request, if this request was rejected. See also
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RejectDelegationRequest.html">RejectDelegationRequest</a>
        /// API documentation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string RejectionReason { get; set; }

        /// <summary>
        /// Checks to see if the RejectionReason property is set.
        /// </summary>
        internal bool IsSetRejectionReason() => this.RejectionReason != null;

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
        [AWSProperty(Min = 0, Max = 200)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Checks to see if the RequestMessage property is set.
        /// </summary>
        internal bool IsSetRequestMessage() => this.RequestMessage != null;

        /// <summary>
        /// Gets and sets the property RequestorId. 
        /// <para>
        /// Identity of the requestor of this delegation request. This will be an Amazon Web Services
        /// account ID.
        /// </para>
        /// </summary>
        public string RequestorId { get; set; }

        /// <summary>
        /// Checks to see if the RequestorId property is set.
        /// </summary>
        internal bool IsSetRequestorId() => this.RequestorId != null;

        /// <summary>
        /// Gets and sets the property RequestorName. 
        /// <para>
        /// A friendly name of the requestor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string RequestorName { get; set; }

        /// <summary>
        /// Checks to see if the RequestorName property is set.
        /// </summary>
        internal bool IsSetRequestorName() => this.RequestorName != null;

        /// <summary>
        /// Gets and sets the property RolePermissionRestrictionArns. 
        /// <para>
        /// If the <c>PermissionPolicy</c> includes role creation permissions, this element will
        /// include the list of permissions boundary policies associated with the role creation.
        /// See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM entities</a> for more details about IAM permission boundaries.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RolePermissionRestrictionArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RolePermissionRestrictionArns property is set.
        /// </summary>
        internal bool IsSetRolePermissionRestrictionArns() => this.RolePermissionRestrictionArns != null && (this.RolePermissionRestrictionArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The life-time of the requested session credential.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 300, Max = 43200)]
        public int? SessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the SessionDuration property is set.
        /// </summary>
        internal bool IsSetSessionDuration() => this.SessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of this delegation request.
        /// </para>
        ///  
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/temporary-delegation-building-integration.html#temporary-delegation-request-lifecycle">Understanding
        /// the Request Lifecycle</a> for an explanation of how these states are transitioned.
        /// 
        /// </para>
        /// </summary>
        public StateType State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// Last updated timestamp of the request.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;
    }
}
