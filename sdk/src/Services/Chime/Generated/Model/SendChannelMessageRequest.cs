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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the SendChannelMessage operation.
    /// Sends a message to a particular channel that the member is a part of.
    /// 
    ///  <note> 
    /// <para>
    ///  <code>STANDARD</code> messages can contain 4KB of data and the 1KB of metadata. <code>CONTROL</code>
    /// messages can contain 30 bytes of data and no metadata.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SendChannelMessageRequest : AmazonChimeRequest
    {
        private string _channelArn;
        private string _clientRequestToken;
        private string _content;
        private string _metadata;
        private ChannelMessagePersistenceType _persistence;
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The <code>Idempotency</code> token for each client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
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
        /// The content of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The optional metadata for each message. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of message, <code>STANDARD</code> or <code>CONTROL</code>.
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