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
    /// Container for the parameters to the UpdateUserPool operation.
    /// Updates the specified user pool with the specified attributes. You can get a list
    /// of the current user pool settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
    /// If you don't provide a value for an attribute, it will be set to the default value.
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
    /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
    /// Service, Amazon SNS might place your account in SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you’ll have limitations, such as sending messages to only verified
    /// phone numbers. After testing in the sandbox environment, you can move out of the SMS
    /// sandbox and into production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
    /// SMS message settings for Cognito User Pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateUserPoolRequest : AmazonCognitoIdentityProviderRequest
    {
        private AccountRecoverySettingType _accountRecoverySetting;
        private AdminCreateUserConfigType _adminCreateUserConfig;
        private List<string> _autoVerifiedAttributes = new List<string>();
        private DeviceConfigurationType _deviceConfiguration;
        private EmailConfigurationType _emailConfiguration;
        private string _emailVerificationMessage;
        private string _emailVerificationSubject;
        private LambdaConfigType _lambdaConfig;
        private UserPoolMfaType _mfaConfiguration;
        private UserPoolPolicyType _policies;
        private string _smsAuthenticationMessage;
        private SmsConfigurationType _smsConfiguration;
        private string _smsVerificationMessage;
        private UserPoolAddOnsType _userPoolAddOns;
        private string _userPoolId;
        private Dictionary<string, string> _userPoolTags = new Dictionary<string, string>();
        private VerificationMessageTemplateType _verificationMessageTemplate;

        /// <summary>
        /// Gets and sets the property AccountRecoverySetting. 
        /// <para>
        /// Use this setting to define which verified available method a user can use to recover
        /// their password when they call <code>ForgotPassword</code>. It allows you to define
        /// a preferred method when a user has more than one method available. With this setting,
        /// SMS does not qualify for a valid password recovery mechanism if the user also has
        /// SMS MFA enabled. In the absence of this setting, Cognito uses the legacy behavior
        /// to determine the recovery method where SMS is preferred over email.
        /// </para>
        /// </summary>
        public AccountRecoverySettingType AccountRecoverySetting
        {
            get { return this._accountRecoverySetting; }
            set { this._accountRecoverySetting = value; }
        }

        // Check to see if AccountRecoverySetting property is set
        internal bool IsSetAccountRecoverySetting()
        {
            return this._accountRecoverySetting != null;
        }

        /// <summary>
        /// Gets and sets the property AdminCreateUserConfig. 
        /// <para>
        /// The configuration for <code>AdminCreateUser</code> requests.
        /// </para>
        /// </summary>
        public AdminCreateUserConfigType AdminCreateUserConfig
        {
            get { return this._adminCreateUserConfig; }
            set { this._adminCreateUserConfig = value; }
        }

        // Check to see if AdminCreateUserConfig property is set
        internal bool IsSetAdminCreateUserConfig()
        {
            return this._adminCreateUserConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes that are automatically verified when the Amazon Cognito service makes
        /// a request to update user pools.
        /// </para>
        /// </summary>
        public List<string> AutoVerifiedAttributes
        {
            get { return this._autoVerifiedAttributes; }
            set { this._autoVerifiedAttributes = value; }
        }

        // Check to see if AutoVerifiedAttributes property is set
        internal bool IsSetAutoVerifiedAttributes()
        {
            return this._autoVerifiedAttributes != null && this._autoVerifiedAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// Device configuration.
        /// </para>
        /// </summary>
        public DeviceConfigurationType DeviceConfiguration
        {
            get { return this._deviceConfiguration; }
            set { this._deviceConfiguration = value; }
        }

        // Check to see if DeviceConfiguration property is set
        internal bool IsSetDeviceConfiguration()
        {
            return this._deviceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EmailConfiguration. 
        /// <para>
        /// Email configuration.
        /// </para>
        /// </summary>
        public EmailConfigurationType EmailConfiguration
        {
            get { return this._emailConfiguration; }
            set { this._emailConfiguration = value; }
        }

        // Check to see if EmailConfiguration property is set
        internal bool IsSetEmailConfiguration()
        {
            return this._emailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationMessage. 
        /// <para>
        /// The contents of the email verification message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
        public string EmailVerificationMessage
        {
            get { return this._emailVerificationMessage; }
            set { this._emailVerificationMessage = value; }
        }

        // Check to see if EmailVerificationMessage property is set
        internal bool IsSetEmailVerificationMessage()
        {
            return this._emailVerificationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationSubject. 
        /// <para>
        /// The subject of the email verification message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string EmailVerificationSubject
        {
            get { return this._emailVerificationSubject; }
            set { this._emailVerificationSubject = value; }
        }

        // Check to see if EmailVerificationSubject property is set
        internal bool IsSetEmailVerificationSubject()
        {
            return this._emailVerificationSubject != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// The Lambda configuration information from the request to update the user pool.
        /// </para>
        /// </summary>
        public LambdaConfigType LambdaConfig
        {
            get { return this._lambdaConfig; }
            set { this._lambdaConfig = value; }
        }

        // Check to see if LambdaConfig property is set
        internal bool IsSetLambdaConfig()
        {
            return this._lambdaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>OFF</code> - MFA tokens are not required and cannot be specified during user
        /// registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ON</code> - MFA tokens are required for all user registrations. You can only
        /// specify ON when you are initially creating a user pool. You can use the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserPoolMfaConfig.html">SetUserPoolMfaConfig</a>
        /// API operation to turn MFA "ON" for existing user pools. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OPTIONAL</code> - Users have the option when registering to create an MFA token.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// A container with the policies you wish to update in a user pool.
        /// </para>
        /// </summary>
        public UserPoolPolicyType Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null;
        }

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// The contents of the SMS authentication message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=140)]
        public string SmsAuthenticationMessage
        {
            get { return this._smsAuthenticationMessage; }
            set { this._smsAuthenticationMessage = value; }
        }

        // Check to see if SmsAuthenticationMessage property is set
        internal bool IsSetSmsAuthenticationMessage()
        {
            return this._smsAuthenticationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SmsConfiguration. 
        /// <para>
        /// SMS configuration.
        /// </para>
        /// </summary>
        public SmsConfigurationType SmsConfiguration
        {
            get { return this._smsConfiguration; }
            set { this._smsConfiguration = value; }
        }

        // Check to see if SmsConfiguration property is set
        internal bool IsSetSmsConfiguration()
        {
            return this._smsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SmsVerificationMessage. 
        /// <para>
        /// A container with information about the SMS verification message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=140)]
        public string SmsVerificationMessage
        {
            get { return this._smsVerificationMessage; }
            set { this._smsVerificationMessage = value; }
        }

        // Check to see if SmsVerificationMessage property is set
        internal bool IsSetSmsVerificationMessage()
        {
            return this._smsVerificationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolAddOns. 
        /// <para>
        /// Used to enable advanced security risk detection. Set the key <code>AdvancedSecurityMode</code>
        /// to the value "AUDIT".
        /// </para>
        /// </summary>
        public UserPoolAddOnsType UserPoolAddOns
        {
            get { return this._userPoolAddOns; }
            set { this._userPoolAddOns = value; }
        }

        // Check to see if UserPoolAddOns property is set
        internal bool IsSetUserPoolAddOns()
        {
            return this._userPoolAddOns != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool you want to update.
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
        /// Gets and sets the property UserPoolTags. 
        /// <para>
        /// The tag keys and values to assign to the user pool. A tag is a label that you can
        /// use to categorize and manage user pools in different ways, such as by purpose, owner,
        /// environment, or other criteria.
        /// </para>
        /// </summary>
        public Dictionary<string, string> UserPoolTags
        {
            get { return this._userPoolTags; }
            set { this._userPoolTags = value; }
        }

        // Check to see if UserPoolTags property is set
        internal bool IsSetUserPoolTags()
        {
            return this._userPoolTags != null && this._userPoolTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerificationMessageTemplate. 
        /// <para>
        /// The template for verification messages.
        /// </para>
        /// </summary>
        public VerificationMessageTemplateType VerificationMessageTemplate
        {
            get { return this._verificationMessageTemplate; }
            set { this._verificationMessageTemplate = value; }
        }

        // Check to see if VerificationMessageTemplate property is set
        internal bool IsSetVerificationMessageTemplate()
        {
            return this._verificationMessageTemplate != null;
        }

    }
}