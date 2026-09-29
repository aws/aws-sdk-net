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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Object containing all the filter fields for resale authorization entity. Client can
    /// add only one wildcard filter and a maximum of 8 filters in a single <c>ListEntities</c>
    /// request.
    /// </summary>
    public partial class ResaleAuthorizationFilters
    {
        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// Allows filtering on the <c>AvailabilityEndDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationAvailabilityEndDateFilter AvailabilityEndDate { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityEndDate property is set.
        /// </summary>
        internal bool IsSetAvailabilityEndDate() => this.AvailabilityEndDate != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Allows filtering on the <c>CreatedDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationCreatedDateFilter CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on the <c>EntityId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property IssuerAccountId. 
        /// <para>
        /// Allows filtering on the <c>IssuerAccountId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationIssuerAccountIdFilter IssuerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the IssuerAccountId property is set.
        /// </summary>
        internal bool IsSetIssuerAccountId() => this.IssuerAccountId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Allows filtering on the <c>LastModifiedDate</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationLastModifiedDateFilter LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property ManufacturerAccountId. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerAccountId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationManufacturerAccountIdFilter ManufacturerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManufacturerAccountId property is set.
        /// </summary>
        internal bool IsSetManufacturerAccountId() => this.ManufacturerAccountId != null;

        /// <summary>
        /// Gets and sets the property ManufacturerLegalName. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerLegalName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationManufacturerLegalNameFilter ManufacturerLegalName { get; set; }

        /// <summary>
        /// Checks to see if the ManufacturerLegalName property is set.
        /// </summary>
        internal bool IsSetManufacturerLegalName() => this.ManufacturerLegalName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <c>Name</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationNameFilter Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OfferExtendedStatus. 
        /// <para>
        /// Allows filtering on the <c>OfferExtendedStatus</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationOfferExtendedStatusFilter OfferExtendedStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfferExtendedStatus property is set.
        /// </summary>
        internal bool IsSetOfferExtendedStatus() => this.OfferExtendedStatus != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// Allows filtering on the <c>ProductId</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationProductIdFilter ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// Allows filtering on the <c>ProductName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationProductNameFilter ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ResellerAccountID. 
        /// <para>
        /// Allows filtering on the <c>ResellerAccountID</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerAccountIDFilter ResellerAccountID { get; set; }

        /// <summary>
        /// Checks to see if the ResellerAccountID property is set.
        /// </summary>
        internal bool IsSetResellerAccountID() => this.ResellerAccountID != null;

        /// <summary>
        /// Gets and sets the property ResellerLegalName. 
        /// <para>
        /// Allows filtering on the <c>ResellerLegalName</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerLegalNameFilter ResellerLegalName { get; set; }

        /// <summary>
        /// Checks to see if the ResellerLegalName property is set.
        /// </summary>
        internal bool IsSetResellerLegalName() => this.ResellerLegalName != null;

        /// <summary>
        /// Gets and sets the property ResellerRole. 
        /// <para>
        /// Allows filtering on the <c>ResellerRole</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerRoleFilter ResellerRole { get; set; }

        /// <summary>
        /// Checks to see if the ResellerRole property is set.
        /// </summary>
        internal bool IsSetResellerRole() => this.ResellerRole != null;

        /// <summary>
        /// Gets and sets the property SourceAuthorization. 
        /// <para>
        /// Allows filtering on the <c>SourceAuthorization</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationSourceAuthorizationFilter SourceAuthorization { get; set; }

        /// <summary>
        /// Checks to see if the SourceAuthorization property is set.
        /// </summary>
        internal bool IsSetSourceAuthorization() => this.SourceAuthorization != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Allows filtering on the <c>Status</c> of a ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationStatusFilter Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
