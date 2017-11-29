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
    /// This message is based on a template that you configured in your call to or . This
    /// template includes your custom sign-up instructions and placeholders for user name
    /// and temporary password.
    /// </para>
    ///  </note> 
    /// <para>
    /// Alternatively, you can call AdminCreateUser with “SUPPRESS” for the <code>MessageAction</code>
    /// parameter, and Amazon Cognito will not send any email. 
    /// </para>
    ///  
    /// <para>
    /// In either case, the user will be in the <code>FORCE_CHANGE_PASSWORD</code> state until
    /// they sign in and change their password.
    /// </para>
    ///  
    /// <para>
    /// AdminCreateUser requires developer credentials.
    /// </para>
    /// </summary>
    public partial class AdminCreateUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _desiredDeliveryMediums = new List<string>();
        private bool? _forceAliasCreation;
        private MessageActionType _messageAction;
        private string _temporaryPassword;
        private List<AttributeType> _userAttributes = new List<AttributeType>();
        private string _username;
        private string _userPoolId;
        private List<AttributeType> _validationData = new List<AttributeType>();

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
        /// (in or in the <b>Attributes</b> tab of the console) must be supplied either by you
        /// (in your call to <code>AdminCreateUser</code>) or by the user (when he or she signs
        /// up in response to your welcome message).
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
        /// attribute to <code>True</code>. (You can also do this by calling .)
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