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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
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
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Summary of the messages in a <c>Channel</c>.
    /// </summary>
    public partial class ChannelMessageSummary
    {
        private string _content;
        private string _contentType;
        private DateTime? _createdTimestamp;
        private DateTime? _lastEditedTimestamp;
        private DateTime? _lastUpdatedTimestamp;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
        private string _messageId;
        private string _metadata;
        private bool? _redacted;
        private Identity _sender;
        private ChannelMessageStatusStructure _status;
        private List<Target> _target = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private ChannelMessageType _type;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the channel message. For Amazon Lex V2 bot responses, this field holds
        /// a list of messages originating from the bot. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
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
        /// The content type of the channel message listed in the summary. For Amazon Lex V2 bot
        /// responses, the content type is <c>application/amz-chime-lex-msgs</c> for success responses
        /// and <c>application/amz-chime-lex-error</c> for failure responses. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=45)]
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the message summary was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastEditedTimestamp. 
        /// <para>
        /// The time at which a message was last edited.
        /// </para>
        /// </summary>
        public DateTime? LastEditedTimestamp
        {
            get { return this._lastEditedTimestamp; }
            set { this._lastEditedTimestamp = value; }
        }

        // Check to see if LastEditedTimestamp property is set
        internal bool IsSetLastEditedTimestamp()
        {
            return this._lastEditedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which a message was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// The attributes for the channel message. For Amazon Lex V2 bot responses, the attributes
        /// are mapped to specific fields from the bot. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes
        {
            get { return this._messageAttributes; }
            set { this._messageAttributes = value; }
        }

        // Check to see if MessageAttributes property is set
        internal bool IsSetMessageAttributes()
        {
            return this._messageAttributes != null && (this._messageAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Redacted. 
        /// <para>
        /// Indicates whether a message was redacted.
        /// </para>
        /// </summary>
        public bool? Redacted
        {
            get { return this._redacted; }
            set { this._redacted = value; }
        }

        // Check to see if Redacted property is set
        internal bool IsSetRedacted()
        {
            return this._redacted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The message sender.
        /// </para>
        /// </summary>
        public Identity Sender
        {
            get { return this._sender; }
            set { this._sender = value; }
        }

        // Check to see if Sender property is set
        internal bool IsSetSender()
        {
            return this._sender != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The message status. The status value is <c>SENT</c> for messages sent to a channel
        /// without a channel flow. For channels associated with channel flow, the value determines
        /// the processing stage.
        /// </para>
        /// </summary>
        public ChannelMessageStatusStructure Status
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of a message, a sender, a user, or a bot. Only the target and the sender
        /// can view targeted messages. Only users who can see targeted messages can take actions
        /// on them. However, administrators can delete targeted messages that they can’t see.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Target> Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null && (this._target.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of message.
        /// </para>
        /// </summary>
        public ChannelMessageType Type
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