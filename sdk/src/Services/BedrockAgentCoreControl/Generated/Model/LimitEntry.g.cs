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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A single rule entry within a rate limit that maps dimension values to rate configurations.
    /// Each entry defines the rate limits for a specific combination of dimension values.
    /// </summary>
    public partial class LimitEntry
    {
        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The connection rate limit configuration. Specifies the maximum number of concurrent
        /// connections allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<RateConfig> Connections { get; set; } = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null && (this.Connections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A map of dimension names to dimension values for this rule entry. Keys must match
        /// the parent rate limit's dimension keys. Values may use <c>*</c> as a wildcard, but
        /// only in trailing positions based on the dimension keys ordering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Requests. 
        /// <para>
        /// The request rate limit configuration. Specifies the maximum number of requests allowed
        /// per time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<RateConfig> Requests { get; set; } = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;

        /// <summary>
        /// Checks to see if the Requests property is set.
        /// </summary>
        internal bool IsSetRequests() => this.Requests != null && (this.Requests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tokens. 
        /// <para>
        /// The token rate limit configuration. Specifies the maximum number of tokens allowed
        /// per time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<RateConfig> Tokens { get; set; } = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;

        /// <summary>
        /// Checks to see if the Tokens property is set.
        /// </summary>
        internal bool IsSetTokens() => this.Tokens != null && (this.Tokens.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
