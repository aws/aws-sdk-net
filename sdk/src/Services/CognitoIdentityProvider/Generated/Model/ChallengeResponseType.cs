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
    /// The responses to the challenge that you received in the previous request. Each challenge
    /// has its own required response parameters. The following examples are partial JSON
    /// request bodies that highlight challenge-response parameters.
    /// 
    ///  <important> 
    /// <para>
    /// You must provide a SECRET_HASH parameter in all challenge responses to an app client
    /// that has a client secret. Include a <c>DEVICE_KEY</c> for device authentication.
    /// </para>
    ///  </important> <dl> <dt>SELECT_CHALLENGE</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "USERNAME": "[username]",
    /// "ANSWER": "[Challenge name]"}</c> 
    /// </para>
    ///  
    /// <para>
    /// Available challenges are <c>PASSWORD</c>, <c>PASSWORD_SRP</c>, <c>EMAIL_OTP</c>, <c>SMS_OTP</c>,
    /// and <c>WEB_AUTHN</c>.
    /// </para>
    ///  
    /// <para>
    /// Complete authentication in the <c>SELECT_CHALLENGE</c> response for <c>PASSWORD</c>,
    /// <c>PASSWORD_SRP</c>, and <c>WEB_AUTHN</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "ANSWER": "WEB_AUTHN",
    /// "USERNAME": "[username]", "CREDENTIAL": "[AuthenticationResponseJSON]"}</c> 
    /// </para>
    ///  
    /// <para>
    /// See <a href="https://www.w3.org/TR/WebAuthn-3/#dictdef-authenticationresponsejson">
    /// AuthenticationResponseJSON</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "ANSWER": "PASSWORD",
    /// "USERNAME": "[username]", "PASSWORD": "[password]"}</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "ANSWER": "PASSWORD_SRP",
    /// "USERNAME": "[username]", "SRP_A": "[SRP_A]"}</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For <c>SMS_OTP</c> and <c>EMAIL_OTP</c>, respond with the username and answer. Your
    /// user pool will send a code for the user to submit in the next challenge response.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "ANSWER": "SMS_OTP",
    /// "USERNAME": "[username]"}</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_CHALLENGE", "ChallengeResponses": { "ANSWER": "EMAIL_OTP",
    /// "USERNAME": "[username]"}</c> 
    /// </para>
    ///  </li> </ul> </dd> <dt>WEB_AUTHN</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "WEB_AUTHN", "ChallengeResponses": { "USERNAME": "[username]",
    /// "CREDENTIAL": "[AuthenticationResponseJSON]"}</c> 
    /// </para>
    ///  
    /// <para>
    /// See <a href="https://www.w3.org/TR/WebAuthn-3/#dictdef-authenticationresponsejson">
    /// AuthenticationResponseJSON</a>.
    /// </para>
    ///  </dd> <dt>PASSWORD</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "PASSWORD", "ChallengeResponses": { "USERNAME": "[username]",
    /// "PASSWORD": "[password]"}</c> 
    /// </para>
    ///  </dd> <dt>PASSWORD_SRP</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "PASSWORD_SRP", "ChallengeResponses": { "USERNAME": "[username]",
    /// "SRP_A": "[SRP_A]"}</c> 
    /// </para>
    ///  </dd> <dt>SMS_OTP</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "SMS_OTP", "ChallengeResponses": {"SMS_OTP_CODE": "[code]", "USERNAME":
    /// "[username]"}</c> 
    /// </para>
    ///  </dd> <dt>EMAIL_OTP</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "EMAIL_OTP", "ChallengeResponses": {"EMAIL_OTP_CODE": "[code]",
    /// "USERNAME": "[username]"}</c> 
    /// </para>
    ///  </dd> <dt>SMS_MFA</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "SMS_MFA", "ChallengeResponses": {"SMS_MFA_CODE": "[code]", "USERNAME":
    /// "[username]"}</c> 
    /// </para>
    ///  </dd> <dt>PASSWORD_VERIFIER</dt> <dd> 
    /// <para>
    /// This challenge response is part of the SRP flow. Amazon Cognito requires that your
    /// application respond to this challenge within a few seconds. When the response time
    /// exceeds this period, your user pool returns a <c>NotAuthorizedException</c> error.
    /// </para>
    ///  
    /// <para>
    ///  <c>"ChallengeName": "PASSWORD_VERIFIER", "ChallengeResponses": {"PASSWORD_CLAIM_SIGNATURE":
    /// "[claim_signature]", "PASSWORD_CLAIM_SECRET_BLOCK": "[secret_block]", "TIMESTAMP":
    /// [timestamp], "USERNAME": "[username]"}</c> 
    /// </para>
    ///  </dd> <dt>CUSTOM_CHALLENGE</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "CUSTOM_CHALLENGE", "ChallengeResponses": {"USERNAME": "[username]",
    /// "ANSWER": "[challenge_answer]"}</c> 
    /// </para>
    ///  </dd> <dt>NEW_PASSWORD_REQUIRED</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "NEW_PASSWORD_REQUIRED", "ChallengeResponses": {"NEW_PASSWORD":
    /// "[new_password]", "USERNAME": "[username]"}</c> 
    /// </para>
    ///  
    /// <para>
    /// To set any required attributes that <c>InitiateAuth</c> returned in an <c>requiredAttributes</c>
    /// parameter, add <c>"userAttributes.[attribute_name]": "[attribute_value]"</c>. This
    /// parameter can also set values for writable attributes that aren't required by your
    /// user pool.
    /// </para>
    ///  <note> 
    /// <para>
    /// In a <c>NEW_PASSWORD_REQUIRED</c> challenge response, you can't modify a required
    /// attribute that already has a value. In <c>AdminRespondToAuthChallenge</c> or <c>RespondToAuthChallenge</c>,
    /// set a value for any keys that Amazon Cognito returned in the <c>requiredAttributes</c>
    /// parameter, then use the <c>AdminUpdateUserAttributes</c> or <c>UpdateUserAttributes</c>
    /// API operation to modify the value of any additional attributes.
    /// </para>
    ///  </note> </dd> <dt>SOFTWARE_TOKEN_MFA</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "SOFTWARE_TOKEN_MFA", "ChallengeResponses": {"USERNAME": "[username]",
    /// "SOFTWARE_TOKEN_MFA_CODE": [authenticator_code]}</c> 
    /// </para>
    ///  </dd> <dt>DEVICE_SRP_AUTH</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "DEVICE_SRP_AUTH", "ChallengeResponses": {"USERNAME": "[username]",
    /// "DEVICE_KEY": "[device_key]", "SRP_A": "[srp_a]"}</c> 
    /// </para>
    ///  </dd> <dt>DEVICE_PASSWORD_VERIFIER</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "DEVICE_PASSWORD_VERIFIER", "ChallengeResponses": {"DEVICE_KEY":
    /// "[device_key]", "PASSWORD_CLAIM_SIGNATURE": "[claim_signature]", "PASSWORD_CLAIM_SECRET_BLOCK":
    /// "[secret_block]", "TIMESTAMP": [timestamp], "USERNAME": "[username]"}</c> 
    /// </para>
    ///  </dd> <dt>MFA_SETUP</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "MFA_SETUP", "ChallengeResponses": {"USERNAME": "[username]"},
    /// "SESSION": "[Session ID from VerifySoftwareToken]"</c> 
    /// </para>
    ///  </dd> <dt>SELECT_MFA_TYPE</dt> <dd> 
    /// <para>
    ///  <c>"ChallengeName": "SELECT_MFA_TYPE", "ChallengeResponses": {"USERNAME": "[username]",
    /// "ANSWER": "[SMS_MFA|EMAIL_MFA|SOFTWARE_TOKEN_MFA]"}</c> 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// For more information about <c>SECRET_HASH</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#cognito-user-pools-computing-secret-hash">Computing
    /// secret hash values</a>. For information about <c>DEVICE_KEY</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
    /// with user devices in your user pool</a>.
    /// </para>
    /// </summary>
    public partial class ChallengeResponseType
    {
        private ChallengeName _challengeName;
        private ChallengeResponse _challengeResponse;

        /// <summary>
        /// Gets and sets the property ChallengeName. 
        /// <para>
        /// The type of challenge that your previous authentication request returned in the parameter
        /// <c>ChallengeName</c>, for example <c>SMS_MFA</c>.
        /// </para>
        /// </summary>
        public ChallengeName ChallengeName
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
        /// Gets and sets the property ChallengeResponse. 
        /// <para>
        /// The set of key-value pairs that provides a response to the requested challenge.
        /// </para>
        /// </summary>
        public ChallengeResponse ChallengeResponse
        {
            get { return this._challengeResponse; }
            set { this._challengeResponse = value; }
        }

        // Check to see if ChallengeResponse property is set
        internal bool IsSetChallengeResponse()
        {
            return this._challengeResponse != null;
        }

    }
}