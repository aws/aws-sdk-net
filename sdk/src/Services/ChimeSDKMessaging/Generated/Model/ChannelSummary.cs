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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Summary of the details of a <code>Channel</code>.
    /// </summary>
    public partial class ChannelSummary
    {
        private string _channelArn;
        private DateTime? _lastMessageTimestamp;
        private string _metadata;
        private ChannelMode _mode;
        private string _name;
        private ChannelPrivacy _privacy;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
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
        /// Gets and sets the property LastMessageTimestamp. 
        /// <para>
        /// The time at which the last persistent message in a channel was sent.
        /// </para>
        /// </summary>
        public DateTime LastMessageTimestamp
        {
            get { return this._lastMessageTimestamp.GetValueOrDefault(); }
            set { this._lastMessageTimestamp = value; }
        }

        // Check to see if LastMessageTimestamp property is set
        internal bool IsSetLastMessageTimestamp()
        {
            return this._lastMessageTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the channel.
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the channel.
        /// </para>
        /// </summary>
        public ChannelMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Privacy. 
        /// <para>
        /// The privacy setting of the channel.
        /// </para>
        /// </summary>
        public ChannelPrivacy Privacy
        {
            get { return this._privacy; }
            set { this._privacy = value; }
        }

        // Check to see if Privacy property is set
        internal bool IsSetPrivacy()
        {
            return this._privacy != null;
        }

    }
}