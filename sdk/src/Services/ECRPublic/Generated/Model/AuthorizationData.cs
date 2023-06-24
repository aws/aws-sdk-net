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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An authorization token data object that corresponds to a public registry.
    /// </summary>
    public partial class AuthorizationData
    {
        private string _authorizationToken;
        private DateTime? _expiresAt;

        /// <summary>
        /// Gets and sets the property AuthorizationToken. 
        /// <para>
        /// A base64-encoded string that contains authorization data for a public Amazon ECR registry.
        /// When the string is decoded, it's presented in the format <code>user:password</code>
        /// for public registry authentication using <code>docker login</code>.
        /// </para>
        /// </summary>
        public string AuthorizationToken
        {
            get { return this._authorizationToken; }
            set { this._authorizationToken = value; }
        }

        // Check to see if AuthorizationToken property is set
        internal bool IsSetAuthorizationToken()
        {
            return this._authorizationToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The Unix time in seconds and milliseconds when the authorization token expires. Authorization
        /// tokens are valid for 12 hours.
        /// </para>
        /// </summary>
        public DateTime ExpiresAt
        {
            get { return this._expiresAt.GetValueOrDefault(); }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

    }
}