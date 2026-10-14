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
    /// The configuration of a user pool.
    /// </summary>
    public partial class UserPoolType
    {
        /// <summary>
        /// Gets and sets the property AccountRecoverySetting. 
        /// <para>
        /// The available verified method a user can use to recover their password when they call
        /// <c>ForgotPassword</c>. You can use this setting to define a preferred method when
        /// a user has more than one method available. With this setting, SMS doesn't qualify
        /// for a valid password recovery mechanism if the user also has SMS multi-factor authentication
        /// (MFA) activated. In the absence of this setting, Amazon Cognito uses the legacy behavior
        /// to determine the recovery method where SMS is preferred through email.
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
        /// The names of the authentication context class reference (ACR) levels for the user
        /// pool. Amazon Cognito always returns the effective configuration, with default names
        /// merged in for any level that you haven't customized.
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
        /// The configuration for <c>AdminCreateUser</c> requests.
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
        /// Attributes supported as an alias for this user pool. An alias is an attribute that
        /// users can enter as an alternative username. Possible values: <b>phone_number</b>,
        /// <b>email</b>, or <b>preferred_username</b>.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes that are auto-verified in a user pool.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDomain. 
        /// <para>
        /// A custom domain name that you provide to Amazon Cognito. This parameter applies only
        /// if you use a custom domain to host the sign-up and sign-in pages for your application.
        /// An example of a custom domain name might be <c>auth.example.com</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
        /// Your Own Domain for the Hosted UI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string CustomDomain { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomain property is set.
        /// </summary>
        internal bool IsSetCustomDomain() => this.CustomDomain != null;

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
        /// The device-remembering configuration for a user pool. A null value indicates that
        /// you have deactivated device remembering in your user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you provide a value for any <c>DeviceConfiguration</c> field, you activate the
        /// Amazon Cognito device-remembering feature.
        /// </para>
        ///  </note>
        /// </summary>
        public DeviceConfigurationType DeviceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeviceConfiguration property is set.
        /// </summary>
        internal bool IsSetDeviceConfiguration() => this.DeviceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain prefix, if the user pool has a domain associated with it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

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
        /// Gets and sets the property EmailConfigurationFailure. 
        /// <para>
        /// Deprecated. Review error codes from API requests with <c>EventSource:cognito-idp.amazonaws.com</c>
        /// in CloudTrail for information about problems with user pool email configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string EmailConfigurationFailure { get; set; }

        /// <summary>
        /// Checks to see if the EmailConfigurationFailure property is set.
        /// </summary>
        internal bool IsSetEmailConfigurationFailure() => this.EmailConfigurationFailure != null;

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
        /// Gets and sets the property EstimatedNumberOfUsers. 
        /// <para>
        /// A number estimating the size of the user pool.
        /// </para>
        /// </summary>
        public int? EstimatedNumberOfUsers { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedNumberOfUsers property is set.
        /// </summary>
        internal bool IsSetEstimatedNumberOfUsers() => this.EstimatedNumberOfUsers.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IssuerConfiguration. 
        /// <para>
        /// The issuer configuration for the user pool, including token issuing settings.
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
        /// The key configuration for the user pool, including encryption settings.
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
        /// possible stages of user pool operations. Triggers can modify the outcome of the operations
        /// that invoked them.
        /// </para>
        /// </summary>
        public LambdaConfigType LambdaConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaConfig property is set.
        /// </summary>
        internal bool IsSetLambdaConfig() => this.LambdaConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OFF</c> - MFA tokens aren't required and can't be specified during user registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ON</c> - MFA tokens are required for all user registrations. You can only specify
        /// required when you're initially creating a user pool.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIONAL</c> - Users have the option when registering to create an MFA token.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserPoolMfaType MfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MfaConfiguration property is set.
        /// </summary>
        internal bool IsSetMfaConfiguration() => this.MfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// A list of user pool policies. Contains the policy that sets password-complexity requirements.
        /// </para>
        /// </summary>
        public UserPoolPolicyType Policies { get; set; }

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null;

        /// <summary>
        /// Gets and sets the property SchemaAttributes. 
        /// <para>
        /// A list of the user attributes and their properties in your user pool. The attribute
        /// schema contains standard attributes, custom attributes with a <c>custom:</c> prefix,
        /// and developer attributes with a <c>dev:</c> prefix. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html">User
        /// pool attributes</a>.
        /// </para>
        ///  
        /// <para>
        /// Developer-only attributes are a legacy feature of user pools, and are read-only to
        /// all app clients. You can create and update developer-only attributes only with IAM-authenticated
        /// API operations. Use app client read/write permissions instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<SchemaAttributeType> SchemaAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaAttributeType>() : null;

        /// <summary>
        /// Checks to see if the SchemaAttributes property is set.
        /// </summary>
        internal bool IsSetSchemaAttributes() => this.SchemaAttributes != null && (this.SchemaAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// The contents of the SMS authentication message.
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
        /// User pool configuration for delivery of SMS messages with Amazon Simple Notification
        /// Service. To send SMS messages with Amazon SNS in the Amazon Web Services Region that
        /// you want, the Amazon Cognito user pool uses an Identity and Access Management (IAM)
        /// role in your Amazon Web Services account.
        /// </para>
        /// </summary>
        public SmsConfigurationType SmsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SmsConfiguration property is set.
        /// </summary>
        internal bool IsSetSmsConfiguration() => this.SmsConfiguration != null;

        /// <summary>
        /// Gets and sets the property SmsConfigurationFailure. 
        /// <para>
        /// The reason why the SMS configuration can't send the messages to your users.
        /// </para>
        ///  
        /// <para>
        /// This message might include comma-separated values to describe why your SMS configuration
        /// can't send messages to user pool end users.
        /// </para>
        ///  <dl> <dt>InvalidSmsRoleAccessPolicyException</dt> <dd> 
        /// <para>
        /// The Identity and Access Management role that Amazon Cognito uses to send SMS messages
        /// isn't properly configured. For more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SmsConfigurationType.html">SmsConfigurationType</a>.
        /// </para>
        ///  </dd> <dt>SNSSandbox</dt> <dd> 
        /// <para>
        /// The Amazon Web Services account is in the SNS SMS Sandbox and messages will only reach
        /// verified end users. This parameter won’t get populated with SNSSandbox if the user
        /// creating the user pool doesn’t have SNS permissions. To learn how to move your Amazon
        /// Web Services account out of the sandbox, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox-moving-to-production.html">Moving
        /// out of the SMS sandbox</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string SmsConfigurationFailure { get; set; }

        /// <summary>
        /// Checks to see if the SmsConfigurationFailure property is set.
        /// </summary>
        internal bool IsSetSmsConfigurationFailure() => this.SmsConfigurationFailure != null;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [Obsolete("This property is no longer available.")]
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// The tags that are assigned to the user pool. A tag is a label that you can apply to
        /// user pools to categorize and manage them in different ways, such as by purpose, owner,
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
        /// they sign up.
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
        /// Case sensitivity of the username input for the selected sign-in option. When case
        /// sensitivity is set to <c>False</c> (case insensitive), users can sign in with any
        /// combination of capital and lowercase letters. For example, <c>username</c>, <c>USERNAME</c>,
        /// or <c>UserName</c>, or for email, <c>email@example.com</c> or <c>EMaiL@eXamplE.Com</c>.
        /// For most use cases, set case sensitivity to <c>False</c> (case insensitive) as a best
        /// practice. When usernames and email addresses are case insensitive, Amazon Cognito
        /// treats any variation in case as the same user, and prevents a case variation from
        /// being assigned to the same attribute for a different user.
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
        /// </summary>
        public VerificationMessageTemplateType VerificationMessageTemplate { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMessageTemplate property is set.
        /// </summary>
        internal bool IsSetVerificationMessageTemplate() => this.VerificationMessageTemplate != null;
    }
}
