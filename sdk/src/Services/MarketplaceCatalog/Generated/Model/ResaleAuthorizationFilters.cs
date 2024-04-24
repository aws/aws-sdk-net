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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Object containing all the filter fields for resale authorization entity. Client can
    /// add only one wildcard filter and a maximum of 8 filters in a single <c>ListEntities</c>
    /// request.
    /// </summary>
    public partial class ResaleAuthorizationFilters
    {
        private ResaleAuthorizationAvailabilityEndDateFilter _availabilityEndDate;
        private ResaleAuthorizationCreatedDateFilter _createdDate;
        private ResaleAuthorizationEntityIdFilter _entityId;
        private ResaleAuthorizationLastModifiedDateFilter _lastModifiedDate;
        private ResaleAuthorizationManufacturerAccountIdFilter _manufacturerAccountId;
        private ResaleAuthorizationManufacturerLegalNameFilter _manufacturerLegalName;
        private ResaleAuthorizationNameFilter _name;
        private ResaleAuthorizationOfferExtendedStatusFilter _offerExtendedStatus;
        private ResaleAuthorizationProductIdFilter _productId;
        private ResaleAuthorizationProductNameFilter _productName;
        private ResaleAuthorizationResellerAccountIDFilter _resellerAccountID;
        private ResaleAuthorizationResellerLegalNameFilter _resellerLegalName;
        private ResaleAuthorizationStatusFilter _status;

        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// Allows filtering on the <c>AvailabilityEndDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationAvailabilityEndDateFilter AvailabilityEndDate
        {
            get { return this._availabilityEndDate; }
            set { this._availabilityEndDate = value; }
        }

        // Check to see if AvailabilityEndDate property is set
        internal bool IsSetAvailabilityEndDate()
        {
            return this._availabilityEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Allows filtering on the <c>CreatedDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationCreatedDateFilter CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on the <c>EntityId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationEntityIdFilter EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Allows filtering on the <c>LastModifiedDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationLastModifiedDateFilter LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerAccountId. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerAccountId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationManufacturerAccountIdFilter ManufacturerAccountId
        {
            get { return this._manufacturerAccountId; }
            set { this._manufacturerAccountId = value; }
        }

        // Check to see if ManufacturerAccountId property is set
        internal bool IsSetManufacturerAccountId()
        {
            return this._manufacturerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerLegalName. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerLegalName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationManufacturerLegalNameFilter ManufacturerLegalName
        {
            get { return this._manufacturerLegalName; }
            set { this._manufacturerLegalName = value; }
        }

        // Check to see if ManufacturerLegalName property is set
        internal bool IsSetManufacturerLegalName()
        {
            return this._manufacturerLegalName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <c>Name</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationNameFilter Name
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
        /// Gets and sets the property OfferExtendedStatus. 
        /// <para>
        /// Allows filtering on the <c>OfferExtendedStatus</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationOfferExtendedStatusFilter OfferExtendedStatus
        {
            get { return this._offerExtendedStatus; }
            set { this._offerExtendedStatus = value; }
        }

        // Check to see if OfferExtendedStatus property is set
        internal bool IsSetOfferExtendedStatus()
        {
            return this._offerExtendedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// Allows filtering on the <c>ProductId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationProductIdFilter ProductId
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
        /// Allows filtering on the <c>ProductName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationProductNameFilter ProductName
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
        /// Gets and sets the property ResellerAccountID. 
        /// <para>
        /// Allows filtering on the <c>ResellerAccountID</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerAccountIDFilter ResellerAccountID
        {
            get { return this._resellerAccountID; }
            set { this._resellerAccountID = value; }
        }

        // Check to see if ResellerAccountID property is set
        internal bool IsSetResellerAccountID()
        {
            return this._resellerAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property ResellerLegalName. 
        /// <para>
        /// Allows filtering on the <c>ResellerLegalName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerLegalNameFilter ResellerLegalName
        {
            get { return this._resellerLegalName; }
            set { this._resellerLegalName = value; }
        }

        // Check to see if ResellerLegalName property is set
        internal bool IsSetResellerLegalName()
        {
            return this._resellerLegalName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Allows filtering on the <c>Status</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationStatusFilter Status
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