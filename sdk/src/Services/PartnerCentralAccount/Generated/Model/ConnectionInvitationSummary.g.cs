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
    /// A summary view of a connection invitation containing key information without full
    /// details.
    /// </summary>
    public partial class ConnectionInvitationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection invitation.
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
        /// The catalog identifier where the connection invitation exists.
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
        /// The identifier of the connection associated with this invitation.
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
        /// The type of connection being requested in the invitation.
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
        /// The timestamp when the connection invitation was created.
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
        /// The timestamp when the connection invitation will expire.
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
        /// The unique identifier of the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OtherParticipantIdentifier. 
        /// <para>
        /// The identifier of the other participant in the connection invitation.
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
        /// The current status of the connection invitation.
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
        /// The timestamp when the connection invitation was last updated.
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
