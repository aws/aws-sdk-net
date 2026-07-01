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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the CreateStreamSessionAdminShell operation.
    /// </summary>
    public partial class CreateStreamSessionAdminShellResponse : AmazonWebServiceResponse
    {
        private string _sessionId;
        private string _streamUrl;
        private string _tokenValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// An Amazon Web Services Systems Manager session identifier that uniquely identifies
        /// the requested terminal session. Use this value with the Amazon Web Services Systems
        /// Manager Session Manager plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamUrl. 
        /// <para>
        /// An Amazon Web Services Systems Manager WebSocket connection endpoint for the requested
        /// terminal session.
        /// </para>
        /// </summary>
        public string StreamUrl
        {
            get { return this._streamUrl; }
            set { this._streamUrl = value; }
        }

        // Check to see if StreamUrl property is set
        internal bool IsSetStreamUrl()
        {
            return this._streamUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// An Amazon Web Services Systems Manager authentication token that authenticates your
        /// access to the session ID and WebSocket URL. This token must be treated with the same
        /// level of security as other user credentials. The token value is only valid for establishing
        /// a new connection within 60 seconds of generation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string TokenValue
        {
            get { return this._tokenValue; }
            set { this._tokenValue = value; }
        }

        // Check to see if TokenValue property is set
        internal bool IsSetTokenValue()
        {
            return this._tokenValue != null;
        }

    }
}