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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// An object that describes the endpoint of the signaling channel returned by the <c>GetSignalingChannelEndpoint</c>
    /// API.
    /// 
    ///  
    /// <para>
    /// The media server endpoint will correspond to the <c>WEBRTC</c> Protocol.
    /// </para>
    /// </summary>
    public partial class ResourceEndpointListItem
    {
        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the signaling channel returned by the <c>GetSignalingChannelEndpoint</c>
        /// API.
        /// </para>
        /// </summary>
        public ChannelProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ResourceEndpoint. 
        /// <para>
        /// The endpoint of the signaling channel returned by the <c>GetSignalingChannelEndpoint</c>
        /// API.
        /// </para>
        /// </summary>
        public string ResourceEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ResourceEndpoint property is set.
        /// </summary>
        internal bool IsSetResourceEndpoint() => this.ResourceEndpoint != null;
    }
}
