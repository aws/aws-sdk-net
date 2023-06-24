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
    /// Container for the parameters to the CreateChannel operation.
    /// Creates a channel to which you can add users and send messages.
    /// 
    ///  
    /// <para>
    ///  <b>Restriction</b>: You can't change a channel's privacy.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
    /// of the user that makes the API call as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateChannelRequest : AmazonChimeRequest
    {
        private string _appInstanceArn;
        private string _chimeBearer;
        private string _clientRequestToken;
        private string _metadata;
        private ChannelMode _mode;
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
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The <code>AppInstanceUserArn</code> of the user that makes the API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
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