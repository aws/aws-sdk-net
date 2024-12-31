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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The GlueOAuth2 credentials of a connection.
    /// </summary>
    public partial class GlueOAuth2Credentials
    {
        private string _accessToken;
        private string _jwtToken;
        private string _refreshToken;
        private string _userManagedClientApplicationClientSecret;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// The jwt token of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8000)]
        public string JwtToken
        {
            get { return this._jwtToken; }
            set { this._jwtToken = value; }
        }

        // Check to see if JwtToken property is set
        internal bool IsSetJwtToken()
        {
            return this._jwtToken != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The refresh token of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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
        /// Gets and sets the property UserManagedClientApplicationClientSecret. 
        /// <para>
        /// The user managed client application client secret of the connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string UserManagedClientApplicationClientSecret
        {
            get { return this._userManagedClientApplicationClientSecret; }
            set { this._userManagedClientApplicationClientSecret = value; }
        }

        // Check to see if UserManagedClientApplicationClientSecret property is set
        internal bool IsSetUserManagedClientApplicationClientSecret()
        {
            return this._userManagedClientApplicationClientSecret != null;
        }

    }
}