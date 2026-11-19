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
    /// Summary information about a marketplace revenue share allocation.
    /// </summary>
    public partial class MarketplaceRevenueShareAllocationSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the allocation was created.
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
        /// The effective start date of the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveFrom property is set.
        /// </summary>
        internal bool IsSetEffectiveFrom() => this.EffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// The effective end date of the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveUntil property is set.
        /// </summary>
        internal bool IsSetEffectiveUntil() => this.EffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the allocation was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The unique identifier of the allocation.
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
        /// The parent marketplace revenue share, short ID form (mrs-...).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string MarketplaceRevenueShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceRevenueShareIdentifier property is set.
        /// </summary>
        internal bool IsSetMarketplaceRevenueShareIdentifier() => this.MarketplaceRevenueShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// The revenue share percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public string RevenueSharePercent { get; set; }

        /// <summary>
        /// Checks to see if the RevenueSharePercent property is set.
        /// </summary>
        internal bool IsSetRevenueSharePercent() => this.RevenueSharePercent != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
