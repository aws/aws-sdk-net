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
    /// The authentication result.
    /// </summary>
    public partial class AuthenticationResultType
    {
        private string _accessToken;
        private int? _expiresIn;
        private string _idToken;
        private NewDeviceMetadataType _newDeviceMetadata;
        private string _refreshToken;
        private string _tokenType;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user who you want to authenticate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The expiration period of the authentication result in seconds.
        /// </para>
        /// </summary>
        public int ExpiresIn
        {
            get { return this._expiresIn.GetValueOrDefault(); }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// The ID token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IdToken
        {
            get { return this._idToken; }
            set { this._idToken = value; }
        }

        // Check to see if IdToken property is set
        internal bool IsSetIdToken()
        {
            return this._idToken != null;
        }

        /// <summary>
        /// Gets and sets the property NewDeviceMetadata. 
        /// <para>
        /// The new device metadata from an authentication result.
        /// </para>
        /// </summary>
        public NewDeviceMetadataType NewDeviceMetadata
        {
            get { return this._newDeviceMetadata; }
            set { this._newDeviceMetadata = value; }
        }

        // Check to see if NewDeviceMetadata property is set
        internal bool IsSetNewDeviceMetadata()
        {
            return this._newDeviceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The refresh token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// The token type.
        /// </para>
        /// </summary>
        public string TokenType
        {
            get { return this._tokenType; }
            set { this._tokenType = value; }
        }

        // Check to see if TokenType property is set
        internal bool IsSetTokenType()
        {
            return this._tokenType != null;
        }

    }
}