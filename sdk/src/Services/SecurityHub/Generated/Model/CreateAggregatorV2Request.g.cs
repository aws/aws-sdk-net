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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAggregatorV2 operation. Enables aggregation
    /// across Amazon Web Services Regions.
    /// </summary>
    public partial class CreateAggregatorV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier used to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LinkedRegions. 
        /// <para>
        /// The list of Regions that are linked to the aggregation Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LinkedRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LinkedRegions property is set.
        /// </summary>
        internal bool IsSetLinkedRegions() => this.LinkedRegions != null && (this.LinkedRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionLinkingMode. 
        /// <para>
        /// Determines how Regions are linked to an Aggregator V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionLinkingMode { get; set; }

        /// <summary>
        /// Checks to see if the RegionLinkingMode property is set.
        /// </summary>
        internal bool IsSetRegionLinkingMode() => this.RegionLinkingMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to be applied to the AggregatorV2.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
