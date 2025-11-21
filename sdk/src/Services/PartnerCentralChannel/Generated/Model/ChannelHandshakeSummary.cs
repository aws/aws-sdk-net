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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
        private string _arn;
        private string _associatedResourceId;
        private string _catalog;
        private DateTime? _createdAt;
        private HandshakeDetail _detail;
        private HandshakeType _handshakeType;
        private string _id;
        private string _ownerAccountId;
        private string _receiverAccountId;
        private string _senderAccountId;
        private string _senderDisplayName;
        private HandshakeStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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
        /// Gets and sets the property AssociatedResourceId. 
        /// <para>
        /// The identifier of the resource associated with the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=17)]
        public string AssociatedResourceId
        {
            get { return this._associatedResourceId; }
            set { this._associatedResourceId = value; }
        }

        // Check to see if AssociatedResourceId property is set
        internal bool IsSetAssociatedResourceId()
        {
            return this._associatedResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier associated with the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the handshake was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// Detailed information about the handshake.
        /// </para>
        /// </summary>
        public HandshakeDetail Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

        /// <summary>
        /// Gets and sets the property HandshakeType. 
        /// <para>
        /// The type of the handshake.
        /// </para>
        /// </summary>
        public HandshakeType HandshakeType
        {
            get { return this._handshakeType; }
            set { this._handshakeType = value; }
        }

        // Check to see if HandshakeType property is set
        internal bool IsSetHandshakeType()
        {
            return this._handshakeType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=16)]
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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The AWS account ID of the handshake owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property ReceiverAccountId. 
        /// <para>
        /// The AWS account ID of the handshake receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ReceiverAccountId
        {
            get { return this._receiverAccountId; }
            set { this._receiverAccountId = value; }
        }

        // Check to see if ReceiverAccountId property is set
        internal bool IsSetReceiverAccountId()
        {
            return this._receiverAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderAccountId. 
        /// <para>
        /// The AWS account ID of the handshake sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string SenderAccountId
        {
            get { return this._senderAccountId; }
            set { this._senderAccountId = value; }
        }

        // Check to see if SenderAccountId property is set
        internal bool IsSetSenderAccountId()
        {
            return this._senderAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderDisplayName. 
        /// <para>
        /// The display name of the handshake sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string SenderDisplayName
        {
            get { return this._senderDisplayName; }
            set { this._senderDisplayName = value; }
        }

        // Check to see if SenderDisplayName property is set
        internal bool IsSetSenderDisplayName()
        {
            return this._senderDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the handshake.
        /// </para>
        /// </summary>
        public HandshakeStatus Status
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
        /// The timestamp when the handshake was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}