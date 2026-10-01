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
    /// Container for the parameters to the GetAuthenticationUrl operation. Retrieves the
    /// AuthenticationUrl for the current authentication session for the AuthenticateCustomer
    /// flow block. <para> For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a>. </para> <note> <ul> <li> <para> This API
    /// can only be called within one minute of receiving the authenticationInitiated event.
    /// </para> </li> <li> <para> The current supported channel is chat. This API is not supported
    /// for Apple Messages for Business, WhatsApp, or SMS chats. </para> </li> </ul> </note>
    /// <note> <para> <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
    /// </para> </note> <para> The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>. </para>
    /// </summary>
    public partial class GetAuthenticationUrlRequest : AmazonConnectParticipantRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ConnectionToken { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionToken property is set.
        /// </summary>
        internal bool IsSetConnectionToken() => this.ConnectionToken != null;

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The URL where the customer will be redirected after Amazon Cognito authorizes the
        /// user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUri property is set.
        /// </summary>
        internal bool IsSetRedirectUri() => this.RedirectUri != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The sessionId provided in the authenticationInitiated event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
