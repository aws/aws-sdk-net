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
    /// Stores information about a callback.
    /// </summary>
    public partial class ChannelMessageCallback
    {
        private string _content;
        private string _contentType;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
        private string _messageId;
        private string _metadata;
        private PushNotificationConfiguration _pushNotification;
        private string _subChannelId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The message content. For Amazon Lex V2 bot responses, this field holds a list of messages
        /// originating from the bot. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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
        /// The content type of the call-back message. For Amazon Lex V2 bot responses, the content
        /// type is <c>application/amz-chime-lex-msgs</c> for success responses and <c>application/amz-chime-lex-error</c>
        /// for failure responses. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
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
        /// The message ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The message metadata.
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
        /// Gets and sets the property PushNotification. 
        /// <para>
        /// The push notification configuration of the message.
        /// </para>
        /// </summary>
        public PushNotificationConfiguration PushNotification
        {
            get { return this._pushNotification; }
            set { this._pushNotification = value; }
        }

        // Check to see if PushNotification property is set
        internal bool IsSetPushNotification()
        {
            return this._pushNotification != null;
        }

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SubChannelId
        {
            get { return this._subChannelId; }
            set { this._subChannelId = value; }
        }

        // Check to see if SubChannelId property is set
        internal bool IsSetSubChannelId()
        {
            return this._subChannelId != null;
        }

    }
}