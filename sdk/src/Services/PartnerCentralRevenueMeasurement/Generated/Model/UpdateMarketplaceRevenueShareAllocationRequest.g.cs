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
    /// Container for the parameters to the UpdateMarketplaceRevenueShareAllocation operation.
    /// Updates an existing marketplace revenue share allocation. Supports modifying the revenue
    /// share percentage and status only, with time-based mutability rules.
    /// </summary>
    public partial class UpdateMarketplaceRevenueShareAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog containing the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token to ensure idempotency of the update request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The identifier of the allocation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string MarketplaceRevenueShareAllocationId { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareAllocationId property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareAllocationId() => this.MarketplaceRevenueShareAllocationId != null;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareIdentifier. 
        /// <para>
        /// The parent marketplace revenue share, by ID (mrs-...) or ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 1011)]
        public string MarketplaceRevenueShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareIdentifier property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareIdentifier() => this.MarketplaceRevenueShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareRevision. 
        /// <para>
        /// The current revision of the parent share. Must match for optimistic concurrency control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string MarketplaceRevenueShareRevision { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareRevision property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareRevision() => this.MarketplaceRevenueShareRevision != null;

        /// <summary>
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// The new revenue share percentage. Only modifiable on future-dated allocations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string RevenueSharePercent { get; set; }

        /// <summary>
        /// Checks to see if the RevenueSharePercent property is set.
        /// </summary>
        internal bool IsSetRevenueSharePercent() => this.RevenueSharePercent != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status. Set to INACTIVE for soft-delete. Only modifiable on future-dated allocations.
        /// </para>
        /// </summary>
        public AllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
