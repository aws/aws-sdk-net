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
    /// This is the response object from the UpdateAggregatorV2 operation.
    /// </summary>
    public partial class UpdateAggregatorV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AggregationRegion. 
        /// <para>
        /// The Amazon Web Services Region where data is aggregated.
        /// </para>
        /// </summary>
        public string AggregationRegion { get; set; }

        /// <summary>
        /// Checks to see if the AggregationRegion property is set.
        /// </summary>
        internal bool IsSetAggregationRegion() => this.AggregationRegion != null;

        /// <summary>
        /// Gets and sets the property AggregatorV2Arn. 
        /// <para>
        /// The ARN of the Aggregator V2.
        /// </para>
        /// </summary>
        public string AggregatorV2Arn { get; set; }

        /// <summary>
        /// Checks to see if the AggregatorV2Arn property is set.
        /// </summary>
        internal bool IsSetAggregatorV2Arn() => this.AggregatorV2Arn != null;

        /// <summary>
        /// Gets and sets the property LinkedRegions. 
        /// <para>
        /// A list of Amazon Web Services Regions linked to the aggegation Region.
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
        /// Determines how Amazon Web Services Regions should be linked to the Aggregator V2.
        /// </para>
        /// </summary>
        public string RegionLinkingMode { get; set; }

        /// <summary>
        /// Checks to see if the RegionLinkingMode property is set.
        /// </summary>
        internal bool IsSetRegionLinkingMode() => this.RegionLinkingMode != null;
    }
}
