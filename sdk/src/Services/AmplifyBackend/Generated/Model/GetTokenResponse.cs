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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the GetToken operation.
    /// </summary>
    public partial class GetTokenResponse : AmazonWebServiceResponse
    {
        private string _appId;
        private string _challengeCode;
        private string _sessionId;
        private string _ttl;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeCode. 
        /// <para>
        /// The one-time challenge code for authenticating into the Amplify Admin UI.
        /// </para>
        /// </summary>
        public string ChallengeCode
        {
            get { return this._challengeCode; }
            set { this._challengeCode = value; }
        }

        // Check to see if ChallengeCode property is set
        internal bool IsSetChallengeCode()
        {
            return this._challengeCode != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique ID provided when creating a new challenge token.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The expiry time for the one-time generated token code.
        /// </para>
        /// </summary>
        public string Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl != null;
        }

    }
}