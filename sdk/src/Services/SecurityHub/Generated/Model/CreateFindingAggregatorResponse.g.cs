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
    /// This is the response object from the CreateFindingAggregator operation.
    /// </summary>
    public partial class CreateFindingAggregatorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FindingAggregationRegion. 
        /// <para>
        /// The home Region. Findings generated in linked Regions are replicated and sent to the
        /// home Region.
        /// </para>
        /// </summary>
        public string FindingAggregationRegion { get; set; }

        /// <summary>
        /// Checks to see if the FindingAggregationRegion property is set.
        /// </summary>
        internal bool IsSetFindingAggregationRegion() => this.FindingAggregationRegion != null;

        /// <summary>
        /// Gets and sets the property FindingAggregatorArn. 
        /// <para>
        /// The ARN of the finding aggregator. You use the finding aggregator ARN to retrieve
        /// details for, update, and stop cross-Region aggregation.
        /// </para>
        /// </summary>
        public string FindingAggregatorArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingAggregatorArn property is set.
        /// </summary>
        internal bool IsSetFindingAggregatorArn() => this.FindingAggregatorArn != null;

        /// <summary>
        /// Gets and sets the property RegionLinkingMode. 
        /// <para>
        /// Indicates whether to link all Regions, all Regions except for a list of excluded Regions,
        /// or a list of included Regions.
        /// </para>
        /// </summary>
        public string RegionLinkingMode { get; set; }

        /// <summary>
        /// Checks to see if the RegionLinkingMode property is set.
        /// </summary>
        internal bool IsSetRegionLinkingMode() => this.RegionLinkingMode != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of excluded Regions or included Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
