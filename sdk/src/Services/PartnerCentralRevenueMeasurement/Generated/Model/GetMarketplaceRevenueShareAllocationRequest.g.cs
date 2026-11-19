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
    /// Container for the parameters to the GetMarketplaceRevenueShareAllocation operation.
    /// Retrieves the details of a specific marketplace revenue share allocation.
    /// </summary>
    public partial class GetMarketplaceRevenueShareAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that the allocation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The unique identifier of the allocation to retrieve.
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
        /// The revision of the parent marketplace revenue share at which to retrieve the allocation.
        /// Omit to return the latest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string MarketplaceRevenueShareRevision { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareRevision property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareRevision() => this.MarketplaceRevenueShareRevision != null;
    }
}
