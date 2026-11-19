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
    /// Summary information about a marketplace revenue share.
    /// </summary>
    public partial class MarketplaceRevenueShareSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that the marketplace revenue share belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the marketplace revenue share was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The date from which this share is effective, derived from the earliest ACTIVE allocation
        /// start date (YYYY-MM-DD). Absent when no ACTIVE allocation remains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveFrom property is set.
        /// </summary>
        internal bool IsSetEffectiveFrom() => this.EffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// The date until which this share is effective, derived from the latest ACTIVE allocation
        /// end date (YYYY-MM-DD). Absent when no ACTIVE allocation remains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string EffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveUntil property is set.
        /// </summary>
        internal bool IsSetEffectiveUntil() => this.EffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the marketplace revenue share, short ID form (mrs-...).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the marketplace revenue share was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property Products. 
        /// <para>
        /// The products in the marketplace revenue share, each with per-type account counts.
        /// Empty when the share is closed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<MarketplaceRevenueShareProductSummary> Products { get; set; } = AWSConfigs.InitializeCollections ? new List<MarketplaceRevenueShareProductSummary>() : null;

        /// <summary>
        /// Checks to see if the Products property is set.
        /// </summary>
        internal bool IsSetProducts() => this.Products != null && (this.Products.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalActiveMarketplaceRevenueShareAllocationCount. 
        /// <para>
        /// The number of active allocations under this share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalActiveMarketplaceRevenueShareAllocationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveMarketplaceRevenueShareAllocationCount property is set.
        /// </summary>
        internal bool IsSetTotalActiveMarketplaceRevenueShareAllocationCount() => this.TotalActiveMarketplaceRevenueShareAllocationCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMarketplaceRevenueShareAllocationCount. 
        /// <para>
        /// The total number of allocations under this share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalMarketplaceRevenueShareAllocationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalMarketplaceRevenueShareAllocationCount property is set.
        /// </summary>
        internal bool IsSetTotalMarketplaceRevenueShareAllocationCount() => this.TotalMarketplaceRevenueShareAllocationCount.HasValue;
    }
}
