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
    /// This is the response object from the GetRevenueAttribution operation.
    /// </summary>
    public partial class GetRevenueAttributionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private CatalogName _catalog;
        private DateTime? _createdDate;
        private string _description;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private string _id;
        private DateTime? _lastModifiedDate;
        private string _latestRevision;
        private MarketplaceProductSummary _marketplaceProduct;
        private string _name;
        private string _revision;
        private TenancyModel _tenancyModel;
        private int? _totalActiveRevenueAttributionAllocationCount;
        private int? _totalRevenueAttributionAllocationCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that the revenue attribution belongs to.
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the revenue attribution was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The date from which this revenue attribution is effective, derived from the earliest
        /// allocation start date (YYYY-MM-DD).
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
        /// The date until which this revenue attribution is effective, derived from the latest
        /// allocation end date (YYYY-MM-DD).
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the revenue attribution was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceProduct. 
        /// <para>
        /// The associated AWS Marketplace product listing, if set.
        /// </para>
        /// </summary>
        public MarketplaceProductSummary MarketplaceProduct
        {
            get { return this._marketplaceProduct; }
            set { this._marketplaceProduct = value; }
        }

        // Check to see if MarketplaceProduct property is set
        internal bool IsSetMarketplaceProduct()
        {
            return this._marketplaceProduct != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the retrieved attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property TenancyModel. 
        /// <para>
        /// The tenancy model for this revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TenancyModel TenancyModel
        {
            get { return this._tenancyModel; }
            set { this._tenancyModel = value; }
        }

        // Check to see if TenancyModel property is set
        internal bool IsSetTenancyModel()
        {
            return this._tenancyModel != null;
        }

        /// <summary>
        /// Gets and sets the property TotalActiveRevenueAttributionAllocationCount. 
        /// <para>
        /// The total number of allocations under this revenue attribution whose Status is ACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalActiveRevenueAttributionAllocationCount
        {
            get { return this._totalActiveRevenueAttributionAllocationCount; }
            set { this._totalActiveRevenueAttributionAllocationCount = value; }
        }

        // Check to see if TotalActiveRevenueAttributionAllocationCount property is set
        internal bool IsSetTotalActiveRevenueAttributionAllocationCount()
        {
            return this._totalActiveRevenueAttributionAllocationCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRevenueAttributionAllocationCount. 
        /// <para>
        /// The total number of allocations under this revenue attribution, counting both ACTIVE
        /// and INACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalRevenueAttributionAllocationCount
        {
            get { return this._totalRevenueAttributionAllocationCount; }
            set { this._totalRevenueAttributionAllocationCount = value; }
        }

        // Check to see if TotalRevenueAttributionAllocationCount property is set
        internal bool IsSetTotalRevenueAttributionAllocationCount()
        {
            return this._totalRevenueAttributionAllocationCount.HasValue; 
        }

    }
}