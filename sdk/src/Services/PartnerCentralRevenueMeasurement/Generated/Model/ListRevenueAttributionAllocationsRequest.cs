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
    /// Container for the parameters to the ListRevenueAttributionAllocations operation.
    /// Returns a paginated list of committed allocations with support for filtering by entity,
    /// customer, status, or date range.
    /// </summary>
    public partial class ListRevenueAttributionAllocationsRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private string _afterEffectiveFrom;
        private string _afterEffectiveUntil;
        private string _beforeEffectiveFrom;
        private string _beforeEffectiveUntil;
        private CatalogName _catalog;
        private List<string> _customerAwsAccountIdFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entityIdentifierFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entityTypeFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _revenueAttributionIdentifier;
        private string _revenueAttributionRevision;
        private RevenueAttributionAllocationSortField _sortBy;
        private SortOrder _sortOrder;
        private AllocationStatus _statusFilter;

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
        /// Gets and sets the property AfterEffectiveUntil. 
        /// <para>
        /// Inclusive lower bound for EffectiveUntil date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string AfterEffectiveUntil
        {
            get { return this._afterEffectiveUntil; }
            set { this._afterEffectiveUntil = value; }
        }

        // Check to see if AfterEffectiveUntil property is set
        internal bool IsSetAfterEffectiveUntil()
        {
            return this._afterEffectiveUntil != null;
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
        /// Gets and sets the property BeforeEffectiveUntil. 
        /// <para>
        /// Exclusive upper bound for EffectiveUntil date filter (half-open range).
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BeforeEffectiveUntil
        {
            get { return this._beforeEffectiveUntil; }
            set { this._beforeEffectiveUntil = value; }
        }

        // Check to see if BeforeEffectiveUntil property is set
        internal bool IsSetBeforeEffectiveUntil()
        {
            return this._beforeEffectiveUntil != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that contains the resource.
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
        /// Gets and sets the property CustomerAwsAccountIdFilters. 
        /// <para>
        /// Filter by customer AWS account IDs for associated deal entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> CustomerAwsAccountIdFilters
        {
            get { return this._customerAwsAccountIdFilters; }
            set { this._customerAwsAccountIdFilters = value; }
        }

        // Check to see if CustomerAwsAccountIdFilters property is set
        internal bool IsSetCustomerAwsAccountIdFilters()
        {
            return this._customerAwsAccountIdFilters != null && (this._customerAwsAccountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifierFilters. 
        /// <para>
        /// Filter by deal entity identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> EntityIdentifierFilters
        {
            get { return this._entityIdentifierFilters; }
            set { this._entityIdentifierFilters = value; }
        }

        // Check to see if EntityIdentifierFilters property is set
        internal bool IsSetEntityIdentifierFilters()
        {
            return this._entityIdentifierFilters != null && (this._entityIdentifierFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityTypeFilters. 
        /// <para>
        /// Filter by deal entity types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> EntityTypeFilters
        {
            get { return this._entityTypeFilters; }
            set { this._entityTypeFilters = value; }
        }

        // Check to see if EntityTypeFilters property is set
        internal bool IsSetEntityTypeFilters()
        {
            return this._entityTypeFilters != null && (this._entityTypeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Pagination token from previous response.
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
        /// Gets and sets the property RevenueAttributionIdentifier. 
        /// <para>
        /// The revenue attribution identifier to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string RevenueAttributionIdentifier
        {
            get { return this._revenueAttributionIdentifier; }
            set { this._revenueAttributionIdentifier = value; }
        }

        // Check to see if RevenueAttributionIdentifier property is set
        internal bool IsSetRevenueAttributionIdentifier()
        {
            return this._revenueAttributionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionRevision. 
        /// <para>
        /// Point-in-time revision number to query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string RevenueAttributionRevision
        {
            get { return this._revenueAttributionRevision; }
            set { this._revenueAttributionRevision = value; }
        }

        // Check to see if RevenueAttributionRevision property is set
        internal bool IsSetRevenueAttributionRevision()
        {
            return this._revenueAttributionRevision != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Field to sort by.
        /// </para>
        /// </summary>
        public RevenueAttributionAllocationSortField SortBy
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
        /// Sort direction. Defaults to ASCENDING.
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
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Filter by allocation status.
        /// </para>
        /// </summary>
        public AllocationStatus StatusFilter
        {
            get { return this._statusFilter; }
            set { this._statusFilter = value; }
        }

        // Check to see if StatusFilter property is set
        internal bool IsSetStatusFilter()
        {
            return this._statusFilter != null;
        }

    }
}