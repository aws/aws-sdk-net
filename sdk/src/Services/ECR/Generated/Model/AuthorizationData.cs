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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing authorization data for an Amazon ECR registry.
    /// </summary>
    public partial class AuthorizationData
    {
        private string _authorizationToken;
        private DateTime? _expiresAt;
        private string _proxyEndpoint;

        /// <summary>
        /// Gets and sets the property AuthorizationToken. 
        /// <para>
        /// A base64-encoded string that contains authorization data for the specified Amazon
        /// ECR registry. When the string is decoded, it is presented in the format <code>user:password</code>
        /// for private registry authentication using <code>docker login</code>.
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

        /// <summary>
        /// Gets and sets the property ProxyEndpoint. 
        /// <para>
        /// The registry URL to use for this authorization token in a <code>docker login</code>
        /// command. The Amazon ECR registry URL format is <code>https://aws_account_id.dkr.ecr.region.amazonaws.com</code>.
        /// For example, <code>https://012345678910.dkr.ecr.us-east-1.amazonaws.com</code>.
        /// </para>
        /// </summary>
        public string ProxyEndpoint
        {
            get { return this._proxyEndpoint; }
            set { this._proxyEndpoint = value; }
        }

        // Check to see if ProxyEndpoint property is set
        internal bool IsSetProxyEndpoint()
        {
            return this._proxyEndpoint != null;
        }

    }
}