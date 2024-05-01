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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
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
namespace Amazon.KinesisVideoSignalingChannels.Model
{
    /// <summary>
    /// Container for the parameters to the GetIceServerConfig operation.
    /// Gets the Interactive Connectivity Establishment (ICE) server configuration information,
    /// including URIs, username, and password which can be used to configure the WebRTC connection.
    /// The ICE component uses this configuration information to setup the WebRTC connection,
    /// including authenticating with the Traversal Using Relays around NAT (TURN) relay server.
    /// 
    /// 
    ///  
    /// <para>
    /// TURN is a protocol that is used to improve the connectivity of peer-to-peer applications.
    /// By providing a cloud-based relay service, TURN ensures that a connection can be established
    /// even when one or more peers are incapable of a direct peer-to-peer connection. For
    /// more information, see <a href="https://tools.ietf.org/html/draft-uberti-rtcweb-turn-rest-00">A
    /// REST API For Access To TURN Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  You can invoke this API to establish a fallback mechanism in case either of the peers
    /// is unable to establish a direct peer-to-peer connection over a signaling channel.
    /// You must specify either a signaling channel ARN or the client ID in order to invoke
    /// this API.
    /// </para>
    /// </summary>
    public partial class GetIceServerConfigRequest : AmazonKinesisVideoSignalingChannelsRequest
    {
        private string _channelARN;
        private string _clientId;
        private Service _service;
        private string _username;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The ARN of the signaling channel to be used for the peer-to-peer connection between
        /// configured peers. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ChannelARN
        {
            get { return this._channelARN; }
            set { this._channelARN = value; }
        }

        // Check to see if ChannelARN property is set
        internal bool IsSetChannelARN()
        {
            return this._channelARN != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Unique identifier for the viewer. Must be unique within the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Specifies the desired service. Currently, <c>TURN</c> is the only valid value.
        /// </para>
        /// </summary>
        public Service Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// An optional user ID to be associated with the credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}