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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Output structure for CreateOAuth2TokenWithIAM operation
    /// 
    ///  
    /// <para>
    /// Contains the JWT access token, token type, and expiration per RFC 6749 §5.1.
    /// </para>
    /// </summary>
    public partial class CreateOAuth2TokenWithIAMResponse : AmazonWebServiceResponse
    {
        private string _accessToken;
        private int? _expiresIn;
        private string _tokenType;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// JWT access token containing principal identity, resource scope, and session metadata
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
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
        /// Token lifetime in seconds. Value is the minimum of session validity and 1 hour.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3600)]
        public int? ExpiresIn
        {
            get { return this._expiresIn; }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Always &quot;Bearer&quot; per OAuth 2.1 specification
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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