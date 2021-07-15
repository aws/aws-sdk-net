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
    /// If <code>MessageAction</code> is not set, the default is to send a welcome message
    /// via email or phone (SMS).
    /// </para>
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
    /// <para>
    /// This message is based on a template that you configured in your call to create or
    /// update a user pool. This template includes your custom sign-up instructions and placeholders
    /// for user name and temporary password.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can call <code>AdminCreateUser</code> with “SUPPRESS” for the <code>MessageAction</code>
    /// parameter, and Amazon Cognito will not send any email. 
    /// </para>
    ///  
    /// <para>
    /// In either case, the user will be in the <code>FORCE_CHANGE_PASSWORD</code> state until
    /// they sign in and change their password.
    /// </para>
    ///  
    /// <para>
    ///  <code>AdminCreateUser</code> requires developer credentials.
    /// </para>
    /// </summary>
    public partial class AdminCreateUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private Dictionary<string, string> _clientMetadata = new Dictionary<string, string>();
        private List<string> _desiredDeliveryMediums = new List<string>();
        private bool? _forceAliasCreation;
        private MessageActionType _messageAction;
        private string _temporaryPassword;
        private List<AttributeType> _userAttributes = new List<AttributeType>();
        private string _username;
        private string _userPoolId;
        private List<AttributeType> _validationData = new List<AttributeType>();

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
        /// a <code>clientMetadata</code> attribute, which provides the data that you assigned
        /// to the ClientMetadata parameter in your AdminCreateUser request. In your function
        /// code in Lambda, you can process the <code>clientMetadata</code> value to enhance your
        /// workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">Customizing
        /// User Pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Take the following limitations into consideration when you use the ClientMetadata
        /// parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito does not store the ClientMetadata value. This data is available only
        /// to Lambda triggers that are assigned to a user pool to support custom workflows. If
        /// your user pool configuration does not include triggers, the ClientMetadata parameter
        /// serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not encrypt the the ClientMetadata value, so don't use it to provide
        /// sensitive information.
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
            return this._clientMetadata != null && this._clientMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DesiredDeliveryMediums. 
        /// <para>
        /// Specify <code>"EMAIL"</code> if email will be used to send the welcome message. Specify
        /// <code>"SMS"</code> if the phone number will be used. The default value is <code>"SMS"</code>.
        /// More than one value can be specified.
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
            return this._desiredDeliveryMediums != null && this._desiredDeliveryMediums.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForceAliasCreation. 
        /// <para>
        /// This parameter is only used if the <code>phone_number_verified</code> or <code>email_verified</code>
        /// attribute is set to <code>True</code>. Otherwise, it is ignored.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <code>True</code> and the phone number or email address
        /// specified in the UserAttributes parameter already exists as an alias with a different
        /// user, the API call will migrate the alias from the previous user to the newly created
        /// user. The previous user will no longer be able to log in using that alias.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <code>False</code>, the API throws an <code>AliasExistsException</code>
        /// error if the alias already exists. The default value is <code>False</code>.
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
        /// Set to <code>"RESEND"</code> to resend the invitation message to a user that already
        /// exists and reset the expiration limit on the user's account. Set to <code>"SUPPRESS"</code>
        /// to suppress sending the message. Only one value can be specified.
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
        /// the user must enter the temporary password in the sign-in page along with a new password
        /// to be used in all future sign-ins.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not required. If you do not specify a value, Amazon Cognito generates
        /// one for you.
        /// </para>
        ///  
        /// <para>
        /// The temporary password can only be used until the user account expiration limit that
        /// you specified when you created the user pool. To reset the account after that time
        /// limit, you must call <code>AdminCreateUser</code> again, specifying <code>"RESEND"</code>
        /// for the <code>MessageAction</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=256)]
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
        /// other than <code>Username</code>. However, any attributes that you specify as required
        /// (when creating a user pool or in the <b>Attributes</b> tab of the console) must be
        /// supplied either by you (in your call to <code>AdminCreateUser</code>) or by the user
        /// (when he or she signs up in response to your welcome message).
        /// </para>
        ///  
        /// <para>
        /// For custom attributes, you must prepend the <code>custom:</code> prefix to the attribute
        /// name.
        /// </para>
        ///  
        /// <para>
        /// To send a message inviting the user to sign up, you must specify the user's email
        /// address or phone number. This can be done in your call to AdminCreateUser or in the
        /// <b>Users</b> tab of the Amazon Cognito console for managing your user pools.
        /// </para>
        ///  
        /// <para>
        /// In your call to <code>AdminCreateUser</code>, you can set the <code>email_verified</code>
        /// attribute to <code>True</code>, and you can set the <code>phone_number_verified</code>
        /// attribute to <code>True</code>. (You can also do this by calling <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminUpdateUserAttributes.html">AdminUpdateUserAttributes</a>.)
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>email</b>: The email address of the user to whom the message that contains the
        /// code and username will be sent. Required if the <code>email_verified</code> attribute
        /// is set to <code>True</code>, or if <code>"EMAIL"</code> is specified in the <code>DesiredDeliveryMediums</code>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>phone_number</b>: The phone number of the user to whom the message that contains
        /// the code and username will be sent. Required if the <code>phone_number_verified</code>
        /// attribute is set to <code>True</code>, or if <code>"SMS"</code> is specified in the
        /// <code>DesiredDeliveryMediums</code> parameter.
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
            return this._userAttributes != null && this._userAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username for the user. Must be unique within the user pool. Must be a UTF-8 string
        /// between 1 and 128 characters. After the user is created, the username cannot be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The user's validation data. This is an array of name-value pairs that contain user
        /// attributes and attribute values that you can use for custom validation, such as restricting
        /// the types of user accounts that can be registered. For example, you might choose to
        /// allow or disallow user sign-up based on the user's domain.
        /// </para>
        ///  
        /// <para>
        /// To configure custom validation, you must create a Pre Sign-up Lambda trigger for the
        /// user pool as described in the Amazon Cognito Developer Guide. The Lambda trigger receives
        /// the validation data and uses it in the validation process.
        /// </para>
        ///  
        /// <para>
        /// The user's validation data is not persisted.
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
            return this._validationData != null && this._validationData.Count > 0; 
        }

    }
}