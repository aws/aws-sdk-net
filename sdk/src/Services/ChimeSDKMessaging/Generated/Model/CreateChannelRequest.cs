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
    /// Container for the parameters to the CreateChannel operation.
    /// Creates a channel to which you can add users and send messages.
    /// 
    ///  
    /// <para>
    ///  <b>Restriction</b>: You can't change a channel's privacy.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the ARN of the
    /// <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes the API call
    /// as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateChannelRequest : AmazonChimeSDKMessagingRequest
    {
        private string _appInstanceArn;
        private string _channelId;
        private string _chimeBearer;
        private string _clientRequestToken;
        private ElasticChannelConfiguration _elasticChannelConfiguration;
        private ExpirationSettings _expirationSettings;
        private List<string> _memberArns = new List<string>();
        private string _metadata;
        private ChannelMode _mode;
        private List<string> _moderatorArns = new List<string>();
        private string _name;
        private ChannelPrivacy _privacy;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the channel request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The ID of the channel in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes
        /// the API call.
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
        /// The client token for the request. An <code>Idempotency</code> token.
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
        /// Gets and sets the property ElasticChannelConfiguration. 
        /// <para>
        /// The attributes required to configure and create an elastic channel. An elastic channel
        /// can support a maximum of 1-million users, excluding moderators.
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
        /// Settings that control the interval after which the channel is automatically deleted.
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
        /// Gets and sets the property MemberArns. 
        /// <para>
        /// The ARNs of the channel members in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> MemberArns
        {
            get { return this._memberArns; }
            set { this._memberArns = value; }
        }

        // Check to see if MemberArns property is set
        internal bool IsSetMemberArns()
        {
            return this._memberArns != null && this._memberArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the creation request. Limited to 1KB and UTF-8.
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
        /// The channel mode: <code>UNRESTRICTED</code> or <code>RESTRICTED</code>. Administrators,
        /// moderators, and channel members can add themselves and other members to unrestricted
        /// channels. Only administrators and moderators can add members to restricted channels.
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
        /// Gets and sets the property ModeratorArns. 
        /// <para>
        /// The ARNs of the channel moderators in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ModeratorArns
        {
            get { return this._moderatorArns; }
            set { this._moderatorArns = value; }
        }

        // Check to see if ModeratorArns property is set
        internal bool IsSetModeratorArns()
        {
            return this._moderatorArns != null && this._moderatorArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// The channel's privacy level: <code>PUBLIC</code> or <code>PRIVATE</code>. Private
        /// channels aren't discoverable by users outside the channel. Public channels are discoverable
        /// by anyone in the <code>AppInstance</code>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}