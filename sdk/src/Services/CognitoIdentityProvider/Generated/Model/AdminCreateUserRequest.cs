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
    /// Container for the parameters to the AdminCreateUser operation.
    /// Creates a new user in the specified user pool.
    /// 
    ///  
    /// <para>
    /// If <c>MessageAction</c> isn't set, the default is to send a welcome message via email
    /// or phone (SMS).
    /// </para>
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
    /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
    /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
    /// your app while in the sandbox environment, you can move out of the sandbox and into
    /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
    /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This message is based on a template that you configured in your call to create or
    /// update a user pool. This template includes your custom sign-up instructions and placeholders
    /// for user name and temporary password.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can call <c>AdminCreateUser</c> with <c>SUPPRESS</c> for the <c>MessageAction</c>
    /// parameter, and Amazon Cognito won't send any email. 
    /// </para>
    ///  
    /// <para>
    /// In either case, the user will be in the <c>FORCE_CHANGE_PASSWORD</c> state until they
    /// sign in and change their password.
    /// </para>
    ///  <note> 
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
    public partial class AdminCreateUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _desiredDeliveryMediums = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _forceAliasCreation;
        private MessageActionType _messageAction;
        private string _temporaryPassword;
        private List<AttributeType> _userAttributes = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;
        private string _username;
        private string _userPoolId;
        private List<AttributeType> _validationData = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the AdminCreateUser API action, Amazon Cognito invokes the function that is
        /// assigned to the <i>pre sign-up</i> trigger. When Amazon Cognito invokes this function,
        /// it passes a JSON payload, which the function receives as input. This payload contains
        /// a <c>clientMetadata</c> attribute, which provides the data that you assigned to the
        /// ClientMetadata parameter in your AdminCreateUser request. In your function code in
        /// Lambda, you can process the <c>clientMetadata</c> value to enhance your workflow for
        /// your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Customizing user pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito
        /// Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the ClientMetadata parameter, remember that Amazon Cognito won't do the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the ClientMetadata value. This data is available only to Lambda triggers that
        /// are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the ClientMetadata parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the ClientMetadata value. Don't use Amazon Cognito to provide sensitive information.
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
        /// Gets and sets the property DesiredDeliveryMediums. 
        /// <para>
        /// Specify <c>"EMAIL"</c> if email will be used to send the welcome message. Specify
        /// <c>"SMS"</c> if the phone number will be used. The default value is <c>"SMS"</c>.
        /// You can specify more than one value.
        /// </para>
        /// </summary>
        public List<string> DesiredDeliveryMediums
        {
            get { return this._desiredDeliveryMediums; }
            set { this._desiredDeliveryMediums = value; }
        }

        // Check to see if DesiredDeliveryMediums property is set
        internal bool IsSetDesiredDeliveryMediums()
        {
            return this._desiredDeliveryMediums != null && (this._desiredDeliveryMediums.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ForceAliasCreation. 
        /// <para>
        /// This parameter is used only if the <c>phone_number_verified</c> or <c>email_verified</c>
        /// attribute is set to <c>True</c>. Otherwise, it is ignored.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <c>True</c> and the phone number or email address specified
        /// in the UserAttributes parameter already exists as an alias with a different user,
        /// the API call will migrate the alias from the previous user to the newly created user.
        /// The previous user will no longer be able to log in using that alias.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <c>False</c>, the API throws an <c>AliasExistsException</c>
        /// error if the alias already exists. The default value is <c>False</c>.
        /// </para>
        /// </summary>
        public bool ForceAliasCreation
        {
            get { return this._forceAliasCreation.GetValueOrDefault(); }
            set { this._forceAliasCreation = value; }
        }

        // Check to see if ForceAliasCreation property is set
        internal bool IsSetForceAliasCreation()
        {
            return this._forceAliasCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageAction. 
        /// <para>
        /// Set to <c>RESEND</c> to resend the invitation message to a user that already exists
        /// and reset the expiration limit on the user's account. Set to <c>SUPPRESS</c> to suppress
        /// sending the message. You can specify only one value.
        /// </para>
        /// </summary>
        public MessageActionType MessageAction
        {
            get { return this._messageAction; }
            set { this._messageAction = value; }
        }

        // Check to see if MessageAction property is set
        internal bool IsSetMessageAction()
        {
            return this._messageAction != null;
        }

        /// <summary>
        /// Gets and sets the property TemporaryPassword. 
        /// <para>
        /// The user's temporary password. This password must conform to the password policy that
        /// you specified when you created the user pool.
        /// </para>
        ///  
        /// <para>
        /// The temporary password is valid only once. To complete the Admin Create User flow,
        /// the user must enter the temporary password in the sign-in page, along with a new password
        /// to be used in all future sign-ins.
        /// </para>
        ///  
        /// <para>
        /// This parameter isn't required. If you don't specify a value, Amazon Cognito generates
        /// one for you.
        /// </para>
        ///  
        /// <para>
        /// The temporary password can only be used until the user account expiration limit that
        /// you set for your user pool. To reset the account after that time limit, you must call
        /// <c>AdminCreateUser</c> again and specify <c>RESEND</c> for the <c>MessageAction</c>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string TemporaryPassword
        {
            get { return this._temporaryPassword; }
            set { this._temporaryPassword = value; }
        }

        // Check to see if TemporaryPassword property is set
        internal bool IsSetTemporaryPassword()
        {
            return this._temporaryPassword != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// An array of name-value pairs that contain user attributes and attribute values to
        /// be set for the user to be created. You can create a user without specifying any attributes
        /// other than <c>Username</c>. However, any attributes that you specify as required (when
        /// creating a user pool or in the <b>Attributes</b> tab of the console) either you should
        /// supply (in your call to <c>AdminCreateUser</c>) or the user should supply (when they
        /// sign up in response to your welcome message).
        /// </para>
        ///  
        /// <para>
        /// For custom attributes, you must prepend the <c>custom:</c> prefix to the attribute
        /// name.
        /// </para>
        ///  
        /// <para>
        /// To send a message inviting the user to sign up, you must specify the user's email
        /// address or phone number. You can do this in your call to AdminCreateUser or in the
        /// <b>Users</b> tab of the Amazon Cognito console for managing your user pools.
        /// </para>
        ///  
        /// <para>
        /// In your call to <c>AdminCreateUser</c>, you can set the <c>email_verified</c> attribute
        /// to <c>True</c>, and you can set the <c>phone_number_verified</c> attribute to <c>True</c>.
        /// You can also do this by calling <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminUpdateUserAttributes.html">AdminUpdateUserAttributes</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>email</b>: The email address of the user to whom the message that contains the
        /// code and username will be sent. Required if the <c>email_verified</c> attribute is
        /// set to <c>True</c>, or if <c>"EMAIL"</c> is specified in the <c>DesiredDeliveryMediums</c>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>phone_number</b>: The phone number of the user to whom the message that contains
        /// the code and username will be sent. Required if the <c>phone_number_verified</c> attribute
        /// is set to <c>True</c>, or if <c>"SMS"</c> is specified in the <c>DesiredDeliveryMediums</c>
        /// parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<AttributeType> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && (this._userAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The value that you want to set as the username sign-in attribute. The following conditions
        /// apply to the username parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The username can't be a duplicate of another username in the same user pool.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't change the value of a username after you create it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only provide a value if usernames are a valid sign-in attribute for your user
        /// pool. If your user pool only supports phone numbers or email addresses as sign-in
        /// attributes, Amazon Cognito automatically generates a username value. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where the user will be created.
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
        /// Gets and sets the property ValidationData. 
        /// <para>
        /// Temporary user attributes that contribute to the outcomes of your pre sign-up Lambda
        /// trigger. This set of key-value pairs are for custom validation of information that
        /// you collect from your users but don't need to retain.
        /// </para>
        ///  
        /// <para>
        /// Your Lambda function can analyze this additional data and act on it. Your function
        /// might perform external API operations like logging user attributes and validation
        /// data to Amazon CloudWatch Logs. Validation data might also affect the response that
        /// your function returns to Amazon Cognito, like automatically confirming the user if
        /// they sign up from within your network.
        /// </para>
        ///  
        /// <para>
        /// For more information about the pre sign-up Lambda trigger, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-sign-up.html">Pre
        /// sign-up Lambda trigger</a>.
        /// </para>
        /// </summary>
        public List<AttributeType> ValidationData
        {
            get { return this._validationData; }
            set { this._validationData = value; }
        }

        // Check to see if ValidationData property is set
        internal bool IsSetValidationData()
        {
            return this._validationData != null && (this._validationData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}