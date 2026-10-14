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
    /// Container for the parameters to the ListMarketplaceRevenueShareAllocations operation.
    /// Returns a paginated list of allocations under a marketplace revenue share, with optional
    /// filtering by status and effective date range. Supports historical reads at a specific
    /// share revision.
    /// </summary>
    public partial class ListMarketplaceRevenueShareAllocationsRequest : AmazonPartnerCentralRevenueMeasurementRequest
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
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog containing the allocations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareRevision. 
        /// <para>
        /// Optional share revision for historical list. Returns allocations as they existed at
        /// this revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string MarketplaceRevenueShareRevision { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareRevision property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareRevision() => this.MarketplaceRevenueShareRevision != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier for the parent revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort marketplace revenue share allocations by.
        /// </para>
        /// </summary>
        public MarketplaceRevenueShareAllocationSortField SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The direction to sort results. Defaults to DESCENDING.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by allocation status.
        /// </para>
        /// </summary>
        public AllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
