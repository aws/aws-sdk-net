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

namespace Amazon.KinesisVideoSignalingChannels.Model
{
    /// <summary>
    /// Container for the parameters to the SendAlexaOfferToMaster operation.
    /// This API allows you to connect WebRTC-enabled devices with Alexa display devices.
    /// When invoked, it sends the Alexa Session Description Protocol (SDP) offer to the master
    /// peer. The offer is delivered as soon as the master is connected to the specified signaling
    /// channel. This API returns the SDP answer from the connected master. If the master
    /// is not connected to the signaling channel, redelivery requests are made until the
    /// message expires.
    /// </summary>
    public partial class SendAlexaOfferToMasterRequest : AmazonKinesisVideoSignalingChannelsRequest
    {
        private string _channelARN;
        private string _messagePayload;
        private string _senderClientId;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The ARN of the signaling channel by which Alexa and the master peer communicate.
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
        /// Gets and sets the property MessagePayload. 
        /// <para>
        /// The base64-encoded SDP offer content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string MessagePayload
        {
            get { return this._messagePayload; }
            set { this._messagePayload = value; }
        }

        // Check to see if MessagePayload property is set
        internal bool IsSetMessagePayload()
        {
            return this._messagePayload != null;
        }

        /// <summary>
        /// Gets and sets the property SenderClientId. 
        /// <para>
        /// The unique identifier for the sender client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SenderClientId
        {
            get { return this._senderClientId; }
            set { this._senderClientId = value; }
        }

        // Check to see if SenderClientId property is set
        internal bool IsSetSenderClientId()
        {
            return this._senderClientId != null;
        }

    }
}