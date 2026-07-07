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
    /// This is the response object from the GetMarketplaceRevenueShare operation.
    /// </summary>
    public partial class GetMarketplaceRevenueShareResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private CatalogName _catalog;
        private DateTime? _createdDate;
        private DateTime? _lastModifiedDate;
        private int? _latestRevision;
        private string _productCode;
        private string _productId;
        private string _productName;
        private int? _revision;
        private int? _totalActiveMarketplaceRevenueShareAllocationCount;
        private int? _totalMarketplaceRevenueShareAllocationCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the marketplace revenue share.
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
        /// The catalog that the marketplace revenue share belongs to.
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
        /// The date when the marketplace revenue share was created.
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the marketplace revenue share was last modified.
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
        /// The latest revision number of the marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The AWS Marketplace product code.
        /// </para>
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier of the revenue share.
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
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The display name of the AWS Marketplace product.
        /// </para>
        /// </summary>
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the retrieved marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalActiveMarketplaceRevenueShareAllocationCount. 
        /// <para>
        /// The number of active allocations under this marketplace revenue share.
        /// </para>
        /// </summary>
        public int? TotalActiveMarketplaceRevenueShareAllocationCount
        {
            get { return this._totalActiveMarketplaceRevenueShareAllocationCount; }
            set { this._totalActiveMarketplaceRevenueShareAllocationCount = value; }
        }

        // Check to see if TotalActiveMarketplaceRevenueShareAllocationCount property is set
        internal bool IsSetTotalActiveMarketplaceRevenueShareAllocationCount()
        {
            return this._totalActiveMarketplaceRevenueShareAllocationCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMarketplaceRevenueShareAllocationCount. 
        /// <para>
        /// The total number of allocations under this marketplace revenue share.
        /// </para>
        /// </summary>
        public int? TotalMarketplaceRevenueShareAllocationCount
        {
            get { return this._totalMarketplaceRevenueShareAllocationCount; }
            set { this._totalMarketplaceRevenueShareAllocationCount = value; }
        }

        // Check to see if TotalMarketplaceRevenueShareAllocationCount property is set
        internal bool IsSetTotalMarketplaceRevenueShareAllocationCount()
        {
            return this._totalMarketplaceRevenueShareAllocationCount.HasValue; 
        }

    }
}