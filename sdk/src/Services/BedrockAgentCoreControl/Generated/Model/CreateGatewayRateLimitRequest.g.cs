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
    /// Container for the parameters to the CreateGatewayRateLimit operation. Creates a rate
    /// limit for a gateway. Rate limits define throttling rules for each dimension that control
    /// request rates, token consumption rates, and concurrent connections through the gateway.
    /// </summary>
    public partial class CreateGatewayRateLimitRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional human-readable description for this rate limit. If not provided, the rate
        /// limit is created without a description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DimensionKeys. 
        /// <para>
        /// The ordered list of dimension key names that define the scope of this rate limit.
        /// Must be unique per gateway—no two rate limits can share the same dimension keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> DimensionKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DimensionKeys property is set.
        /// </summary>
        internal bool IsSetDimensionKeys() => this.DimensionKeys != null && (this.DimensionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The rule entries that map dimension values to rate configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public List<LimitEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<LimitEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The unique identifier of the gateway to create the rate limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetGatewayIdentifier() => this.GatewayIdentifier != null;

        /// <summary>
        /// Gets and sets the property RateLimitId. 
        /// <para>
        /// An optional customer-defined identifier for the rate limit. If not provided, the system
        /// generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string RateLimitId { get; set; }

        /// <summary>
        /// Checks to see if the RateLimitId property is set.
        /// </summary>
        internal bool IsSetRateLimitId() => this.RateLimitId != null;
    }
}
