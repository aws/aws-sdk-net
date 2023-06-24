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
    /// Container for the parameters to the AdminRespondToAuthChallenge operation.
    /// Responds to an authentication challenge, as an administrator.
    /// 
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
    /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
    /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
    /// your app while in the sandbox environment, you can move out of the sandbox and into
    /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
    /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Calling this action requires developer credentials.
    /// </para>
    /// </summary>
    public partial class AdminRespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private ChallengeNameType _challengeName;
        private Dictionary<string, string> _challengeResponses = new Dictionary<string, string>();
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = new Dictionary<string, string>();
        private ContextDataType _contextData;
        private string _session;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The analytics metadata for collecting Amazon Pinpoint metrics for <code>AdminRespondToAuthChallenge</code>
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
        /// The challenge name. For more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminInitiateAuth.html">AdminInitiateAuth</a>.
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
        /// The challenge responses. These are inputs corresponding to the value of <code>ChallengeName</code>,
        /// for example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SMS_MFA</code>: <code>SMS_MFA_CODE</code>, <code>USERNAME</code>, <code>SECRET_HASH</code>
        /// (if app client is configured with client secret).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PASSWORD_VERIFIER</code>: <code>PASSWORD_CLAIM_SIGNATURE</code>, <code>PASSWORD_CLAIM_SECRET_BLOCK</code>,
        /// <code>TIMESTAMP</code>, <code>USERNAME</code>, <code>SECRET_HASH</code> (if app client
        /// is configured with client secret).
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>PASSWORD_VERIFIER</code> requires <code>DEVICE_KEY</code> when signing in with
        /// a remembered device.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>ADMIN_NO_SRP_AUTH</code>: <code>PASSWORD</code>, <code>USERNAME</code>, <code>SECRET_HASH</code>
        /// (if app client is configured with client secret). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_PASSWORD_REQUIRED</code>: <code>NEW_PASSWORD</code>, <code>USERNAME</code>,
        /// <code>SECRET_HASH</code> (if app client is configured with client secret). To set
        /// any required attributes that Amazon Cognito returned as <code>requiredAttributes</code>
        /// in the <code>AdminInitiateAuth</code> response, add a <code>userAttributes.<i>attributename</i>
        /// </code> parameter. This parameter can also set values for writable attributes that
        /// aren't required by your user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// In a <code>NEW_PASSWORD_REQUIRED</code> challenge response, you can't modify a required
        /// attribute that already has a value. In <code>AdminRespondToAuthChallenge</code>, set
        /// a value for any keys that Amazon Cognito returned in the <code>requiredAttributes</code>
        /// parameter, then use the <code>AdminUpdateUserAttributes</code> API operation to modify
        /// the value of any additional attributes.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>MFA_SETUP</code> requires <code>USERNAME</code>, plus you must use the session
        /// value returned by <code>VerifySoftwareToken</code> in the <code>Session</code> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The value of the <code>USERNAME</code> attribute must be the user's actual username,
        /// not an alias (such as an email address or phone number). To make this simpler, the
        /// <code>AdminInitiateAuth</code> response includes the actual username value in the
        /// <code>USERNAMEUSER_ID_FOR_SRP</code> attribute. This happens even if you specified
        /// an alias in your call to <code>AdminInitiateAuth</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ChallengeResponses
        {
            get { return this._challengeResponses; }
            set { this._challengeResponses = value; }
        }

        // Check to see if ChallengeResponses property is set
        internal bool IsSetChallengeResponses()
        {
            return this._challengeResponses != null && this._challengeResponses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client ID.
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
        /// pre sign-up
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// custom message
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// post authentication
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// user migration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pre token generation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// define auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// create auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// verify auth challenge response
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When Amazon Cognito invokes any of these functions, it passes a JSON payload, which
        /// the function receives as input. This payload contains a <code>clientMetadata</code>
        /// attribute that provides the data that you assigned to the ClientMetadata parameter
        /// in your AdminRespondToAuthChallenge request. In your function code in Lambda, you
        /// can process the <code>clientMetadata</code> value to enhance your workflow for your
        /// specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Customizing user pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito
        /// Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the ClientMetadata parameter, remember that Amazon Cognito won't do the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the ClientMetadata value. This data is available only to Lambda triggers that
        /// are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the ClientMetadata parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the ClientMetadata value. Don't use Amazon Cognito to provide sensitive information.
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
            return this._clientMetadata != null && this._clientMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContextData. 
        /// <para>
        /// Contextual data about your user session, such as the device fingerprint, IP address,
        /// or location. Amazon Cognito advanced security evaluates the risk of an authentication
        /// event based on the context that your app generates and passes to Amazon Cognito when
        /// it makes API requests.
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
        /// The session that should be passed both ways in challenge-response calls to the service.
        /// If an <code>InitiateAuth</code> or <code>RespondToAuthChallenge</code> API call determines
        /// that the caller must pass another challenge, it returns a session with other challenge
        /// parameters. This session should be passed as it is to the next <code>RespondToAuthChallenge</code>
        /// API call.
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
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito user pool.
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