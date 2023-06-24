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
    /// The details of a channel.
    /// </summary>
    public partial class Channel
    {
        private string _channelArn;
        private string _channelFlowArn;
        private Identity _createdBy;
        private DateTime? _createdTimestamp;
        private ElasticChannelConfiguration _elasticChannelConfiguration;
        private ExpirationSettings _expirationSettings;
        private DateTime? _lastMessageTimestamp;
        private DateTime? _lastUpdatedTimestamp;
        private string _metadata;
        private ChannelMode _mode;
        private string _name;
        private ChannelPrivacy _privacy;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of a channel.
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
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string ChannelFlowArn
        {
            get { return this._channelFlowArn; }
            set { this._channelFlowArn = value; }
        }

        // Check to see if ChannelFlowArn property is set
        internal bool IsSetChannelFlowArn()
        {
            return this._channelFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The <code>AppInstanceUser</code> who created the channel.
        /// </para>
        /// </summary>
        public Identity CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the <code>AppInstanceUser</code> created the channel.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElasticChannelConfiguration. 
        /// <para>
        /// The attributes required to configure and create an elastic channel. An elastic channel
        /// can support a maximum of 1-million members.
        /// </para>
        /// </summary>
        public ElasticChannelConfiguration ElasticChannelConfiguration
        {
            get { return this._elasticChannelConfiguration; }
            set { this._elasticChannelConfiguration = value; }
        }

        // Check to see if ElasticChannelConfiguration property is set
        internal bool IsSetElasticChannelConfiguration()
        {
            return this._elasticChannelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationSettings. 
        /// <para>
        /// Settings that control when a channel expires.
        /// </para>
        /// </summary>
        public ExpirationSettings ExpirationSettings
        {
            get { return this._expirationSettings; }
            set { this._expirationSettings = value; }
        }

        // Check to see if ExpirationSettings property is set
        internal bool IsSetExpirationSettings()
        {
            return this._expirationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LastMessageTimestamp. 
        /// <para>
        /// The time at which a member sent the last message in the channel.
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
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which a channel was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The channel's metadata.
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
        /// The name of a channel.
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
        /// The channel's privacy setting.
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