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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// This is the response object from the CreateParticipantConnection operation.
    /// </summary>
    public partial class CreateParticipantConnectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionCredentials. 
        /// <para>
        /// Creates the participant's connection credentials. The authentication token associated
        /// with the participant's connection.
        /// </para>
        /// </summary>
        public ConnectionCredentials ConnectionCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionCredentials property is set.
        /// </summary>
        internal bool IsSetConnectionCredentials() => this.ConnectionCredentials != null;

        /// <summary>
        /// Gets and sets the property WebRTCConnection. 
        /// <para>
        /// Creates the participant's WebRTC connection data required for the client application
        /// (mobile application or website) to connect to the call. 
        /// </para>
        /// </summary>
        public WebRTCConnection WebRTCConnection { get; set; }

        /// <summary>
        /// Checks to see if the WebRTCConnection property is set.
        /// </summary>
        internal bool IsSetWebRTCConnection() => this.WebRTCConnection != null;

        /// <summary>
        /// Gets and sets the property Websocket. 
        /// <para>
        /// Creates the participant's websocket connection.
        /// </para>
        /// </summary>
        public Websocket Websocket { get; set; }

        /// <summary>
        /// Checks to see if the Websocket property is set.
        /// </summary>
        internal bool IsSetWebsocket() => this.Websocket != null;
    }
}
