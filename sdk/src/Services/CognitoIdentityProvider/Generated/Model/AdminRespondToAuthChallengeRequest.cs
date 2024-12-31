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
    /// Container for the parameters to the AdminRespondToAuthChallenge operation.
    /// Some API operations in a user pool generate a challenge, like a prompt for an MFA
    /// code, for device authentication that bypasses MFA, or for a custom authentication
    /// challenge. An <c>AdminRespondToAuthChallenge</c> API request provides the answer to
    /// that challenge, like a code or a secure remote password (SRP). The parameters of a
    /// response to an authentication challenge vary with the type of challenge.
    /// 
    ///  
    /// <para>
    /// For more information about custom authentication challenges, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">Custom
    /// authentication challenge Lambda triggers</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
    /// carriers require you to register an origination phone number before you can send SMS
    /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
    /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
    /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
    /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
    /// their accounts, or sign in.
    /// </para>
    ///  
    /// <para>
    /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
    /// Services service, Amazon Simple Notification Service might place your account in the
    /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
    /// your app while in the sandbox environment, you can move out of the sandbox and into
    /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
    /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AdminRespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private ChallengeNameType _challengeName;
        private Dictionary<string, string> _challengeResponses = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ContextDataType _contextData;
        private string _session;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The analytics metadata for collecting Amazon Pinpoint metrics for <c>AdminRespondToAuthChallenge</c>
        /// calls.
        /// </para>
        /// </summary>
        public AnalyticsMetadataType AnalyticsMetadata
        {
            get { return this._analyticsMetadata; }
            set { this._analyticsMetadata = value; }
        }

        // Check to see if AnalyticsMetadata property is set
        internal bool IsSetAnalyticsMetadata()
        {
            return this._analyticsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeName. 
        /// <para>
        /// The name of the challenge that you are responding to. You can find more information
        /// about values for <c>ChallengeName</c> in the response parameters of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminInitiateAuth.html#CognitoUserPools-AdminInitiateAuth-response-ChallengeName">AdminInitiateAuth</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ChallengeResponses. 
        /// <para>
        /// The responses to the challenge that you received in the previous request. Each challenge
        /// has its own required response parameters. The following examples are partial JSON
        /// request bodies that highlight challenge-response parameters.
        /// </para>
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
        /// See <a href="https://www.w3.org/TR/webauthn-3/#dictdef-authenticationresponsejson">
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
        ///  </li> </ul> </dd> <dt>SMS_OTP</dt> <dd> 
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
        ///  
        /// <para>
        /// Add <c>"DEVICE_KEY"</c> when you sign in with a remembered device.
        /// </para>
        ///  </dd> <dt>CUSTOM_CHALLENGE</dt> <dd> 
        /// <para>
        ///  <c>"ChallengeName": "CUSTOM_CHALLENGE", "ChallengeResponses": {"USERNAME": "[username]",
        /// "ANSWER": "[challenge_answer]"}</c> 
        /// </para>
        ///  
        /// <para>
        /// Add <c>"DEVICE_KEY"</c> when you sign in with a remembered device.
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
        /// attribute that already has a value. In <c>RespondToAuthChallenge</c>, set a value
        /// for any keys that Amazon Cognito returned in the <c>requiredAttributes</c> parameter,
        /// then use the <c>UpdateUserAttributes</c> API operation to modify the value of any
        /// additional attributes.
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
        /// "ANSWER": "[SMS_MFA or SOFTWARE_TOKEN_MFA]"}</c> 
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For more information about <c>SECRET_HASH</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#cognito-user-pools-computing-secret-hash">Computing
        /// secret hash values</a>. For information about <c>DEVICE_KEY</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> ChallengeResponses
        {
            get { return this._challengeResponses; }
            set { this._challengeResponses = value; }
        }

        // Check to see if ChallengeResponses property is set
        internal bool IsSetChallengeResponses()
        {
            return this._challengeResponses != null && (this._challengeResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client where you initiated sign-in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the AdminRespondToAuthChallenge API action, Amazon Cognito invokes any functions
        /// that you have assigned to the following triggers: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pre sign-up
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// custom message
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post authentication
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User migration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pre token generation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verify auth challenge response
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When Amazon Cognito invokes any of these functions, it passes a JSON payload, which
        /// the function receives as input. This payload contains a <c>clientMetadata</c> attribute
        /// that provides the data that you assigned to the ClientMetadata parameter in your AdminRespondToAuthChallenge
        /// request. In your function code in Lambda, you can process the <c>clientMetadata</c>
        /// value to enhance your workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Customizing user pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito
        /// Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the <c>ClientMetadata</c> parameter, note that Amazon Cognito won't do
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the <c>ClientMetadata</c> value. This data is available only to Lambda triggers
        /// that are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the <c>ClientMetadata</c> parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the <c>ClientMetadata</c> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the <c>ClientMetadata</c> value. Don't send sensitive information in this
        /// parameter.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public Dictionary<string, string> ClientMetadata
        {
            get { return this._clientMetadata; }
            set { this._clientMetadata = value; }
        }

        // Check to see if ClientMetadata property is set
        internal bool IsSetClientMetadata()
        {
            return this._clientMetadata != null && (this._clientMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContextData. 
        /// <para>
        /// Contextual data about your user session, such as the device fingerprint, IP address,
        /// or location. Amazon Cognito advanced security evaluates the risk of an authentication
        /// event based on the context that your app generates and passes to Amazon Cognito when
        /// it makes API requests.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-viewing-threat-protection-app.html">Collecting
        /// data for threat protection in applications</a>.
        /// </para>
        /// </summary>
        public ContextDataType ContextData
        {
            get { return this._contextData; }
            set { this._contextData = value; }
        }

        // Check to see if ContextData property is set
        internal bool IsSetContextData()
        {
            return this._contextData != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session identifier that maintains the state of authentication requests and challenge
        /// responses. If an <c>AdminInitiateAuth</c> or <c>AdminRespondToAuthChallenge</c> API
        /// request results in a determination that your application must pass another challenge,
        /// Amazon Cognito returns a session with other challenge parameters. Send this session
        /// identifier, unmodified, to the next <c>AdminRespondToAuthChallenge</c> request.
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

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to respond to an authentication challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}