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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Container for the parameters to the ListRevenueAttributionAllocations operation. Returns
    /// a paginated list of committed allocations with support for filtering by entity, customer,
    /// status, or date range.
    /// </summary>
    public partial class ListRevenueAttributionAllocationsRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        /// <summary>
        /// Gets and sets the property AfterEffectiveFrom. 
        /// <para>
        /// Inclusive lower bound for EffectiveFrom date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string AfterEffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the AfterEffectiveFrom property is set.
        /// </summary>
        internal bool IsSetAfterEffectiveFrom() => this.AfterEffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property AfterEffectiveUntil. 
        /// <para>
        /// Inclusive lower bound for EffectiveUntil date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string AfterEffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the AfterEffectiveUntil property is set.
        /// </summary>
        internal bool IsSetAfterEffectiveUntil() => this.AfterEffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property BeforeEffectiveFrom. 
        /// <para>
        /// Exclusive upper bound for EffectiveFrom date filter (half-open range).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BeforeEffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the BeforeEffectiveFrom property is set.
        /// </summary>
        internal bool IsSetBeforeEffectiveFrom() => this.BeforeEffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property BeforeEffectiveUntil. 
        /// <para>
        /// Exclusive upper bound for EffectiveUntil date filter (half-open range).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BeforeEffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the BeforeEffectiveUntil property is set.
        /// </summary>
        internal bool IsSetBeforeEffectiveUntil() => this.BeforeEffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that contains the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CustomerAwsAccountIdFilters. 
        /// <para>
        /// Filter by customer AWS account IDs for associated deal entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> CustomerAwsAccountIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomerAwsAccountIdFilters property is set.
        /// </summary>
        internal bool IsSetCustomerAwsAccountIdFilters() => this.CustomerAwsAccountIdFilters != null && (this.CustomerAwsAccountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityIdentifierFilters. 
        /// <para>
        /// Filter by deal entity identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> EntityIdentifierFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntityIdentifierFilters property is set.
        /// </summary>
        internal bool IsSetEntityIdentifierFilters() => this.EntityIdentifierFilters != null && (this.EntityIdentifierFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityTypeFilters. 
        /// <para>
        /// Filter by deal entity types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> EntityTypeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntityTypeFilters property is set.
        /// </summary>
        internal bool IsSetEntityTypeFilters() => this.EntityTypeFilters != null && (this.EntityTypeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionIdentifier. 
        /// <para>
        /// The revenue attribution identifier to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string RevenueAttributionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionIdentifier property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionIdentifier() => this.RevenueAttributionIdentifier != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionRevision. 
        /// <para>
        /// Point-in-time revision number to query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string RevenueAttributionRevision { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionRevision property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionRevision() => this.RevenueAttributionRevision != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Field to sort by.
        /// </para>
        /// </summary>
        public RevenueAttributionAllocationSortField SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Sort direction. Defaults to ASCENDING.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Filter by allocation status.
        /// </para>
        /// </summary>
        public AllocationStatus StatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null;
    }
}
