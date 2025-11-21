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
    /// Container for the parameters to the AdminInitiateAuth operation.
    /// Starts sign-in for applications with a server-side component, for example a traditional
    /// web application. This operation specifies the authentication flow that you'd like
    /// to begin. The authentication flow that you specify must be supported in your app client
    /// configuration. For more information about authentication flows, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow-methods.html">Authentication
    /// flows</a>.
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
    public partial class AdminInitiateAuthRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private AuthFlowType _authFlow;
        private Dictionary<string, string> _authParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ContextDataType _contextData;
        private string _session;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// Information that supports analytics outcomes with Amazon Pinpoint, including the user's
        /// endpoint ID. The endpoint ID is a destination for Amazon Pinpoint push notifications,
        /// for example a device identifier, email address, or phone number.
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
        /// <c>AuthParameters</c> that you must submit. The following are some example flows.
        /// </para>
        ///  <dl> <dt>USER_AUTH</dt> <dd> 
        /// <para>
        /// The entry point for <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flows-selection-sdk.html#authentication-flows-selection-choice">choice-based
        /// authentication</a> with passwords, one-time passwords, and WebAuthn authenticators.
        /// Request a preferred authentication type or review available authentication types.
        /// From the offered authentication types, select one in a challenge response and then
        /// authenticate with that method in an additional challenge response. To activate this
        /// setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        ///  </dd> <dt>USER_SRP_AUTH</dt> <dd> 
        /// <para>
        /// Username-password authentication with the Secure Remote Password (SRP) protocol. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow.html#Using-SRP-password-verification-in-custom-authentication-flow">Use
        /// SRP password verification in custom authentication flow</a>.
        /// </para>
        ///  </dd> <dt>REFRESH_TOKEN_AUTH and REFRESH_TOKEN</dt> <dd> 
        /// <para>
        /// Receive new ID and access tokens when you pass a <c>REFRESH_TOKEN</c> parameter with
        /// a valid refresh token as the value. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-using-the-refresh-token.html">Using
        /// the refresh token</a>.
        /// </para>
        ///  </dd> <dt>CUSTOM_AUTH</dt> <dd> 
        /// <para>
        /// Custom authentication with Lambda triggers. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">Custom
        /// authentication challenge Lambda triggers</a>.
        /// </para>
        ///  </dd> <dt>ADMIN_USER_PASSWORD_AUTH</dt> <dd> 
        /// <para>
        /// Server-side username-password authentication with the password sent directly in the
        /// request. For more information about client-side and server-side authentication, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flows-public-server-side.html">SDK
        /// authorization models</a>.
        /// </para>
        ///  </dd> </dl>
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
        /// that you're invoking.
        /// </para>
        ///  
        /// <para>
        /// The following are some authentication flows and their parameters. Add a <c>SECRET_HASH</c>
        /// parameter if your app client has a client secret. Add <c>DEVICE_KEY</c> if you want
        /// to bypass multi-factor authentication with a remembered device. 
        /// </para>
        ///  <dl> <dt>USER_AUTH</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>USERNAME</c> (required)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PREFERRED_CHALLENGE</c>. If you don't provide a value for <c>PREFERRED_CHALLENGE</c>,
        /// Amazon Cognito responds with the <c>AvailableChallenges</c> parameter that specifies
        /// the available sign-in methods.
        /// </para>
        ///  </li> </ul> </dd> <dt>USER_SRP_AUTH</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>USERNAME</c> (required)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRP_A</c> (required)
        /// </para>
        ///  </li> </ul> </dd> <dt>ADMIN_USER_PASSWORD_AUTH</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>USERNAME</c> (required)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASSWORD</c> (required)
        /// </para>
        ///  </li> </ul> </dd> <dt>REFRESH_TOKEN_AUTH/REFRESH_TOKEN</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>REFRESH_TOKEN</c>(required)
        /// </para>
        ///  </li> </ul> </dd> <dt>CUSTOM_AUTH</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>USERNAME</c> (required)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ChallengeName: SRP_A</c> (when preceding custom authentication with SRP authentication)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRP_A: (An SRP_A value)</c> (when preceding custom authentication with SRP authentication)
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// For more information about <c>SECRET_HASH</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#cognito-user-pools-computing-secret-hash">Computing
        /// secret hash values</a>. For information about <c>DEVICE_KEY</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The ID of the app client where the user wants to sign in.
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
        /// you use the AdminInitiateAuth API action, Amazon Cognito invokes the Lambda functions
        /// that are specified for various triggers. The ClientMetadata value is passed as input
        /// to the functions for only the following triggers:
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
        /// in your AdminInitiateAuth request. In your function code in Lambda, you can process
        /// the <c>validationData</c> value to enhance your workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// When you use the AdminInitiateAuth API action, Amazon Cognito also invokes the functions
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
        /// Using Lambda triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Contextual data about your user session like the device fingerprint, IP address, or
        /// location. Amazon Cognito threat protection evaluates the risk of an authentication
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
        /// The optional session ID from a <c>ConfirmSignUp</c> API request. You can sign in a
        /// user directly from the sign-up process with an <c>AuthFlow</c> of <c>USER_AUTH</c>
        /// and <c>AuthParameters</c> of <c>EMAIL_OTP</c> or <c>SMS_OTP</c>, depending on how
        /// your user pool sent the confirmation-code message.
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
        /// The ID of the user pool where the user wants to sign in.
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