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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The credentials used when the authentication type is OAuth2 authentication.
    /// </summary>
    public partial class OAuth2Credentials
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token used when the authentication type is OAuth2.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// The JSON Web Token (JWT) used when the authentication type is OAuth2.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 8000)]
        public string JwtToken { get; set; }

        /// <summary>
        /// Checks to see if the JwtToken property is set.
        /// </summary>
        internal bool IsSetJwtToken() => this.JwtToken != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The refresh token used when the authentication type is OAuth2.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property UserManagedClientApplicationClientSecret. 
        /// <para>
        /// The client application client secret if the client application is user managed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string UserManagedClientApplicationClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the UserManagedClientApplicationClientSecret property is set.
        /// </summary>
        internal bool IsSetUserManagedClientApplicationClientSecret() => this.UserManagedClientApplicationClientSecret != null;
    }
}
