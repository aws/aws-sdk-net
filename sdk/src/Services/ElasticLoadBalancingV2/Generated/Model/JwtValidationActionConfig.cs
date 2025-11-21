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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a JSON Web Token (JWT) validation action.
    /// </summary>
    public partial class JwtValidationActionConfig
    {
        private List<JwtValidationActionAdditionalClaim> _additionalClaims = AWSConfigs.InitializeCollections ? new List<JwtValidationActionAdditionalClaim>() : null;
        private string _issuer;
        private string _jwksEndpoint;

        /// <summary>
        /// Gets and sets the property AdditionalClaims. 
        /// <para>
        /// Additional claims to validate. The maximum size of the list is 10. We validate the
        /// <c>exp</c>, <c>iss</c>, <c>nbf</c>, and <c>iat</c> claims by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JwtValidationActionAdditionalClaim> AdditionalClaims
        {
            get { return this._additionalClaims; }
            set { this._additionalClaims = value; }
        }

        // Check to see if AdditionalClaims property is set
        internal bool IsSetAdditionalClaims()
        {
            return this._additionalClaims != null && (this._additionalClaims.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer of the JWT. The maximum length is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property JwksEndpoint. 
        /// <para>
        /// The JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that
        /// are used to validate signatures from the provider.
        /// </para>
        ///  
        /// <para>
        /// This must be a full URL, including the HTTPS protocol, the domain, and the path. The
        /// maximum length is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JwksEndpoint
        {
            get { return this._jwksEndpoint; }
            set { this._jwksEndpoint = value; }
        }

        // Check to see if JwksEndpoint property is set
        internal bool IsSetJwksEndpoint()
        {
            return this._jwksEndpoint != null;
        }

    }
}