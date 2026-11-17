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
    /// An additional claim rule for an issuer.
    /// </summary>
    public partial class JwtAdditionalClaim
    {
        /// <summary>
        /// Gets and sets the property ClaimName. 
        /// <para>
        /// The name of the claim to check. The value cannot be empty and cannot be <c>iss</c>,
        /// <c>aud</c>, <c>exp</c>, <c>nbf</c>, <c>iat</c>, <c>scope</c>, or <c>scp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClaimName { get; set; }

        /// <summary>
        /// Checks to see if the ClaimName property is set.
        /// </summary>
        internal bool IsSetClaimName() => this.ClaimName != null;

        /// <summary>
        /// Gets and sets the property ExpectedValues. 
        /// <para>
        /// The accepted value for the claim. The value cannot be empty. When a value is specified,
        /// the claim must match it exactly, and the match is case-sensitive. When no value is
        /// specified, the claim only has to be present.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExpectedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExpectedValues property is set.
        /// </summary>
        internal bool IsSetExpectedValues() => this.ExpectedValues != null && (this.ExpectedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the claim value. The only valid value is <c>SINGLE_STRING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JwtClaimFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether the claim must be present in the token. Defaults to <c>false</c>.
        /// When <c>true</c>, the token must contain the claim.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}
