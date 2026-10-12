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
    /// The object that your application receives after authentication. Contains tokens and
    /// information for device authentication.
    /// </summary>
    public partial class AuthenticationResultType
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// Your user's access token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The expiration period of the authentication result in seconds.
        /// </para>
        /// </summary>
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresIn property is set.
        /// </summary>
        internal bool IsSetExpiresIn() => this.ExpiresIn.HasValue;

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// Your user's ID token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string IdToken { get; set; }

        /// <summary>
        /// Checks to see if the IdToken property is set.
        /// </summary>
        internal bool IsSetIdToken() => this.IdToken != null;

        /// <summary>
        /// Gets and sets the property NewDeviceMetadata. 
        /// <para>
        /// The new device metadata from an authentication result.
        /// </para>
        /// </summary>
        public NewDeviceMetadataType NewDeviceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the NewDeviceMetadata property is set.
        /// </summary>
        internal bool IsSetNewDeviceMetadata() => this.NewDeviceMetadata != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Your user's refresh token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// The intended use of the token, for example <c>Bearer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
