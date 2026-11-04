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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetWebIdentityToken operation. Returns a signed
    /// JSON Web Token (JWT) that represents the calling Amazon Web Services identity. The
    /// returned JWT can be used to authenticate with external services that support OIDC
    /// discovery. The token is signed by Amazon Web Services STS and can be publicly verified
    /// using the verification keys published at the issuer's JWKS endpoint. <note> <para>
    /// The <c>GetWebIdentityToken</c> API is not available on the STS Global endpoint. </para>
    /// </note>
    /// </summary>
    public partial class GetWebIdentityTokenRequest : AmazonSecurityTokenServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The intended recipient of the web identity token. This value populates the <c>aud</c>
        /// claim in the JWT and should identify the service or application that will validate
        /// and use the token. The external service should verify this claim to ensure the token
        /// was intended for their use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> Audience { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Audience property is set.
        /// </summary>
        internal bool IsSetAudience() => this.Audience != null && (this.Audience.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, for which the JSON Web Token (JWT) will remain valid. The
        /// value can range from 60 seconds (1 minute) to 3600 seconds (1 hour). If not specified,
        /// the default duration is 300 seconds (5 minutes). The token is designed to be short-lived
        /// and should be used for proof of identity, then exchanged for credentials or short-lived
        /// tokens in the external service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The cryptographic algorithm to use for signing the JSON Web Token (JWT). Valid values
        /// are RS256 (RSA with SHA-256) and ES384 (ECDSA using P-384 curve with SHA-384). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of tags to include in the JSON Web Token (JWT). These tags are added
        /// as custom claims to the JWT and can be used by the downstream service for authorization
        /// decisions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
