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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
        private ConnectionCredentials _connectionCredentials;
        private WebRTCConnection _webRTCConnection;
        private Websocket _websocket;

        /// <summary>
        /// Gets and sets the property ConnectionCredentials. 
        /// <para>
        /// Creates the participant's connection credentials. The authentication token associated
        /// with the participant's connection.
        /// </para>
        /// </summary>
        public ConnectionCredentials ConnectionCredentials
        {
            get { return this._connectionCredentials; }
            set { this._connectionCredentials = value; }
        }

        // Check to see if ConnectionCredentials property is set
        internal bool IsSetConnectionCredentials()
        {
            return this._connectionCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property WebRTCConnection. 
        /// <para>
        /// Creates the participant's WebRTC connection data required for the client application
        /// (mobile application or website) to connect to the call. 
        /// </para>
        /// </summary>
        public WebRTCConnection WebRTCConnection
        {
            get { return this._webRTCConnection; }
            set { this._webRTCConnection = value; }
        }

        // Check to see if WebRTCConnection property is set
        internal bool IsSetWebRTCConnection()
        {
            return this._webRTCConnection != null;
        }

        /// <summary>
        /// Gets and sets the property Websocket. 
        /// <para>
        /// Creates the participant's websocket connection.
        /// </para>
        /// </summary>
        public Websocket Websocket
        {
            get { return this._websocket; }
            set { this._websocket = value; }
        }

        // Check to see if Websocket property is set
        internal bool IsSetWebsocket()
        {
            return this._websocket != null;
        }

    }
}