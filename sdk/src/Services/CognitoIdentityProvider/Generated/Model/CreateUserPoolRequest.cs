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
    /// Container for the parameters to the CreateUserPool operation.
    /// Creates a new Amazon Cognito user pool. This operation sets basic and advanced configuration
    /// options.
    /// 
    ///  <important> 
    /// <para>
    /// If you don't provide a value for an attribute, Amazon Cognito sets it to its default
    /// value.
    /// </para>
    ///  </important> <note> 
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
    public partial class CreateUserPoolRequest : AmazonCognitoIdentityProviderRequest
    {
        private AccountRecoverySettingType _accountRecoverySetting;
        private AdminCreateUserConfigType _adminCreateUserConfig;
        private List<string> _aliasAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _autoVerifiedAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DeletionProtectionType _deletionProtection;
        private DeviceConfigurationType _deviceConfiguration;
        private EmailConfigurationType _emailConfiguration;
        private string _emailVerificationMessage;
        private string _emailVerificationSubject;
        private LambdaConfigType _lambdaConfig;
        private UserPoolMfaType _mfaConfiguration;
        private UserPoolPolicyType _policies;
        private string _poolName;
        private List<SchemaAttributeType> _schema = AWSConfigs.InitializeCollections ? new List<SchemaAttributeType>() : null;
        private string _smsAuthenticationMessage;
        private SmsConfigurationType _smsConfiguration;
        private string _smsVerificationMessage;
        private UserAttributeUpdateSettingsType _userAttributeUpdateSettings;
        private List<string> _usernameAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UsernameConfigurationType _usernameConfiguration;
        private UserPoolAddOnsType _userPoolAddOns;
        private Dictionary<string, string> _userPoolTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private UserPoolTierType _userPoolTier;
        private VerificationMessageTemplateType _verificationMessageTemplate;

        /// <summary>
        /// Gets and sets the property AccountRecoverySetting. 
        /// <para>
        /// The available verified method a user can use to recover their password when they call
        /// <c>ForgotPassword</c>. You can use this setting to define a preferred method when
        /// a user has more than one method available. With this setting, SMS doesn't qualify
        /// for a valid password recovery mechanism if the user also has SMS multi-factor authentication
        /// (MFA) activated. Email MFA is also disqualifying for account recovery with email.
        /// In the absence of this setting, Amazon Cognito uses the legacy behavior to determine
        /// the recovery method where SMS is preferred over email.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, configure both <c>verified_email</c> and <c>verified_phone_number</c>,
        /// with one having a higher priority than the other.
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
        /// The configuration for administrative creation of users. Includes the template for
        /// the invitation message for new users, the duration of temporary passwords, and permitting
        /// self-service sign-up.
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
        /// Gets and sets the property AliasAttributes. 
        /// <para>
        /// Attributes supported as an alias for this user pool. For more information about alias
        /// attributes, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AliasAttributes
        {
            get { return this._aliasAttributes; }
            set { this._aliasAttributes = value; }
        }

        // Check to see if AliasAttributes property is set
        internal bool IsSetAliasAttributes()
        {
            return this._aliasAttributes != null && (this._aliasAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes that you want your user pool to automatically verify. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#allowing-users-to-sign-up-and-confirm-themselves">Verifying
        /// contact information at sign-up</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoVerifiedAttributes
        {
            get { return this._autoVerifiedAttributes; }
            set { this._autoVerifiedAttributes = value; }
        }

        // Check to see if AutoVerifiedAttributes property is set
        internal bool IsSetAutoVerifiedAttributes()
        {
            return this._autoVerifiedAttributes != null && (this._autoVerifiedAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// When active, <c>DeletionProtection</c> prevents accidental deletion of your user pool.
        /// Before you can delete a user pool that you have protected against deletion, you must
        /// deactivate this feature.
        /// </para>
        ///  
        /// <para>
        /// When you try to delete a protected user pool in a <c>DeleteUserPool</c> API request,
        /// Amazon Cognito returns an <c>InvalidParameterException</c> error. To delete a protected
        /// user pool, send a new <c>DeleteUserPool</c> request after you deactivate deletion
        /// protection in an <c>UpdateUserPool</c> API request.
        /// </para>
        /// </summary>
        public DeletionProtectionType DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// The device-remembering configuration for a user pool. Device remembering or device
        /// tracking is a "Remember me on this device" option for user pools that perform authentication
        /// with the device key of a trusted device in the back end, instead of a user-provided
        /// MFA code. For more information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>. A null value indicates that you have deactivated
        /// device remembering in your user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you provide a value for any <c>DeviceConfiguration</c> field, you activate the
        /// Amazon Cognito device-remembering feature. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// </para>
        ///  </note>
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
        /// The email configuration of your user pool. The email configuration type sets your
        /// preferred sending method, Amazon Web Services Region, and sender for messages from
        /// your user pool.
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
        /// This parameter is no longer used.
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
        /// This parameter is no longer used.
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
        /// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers at several
        /// possible stages of authentication operations. Triggers can modify the outcome of the
        /// operations that invoked them.
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// The password policy and sign-in policy in the user pool. The password policy sets
        /// options like password complexity requirements and password history. The sign-in policy
        /// sets the options available to applications in <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flows-selection-sdk.html#authentication-flows-selection-choice">choice-based
        /// authentication</a>.
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
        /// Gets and sets the property PoolName. 
        /// <para>
        /// A friendly name for your user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// An array of attributes for the new user pool. You can add custom attributes and modify
        /// the properties of default attributes. The specifications in this parameter set the
        /// required attributes in your user pool. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html">Working
        /// with user attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<SchemaAttributeType> Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null && (this._schema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// The contents of the SMS message that your user pool sends to users in SMS OTP and
        /// MFA authentication.
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
        /// The settings for your Amazon Cognito user pool to send SMS messages with Amazon Simple
        /// Notification Service. To send SMS messages with Amazon SNS in the Amazon Web Services
        /// Region that you want, the Amazon Cognito user pool uses an Identity and Access Management
        /// (IAM) role in your Amazon Web Services account. For more information see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">SMS
        /// message settings</a>.
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
        /// This parameter is no longer used.
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
        /// Gets and sets the property UserAttributeUpdateSettings. 
        /// <para>
        /// The settings for updates to user attributes. These settings include the property <c>AttributesRequireVerificationBeforeUpdate</c>,
        /// a user-pool setting that tells Amazon Cognito how to handle changes to the value of
        /// your users' email address and phone number attributes. For more information, see <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-email-phone-verification.html#user-pool-settings-verifications-verify-attribute-updates">
        /// Verifying updates to email addresses and phone numbers</a>.
        /// </para>
        /// </summary>
        public UserAttributeUpdateSettingsType UserAttributeUpdateSettings
        {
            get { return this._userAttributeUpdateSettings; }
            set { this._userAttributeUpdateSettings = value; }
        }

        // Check to see if UserAttributeUpdateSettings property is set
        internal bool IsSetUserAttributeUpdateSettings()
        {
            return this._userAttributeUpdateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameAttributes. 
        /// <para>
        /// Specifies whether a user can use an email address or phone number as a username when
        /// they sign up. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UsernameAttributes
        {
            get { return this._usernameAttributes; }
            set { this._usernameAttributes = value; }
        }

        // Check to see if UsernameAttributes property is set
        internal bool IsSetUsernameAttributes()
        {
            return this._usernameAttributes != null && (this._usernameAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsernameConfiguration. 
        /// <para>
        /// Sets the case sensitivity option for sign-in usernames. When <c>CaseSensitive</c>
        /// is <c>false</c> (case insensitive), users can sign in with any combination of capital
        /// and lowercase letters. For example, <c>username</c>, <c>USERNAME</c>, or <c>UserName</c>,
        /// or for email, <c>email@example.com</c> or <c>EMaiL@eXamplE.Com</c>. For most use cases,
        /// set case sensitivity to <c>false</c> as a best practice. When usernames and email
        /// addresses are case insensitive, Amazon Cognito treats any variation in case as the
        /// same user, and prevents a case variation from being assigned to the same attribute
        /// for a different user.
        /// </para>
        ///  
        /// <para>
        /// When <c>CaseSensitive</c> is <c>true</c> (case sensitive), Amazon Cognito interprets
        /// <c>USERNAME</c> and <c>UserName</c> as distinct users.
        /// </para>
        ///  
        /// <para>
        /// This configuration is immutable after you set it.
        /// </para>
        /// </summary>
        public UsernameConfigurationType UsernameConfiguration
        {
            get { return this._usernameConfiguration; }
            set { this._usernameConfiguration = value; }
        }

        // Check to see if UsernameConfiguration property is set
        internal bool IsSetUsernameConfiguration()
        {
            return this._usernameConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolAddOns. 
        /// <para>
        /// Contains settings for activation of threat protection, including the operating mode
        /// and additional authentication types. To log user security information but take no
        /// action, set to <c>AUDIT</c>. To configure automatic security responses to potentially
        /// unwanted traffic to your user pool, set to <c>ENFORCED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">Adding
        /// advanced security to a user pool</a>. To activate this setting, your user pool must
        /// be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
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
        /// Gets and sets the property UserPoolTags. 
        /// <para>
        /// The tag keys and values to assign to the user pool. A tag is a label that you can
        /// use to categorize and manage user pools in different ways, such as by purpose, owner,
        /// environment, or other criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserPoolTags
        {
            get { return this._userPoolTags; }
            set { this._userPoolTags = value; }
        }

        // Check to see if UserPoolTags property is set
        internal bool IsSetUserPoolTags()
        {
            return this._userPoolTags != null && (this._userPoolTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserPoolTier. 
        /// <para>
        /// The user pool <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-sign-in-feature-plans.html">feature
        /// plan</a>, or tier. This parameter determines the eligibility of the user pool for
        /// features like managed login, access-token customization, and threat protection. Defaults
        /// to <c>ESSENTIALS</c>.
        /// </para>
        /// </summary>
        public UserPoolTierType UserPoolTier
        {
            get { return this._userPoolTier; }
            set { this._userPoolTier = value; }
        }

        // Check to see if UserPoolTier property is set
        internal bool IsSetUserPoolTier()
        {
            return this._userPoolTier != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationMessageTemplate. 
        /// <para>
        /// The template for the verification message that your user pool delivers to users who
        /// set an email address or phone number attribute.
        /// </para>
        ///  
        /// <para>
        /// Set the email message type that corresponds to your <c>DefaultEmailOption</c> selection.
        /// For <c>CONFIRM_WITH_LINK</c>, specify an <c>EmailMessageByLink</c> and leave <c>EmailMessage</c>
        /// blank. For <c>CONFIRM_WITH_CODE</c>, specify an <c>EmailMessage</c> and leave <c>EmailMessageByLink</c>
        /// blank. When you supply both parameters with either choice, Amazon Cognito returns
        /// an error.
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