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
    /// A container for information about the user pool.
    /// </summary>
    public partial class UserPoolType
    {
        private AccountRecoverySettingType _accountRecoverySetting;
        private AdminCreateUserConfigType _adminCreateUserConfig;
        private List<string> _aliasAttributes = new List<string>();
        private string _arn;
        private List<string> _autoVerifiedAttributes = new List<string>();
        private DateTime? _creationDate;
        private string _customDomain;
        private DeletionProtectionType _deletionProtection;
        private DeviceConfigurationType _deviceConfiguration;
        private string _domain;
        private EmailConfigurationType _emailConfiguration;
        private string _emailConfigurationFailure;
        private string _emailVerificationMessage;
        private string _emailVerificationSubject;
        private int? _estimatedNumberOfUsers;
        private string _id;
        private LambdaConfigType _lambdaConfig;
        private DateTime? _lastModifiedDate;
        private UserPoolMfaType _mfaConfiguration;
        private string _name;
        private UserPoolPolicyType _policies;
        private List<SchemaAttributeType> _schemaAttributes = new List<SchemaAttributeType>();
        private string _smsAuthenticationMessage;
        private SmsConfigurationType _smsConfiguration;
        private string _smsConfigurationFailure;
        private string _smsVerificationMessage;
        private StatusType _status;
        private UserAttributeUpdateSettingsType _userAttributeUpdateSettings;
        private List<string> _usernameAttributes = new List<string>();
        private UsernameConfigurationType _usernameConfiguration;
        private UserPoolAddOnsType _userPoolAddOns;
        private Dictionary<string, string> _userPoolTags = new Dictionary<string, string>();
        private VerificationMessageTemplateType _verificationMessageTemplate;

        /// <summary>
        /// Gets and sets the property AccountRecoverySetting. 
        /// <para>
        /// The available verified method a user can use to recover their password when they call
        /// <code>ForgotPassword</code>. You can use this setting to define a preferred method
        /// when a user has more than one method available. With this setting, SMS doesn't qualify
        /// for a valid password recovery mechanism if the user also has SMS multi-factor authentication
        /// (MFA) activated. In the absence of this setting, Amazon Cognito uses the legacy behavior
        /// to determine the recovery method where SMS is preferred through email.
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
        /// Gets and sets the property AliasAttributes. 
        /// <para>
        /// The attributes that are aliased in a user pool.
        /// </para>
        /// </summary>
        public List<string> AliasAttributes
        {
            get { return this._aliasAttributes; }
            set { this._aliasAttributes = value; }
        }

        // Check to see if AliasAttributes property is set
        internal bool IsSetAliasAttributes()
        {
            return this._aliasAttributes != null && this._aliasAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes that are auto-verified in a user pool.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the user pool was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomain. 
        /// <para>
        /// A custom domain name that you provide to Amazon Cognito. This parameter applies only
        /// if you use a custom domain to host the sign-up and sign-in pages for your application.
        /// An example of a custom domain name might be <code>auth.example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
        /// Your Own Domain for the Hosted UI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CustomDomain
        {
            get { return this._customDomain; }
            set { this._customDomain = value; }
        }

        // Check to see if CustomDomain property is set
        internal bool IsSetCustomDomain()
        {
            return this._customDomain != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// When active, <code>DeletionProtection</code> prevents accidental deletion of your
        /// user pool. Before you can delete a user pool that you have protected against deletion,
        /// you must deactivate this feature.
        /// </para>
        ///  
        /// <para>
        /// When you try to delete a protected user pool in a <code>DeleteUserPool</code> API
        /// request, Amazon Cognito returns an <code>InvalidParameterException</code> error. To
        /// delete a protected user pool, send a new <code>DeleteUserPool</code> request after
        /// you deactivate deletion protection in an <code>UpdateUserPool</code> API request.
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
        /// The device-remembering configuration for a user pool. A null value indicates that
        /// you have deactivated device remembering in your user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you provide a value for any <code>DeviceConfiguration</code> field, you activate
        /// the Amazon Cognito device-remembering feature.
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain prefix, if the user pool has a domain associated with it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EmailConfiguration. 
        /// <para>
        /// The email configuration of your user pool. The email configuration type sets your
        /// preferred sending method, Amazon Web Services Region, and sender for messages tfrom
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
        /// Gets and sets the property EmailConfigurationFailure. 
        /// <para>
        /// Deprecated. Review error codes from API requests with <code>EventSource:cognito-idp.amazonaws.com</code>
        /// in CloudTrail for information about problems with user pool email configuration.
        /// </para>
        /// </summary>
        public string EmailConfigurationFailure
        {
            get { return this._emailConfigurationFailure; }
            set { this._emailConfigurationFailure = value; }
        }

        // Check to see if EmailConfigurationFailure property is set
        internal bool IsSetEmailConfigurationFailure()
        {
            return this._emailConfigurationFailure != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationMessage. 
        /// <para>
        /// This parameter is no longer used. See <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html">VerificationMessageTemplateType</a>.
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
        /// This parameter is no longer used. See <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html">VerificationMessageTemplateType</a>.
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
        /// Gets and sets the property EstimatedNumberOfUsers. 
        /// <para>
        /// A number estimating the size of the user pool.
        /// </para>
        /// </summary>
        public int EstimatedNumberOfUsers
        {
            get { return this._estimatedNumberOfUsers.GetValueOrDefault(); }
            set { this._estimatedNumberOfUsers = value; }
        }

        // Check to see if EstimatedNumberOfUsers property is set
        internal bool IsSetEstimatedNumberOfUsers()
        {
            return this._estimatedNumberOfUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// The Lambda triggers associated with the user pool.
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the user pool was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>OFF</code> - MFA tokens aren't required and can't be specified during user
        /// registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ON</code> - MFA tokens are required for all user registrations. You can only
        /// specify required when you're initially creating a user pool.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// The policies associated with the user pool.
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
        /// Gets and sets the property SchemaAttributes. 
        /// <para>
        /// A container with the schema attributes of a user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<SchemaAttributeType> SchemaAttributes
        {
            get { return this._schemaAttributes; }
            set { this._schemaAttributes = value; }
        }

        // Check to see if SchemaAttributes property is set
        internal bool IsSetSchemaAttributes()
        {
            return this._schemaAttributes != null && this._schemaAttributes.Count > 0; 
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
        /// The SMS configuration with the settings that your Amazon Cognito user pool must use
        /// to send an SMS message from your Amazon Web Services account through Amazon Simple
        /// Notification Service. To send SMS messages with Amazon SNS in the Amazon Web Services
        /// Region that you want, the Amazon Cognito user pool uses an Identity and Access Management
        /// (IAM) role in your Amazon Web Services account.
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
        /// verified end users. This parameter won’t get populated with SNSSandbox if the IAM
        /// user creating the user pool doesn’t have SNS permissions. To learn how to move your
        /// Amazon Web Services account out of the sandbox, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox-moving-to-production.html">Moving
        /// out of the SMS sandbox</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string SmsConfigurationFailure
        {
            get { return this._smsConfigurationFailure; }
            set { this._smsConfigurationFailure = value; }
        }

        // Check to see if SmsConfigurationFailure property is set
        internal bool IsSetSmsConfigurationFailure()
        {
            return this._smsConfigurationFailure != null;
        }

        /// <summary>
        /// Gets and sets the property SmsVerificationMessage. 
        /// <para>
        /// This parameter is no longer used. See <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html">VerificationMessageTemplateType</a>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a user pool.
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributeUpdateSettings. 
        /// <para>
        /// The settings for updates to user attributes. These settings include the property <code>AttributesRequireVerificationBeforeUpdate</code>,
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
        /// they sign up.
        /// </para>
        /// </summary>
        public List<string> UsernameAttributes
        {
            get { return this._usernameAttributes; }
            set { this._usernameAttributes = value; }
        }

        // Check to see if UsernameAttributes property is set
        internal bool IsSetUsernameAttributes()
        {
            return this._usernameAttributes != null && this._usernameAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsernameConfiguration. 
        /// <para>
        /// Case sensitivity of the username input for the selected sign-in option. For example,
        /// when case sensitivity is set to <code>False</code>, users can sign in using either
        /// "username" or "Username". This configuration is immutable once it has been set. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UsernameConfigurationType.html">UsernameConfigurationType</a>.
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
        /// The user pool add-ons.
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
        /// The tags that are assigned to the user pool. A tag is a label that you can apply to
        /// user pools to categorize and manage them in different ways, such as by purpose, owner,
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