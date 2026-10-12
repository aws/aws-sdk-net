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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateUserPool operation. Creates a new Amazon
    /// Cognito user pool. This operation sets basic and advanced configuration options. <important>
    /// <para> If you don't provide a value for an attribute, Amazon Cognito sets it to its
    /// default value. </para> </important> <note> <para> This action might generate an SMS
    /// text message. Starting June 1, 2021, US telecom carriers require you to register an
    /// origination phone number before you can send SMS messages to US phone numbers. If
    /// you use SMS text messages in Amazon Cognito, you must register a phone number with
    /// <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon Pinpoint</a>. Amazon
    /// Cognito uses the registered number automatically. Otherwise, Amazon Cognito users
    /// who must receive SMS messages might not be able to sign up, activate their accounts,
    /// or sign in. </para> <para> If you have never used SMS text messages with Amazon Cognito
    /// or any other Amazon Web Services service, Amazon Simple Notification Service might
    /// place your account in the SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
    /// your app while in the sandbox environment, you can move out of the sandbox and into
    /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
    /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>. </para> </note> <note> <para> Amazon Cognito evaluates Identity and Access
    /// Management (IAM) policies in requests for this API operation. For this operation,
    /// you must use IAM credentials to authorize requests, and you must grant yourself the
    /// corresponding IAM permission in a policy. </para> <para> <b>Learn more</b> </para>
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class CreateUserPoolRequest : AmazonCognitoIdentityProviderRequest
    {
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
        public AccountRecoverySettingType AccountRecoverySetting { get; set; }

        /// <summary>
        /// Checks to see if the AccountRecoverySetting property is set.
        /// </summary>
        internal bool IsSetAccountRecoverySetting() => this.AccountRecoverySetting != null;

        /// <summary>
        /// Gets and sets the property AcrConfiguration. 
        /// <para>
        /// The custom names for the authentication context class reference (ACR) levels in your
        /// user pool. Amazon Cognito defines four fixed ACR levels that represent increasing
        /// authentication assurance. The combination of authentication factors that satisfies
        /// each level is fixed and you can't change it. With this configuration, you customize
        /// only the URI name that Amazon Cognito reports for each level in the <c>acr</c> token
        /// claim.
        /// </para>
        ///  
        /// <para>
        /// You can override a subset of the levels. By default, the levels are named <c>urn:cognito:loa:1</c>
        /// through <c>urn:cognito:loa:4</c>, and Amazon Cognito applies the default name to any
        /// level that you don't specify. Each name must be unique across all four levels, including
        /// any default names that apply to levels you don't override. A name can contain any
        /// character that is valid in a URL or a URN.
        /// </para>
        ///  
        /// <para>
        /// Configuring custom ACR level names requires the Essentials or Plus feature plan. To
        /// activate this setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public Dictionary<string, AcrLevelConfigType> AcrConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AcrLevelConfigType>() : null;

        /// <summary>
        /// Checks to see if the AcrConfiguration property is set.
        /// </summary>
        internal bool IsSetAcrConfiguration() => this.AcrConfiguration != null && (this.AcrConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdminCreateUserConfig. 
        /// <para>
        /// The configuration for administrative creation of users. Includes the template for
        /// the invitation message for new users, the duration of temporary passwords, and permitting
        /// self-service sign-up.
        /// </para>
        /// </summary>
        public AdminCreateUserConfigType AdminCreateUserConfig { get; set; }

        /// <summary>
        /// Checks to see if the AdminCreateUserConfig property is set.
        /// </summary>
        internal bool IsSetAdminCreateUserConfig() => this.AdminCreateUserConfig != null;

        /// <summary>
        /// Gets and sets the property AliasAttributes. 
        /// <para>
        /// Attributes supported as an alias for this user pool. For more information about alias
        /// attributes, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AliasAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AliasAttributes property is set.
        /// </summary>
        internal bool IsSetAliasAttributes() => this.AliasAttributes != null && (this.AliasAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes that you want your user pool to automatically verify. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#allowing-users-to-sign-up-and-confirm-themselves">Verifying
        /// contact information at sign-up</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoVerifiedAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoVerifiedAttributes property is set.
        /// </summary>
        internal bool IsSetAutoVerifiedAttributes() => this.AutoVerifiedAttributes != null && (this.AutoVerifiedAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public DeletionProtectionType DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection != null;

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
        public DeviceConfigurationType DeviceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeviceConfiguration property is set.
        /// </summary>
        internal bool IsSetDeviceConfiguration() => this.DeviceConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmailConfiguration. 
        /// <para>
        /// The email configuration of your user pool. The email configuration type sets your
        /// preferred sending method, Amazon Web Services Region, and sender for messages from
        /// your user pool.
        /// </para>
        /// </summary>
        public EmailConfigurationType EmailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmailConfiguration property is set.
        /// </summary>
        internal bool IsSetEmailConfiguration() => this.EmailConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmailVerificationMessage. 
        /// <para>
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 20000)]
        public string EmailVerificationMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailVerificationMessage property is set.
        /// </summary>
        internal bool IsSetEmailVerificationMessage() => this.EmailVerificationMessage != null;

        /// <summary>
        /// Gets and sets the property EmailVerificationSubject. 
        /// <para>
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string EmailVerificationSubject { get; set; }

        /// <summary>
        /// Checks to see if the EmailVerificationSubject property is set.
        /// </summary>
        internal bool IsSetEmailVerificationSubject() => this.EmailVerificationSubject != null;

        /// <summary>
        /// Gets and sets the property IssuerConfiguration. 
        /// <para>
        /// The issuer configuration for the user pool. Specifies the issuer type for token generation.
        /// </para>
        /// </summary>
        public IssuerConfigurationType IssuerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IssuerConfiguration property is set.
        /// </summary>
        internal bool IsSetIssuerConfiguration() => this.IssuerConfiguration != null;

        /// <summary>
        /// Gets and sets the property KeyConfiguration. 
        /// <para>
        /// The key configuration for the user pool. Specifies the key type and KMS key ARN for
        /// encryption.
        /// </para>
        /// </summary>
        public KeyConfigurationType KeyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KeyConfiguration property is set.
        /// </summary>
        internal bool IsSetKeyConfiguration() => this.KeyConfiguration != null;

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers at several
        /// possible stages of authentication operations. Triggers can modify the outcome of the
        /// operations that invoked them.
        /// </para>
        /// </summary>
        public LambdaConfigType LambdaConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaConfig property is set.
        /// </summary>
        internal bool IsSetLambdaConfig() => this.LambdaConfig != null;

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
        ///  
        /// <para>
        /// The <c>CreateUserPool</c> operation supports only SMS MFA configuration. If you set
        /// <c>MfaConfiguration</c> to either of these values, include an <c>SmsConfiguration</c>
        /// in the same request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ON</c> – Requires MFA for all users
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIONAL</c> – Makes MFA optional for each user
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you omit <c>SmsConfiguration</c>, the operation returns an <c>InvalidParameterException</c>.
        /// To configure TOTP or email MFA, use the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserPoolMfaConfig.html">SetUserPoolMfaConfig</a>
        /// operation. You can also use <c>SetUserPoolMfaConfig</c> to add MFA factors later.
        /// </para>
        /// </summary>
        public UserPoolMfaType MfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MfaConfiguration property is set.
        /// </summary>
        internal bool IsSetMfaConfiguration() => this.MfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// The password policy and sign-in policy in the user pool. The password policy sets
        /// options like password complexity requirements and password history. The sign-in policy
        /// sets the options available to applications in <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flows-selection-sdk.html#authentication-flows-selection-choice">choice-based
        /// authentication</a>.
        /// </para>
        /// </summary>
        public UserPoolPolicyType Policies { get; set; }

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// A friendly name for your user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// An array of attributes for the new user pool. You can add custom attributes and modify
        /// the properties of default attributes. The specifications in this parameter set the
        /// required attributes in your user pool. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html">Working
        /// with user attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<SchemaAttributeType> Schema { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaAttributeType>() : null;

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null && (this.Schema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// The contents of the SMS message that your user pool sends to users in SMS OTP and
        /// MFA authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 140)]
        public string SmsAuthenticationMessage { get; set; }

        /// <summary>
        /// Checks to see if the SmsAuthenticationMessage property is set.
        /// </summary>
        internal bool IsSetSmsAuthenticationMessage() => this.SmsAuthenticationMessage != null;

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
        public SmsConfigurationType SmsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SmsConfiguration property is set.
        /// </summary>
        internal bool IsSetSmsConfiguration() => this.SmsConfiguration != null;

        /// <summary>
        /// Gets and sets the property SmsVerificationMessage. 
        /// <para>
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 140)]
        public string SmsVerificationMessage { get; set; }

        /// <summary>
        /// Checks to see if the SmsVerificationMessage property is set.
        /// </summary>
        internal bool IsSetSmsVerificationMessage() => this.SmsVerificationMessage != null;

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
        public UserAttributeUpdateSettingsType UserAttributeUpdateSettings { get; set; }

        /// <summary>
        /// Checks to see if the UserAttributeUpdateSettings property is set.
        /// </summary>
        internal bool IsSetUserAttributeUpdateSettings() => this.UserAttributeUpdateSettings != null;

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
        public UserPoolAddOnsType UserPoolAddOns { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolAddOns property is set.
        /// </summary>
        internal bool IsSetUserPoolAddOns() => this.UserPoolAddOns != null;

        /// <summary>
        /// Gets and sets the property UserPoolTags. 
        /// <para>
        /// The tag keys and values to assign to the user pool. A tag is a label that you can
        /// use to categorize and manage user pools in different ways, such as by purpose, owner,
        /// environment, or other criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserPoolTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UserPoolTags property is set.
        /// </summary>
        internal bool IsSetUserPoolTags() => this.UserPoolTags != null && (this.UserPoolTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserPoolTier. 
        /// <para>
        /// The user pool <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-sign-in-feature-plans.html">feature
        /// plan</a>, or tier. This parameter determines the eligibility of the user pool for
        /// features like managed login, access-token customization, and threat protection. Defaults
        /// to <c>ESSENTIALS</c>.
        /// </para>
        /// </summary>
        public UserPoolTierType UserPoolTier { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolTier property is set.
        /// </summary>
        internal bool IsSetUserPoolTier() => this.UserPoolTier != null;

        /// <summary>
        /// Gets and sets the property UsernameAttributes. 
        /// <para>
        /// Specifies whether a user can use an email address or phone number as a username when
        /// they sign up. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UsernameAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UsernameAttributes property is set.
        /// </summary>
        internal bool IsSetUsernameAttributes() => this.UsernameAttributes != null && (this.UsernameAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public UsernameConfigurationType UsernameConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UsernameConfiguration property is set.
        /// </summary>
        internal bool IsSetUsernameConfiguration() => this.UsernameConfiguration != null;

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
        public VerificationMessageTemplateType VerificationMessageTemplate { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMessageTemplate property is set.
        /// </summary>
        internal bool IsSetVerificationMessageTemplate() => this.VerificationMessageTemplate != null;
    }
}
