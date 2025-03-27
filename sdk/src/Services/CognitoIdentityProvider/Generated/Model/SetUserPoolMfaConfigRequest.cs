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
    /// Container for the parameters to the SetUserPoolMfaConfig operation.
    /// Sets user pool multi-factor authentication (MFA) and passkey configuration. For more
    /// information about user pool MFA, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-mfa.html">Adding
    /// MFA</a>. For more information about WebAuthn passkeys see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow-methods.html#amazon-cognito-user-pools-authentication-flow-methods-passkey">Authentication
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
    ///  </note>
    /// </summary>
    public partial class SetUserPoolMfaConfigRequest : AmazonCognitoIdentityProviderRequest
    {
        private EmailMfaConfigType _emailMfaConfiguration;
        private UserPoolMfaType _mfaConfiguration;
        private SmsMfaConfigType _smsMfaConfiguration;
        private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;
        private string _userPoolId;
        private WebAuthnConfigurationType _webAuthnConfiguration;

        /// <summary>
        /// Gets and sets the property EmailMfaConfiguration. 
        /// <para>
        /// Sets configuration for user pool email message MFA and sign-in with one-time passwords
        /// (OTPs). Includes the subject and body of the email message template for sign-in and
        /// MFA messages. To activate this setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        /// </summary>
        public EmailMfaConfigType EmailMfaConfiguration
        {
            get { return this._emailMfaConfiguration; }
            set { this._emailMfaConfiguration = value; }
        }

        // Check to see if EmailMfaConfiguration property is set
        internal bool IsSetEmailMfaConfiguration()
        {
            return this._emailMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Sets multi-factor authentication (MFA) to be on, off, or optional. When <c>ON</c>,
        /// all users must set up MFA before they can sign in. When <c>OPTIONAL</c>, your application
        /// must make a client-side determination of whether a user wants to register an MFA device.
        /// For user pools with adaptive authentication with threat protection, choose <c>OPTIONAL</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>MfaConfiguration</c> is <c>OPTIONAL</c>, managed login doesn't automatically
        /// prompt users to set up MFA. Amazon Cognito generates MFA prompts in API responses
        /// and in managed login for users who have chosen and configured a preferred MFA factor.
        /// </para>
        /// </summary>
        public UserPoolMfaType MfaConfiguration
        {
            get { return this._mfaConfiguration; }
            set { this._mfaConfiguration = value; }
        }

        // Check to see if MfaConfiguration property is set
        internal bool IsSetMfaConfiguration()
        {
            return this._mfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SmsMfaConfiguration. 
        /// <para>
        /// Configures user pool SMS messages for MFA. Sets the message template and the SMS message
        /// sending configuration for Amazon SNS.
        /// </para>
        /// </summary>
        public SmsMfaConfigType SmsMfaConfiguration
        {
            get { return this._smsMfaConfiguration; }
            set { this._smsMfaConfiguration = value; }
        }

        // Check to see if SmsMfaConfiguration property is set
        internal bool IsSetSmsMfaConfiguration()
        {
            return this._smsMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareTokenMfaConfiguration. 
        /// <para>
        /// Configures a user pool for time-based one-time password (TOTP) MFA. Enables or disables
        /// TOTP.
        /// </para>
        /// </summary>
        public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
        {
            get { return this._softwareTokenMfaConfiguration; }
            set { this._softwareTokenMfaConfiguration = value; }
        }

        // Check to see if SoftwareTokenMfaConfiguration property is set
        internal bool IsSetSoftwareTokenMfaConfiguration()
        {
            return this._softwareTokenMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
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

        /// <summary>
        /// Gets and sets the property WebAuthnConfiguration. 
        /// <para>
        /// The configuration of your user pool for passkey, or WebAuthn, authentication and registration.
        /// You can set this configuration independent of the MFA configuration options in this
        /// operation.
        /// </para>
        /// </summary>
        public WebAuthnConfigurationType WebAuthnConfiguration
        {
            get { return this._webAuthnConfiguration; }
            set { this._webAuthnConfiguration = value; }
        }

        // Check to see if WebAuthnConfiguration property is set
        internal bool IsSetWebAuthnConfiguration()
        {
            return this._webAuthnConfiguration != null;
        }

    }
}