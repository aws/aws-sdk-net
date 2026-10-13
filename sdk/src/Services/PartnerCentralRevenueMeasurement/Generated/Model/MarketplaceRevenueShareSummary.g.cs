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
        [AWSProperty(Required = true)]
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
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the marketplace revenue share was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision number of the marketplace revenue share.
        /// </para>
        /// </summary>
        public int? LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision.HasValue;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The AWS Marketplace product code.
        /// </para>
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The display name of the AWS Marketplace product.
        /// </para>
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property TotalActiveMarketplaceRevenueShareAllocationCount. 
        /// <para>
        /// The number of active allocations under this share.
        /// </para>
        /// </summary>
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
        public int? TotalMarketplaceRevenueShareAllocationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalMarketplaceRevenueShareAllocationCount property is set.
        /// </summary>
        internal bool IsSetTotalMarketplaceRevenueShareAllocationCount() => this.TotalMarketplaceRevenueShareAllocationCount.HasValue;
    }
}
