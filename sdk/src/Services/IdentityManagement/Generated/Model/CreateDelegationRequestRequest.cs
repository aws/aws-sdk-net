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
    /// Container for the parameters to the CreateDelegationRequest operation.
    /// This API is currently unavailable for general use.
    /// </summary>
    public partial class CreateDelegationRequestRequest : AmazonIdentityManagementServiceRequest
    {
        private string _description;
        private string _notificationChannel;
        private bool? _onlySendByOwner;
        private string _ownerAccountId;
        private DelegationPermission _permissions;
        private string _redirectUrl;
        private string _requestMessage;
        private string _requestorWorkflowId;
        private int? _sessionDuration;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
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
        /// Gets and sets the property NotificationChannel.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=400)]
        public string NotificationChannel
        {
            get { return this._notificationChannel; }
            set { this._notificationChannel = value; }
        }

        // Check to see if NotificationChannel property is set
        internal bool IsSetNotificationChannel()
        {
            return this._notificationChannel != null;
        }

        /// <summary>
        /// Gets and sets the property OnlySendByOwner.
        /// </summary>
        public bool? OnlySendByOwner
        {
            get { return this._onlySendByOwner; }
            set { this._onlySendByOwner = value; }
        }

        // Check to see if OnlySendByOwner property is set
        internal bool IsSetOnlySendByOwner()
        {
            return this._onlySendByOwner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId.
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
        /// Gets and sets the property Permissions.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RequestMessage.
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
        /// Gets and sets the property RequestorWorkflowId.
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=400)]
        public string RequestorWorkflowId
        {
            get { return this._requestorWorkflowId; }
            set { this._requestorWorkflowId = value; }
        }

        // Check to see if RequestorWorkflowId property is set
        internal bool IsSetRequestorWorkflowId()
        {
            return this._requestorWorkflowId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionDuration.
        /// </summary>
        [AWSProperty(Required=true, Min=3600, Max=43200)]
        public int? SessionDuration
        {
            get { return this._sessionDuration; }
            set { this._sessionDuration = value; }
        }

        // Check to see if SessionDuration property is set
        internal bool IsSetSessionDuration()
        {
            return this._sessionDuration.HasValue; 
        }

    }
}