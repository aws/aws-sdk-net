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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the SendChannelMessage operation. Sends a message
    /// to a particular channel that the member is a part of. <note> <para> The <c>x-amz-chime-bearer</c>
    /// request header is mandatory. Use the ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c>
    /// that makes the API call as the value in the header. </para> <para> Also, <c>STANDARD</c>
    /// messages can be up to 4KB in size and contain metadata. Metadata is arbitrary, and
    /// you can use it in a variety of ways, such as containing a link to an attachment. </para>
    /// <para> <c>CONTROL</c> messages are limited to 30 bytes and do not contain metadata.
    /// </para> </note>
    /// </summary>
    public partial class SendChannelMessageRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c> that makes the API
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChimeBearer { get; set; }

        /// <summary>
        /// Checks to see if the ChimeBearer property is set.
        /// </summary>
        internal bool IsSetChimeBearer() => this.ChimeBearer != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The <c>Idempotency</c> token for each client request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the channel message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the channel message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 45)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// The attributes for the message, used for message filtering along with a <c>FilterRule</c>
        /// defined in the <c>PushNotificationPreferences</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the MessageAttributes property is set.
        /// </summary>
        internal bool IsSetMessageAttributes() => this.MessageAttributes != null && (this.MessageAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The optional metadata for each message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Persistence. 
        /// <para>
        /// Boolean that controls whether the message is persisted on the back end. Required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelMessagePersistenceType Persistence { get; set; }

        /// <summary>
        /// Checks to see if the Persistence property is set.
        /// </summary>
        internal bool IsSetPersistence() => this.Persistence != null;

        /// <summary>
        /// Gets and sets the property PushNotification. 
        /// <para>
        /// The push notification configuration of the message.
        /// </para>
        /// </summary>
        public PushNotificationConfiguration PushNotification { get; set; }

        /// <summary>
        /// Checks to see if the PushNotification property is set.
        /// </summary>
        internal bool IsSetPushNotification() => this.PushNotification != null;

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SubChannelId { get; set; }

        /// <summary>
        /// Checks to see if the SubChannelId property is set.
        /// </summary>
        internal bool IsSetSubChannelId() => this.SubChannelId != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of a message. Must be a member of the channel, such as another user, a
        /// bot, or the sender. Only the target and the sender can view targeted messages. Only
        /// users who can see targeted messages can take actions on them. However, administrators
        /// can delete targeted messages that they can’t see. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Target> Target { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null && (this.Target.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public ChannelMessageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
