/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Initiates the authentication response, as an administrator.
    /// </summary>
    public partial class AdminInitiateAuthResponse : AmazonWebServiceResponse
    {
        private AuthenticationResultType _authenticationResult;
        private ChallengeNameType _challengeName;
        private Dictionary<string, string> _challengeParameters = new Dictionary<string, string>();
        private string _session;

        /// <summary>
        /// Gets and sets the property AuthenticationResult. 
        /// <para>
        /// The result of the authentication response. This is only returned if the caller does
        /// not need to pass another challenge. If the caller does need to pass another challenge
        /// before it gets tokens, <code>ChallengeName</code>, <code>ChallengeParameters</code>,
        /// and <code>Session</code> are returned.
        /// </para>
        /// </summary>
        public AuthenticationResultType AuthenticationResult
        {
            get { return this._authenticationResult; }
            set { this._authenticationResult = value; }
        }

        // Check to see if AuthenticationResult property is set
        internal bool IsSetAuthenticationResult()
        {
            return this._authenticationResult != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeName. 
        /// <para>
        /// The name of the challenge which you are responding to with this call. This is returned
        /// to you in the <code>AdminInitiateAuth</code> response if you need to pass another
        /// challenge.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MFA_SETUP</code>: If MFA is required, users who do not have at least one of
        /// the MFA methods set up are presented with an <code>MFA_SETUP</code> challenge. The
        /// user must set up at least one MFA type to continue to authenticate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SELECT_MFA_TYPE</code>: Selects the MFA type. Valid MFA options are <code>SMS_MFA</code>
        /// for text SMS MFA, and <code>SOFTWARE_TOKEN_MFA</code> for TOTP software token MFA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMS_MFA</code>: Next challenge is to supply an <code>SMS_MFA_CODE</code>, delivered
        /// via SMS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PASSWORD_VERIFIER</code>: Next challenge is to supply <code>PASSWORD_CLAIM_SIGNATURE</code>,
        /// <code>PASSWORD_CLAIM_SECRET_BLOCK</code>, and <code>TIMESTAMP</code> after the client-side
        /// SRP calculations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_CHALLENGE</code>: This is returned if your custom authentication flow
        /// determines that the user should pass another challenge before tokens are issued.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEVICE_SRP_AUTH</code>: If device tracking was enabled on your user pool and
        /// the previous challenges were passed, this challenge is returned so that Amazon Cognito
        /// can start tracking this device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEVICE_PASSWORD_VERIFIER</code>: Similar to <code>PASSWORD_VERIFIER</code>,
        /// but for devices only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADMIN_NO_SRP_AUTH</code>: This is returned if you need to authenticate with
        /// <code>USERNAME</code> and <code>PASSWORD</code> directly. An app client must be enabled
        /// to use this flow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_PASSWORD_REQUIRED</code>: For users which are required to change their
        /// passwords after successful first login. This challenge should be passed with <code>NEW_PASSWORD</code>
        /// and any other required attributes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChallengeNameType ChallengeName
        {
            get { return this._challengeName; }
            set { this._challengeName = value; }
        }

        // Check to see if ChallengeName property is set
        internal bool IsSetChallengeName()
        {
            return this._challengeName != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeParameters. 
        /// <para>
        /// The challenge parameters. These are returned to you in the <code>AdminInitiateAuth</code>
        /// response if you need to pass another challenge. The responses in this parameter should
        /// be used to compute inputs to the next call (<code>AdminRespondToAuthChallenge</code>).
        /// </para>
        ///  
        /// <para>
        /// All challenges require <code>USERNAME</code> and <code>SECRET_HASH</code> (if applicable).
        /// </para>
        ///  
        /// <para>
        /// The value of the <code>USER_ID_FOR_SRP</code> attribute will be the user's actual
        /// username, not an alias (such as email address or phone number), even if you specified
        /// an alias in your call to <code>AdminInitiateAuth</code>. This is because, in the <code>AdminRespondToAuthChallenge</code>
        /// API <code>ChallengeResponses</code>, the <code>USERNAME</code> attribute cannot be
        /// an alias.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ChallengeParameters
        {
            get { return this._challengeParameters; }
            set { this._challengeParameters = value; }
        }

        // Check to see if ChallengeParameters property is set
        internal bool IsSetChallengeParameters()
        {
            return this._challengeParameters != null && this._challengeParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session which should be passed both ways in challenge-response calls to the service.
        /// If <code>AdminInitiateAuth</code> or <code>AdminRespondToAuthChallenge</code> API
        /// call determines that the caller needs to go through another challenge, they return
        /// a session with other challenge parameters. This session should be passed as it is
        /// to the next <code>AdminRespondToAuthChallenge</code> API call.
        /// </para>
        /// </summary>
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

    }
}