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
    /// Container for the parameters to the UpdateMarketplaceRevenueShareAllocation operation.
    /// Updates an existing marketplace revenue share allocation. Supports modifying effective
    /// dates, revenue share percentage, and status with time-based mutability rules.
    /// </summary>
    public partial class UpdateMarketplaceRevenueShareAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private string _clientToken;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private string _marketplaceRevenueShareAllocationId;
        private string _marketplaceRevenueShareRevision;
        private string _productId;
        private string _revenueSharePercent;
        private AllocationStatus _status;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog containing the allocation.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token to ensure idempotency of the update request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The new effective start date. Must be the first day of a month. Only modifiable on
        /// future-dated allocations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string EffectiveFrom
        {
            get { return this._effectiveFrom; }
            set { this._effectiveFrom = value; }
        }

        // Check to see if EffectiveFrom property is set
        internal bool IsSetEffectiveFrom()
        {
            return this._effectiveFrom != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// The new effective end date. Must be the last day of a month and on or after today.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string EffectiveUntil
        {
            get { return this._effectiveUntil; }
            set { this._effectiveUntil = value; }
        }

        // Check to see if EffectiveUntil property is set
        internal bool IsSetEffectiveUntil()
        {
            return this._effectiveUntil != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The identifier of the allocation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=18, Max=18)]
        public string MarketplaceRevenueShareAllocationId
        {
            get { return this._marketplaceRevenueShareAllocationId; }
            set { this._marketplaceRevenueShareAllocationId = value; }
        }

        // Check to see if MarketplaceRevenueShareAllocationId property is set
        internal bool IsSetMarketplaceRevenueShareAllocationId()
        {
            return this._marketplaceRevenueShareAllocationId != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareRevision. 
        /// <para>
        /// The current revision of the parent share. Must match for optimistic concurrency control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=19)]
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
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// The new revenue share percentage. Only modifiable on future-dated allocations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public string RevenueSharePercent
        {
            get { return this._revenueSharePercent; }
            set { this._revenueSharePercent = value; }
        }

        // Check to see if RevenueSharePercent property is set
        internal bool IsSetRevenueSharePercent()
        {
            return this._revenueSharePercent != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status. Set to INACTIVE for soft-delete. Only modifiable on future-dated allocations.
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