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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A trusted issuer in the JWT configuration.
    /// </summary>
    public partial class JwtIssuerInput
    {
        /// <summary>
        /// Gets and sets the property AdditionalClaims. 
        /// <para>
        /// The additional claim rules for this issuer. Claim names must be unique within the
        /// issuer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JwtAdditionalClaim> AdditionalClaims { get; set; } = AWSConfigs.InitializeCollections ? new List<JwtAdditionalClaim>() : null;

        /// <summary>
        /// Checks to see if the AdditionalClaims property is set.
        /// </summary>
        internal bool IsSetAdditionalClaims() => this.AdditionalClaims != null && (this.AdditionalClaims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The audiences that the issuer can issue tokens for. None can be empty. The token's
        /// <c>aud</c> claim must contain at least one of these values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Audiences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Audiences property is set.
        /// </summary>
        internal bool IsSetAudiences() => this.Audiences != null && (this.Audiences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OpenID Connect (OIDC) issuer URL. The value must be an absolute <c>https</c> URL
        /// that includes a host and has no user information, query, or fragment. It must exactly
        /// match the <c>iss</c> claim of the token, and the issuer's OIDC discovery document
        /// must name this exact issuer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;
    }
}
