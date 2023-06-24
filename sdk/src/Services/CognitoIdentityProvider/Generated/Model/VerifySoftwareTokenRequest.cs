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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the VerifySoftwareToken operation.
    /// Use this API to register a user's entered time-based one-time password (TOTP) code
    /// and mark the user's software token MFA status as "verified" if successful. The request
    /// takes an access token or a session string, but not both.
    /// </summary>
    public partial class VerifySoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _friendlyDeviceName;
        private string _session;
        private string _userCode;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose software token you
        /// want to verify.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property FriendlyDeviceName. 
        /// <para>
        /// The friendly device name.
        /// </para>
        /// </summary>
        public string FriendlyDeviceName
        {
            get { return this._friendlyDeviceName; }
            set { this._friendlyDeviceName = value; }
        }

        // Check to see if FriendlyDeviceName property is set
        internal bool IsSetFriendlyDeviceName()
        {
            return this._friendlyDeviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session that should be passed both ways in challenge-response calls to the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property UserCode. 
        /// <para>
        /// The one- time password computed using the secret code returned by <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AssociateSoftwareToken.html">AssociateSoftwareToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=6)]
        public string UserCode
        {
            get { return this._userCode; }
            set { this._userCode = value; }
        }

        // Check to see if UserCode property is set
        internal bool IsSetUserCode()
        {
            return this._userCode != null;
        }

    }
}