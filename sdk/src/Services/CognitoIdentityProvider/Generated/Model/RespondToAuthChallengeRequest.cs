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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the RespondToAuthChallenge operation.
    /// Responds to the authentication challenge.
    /// 
    ///  <note> 
    /// <para>
    /// This action might generate an SMS text message. Starting June 1, 2021, U.S. telecom
    /// carriers require that you register an origination phone number before you can send
    /// SMS messages to U.S. phone numbers. If you use SMS text messages in Amazon Cognito,
    /// you must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
    /// Pinpoint</a>. Cognito will use the the registered number automatically. Otherwise,
    /// Cognito users that must receive SMS messages might be unable to sign up, activate
    /// their accounts, or sign in.
    /// </para>
    ///  
    /// <para>
    /// If you have never used SMS text messages with Amazon Cognito or any other AWS service,
    /// Amazon SNS might place your account in SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you’ll have limitations, such as sending messages to only verified
    /// phone numbers. After testing in the sandbox environment, you can move out of the SMS
    /// sandbox and into production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
    /// SMS message settings for Cognito User Pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private ChallengeNameType _challengeName;
        private Dictionary<string, string> _challengeResponses = new Dictionary<string, string>();
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = new Dictionary<string, string>();
        private string _session;
        private UserContextDataType _userContextData;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The Amazon Pinpoint analytics metadata for collecting metrics for <code>RespondToAuthChallenge</code>
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
        /// The challenge name. For more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_InitiateAuth.html">InitiateAuth</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>ADMIN_NO_SRP_AUTH</code> is not a valid value.
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
        ///  <note> 
        /// <para>
        ///  <code>SECRET_HASH</code> (if app client is configured with client secret) applies
        /// to all inputs below (including <code>SOFTWARE_TOKEN_MFA</code>).
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>SMS_MFA</code>: <code>SMS_MFA_CODE</code>, <code>USERNAME</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PASSWORD_VERIFIER</code>: <code>PASSWORD_CLAIM_SIGNATURE</code>, <code>PASSWORD_CLAIM_SECRET_BLOCK</code>,
        /// <code>TIMESTAMP</code>, <code>USERNAME</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_PASSWORD_REQUIRED</code>: <code>NEW_PASSWORD</code>, any other required
        /// attributes, <code>USERNAME</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SOFTWARE_TOKEN_MFA</code>: <code>USERNAME</code> and <code>SOFTWARE_TOKEN_MFA_CODE</code>
        /// are required attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEVICE_SRP_AUTH</code> requires <code>USERNAME</code>, <code>DEVICE_KEY</code>,
        /// <code>SRP_A</code> (and <code>SECRET_HASH</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEVICE_PASSWORD_VERIFIER</code> requires everything that <code>PASSWORD_VERIFIER</code>
        /// requires plus <code>DEVICE_KEY</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MFA_SETUP</code> requires <code>USERNAME</code>, plus you need to use the session
        /// value returned by <code>VerifySoftwareToken</code> in the <code>Session</code> parameter.
        /// </para>
        ///  </li> </ul>
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
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// You create custom workflows by assigning AWS Lambda functions to user pool triggers.
        /// When you use the RespondToAuthChallenge API action, Amazon Cognito invokes any functions
        /// that are assigned to the following triggers: <i>post authentication</i>, <i>pre token
        /// generation</i>, <i>define auth challenge</i>, <i>create auth challenge</i>, and <i>verify
        /// auth challenge</i>. When Amazon Cognito invokes any of these functions, it passes
        /// a JSON payload, which the function receives as input. This payload contains a <code>clientMetadata</code>
        /// attribute, which provides the data that you assigned to the ClientMetadata parameter
        /// in your RespondToAuthChallenge request. In your function code in AWS Lambda, you can
        /// process the <code>clientMetadata</code> value to enhance your workflow for your specific
        /// needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">Customizing
        /// User Pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Take the following limitations into consideration when you use the ClientMetadata
        /// parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito does not store the ClientMetadata value. This data is available only
        /// to AWS Lambda triggers that are assigned to a user pool to support custom workflows.
        /// If your user pool configuration does not include triggers, the ClientMetadata parameter
        /// serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not encrypt the the ClientMetadata value, so don't use it to provide
        /// sensitive information.
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
        /// Gets and sets the property Session. 
        /// <para>
        /// The session which should be passed both ways in challenge-response calls to the service.
        /// If <code>InitiateAuth</code> or <code>RespondToAuthChallenge</code> API call determines
        /// that the caller needs to go through another challenge, they return a session with
        /// other challenge parameters. This session should be passed as it is to the next <code>RespondToAuthChallenge</code>
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
        /// Gets and sets the property UserContextData. 
        /// <para>
        /// Contextual data such as the user's device fingerprint, IP address, or location used
        /// for evaluating the risk of an unexpected event by Amazon Cognito advanced security.
        /// </para>
        /// </summary>
        public UserContextDataType UserContextData
        {
            get { return this._userContextData; }
            set { this._userContextData = value; }
        }

        // Check to see if UserContextData property is set
        internal bool IsSetUserContextData()
        {
            return this._userContextData != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}