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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// An object that contains the endpoint configuration for the <code>SINGLE_MASTER</code>
    /// channel type.
    /// </summary>
    public partial class SingleMasterChannelEndpointConfiguration
    {
        private List<string> _protocols = new List<string>();
        private ChannelRole _role;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// This property is used to determine the nature of communication over this <code>SINGLE_MASTER</code>
        /// signaling channel. If <code>WSS</code> is specified, this API returns a websocket
        /// endpoint. If <code>HTTPS</code> is specified, this API returns an <code>HTTPS</code>
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// This property is used to determine messaging permissions in this <code>SINGLE_MASTER</code>
        /// signaling channel. If <code>MASTER</code> is specified, this API returns an endpoint
        /// that a client can use to receive offers from and send answers to any of the viewers
        /// on this signaling channel. If <code>VIEWER</code> is specified, this API returns an
        /// endpoint that a client can use only to send offers to another <code>MASTER</code>
        /// client on this signaling channel. 
        /// </para>
        /// </summary>
        public ChannelRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}