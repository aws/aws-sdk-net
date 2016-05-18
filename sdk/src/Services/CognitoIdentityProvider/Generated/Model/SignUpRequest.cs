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
    /// Container for the parameters to the SignUp operation.
    /// Registers the user in the specified user pool and creates a user name, password, and
    /// user attributes.
    /// </summary>
    public partial class SignUpRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientId;
        private string _password;
        private string _secretHash;
        private List<AttributeType> _userAttributes = new List<AttributeType>();
        private string _username;
        private List<AttributeType> _validationData = new List<AttributeType>();

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the client associated with the user pool.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the user you wish to register.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property SecretHash. 
        /// <para>
        /// A keyed-hash message authentication code (HMAC) calculated using the secret key of
        /// a user pool client and username plus the client ID in the message.
        /// </para>
        /// </summary>
        public string SecretHash
        {
            get { return this._secretHash; }
            set { this._secretHash = value; }
        }

        // Check to see if SecretHash property is set
        internal bool IsSetSecretHash()
        {
            return this._secretHash != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// An array of name-value pairs representing user attributes.
        /// </para>
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
        /// The user name of the user you wish to register.
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
        /// Gets and sets the property ValidationData. 
        /// <para>
        /// The validation data in the request to register a user.
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