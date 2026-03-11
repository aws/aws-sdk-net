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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetOutboundWebIdentityFederationInfo operation.
    /// </summary>
    public partial class GetOutboundWebIdentityFederationInfoResponse : AmazonWebServiceResponse
    {
        private string _issuerIdentifier;
        private bool? _jwtVendingEnabled;

        /// <summary>
        /// Gets and sets the property IssuerIdentifier. 
        /// <para>
        /// A unique issuer URL for your Amazon Web Services account that hosts the OpenID Connect
        /// (OIDC) discovery endpoints at <c>/.well-known/openid-configuration and /.well-known/jwks.json</c>.
        /// The OpenID Connect (OIDC) discovery endpoints contain verification keys and metadata
        /// necessary for token verification.
        /// </para>
        /// </summary>
        public string IssuerIdentifier
        {
            get { return this._issuerIdentifier; }
            set { this._issuerIdentifier = value; }
        }

        // Check to see if IssuerIdentifier property is set
        internal bool IsSetIssuerIdentifier()
        {
            return this._issuerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property JwtVendingEnabled. 
        /// <para>
        /// Indicates whether outbound identity federation is currently enabled for your Amazon
        /// Web Services account. When true, IAM principals in the account can call the <c>GetWebIdentityToken</c>
        /// API to obtain JSON Web Tokens (JWTs) for authentication with external services. 
        /// </para>
        /// </summary>
        public bool? JwtVendingEnabled
        {
            get { return this._jwtVendingEnabled; }
            set { this._jwtVendingEnabled = value; }
        }

        // Check to see if JwtVendingEnabled property is set
        internal bool IsSetJwtVendingEnabled()
        {
            return this._jwtVendingEnabled.HasValue; 
        }

    }
}