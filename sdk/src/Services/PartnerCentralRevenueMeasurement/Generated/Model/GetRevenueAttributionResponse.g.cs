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
    /// This is the response object from the GetRevenueAttribution operation.
    /// </summary>
    public partial class GetRevenueAttributionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the revenue attribution.
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
        /// The catalog that the revenue attribution belongs to.
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
        /// The date when the revenue attribution was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The date from which this revenue attribution is effective, derived from the earliest
        /// allocation start date (YYYY-MM-DD).
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
        /// The date until which this revenue attribution is effective, derived from the latest
        /// allocation end date (YYYY-MM-DD).
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
        /// The unique identifier of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the revenue attribution was last modified.
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
        /// The latest revision of the attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property MarketplaceProduct. 
        /// <para>
        /// The associated AWS Marketplace product listing, if set.
        /// </para>
        /// </summary>
        public MarketplaceProductSummary MarketplaceProduct { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceProduct property is set.
        /// </summary>
        internal bool IsSetMarketplaceProduct() => this.MarketplaceProduct != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the retrieved attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property TenancyModel. 
        /// <para>
        /// The tenancy model for this revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TenancyModel TenancyModel { get; set; }

        /// <summary>
        /// Checks to see if the TenancyModel property is set.
        /// </summary>
        internal bool IsSetTenancyModel() => this.TenancyModel != null;

        /// <summary>
        /// Gets and sets the property TotalActiveRevenueAttributionAllocationCount. 
        /// <para>
        /// The total number of allocations under this revenue attribution whose Status is ACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalActiveRevenueAttributionAllocationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveRevenueAttributionAllocationCount property is set.
        /// </summary>
        internal bool IsSetTotalActiveRevenueAttributionAllocationCount() => this.TotalActiveRevenueAttributionAllocationCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRevenueAttributionAllocationCount. 
        /// <para>
        /// The total number of allocations under this revenue attribution, counting both ACTIVE
        /// and INACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalRevenueAttributionAllocationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRevenueAttributionAllocationCount property is set.
        /// </summary>
        internal bool IsSetTotalRevenueAttributionAllocationCount() => this.TotalRevenueAttributionAllocationCount.HasValue;
    }
}
