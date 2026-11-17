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
    /// The JWT configuration supplied for a JWT authorizer.
    /// </summary>
    public partial class JwtConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property DefaultAlgorithms. 
        /// <para>
        /// The signing algorithms that the authorizer accepts, applied to every issuer. Valid
        /// values are <c>RS256</c>, <c>RS384</c>, <c>RS512</c>, <c>ES256</c>, <c>ES384</c>, and
        /// <c>ES512</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> DefaultAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DefaultAlgorithms property is set.
        /// </summary>
        internal bool IsSetDefaultAlgorithms() => this.DefaultAlgorithms != null && (this.DefaultAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Issuers. 
        /// <para>
        /// The issuers that the authorizer trusts. Issuer URLs must be unique.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<JwtIssuerInput> Issuers { get; set; } = AWSConfigs.InitializeCollections ? new List<JwtIssuerInput>() : null;

        /// <summary>
        /// Checks to see if the Issuers property is set.
        /// </summary>
        internal bool IsSetIssuers() => this.Issuers != null && (this.Issuers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
