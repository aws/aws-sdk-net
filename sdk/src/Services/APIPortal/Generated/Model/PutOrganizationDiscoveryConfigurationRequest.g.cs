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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationDiscoveryConfiguration operation.
    /// Creates or updates the organization-wide discovery configuration. This is a singleton
    /// per organization. Only the organization management account and registered delegated
    /// administrators may call this operation.
    /// </summary>
    public partial class PutOrganizationDiscoveryConfigurationRequest : AmazonAPIPortalRequest
    {
        /// <summary>
        /// Gets and sets the property DiscoveryFilters. The accounts or organizational units
        /// to include in or exclude from discovery.
        /// </summary>
        public OrganizationDiscoveryFilters DiscoveryFilters { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryFilters property is set.
        /// </summary>
        internal bool IsSetDiscoveryFilters() => this.DiscoveryFilters != null;

        /// <summary>
        /// Gets and sets the property DiscoverySources. The sources to discover APIs from. Omitting
        /// it removes all sources, which stops discovery for this configuration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> DiscoverySources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DiscoverySources property is set.
        /// </summary>
        internal bool IsSetDiscoverySources() => this.DiscoverySources != null && (this.DiscoverySources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExclusionFilters. Exclusion filters for organization-scoped
        /// discovery. @deprecated. Remove this once client (Console) moves to discoveryFilters
        /// </summary>
        public DiscoveryExclusionFilters ExclusionFilters { get; set; }

        /// <summary>
        /// Checks to see if the ExclusionFilters property is set.
        /// </summary>
        internal bool IsSetExclusionFilters() => this.ExclusionFilters != null;

        /// <summary>
        /// Gets and sets the property Features. Optional capabilities to enable. Omitting it
        /// disables all of them, as with the other fields.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags.
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
