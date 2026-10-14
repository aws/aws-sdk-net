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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes updated configuration settings for a trusted token issuer
    /// that supports OpenID Connect (OIDC) and JSON Web Tokens (JWTs).
    /// </summary>
    public partial class OidcJwtUpdateConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClaimAttributePath. 
        /// <para>
        /// The path of the source attribute in the JWT from the trusted token issuer. The attribute
        /// mapped by this JMESPath expression is compared against the attribute mapped by <c>IdentityStoreAttributePath</c>
        /// when a trusted token issuer token is exchanged for an IAM Identity Center token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClaimAttributePath { get; set; }

        /// <summary>
        /// Checks to see if the ClaimAttributePath property is set.
        /// </summary>
        internal bool IsSetClaimAttributePath() => this.ClaimAttributePath != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreAttributePath. 
        /// <para>
        /// The path of the destination attribute in a JWT from IAM Identity Center. The attribute
        /// mapped by this JMESPath expression is compared against the attribute mapped by <c>ClaimAttributePath</c>
        /// when a trusted token issuer token is exchanged for an IAM Identity Center token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string IdentityStoreAttributePath { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreAttributePath property is set.
        /// </summary>
        internal bool IsSetIdentityStoreAttributePath() => this.IdentityStoreAttributePath != null;

        /// <summary>
        /// Gets and sets the property JwksRetrievalOption. 
        /// <para>
        /// The method that the trusted token issuer can use to retrieve the JSON Web Key Set
        /// used to verify a JWT.
        /// </para>
        /// </summary>
        public JwksRetrievalOption JwksRetrievalOption { get; set; }

        /// <summary>
        /// Checks to see if the JwksRetrievalOption property is set.
        /// </summary>
        internal bool IsSetJwksRetrievalOption() => this.JwksRetrievalOption != null;
    }
}
