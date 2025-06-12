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
    /// Container for the parameters to the SendChannelMessage operation.
    /// Sends a message to a particular channel that the member is a part of.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>x-amz-chime-bearer</c> request header is mandatory. Use the ARN of the <c>AppInstanceUser</c>
    /// or <c>AppInstanceBot</c> that makes the API call as the value in the header.
    /// </para>
    ///  
    /// <para>
    /// Also, <c>STANDARD</c> messages can be up to 4KB in size and contain metadata. Metadata
    /// is arbitrary, and you can use it in a variety of ways, such as containing a link to
    /// an attachment.
    /// </para>
    ///  
    /// <para>
    ///  <c>CONTROL</c> messages are limited to 30 bytes and do not contain metadata.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SendChannelMessageRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private string _clientRequestToken;
        private string _content;
        private string _contentType;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
        private string _metadata;
        private ChannelMessagePersistenceType _persistence;
        private PushNotificationConfiguration _pushNotification;
        private string _subChannelId;
        private List<Target> _target = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private ChannelMessageType _type;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c> that makes the API
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChimeBearer
        {
            get { return this._chimeBearer; }
            set { this._chimeBearer = value; }
        }

        // Check to see if ChimeBearer property is set
        internal bool IsSetChimeBearer()
        {
            return this._chimeBearer != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The <c>Idempotency</c> token for each client request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the channel message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
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
        /// The content type of the channel message.
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
        /// The attributes for the message, used for message filtering along with a <c>FilterRule</c>
        /// defined in the <c>PushNotificationPreferences</c>.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The optional metadata for each message.
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
        /// Gets and sets the property Persistence. 
        /// <para>
        /// Boolean that controls whether the message is persisted on the back end. Required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelMessagePersistenceType Persistence
        {
            get { return this._persistence; }
            set { this._persistence = value; }
        }

        // Check to see if Persistence property is set
        internal bool IsSetPersistence()
        {
            return this._persistence != null;
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
        /// The ID of the SubChannel in the request.
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

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of a message. Must be a member of the channel, such as another user, a
        /// bot, or the sender. Only the target and the sender can view targeted messages. Only
        /// users who can see targeted messages can take actions on them. However, administrators
        /// can delete targeted messages that they can’t see. 
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
        /// The type of message, <c>STANDARD</c> or <c>CONTROL</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>STANDARD</c> messages can be up to 4KB in size and contain metadata. Metadata
        /// is arbitrary, and you can use it in a variety of ways, such as containing a link to
        /// an attachment.
        /// </para>
        ///  
        /// <para>
        ///  <c>CONTROL</c> messages are limited to 30 bytes and do not contain metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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