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
    /// The details of a message in a channel.
    /// </summary>
    public partial class ChannelMessage
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the channel message. For Amazon Lex V2 bot responses, this field holds
        /// a list of messages originating from the bot. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the channel message. For Amazon Lex V2 bot responses, the content
        /// type is <c>application/amz-chime-lex-msgs</c> for success responses and <c>application/amz-chime-lex-error</c>
        /// for failure responses. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 45)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the message was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastEditedTimestamp. 
        /// <para>
        /// The time at which a message was edited.
        /// </para>
        /// </summary>
        public DateTime? LastEditedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastEditedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastEditedTimestamp() => this.LastEditedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which a message was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// The attributes for the channel message. For Amazon Lex V2 bot responses, the attributes
        /// are mapped to specific fields from the bot. For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/appinstance-bots#process-response.html">Processing
        /// responses from an AppInstanceBot</a> in the <i>Amazon Chime SDK Messaging Developer
        /// Guide</i>.
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
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID of a message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The message metadata.
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
        /// The persistence setting for a channel message.
        /// </para>
        /// </summary>
        public ChannelMessagePersistenceType Persistence { get; set; }

        /// <summary>
        /// Checks to see if the Persistence property is set.
        /// </summary>
        internal bool IsSetPersistence() => this.Persistence != null;

        /// <summary>
        /// Gets and sets the property Redacted. 
        /// <para>
        /// Hides the content of a message.
        /// </para>
        /// </summary>
        public bool? Redacted { get; set; }

        /// <summary>
        /// Checks to see if the Redacted property is set.
        /// </summary>
        internal bool IsSetRedacted() => this.Redacted.HasValue;

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The message sender.
        /// </para>
        /// </summary>
        public Identity Sender { get; set; }

        /// <summary>
        /// Checks to see if the Sender property is set.
        /// </summary>
        internal bool IsSetSender() => this.Sender != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the channel message.
        /// </para>
        /// </summary>
        public ChannelMessageStatusStructure Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel.
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
        /// The target of a message, a sender, a user, or a bot. Only the target and the sender
        /// can view targeted messages. Only users who can see targeted messages can take actions
        /// on them. However, administrators can delete targeted messages that they can’t see.
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
        /// The message type.
        /// </para>
        /// </summary>
        public ChannelMessageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
