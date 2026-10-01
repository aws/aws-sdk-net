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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListCoreNetworkRoutingInformation operation. Lists
    /// routing information for a core network, including routes and their attributes.
    /// </summary>
    public partial class ListCoreNetworkRoutingInformationRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CommunityMatches. 
        /// <para>
        /// BGP community values to match when filtering routing information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CommunityMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CommunityMatches property is set.
        /// </summary>
        internal bool IsSetCommunityMatches() => this.CommunityMatches != null && (this.CommunityMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network to retrieve routing information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location to filter routing information by.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string EdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the EdgeLocation property is set.
        /// </summary>
        internal bool IsSetEdgeLocation() => this.EdgeLocation != null;

        /// <summary>
        /// Gets and sets the property ExactAsPathMatches. 
        /// <para>
        /// Exact AS path values to match when filtering routing information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExactAsPathMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExactAsPathMatches property is set.
        /// </summary>
        internal bool IsSetExactAsPathMatches() => this.ExactAsPathMatches != null && (this.ExactAsPathMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalPreferenceMatches. 
        /// <para>
        /// Local preference values to match when filtering routing information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LocalPreferenceMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LocalPreferenceMatches property is set.
        /// </summary>
        internal bool IsSetLocalPreferenceMatches() => this.LocalPreferenceMatches != null && (this.LocalPreferenceMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of routing information entries to return in a single page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MedMatches. 
        /// <para>
        /// Multi-Exit Discriminator (MED) values to match when filtering routing information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MedMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MedMatches property is set.
        /// </summary>
        internal bool IsSetMedMatches() => this.MedMatches != null && (this.MedMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextHopFilters. 
        /// <para>
        /// Filters to apply based on next hop information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> NextHopFilters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the NextHopFilters property is set.
        /// </summary>
        internal bool IsSetNextHopFilters() => this.NextHopFilters != null && (this.NextHopFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment to filter routing information by.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;
    }
}
