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
    /// Container for the parameters to the CancelParticipantAuthentication operation.
    /// Cancels the authentication session. The opted out branch of the Authenticate Customer
    /// flow block will be taken.
    /// 
    ///  <note> 
    /// <para>
    /// The current supported channel is chat. This API is not supported for Apple Messages
    /// for Business, WhatsApp, or SMS chats.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    /// </summary>
    public partial class CancelParticipantAuthenticationRequest : AmazonConnectParticipantRequest
    {
        private string _connectionToken;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ConnectionToken
        {
            get { return this._connectionToken; }
            set { this._connectionToken = value; }
        }

        // Check to see if ConnectionToken property is set
        internal bool IsSetConnectionToken()
        {
            return this._connectionToken != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The <c>sessionId</c> provided in the <c>authenticationInitiated</c> event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

    }
}