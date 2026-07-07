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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
        private string _afterEffectiveFrom;
        private string _beforeEffectiveFrom;
        private CatalogName _catalog;
        private string _marketplaceRevenueShareRevision;
        private int? _maxResults;
        private string _nextToken;
        private string _productId;
        private MarketplaceRevenueShareAllocationSortField _sortBy;
        private SortOrder _sortOrder;
        private AllocationStatus _status;

        /// <summary>
        /// Gets and sets the property AfterEffectiveFrom. 
        /// <para>
        /// Inclusive lower bound for EffectiveFrom date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string AfterEffectiveFrom
        {
            get { return this._afterEffectiveFrom; }
            set { this._afterEffectiveFrom = value; }
        }

        // Check to see if AfterEffectiveFrom property is set
        internal bool IsSetAfterEffectiveFrom()
        {
            return this._afterEffectiveFrom != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeEffectiveFrom. 
        /// <para>
        /// Exclusive upper bound for EffectiveFrom date filter (half-open range).
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BeforeEffectiveFrom
        {
            get { return this._beforeEffectiveFrom; }
            set { this._beforeEffectiveFrom = value; }
        }

        // Check to see if BeforeEffectiveFrom property is set
        internal bool IsSetBeforeEffectiveFrom()
        {
            return this._beforeEffectiveFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog containing the allocations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogName Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareRevision. 
        /// <para>
        /// Optional share revision for historical list. Returns allocations as they existed at
        /// this revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string MarketplaceRevenueShareRevision
        {
            get { return this._marketplaceRevenueShareRevision; }
            set { this._marketplaceRevenueShareRevision = value; }
        }

        // Check to see if MarketplaceRevenueShareRevision property is set
        internal bool IsSetMarketplaceRevenueShareRevision()
        {
            return this._marketplaceRevenueShareRevision != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier for the parent revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=18, Max=18)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort marketplace revenue share allocations by.
        /// </para>
        /// </summary>
        public MarketplaceRevenueShareAllocationSortField SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The direction to sort results. Defaults to DESCENDING.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by allocation status.
        /// </para>
        /// </summary>
        public AllocationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}