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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// This is the response object from the CreateConnectionInvitation operation.
    /// </summary>
    public partial class CreateConnectionInvitationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _catalog;
        private string _connectionId;
        private ConnectionType _connectionType;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private string _id;
        private string _invitationMessage;
        private string _inviterEmail;
        private string _inviterName;
        private string _otherParticipantIdentifier;
        private ParticipantType _participantType;
        private InvitationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the connection invitation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The identifier of the connection associated with this invitation.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection being requested in the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the connection invitation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the connection invitation will expire if not responded to.
        /// </para>
        /// </summary>
        public DateTime ExpiresAt
        {
            get { return this._expiresAt.GetValueOrDefault(); }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the created connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InvitationMessage. 
        /// <para>
        /// The custom message included with the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string InvitationMessage
        {
            get { return this._invitationMessage; }
            set { this._invitationMessage = value; }
        }

        // Check to see if InvitationMessage property is set
        internal bool IsSetInvitationMessage()
        {
            return this._invitationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InviterEmail. 
        /// <para>
        /// The email address of the person who sent the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=320)]
        public string InviterEmail
        {
            get { return this._inviterEmail; }
            set { this._inviterEmail = value; }
        }

        // Check to see if InviterEmail property is set
        internal bool IsSetInviterEmail()
        {
            return this._inviterEmail != null;
        }

        /// <summary>
        /// Gets and sets the property InviterName. 
        /// <para>
        /// The name of the person who sent the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=80)]
        public string InviterName
        {
            get { return this._inviterName; }
            set { this._inviterName = value; }
        }

        // Check to see if InviterName property is set
        internal bool IsSetInviterName()
        {
            return this._inviterName != null;
        }

        /// <summary>
        /// Gets and sets the property OtherParticipantIdentifier. 
        /// <para>
        /// The identifier of the organization or partner being invited.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string OtherParticipantIdentifier
        {
            get { return this._otherParticipantIdentifier; }
            set { this._otherParticipantIdentifier = value; }
        }

        // Check to see if OtherParticipantIdentifier property is set
        internal bool IsSetOtherParticipantIdentifier()
        {
            return this._otherParticipantIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// The type of participant (inviter or invitee) in the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantType ParticipantType
        {
            get { return this._participantType; }
            set { this._participantType = value; }
        }

        // Check to see if ParticipantType property is set
        internal bool IsSetParticipantType()
        {
            return this._participantType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the connection invitation (pending, accepted, rejected, etc.).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvitationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the connection invitation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}