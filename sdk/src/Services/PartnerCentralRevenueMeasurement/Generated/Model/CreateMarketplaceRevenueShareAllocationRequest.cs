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
    /// Container for the parameters to the CreateMarketplaceRevenueShareAllocation operation.
    /// Creates a new marketplace revenue share allocation for the specified product.
    /// </summary>
    public partial class CreateMarketplaceRevenueShareAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private string _clientToken;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private string _productId;
        private string _revenueSharePercent;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which to create the allocation.
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
        /// A unique token to ensure idempotency of the create request.
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
        /// The effective start date for the allocation. Must be the first day of a month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// The effective end date for the allocation. Must be the last day of a month (YYYY-MM-DD).
        /// Omit for open-ended allocations.
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
        /// The revenue share percentage for this allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
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

    }
}