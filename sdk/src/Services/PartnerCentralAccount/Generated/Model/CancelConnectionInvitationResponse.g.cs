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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// This is the response object from the CancelConnectionInvitation operation.
    /// </summary>
    public partial class CancelConnectionInvitationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the canceled connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the connection invitation was canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The identifier of the connection associated with the canceled invitation.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection that was being invited for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the connection invitation was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the connection invitation would have expired if not canceled.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the canceled connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InvitationMessage. 
        /// <para>
        /// The message that was included with the original connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InvitationMessage { get; set; }

        /// <summary>
        /// Checks to see if the InvitationMessage property is set.
        /// </summary>
        internal bool IsSetInvitationMessage() => this.InvitationMessage != null;

        /// <summary>
        /// Gets and sets the property InviterEmail. 
        /// <para>
        /// The email address of the person who sent the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 320)]
        public string InviterEmail { get; set; }

        /// <summary>
        /// Checks to see if the InviterEmail property is set.
        /// </summary>
        internal bool IsSetInviterEmail() => this.InviterEmail != null;

        /// <summary>
        /// Gets and sets the property InviterName. 
        /// <para>
        /// The name of the person who sent the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string InviterName { get; set; }

        /// <summary>
        /// Checks to see if the InviterName property is set.
        /// </summary>
        internal bool IsSetInviterName() => this.InviterName != null;

        /// <summary>
        /// Gets and sets the property OtherParticipantIdentifier. 
        /// <para>
        /// The identifier of the other participant who was invited to connect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string OtherParticipantIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OtherParticipantIdentifier property is set.
        /// </summary>
        internal bool IsSetOtherParticipantIdentifier() => this.OtherParticipantIdentifier != null;

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// The type of participant (inviter or invitee) in the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantType ParticipantType { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantType property is set.
        /// </summary>
        internal bool IsSetParticipantType() => this.ParticipantType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the connection invitation (canceled).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvitationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the connection invitation was last updated (canceled).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
