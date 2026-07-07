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
    /// Container for the parameters to the GetMarketplaceRevenueShareAllocation operation.
    /// Retrieves the details of a specific marketplace revenue share allocation.
    /// </summary>
    public partial class GetMarketplaceRevenueShareAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private string _marketplaceRevenueShareAllocationId;
        private string _marketplaceRevenueShareRevision;
        private string _productId;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that the allocation belongs to.
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
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The unique identifier of the allocation to retrieve.
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
        /// The revision of the parent marketplace revenue share at which to retrieve the allocation.
        /// Omit to return the latest.
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier of the parent revenue share.
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

    }
}