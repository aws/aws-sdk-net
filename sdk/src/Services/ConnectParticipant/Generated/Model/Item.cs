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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// An item - message or event - that has been sent.
    /// </summary>
    public partial class Item
    {
        private string _absoluteTime;
        private List<AttachmentItem> _attachments = new List<AttachmentItem>();
        private string _contactId;
        private string _content;
        private string _contentType;
        private string _displayName;
        private string _id;
        private MessageMetadata _messageMetadata;
        private string _participantId;
        private ParticipantRole _participantRole;
        private string _relatedContactId;
        private ChatItemType _type;

        /// <summary>
        /// Gets and sets the property AbsoluteTime. 
        /// <para>
        /// The time when the message or event was sent.
        /// </para>
        ///  
        /// <para>
        /// It's specified in ISO 8601 format: yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AbsoluteTime
        {
            get { return this._absoluteTime; }
            set { this._absoluteTime = value; }
        }

        // Check to see if AbsoluteTime property is set
        internal bool IsSetAbsoluteTime()
        {
            return this._absoluteTime != null;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Provides information about the attachments.
        /// </para>
        /// </summary>
        public List<AttachmentItem> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The contactId on which the transcript item was originally sent. This field is populated
        /// only when the transcript item is from the current chat session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the message or event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content of the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The chat display name of the sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property MessageMetadata. 
        /// <para>
        /// The metadata related to the message. Currently this supports only information related
        /// to message receipts.
        /// </para>
        /// </summary>
        public MessageMetadata MessageMetadata
        {
            get { return this._messageMetadata; }
            set { this._messageMetadata = value; }
        }

        // Check to see if MessageMetadata property is set
        internal bool IsSetMessageMetadata()
        {
            return this._messageMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The ID of the sender in the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the sender. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId on which the transcript item was originally sent. This field is only
        /// populated for persistent chats when the transcript item is from the past chat session.
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RelatedContactId
        {
            get { return this._relatedContactId; }
            set { this._relatedContactId = value; }
        }

        // Check to see if RelatedContactId property is set
        internal bool IsSetRelatedContactId()
        {
            return this._relatedContactId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the item: message or event. 
        /// </para>
        /// </summary>
        public ChatItemType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}