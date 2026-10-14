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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Summary information about a channel handshake.
    /// </summary>
    public partial class ChannelHandshakeSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceId. 
        /// <para>
        /// The identifier of the resource associated with the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 17)]
        public string AssociatedResourceId { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceId property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceId() => this.AssociatedResourceId != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier associated with the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the handshake was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// Detailed information about the handshake.
        /// </para>
        /// </summary>
        public HandshakeDetail Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property HandshakeType. 
        /// <para>
        /// The type of the handshake.
        /// </para>
        /// </summary>
        public HandshakeType HandshakeType { get; set; }

        /// <summary>
        /// Checks to see if the HandshakeType property is set.
        /// </summary>
        internal bool IsSetHandshakeType() => this.HandshakeType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 16)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The AWS account ID of the handshake owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ReceiverAccountId. 
        /// <para>
        /// The AWS account ID of the handshake receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ReceiverAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverAccountId property is set.
        /// </summary>
        internal bool IsSetReceiverAccountId() => this.ReceiverAccountId != null;

        /// <summary>
        /// Gets and sets the property SenderAccountId. 
        /// <para>
        /// The AWS account ID of the handshake sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SenderAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SenderAccountId property is set.
        /// </summary>
        internal bool IsSetSenderAccountId() => this.SenderAccountId != null;

        /// <summary>
        /// Gets and sets the property SenderDisplayName. 
        /// <para>
        /// The display name of the handshake sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string SenderDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the SenderDisplayName property is set.
        /// </summary>
        internal bool IsSetSenderDisplayName() => this.SenderDisplayName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the handshake.
        /// </para>
        /// </summary>
        public HandshakeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the handshake was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
