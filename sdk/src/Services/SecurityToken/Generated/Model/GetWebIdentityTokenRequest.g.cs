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
    /// JSON Web Token (JWT) that represents the calling Amazon Web Services identity or,
    /// if you set <c>SubjectMode</c> to <c>OriginIdentity</c>, the human user or workload
    /// on whose behalf the calling session acts. The returned JWT can be used to authenticate
    /// with external services that support OIDC discovery. The token is signed by Amazon
    /// Web Services STS and can be publicly verified using the verification keys published
    /// at the issuer's JWKS endpoint. <para> The <c>sub</c> (subject) claim contains the
    /// identity that <c>SubjectMode</c> selects. Whichever subject mode you use, the <c>principal_id</c>
    /// claim under the <c>https://sts.amazonaws.com/</c> namespace contains the ARN of the
    /// principal that requested the token, when that principal has an ARN. For a role session,
    /// this is the ARN of the role. </para> <note> <para> The <c>GetWebIdentityToken</c>
    /// API is not available on the STS Global endpoint. </para> </note>
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// One or more OAuth 2.0 scope values to include in the JSON Web Token (JWT). Amazon
        /// Web Services STS copies the value exactly as you send it into the top-level <c>scope</c>
        /// claim of the token. If you don't specify <c>Scope</c>, the token doesn't include a
        /// <c>scope</c> claim.
        /// </para>
        ///  
        /// <para>
        /// Separate multiple values with a single space, as defined in <a href="https://www.rfc-editor.org/rfc/rfc6749#section-3.3">RFC
        /// 6749, section 3.3</a> on the IETF website. Don't begin or end <c>Scope</c> with a
        /// space. Each scope value can contain printable ASCII characters except spaces, double
        /// quotation marks (<c>"</c>), commas (<c>,</c>), and backslashes (<c>\</c>).
        /// </para>
        ///  
        /// <para>
        /// You can't repeat a scope value. Scope values are case sensitive. This means that <c>read</c>
        /// and <c>READ</c> are separate values.
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>Scope</c> only when <c>SubjectMode</c> is <c>OriginIdentity</c>
        /// and you request exactly one audience. To specify <c>Scope</c>, the calling principal
        /// must have permission for the <c>sts:SetWebIdentityTokenScope</c> action in addition
        /// to <c>sts:GetWebIdentityToken</c>. You can use the multivalued <c>sts:IdentityTokenScope</c>
        /// condition key in a policy to control which scope values a principal can request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

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
        /// Gets and sets the property SubjectMode. 
        /// <para>
        /// Specifies which identity STS puts in the <c>sub</c> (subject) claim of the JSON Web
        /// Token (JWT). Valid values are <c>AWSIdentity</c> and <c>OriginIdentity</c>. If you
        /// don't specify a value, Amazon Web Services STS uses <c>AWSIdentity</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWSIdentity</c> – The <c>sub</c> claim contains the ARN of the calling Amazon
        /// Web Services principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OriginIdentity</c> – The <c>sub</c> claim contains the value of the <c>aws:OriginIdentity/Subject</c>
        /// key in the trusted identity propagation context of the calling session. For example,
        /// this can identify the human user or workload on whose behalf the calling session acts.
        /// Amazon Web Services STS also adds a <c>subject_mode</c> claim to the token.
        /// </para>
        ///  
        /// <para>
        /// To use <c>OriginIdentity</c>, the trusted identity propagation context of the calling
        /// session must contain the <c>aws:OriginIdentity/Subject</c> key and either the <c>aws:OriginIdentity/Issuer</c>
        /// key or the <c>aws:OriginIdentity/FederatedProviderArn</c> key. If it doesn't, or if
        /// the subject is blank, Amazon Web Services STS rejects the request with a validation
        /// error.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services STS denies the request if the subject begins with the text <c>arn:</c>,
        /// in any combination of uppercase and lowercase letters. Amazon Web Services STS also
        /// denies the request if the subject begins or ends with a space, or contains a control,
        /// format, or separator character other than a space.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use the <c>sts:SubjectMode</c> condition key in a policy to control which
        /// subject modes a principal can request.
        /// </para>
        /// </summary>
        public WebIdentityTokenSubjectModeType SubjectMode { get; set; }

        /// <summary>
        /// Checks to see if the SubjectMode property is set.
        /// </summary>
        internal bool IsSetSubjectMode() => this.SubjectMode != null;

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
