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
    /// This is the response object from the CreateGatewayRateLimit operation.
    /// </summary>
    public partial class CreateGatewayRateLimitResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the rate limit was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The human-readable description of the rate limit.
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
        /// The list of rule entries that map dimension values to rate configurations.
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
        /// The unique identifier of the gateway.
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
        /// The unique identifier of the created rate limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string RateLimitId { get; set; }

        /// <summary>
        /// Checks to see if the RateLimitId property is set.
        /// </summary>
        internal bool IsSetRateLimitId() => this.RateLimitId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the rate limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayRateLimitStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the rate limit was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
