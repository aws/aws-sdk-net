/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A container for information about the user pool.
    /// </summary>
    public partial class UserPoolType
    {
        private AdminCreateUserConfigType _adminCreateUserConfig;
        private List<string> _aliasAttributes = new List<string>();
        private string _arn;
        private List<string> _autoVerifiedAttributes = new List<string>();
        private DateTime? _creationDate;
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
        private List<string> _usernameAttributes = new List<string>();
        private UserPoolAddOnsType _userPoolAddOns;
        private Dictionary<string, string> _userPoolTags = new Dictionary<string, string>();
        private VerificationMessageTemplateType _verificationMessageTemplate;

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
        /// Specifies the attributes that are aliased in a user pool.
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
        /// Specifies the attributes that are auto-verified in a user pool.
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
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// The device configuration.
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// Holds the domain prefix if the user pool has a domain associated with it.
        /// </para>
        /// </summary>
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
        /// The email configuration.
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
        /// The reason why the email configuration cannot send the messages to your users.
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
        /// The contents of the email verification message.
        /// </para>
        /// </summary>
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
        /// The AWS Lambda triggers associated with the user pool.
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
        ///  <code>OFF</code> - MFA tokens are not required and cannot be specified during user
        /// registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ON</code> - MFA tokens are required for all user registrations. You can only
        /// specify required when you are initially creating a user pool.
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
        /// The SMS configuration.
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
        /// The reason why the SMS configuration cannot send the messages to your users.
        /// </para>
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
        /// The contents of the SMS verification message.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UsernameAttributes. 
        /// <para>
        /// Specifies whether email addresses or phone numbers can be specified as usernames when
        /// a user signs up.
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
        /// The cost allocation tags for the user pool. For more information, see <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-cost-allocation-tagging.html">Adding
        /// Cost Allocation Tags to Your User Pool</a> 
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