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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateAuth operation.
    /// Initiates sign-in for a user in the Amazon Cognito user directory. You can't sign
    /// in a user with a federated IdP with <c>InitiateAuth</c>. For more information, see
    /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">
    /// Adding user pool sign-in through a third party</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note> <note> 
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
    ///  </note>
    /// </summary>
    public partial class InitiateAuthRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private AuthFlowType _authFlow;
        private Dictionary<string, string> _authParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _session;
        private UserContextDataType _userContextData;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The Amazon Pinpoint analytics metadata that contributes to your metrics for <c>InitiateAuth</c>
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
        /// Gets and sets the property AuthFlow. 
        /// <para>
        /// The authentication flow that you want to initiate. Each <c>AuthFlow</c> has linked
        /// <c>AuthParameters</c> that you must submit. The following are some example flows and
        /// their parameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>USER_AUTH</c>: Request a preferred authentication type or review available authentication
        /// types. From the offered authentication types, select one in a challenge response and
        /// then authenticate with that method in an additional challenge response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REFRESH_TOKEN_AUTH</c>: Receive new ID and access tokens when you pass a <c>REFRESH_TOKEN</c>
        /// parameter with a valid refresh token as the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_SRP_AUTH</c>: Receive secure remote password (SRP) variables for the next
        /// challenge, <c>PASSWORD_VERIFIER</c>, when you pass <c>USERNAME</c> and <c>SRP_A</c>
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_PASSWORD_AUTH</c>: Receive new tokens or the next challenge, for example
        /// <c>SOFTWARE_TOKEN_MFA</c>, when you pass <c>USERNAME</c> and <c>PASSWORD</c> parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <i>All flows</i> 
        /// </para>
        ///  <dl> <dt>USER_AUTH</dt> <dd> 
        /// <para>
        /// The entry point for sign-in with passwords, one-time passwords, and WebAuthN authenticators.
        /// </para>
        ///  </dd> <dt>USER_SRP_AUTH</dt> <dd> 
        /// <para>
        /// Username-password authentication with the Secure Remote Password (SRP) protocol. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow.html#Using-SRP-password-verification-in-custom-authentication-flow">Use
        /// SRP password verification in custom authentication flow</a>.
        /// </para>
        ///  </dd> <dt>REFRESH_TOKEN_AUTH and REFRESH_TOKEN</dt> <dd> 
        /// <para>
        /// Provide a valid refresh token and receive new ID and access tokens. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-using-the-refresh-token.html">Using
        /// the refresh token</a>.
        /// </para>
        ///  </dd> <dt>CUSTOM_AUTH</dt> <dd> 
        /// <para>
        /// Custom authentication with Lambda triggers. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">Custom
        /// authentication challenge Lambda triggers</a>.
        /// </para>
        ///  </dd> <dt>USER_PASSWORD_AUTH</dt> <dd> 
        /// <para>
        /// Username-password authentication with the password sent directly in the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow.html#Built-in-authentication-flow-and-challenges">Admin
        /// authentication flow</a>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  <c>ADMIN_USER_PASSWORD_AUTH</c> is a flow type of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminInitiateAuth.html">AdminInitiateAuth</a>
        /// and isn't valid for InitiateAuth. <c>ADMIN_NO_SRP_AUTH</c> is a legacy server-side
        /// username-password flow and isn't valid for InitiateAuth.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthFlowType AuthFlow
        {
            get { return this._authFlow; }
            set { this._authFlow = value; }
        }

        // Check to see if AuthFlow property is set
        internal bool IsSetAuthFlow()
        {
            return this._authFlow != null;
        }

        /// <summary>
        /// Gets and sets the property AuthParameters. 
        /// <para>
        /// The authentication parameters. These are inputs corresponding to the <c>AuthFlow</c>
        /// that you're invoking. The required values depend on the value of <c>AuthFlow</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>USER_AUTH</c>: <c>USERNAME</c> (required), <c>PREFERRED_CHALLENGE</c>. If you
        /// don't provide a value for <c>PREFERRED_CHALLENGE</c>, Amazon Cognito responds with
        /// the <c>AvailableChallenges</c> parameter that specifies the available sign-in methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>USER_SRP_AUTH</c>: <c>USERNAME</c> (required), <c>SRP_A</c> (required), <c>SECRET_HASH</c>
        /// (required if the app client is configured with a client secret), <c>DEVICE_KEY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>USER_PASSWORD_AUTH</c>: <c>USERNAME</c> (required), <c>PASSWORD</c> (required),
        /// <c>SECRET_HASH</c> (required if the app client is configured with a client secret),
        /// <c>DEVICE_KEY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>REFRESH_TOKEN_AUTH/REFRESH_TOKEN</c>: <c>REFRESH_TOKEN</c> (required), <c>SECRET_HASH</c>
        /// (required if the app client is configured with a client secret), <c>DEVICE_KEY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>CUSTOM_AUTH</c>: <c>USERNAME</c> (required), <c>SECRET_HASH</c> (if app client
        /// is configured with client secret), <c>DEVICE_KEY</c>. To start the authentication
        /// flow with password verification, include <c>ChallengeName: SRP_A</c> and <c>SRP_A:
        /// (The SRP_A Value)</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about <c>SECRET_HASH</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#cognito-user-pools-computing-secret-hash">Computing
        /// secret hash values</a>. For information about <c>DEVICE_KEY</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> AuthParameters
        {
            get { return this._authParameters; }
            set { this._authParameters = value; }
        }

        // Check to see if AuthParameters property is set
        internal bool IsSetAuthParameters()
        {
            return this._authParameters != null && (this._authParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// A map of custom key-value pairs that you can provide as input for certain custom workflows
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the InitiateAuth API action, Amazon Cognito invokes the Lambda functions that
        /// are specified for various triggers. The ClientMetadata value is passed as input to
        /// the functions for only the following triggers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pre signup
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pre authentication
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User migration
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When Amazon Cognito invokes the functions for these triggers, it passes a JSON payload,
        /// which the function receives as input. This payload contains a <c>validationData</c>
        /// attribute, which provides the data that you assigned to the ClientMetadata parameter
        /// in your InitiateAuth request. In your function code in Lambda, you can process the
        /// <c>validationData</c> value to enhance your workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// When you use the InitiateAuth API action, Amazon Cognito also invokes the functions
        /// for the following triggers, but it doesn't provide the ClientMetadata value as input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Post authentication
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom message
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pre token generation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define auth challenge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom email sender
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom SMS sender
        /// </para>
        ///  </li> </ul> 
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
        /// Gets and sets the property Session. 
        /// <para>
        /// The optional session ID from a <c>ConfirmSignUp</c> API request. You can sign in a
        /// user directly from the sign-up process with the <c>USER_AUTH</c> authentication flow.
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
        /// Gets and sets the property UserContextData. 
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
        [AWSProperty(Sensitive=true)]
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