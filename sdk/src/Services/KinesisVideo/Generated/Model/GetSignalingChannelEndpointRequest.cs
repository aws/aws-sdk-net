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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the GetSignalingChannelEndpoint operation.
    /// Provides an endpoint for the specified signaling channel to send and receive messages.
    /// This API uses the <c>SingleMasterChannelEndpointConfiguration</c> input parameter,
    /// which consists of the <c>Protocols</c> and <c>Role</c> properties.
    /// 
    ///  
    /// <para>
    ///  <c>Protocols</c> is used to determine the communication mechanism. For example, if
    /// you specify <c>WSS</c> as the protocol, this API produces a secure websocket endpoint.
    /// If you specify <c>HTTPS</c> as the protocol, this API generates an HTTPS endpoint.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>Role</c> determines the messaging permissions. A <c>MASTER</c> role results in
    /// this API generating an endpoint that a client can use to communicate with any of the
    /// viewers on the channel. A <c>VIEWER</c> role results in this API generating an endpoint
    /// that a client can use to communicate only with a <c>MASTER</c>. 
    /// </para>
    /// </summary>
    public partial class GetSignalingChannelEndpointRequest : AmazonKinesisVideoRequest
    {
        private string _channelARN;
        private SingleMasterChannelEndpointConfiguration _singleMasterChannelEndpointConfiguration;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signalling channel for which you want to get
        /// an endpoint.
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
        /// Gets and sets the property SingleMasterChannelEndpointConfiguration. 
        /// <para>
        /// A structure containing the endpoint configuration for the <c>SINGLE_MASTER</c> channel
        /// type.
        /// </para>
        /// </summary>
        public SingleMasterChannelEndpointConfiguration SingleMasterChannelEndpointConfiguration
        {
            get { return this._singleMasterChannelEndpointConfiguration; }
            set { this._singleMasterChannelEndpointConfiguration = value; }
        }

        // Check to see if SingleMasterChannelEndpointConfiguration property is set
        internal bool IsSetSingleMasterChannelEndpointConfiguration()
        {
            return this._singleMasterChannelEndpointConfiguration != null;
        }

    }
}