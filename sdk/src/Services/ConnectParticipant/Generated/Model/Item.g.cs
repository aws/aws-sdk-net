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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// An item - message or event - that has been sent.
    /// </summary>
    public partial class Item
    {
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
        [AWSProperty(Min = 1, Max = 100)]
        public string AbsoluteTime { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteTime property is set.
        /// </summary>
        internal bool IsSetAbsoluteTime() => this.AbsoluteTime != null;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Provides information about the attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentItem> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentItem>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The contactId on which the transcript item was originally sent. This field is populated
        /// only when the transcript item is from the current chat session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the message or event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content of the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The chat display name of the sender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MessageMetadata. 
        /// <para>
        /// The metadata related to the message. Currently this supports only information related
        /// to message receipts.
        /// </para>
        /// </summary>
        public MessageMetadata MessageMetadata { get; set; }

        /// <summary>
        /// Checks to see if the MessageMetadata property is set.
        /// </summary>
        internal bool IsSetMessageMetadata() => this.MessageMetadata != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The ID of the sender in the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the sender. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId on which the transcript item was originally sent. This field is only
        /// populated for persistent chats when the transcript item is from the past chat session.
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the item: message or event. 
        /// </para>
        /// </summary>
        public ChatItemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
