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
    /// This is the response object from the CreateMarketplaceRevenueShareAllocation operation.
    /// </summary>
    public partial class CreateMarketplaceRevenueShareAllocationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdDate;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private DateTime? _lastModifiedDate;
        private string _latestMarketplaceRevenueShareRevision;
        private string _marketplaceRevenueShareAllocationId;
        private string _productId;
        private string _productName;
        private string _revenueSharePercent;
        private AllocationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the allocation.
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the allocation was created.
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
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The effective start date of the allocation.
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
        /// The effective end date of the allocation, or null if open-ended.
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the allocation was last modified.
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
        /// Gets and sets the property LatestMarketplaceRevenueShareRevision. 
        /// <para>
        /// The latest revision of the parent marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string LatestMarketplaceRevenueShareRevision
        {
            get { return this._latestMarketplaceRevenueShareRevision; }
            set { this._latestMarketplaceRevenueShareRevision = value; }
        }

        // Check to see if LatestMarketplaceRevenueShareRevision property is set
        internal bool IsSetLatestMarketplaceRevenueShareRevision()
        {
            return this._latestMarketplaceRevenueShareRevision != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceRevenueShareAllocationId. 
        /// <para>
        /// The unique identifier of the newly created allocation.
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier.
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
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// The revenue share percentage.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllocationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}