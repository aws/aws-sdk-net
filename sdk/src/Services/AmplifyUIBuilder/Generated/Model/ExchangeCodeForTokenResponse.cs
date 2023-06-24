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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// This is the response object from the ExchangeCodeForToken operation.
    /// </summary>
    public partial class ExchangeCodeForTokenResponse : AmazonWebServiceResponse
    {
        private string _accessToken;
        private int? _expiresIn;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// The date and time when the new access token expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The token to use to refresh a previously issued access token that might have expired.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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

    }
}