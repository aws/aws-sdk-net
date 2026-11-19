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
    /// Container for the parameters to the UpdateMarketplaceRevenueShare operation. Replaces
    /// the products of a marketplace revenue share. The request carries the complete desired
    /// set of products and their typed account lists; a product not listed is removed and
    /// its account lists cleared, and an empty Products list closes the marketplace revenue
    /// share. Closing is one-way.
    /// </summary>
    public partial class UpdateMarketplaceRevenueShareRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The marketplace revenue share to update, by ID (mrs-...) or ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 1011)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Products. 
        /// <para>
        /// The complete desired set of products in the marketplace revenue share, each with its
        /// typed account lists. 0 to 25 products; an empty list closes the marketplace revenue
        /// share.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<MarketplaceRevenueShareProductEntry> Products { get; set; } = AWSConfigs.InitializeCollections ? new List<MarketplaceRevenueShareProductEntry>() : null;

        /// <summary>
        /// Checks to see if the Products property is set.
        /// </summary>
        internal bool IsSetProducts() => this.Products != null && (this.Products.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision of the marketplace revenue share, for optimistic concurrency
        /// control. A stale value returns ConflictException with Reason REVISION_MISMATCH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;
    }
}
