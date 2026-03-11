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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The response to respond to the authentication challenge.
    /// </summary>
    public partial class RespondToAuthChallengeResponse : AmazonWebServiceResponse
    {
        private AuthenticationResultType _authenticationResult;
        private ChallengeNameType _challengeName;
        private Dictionary<string, string> _challengeParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _session;

        /// <summary>
        /// Gets and sets the property AuthenticationResult. 
        /// <para>
        /// The outcome of a successful authentication process. After your application has passed
        /// all challenges, Amazon Cognito returns an <c>AuthenticationResult</c> with the JSON
        /// web tokens (JWTs) that indicate successful sign-in.
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
        /// The name of the next challenge that you must respond to.
        /// </para>
        ///  
        /// <para>
        /// Possible challenges include the following:
        /// </para>
        ///  <note> 
        /// <para>
        /// All of the following challenges require <c>USERNAME</c> and, when the app client has
        /// a client secret, <c>SECRET_HASH</c> in the parameters. Include a <c>DEVICE_KEY</c>
        /// for device authentication.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>WEB_AUTHN</c>: Respond to the challenge with the results of a successful authentication
        /// with a WebAuthn authenticator, or passkey, as <c>CREDENTIAL</c>. Examples of WebAuthn
        /// authenticators include biometric devices and security keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASSWORD</c>: Respond with the user's password as <c>PASSWORD</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASSWORD_SRP</c>: Respond with the initial SRP secret as <c>SRP_A</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SELECT_CHALLENGE</c>: Respond with a challenge selection as <c>ANSWER</c>. It
        /// must be one of the challenge types in the <c>AvailableChallenges</c> response parameter.
        /// Add the parameters of the selected challenge, for example <c>USERNAME</c> and <c>SMS_OTP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SMS_MFA</c>: Respond with the code that your user pool delivered in an SMS message,
        /// as <c>SMS_MFA_CODE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL_MFA</c>: Respond with the code that your user pool delivered in an email
        /// message, as <c>EMAIL_MFA_CODE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL_OTP</c>: Respond with the code that your user pool delivered in an email
        /// message, as <c>EMAIL_OTP_CODE</c> .
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SMS_OTP</c>: Respond with the code that your user pool delivered in an SMS message,
        /// as <c>SMS_OTP_CODE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASSWORD_VERIFIER</c>: Respond with the second stage of SRP secrets as <c>PASSWORD_CLAIM_SIGNATURE</c>,
        /// <c>PASSWORD_CLAIM_SECRET_BLOCK</c>, and <c>TIMESTAMP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_CHALLENGE</c>: This is returned if your custom authentication flow determines
        /// that the user should pass another challenge before tokens are issued. The parameters
        /// of the challenge are determined by your Lambda function and issued in the <c>ChallengeParameters</c>
        /// of a challenge response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEVICE_SRP_AUTH</c>: Respond with the initial parameters of device SRP authentication.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html#user-pools-remembered-devices-signing-in-with-a-device">Signing
        /// in with a device</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEVICE_PASSWORD_VERIFIER</c>: Respond with <c>PASSWORD_CLAIM_SIGNATURE</c>, <c>PASSWORD_CLAIM_SECRET_BLOCK</c>,
        /// and <c>TIMESTAMP</c> after client-side SRP calculations. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html#user-pools-remembered-devices-signing-in-with-a-device">Signing
        /// in with a device</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_PASSWORD_REQUIRED</c>: For users who are required to change their passwords
        /// after successful first login. Respond to this challenge with <c>NEW_PASSWORD</c> and
        /// any required attributes that Amazon Cognito returned in the <c>requiredAttributes</c>
        /// parameter. You can also set values for attributes that aren't required by your user
        /// pool and that your app client can write.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito only returns this challenge for users who have temporary passwords.
        /// When you create passwordless users, you must provide values for all required attributes.
        /// </para>
        ///  <note> 
        /// <para>
        /// In a <c>NEW_PASSWORD_REQUIRED</c> challenge response, you can't modify a required
        /// attribute that already has a value. In <c>AdminRespondToAuthChallenge</c> or <c>RespondToAuthChallenge</c>,
        /// set a value for any keys that Amazon Cognito returned in the <c>requiredAttributes</c>
        /// parameter, then use the <c>AdminUpdateUserAttributes</c> or <c>UpdateUserAttributes</c>
        /// API operation to modify the value of any additional attributes.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>MFA_SETUP</c>: For users who are required to setup an MFA factor before they can
        /// sign in. The MFA types activated for the user pool will be listed in the challenge
        /// parameters <c>MFAS_CAN_SETUP</c> value. 
        /// </para>
        ///  
        /// <para>
        /// To set up time-based one-time password (TOTP) MFA, use the session returned in this
        /// challenge from <c>InitiateAuth</c> or <c>AdminInitiateAuth</c> as an input to <c>AssociateSoftwareToken</c>.
        /// Then, use the session returned by <c>VerifySoftwareToken</c> as an input to <c>RespondToAuthChallenge</c>
        /// or <c>AdminRespondToAuthChallenge</c> with challenge name <c>MFA_SETUP</c> to complete
        /// sign-in. 
        /// </para>
        ///  
        /// <para>
        /// To set up SMS or email MFA, collect a <c>phone_number</c> or <c>email</c> attribute
        /// for the user. Then restart the authentication flow with an <c>InitiateAuth</c> or
        /// <c>AdminInitiateAuth</c> request. 
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
        /// The parameters that define your response to the next challenge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ChallengeParameters
        {
            get { return this._challengeParameters; }
            set { this._challengeParameters = value; }
        }

        // Check to see if ChallengeParameters property is set
        internal bool IsSetChallengeParameters()
        {
            return this._challengeParameters != null && (this._challengeParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session identifier that maintains the state of authentication requests and challenge
        /// responses. If an <c>InitiateAuth</c> or <c>RespondToAuthChallenge</c> API request
        /// results in a determination that your application must pass another challenge, Amazon
        /// Cognito returns a session with other challenge parameters. Send this session identifier,
        /// unmodified, to the next <c>RespondToAuthChallenge</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
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