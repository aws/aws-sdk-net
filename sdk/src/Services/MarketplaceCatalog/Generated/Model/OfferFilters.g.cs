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
    /// Object containing all the filter fields for offers entity. Client can add only one
    /// wildcard filter and a maximum of 8 filters in a single <c>ListEntities</c> request.
    /// </summary>
    public partial class OfferFilters
    {
        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// Allows filtering on the <c>AvailabilityEndDate</c> of an offer.
        /// </para>
        /// </summary>
        public OfferAvailabilityEndDateFilter AvailabilityEndDate { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityEndDate property is set.
        /// </summary>
        internal bool IsSetAvailabilityEndDate() => this.AvailabilityEndDate != null;

        /// <summary>
        /// Gets and sets the property BuyerAccounts. 
        /// <para>
        /// Allows filtering on the <c>BuyerAccounts</c> of an offer.
        /// </para>
        /// </summary>
        public OfferBuyerAccountsFilter BuyerAccounts { get; set; }

        /// <summary>
        /// Checks to see if the BuyerAccounts property is set.
        /// </summary>
        internal bool IsSetBuyerAccounts() => this.BuyerAccounts != null;

        /// <summary>
        /// Gets and sets the property CreatedBySource. 
        /// <para>
        /// Allows filtering on the <c>CreatedBySource</c> of an offer.
        /// </para>
        /// </summary>
        public OfferCreatedBySourceFilter CreatedBySource { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBySource property is set.
        /// </summary>
        internal bool IsSetCreatedBySource() => this.CreatedBySource != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on <c>EntityId</c> of an offer.
        /// </para>
        /// </summary>
        public OfferEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Allows filtering on the <c>LastModifiedDate</c> of an offer.
        /// </para>
        /// </summary>
        public OfferLastModifiedDateFilter LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <c>Name</c> of an offer.
        /// </para>
        /// </summary>
        public OfferNameFilter Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OfferSetId. 
        /// <para>
        /// Allows filtering on the <c>OfferSetId</c> of an offer.
        /// </para>
        /// </summary>
        public OfferSetIdFilter OfferSetId { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetId property is set.
        /// </summary>
        internal bool IsSetOfferSetId() => this.OfferSetId != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// Allows filtering on the <c>ProductId</c> of an offer.
        /// </para>
        /// </summary>
        public OfferProductIdFilter ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// Allows filtering on the <c>ReleaseDate</c> of an offer.
        /// </para>
        /// </summary>
        public OfferReleaseDateFilter ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate != null;

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationId. 
        /// <para>
        /// Allows filtering on the <c>ResaleAuthorizationId</c> of an offer.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all offers have a <c>ResaleAuthorizationId</c>. The response will only include
        /// offers for which you have permissions.
        /// </para>
        ///  </note>
        /// </summary>
        public OfferResaleAuthorizationIdFilter ResaleAuthorizationId { get; set; }

        /// <summary>
        /// Checks to see if the ResaleAuthorizationId property is set.
        /// </summary>
        internal bool IsSetResaleAuthorizationId() => this.ResaleAuthorizationId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Allows filtering on the <c>State</c> of an offer.
        /// </para>
        /// </summary>
        public OfferStateFilter State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetAgreementId. 
        /// <para>
        /// Allows filtering on the <c>TargetAgreementId</c> of an offer.
        /// </para>
        /// </summary>
        public OfferTargetAgreementIdFilter TargetAgreementId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAgreementId property is set.
        /// </summary>
        internal bool IsSetTargetAgreementId() => this.TargetAgreementId != null;

        /// <summary>
        /// Gets and sets the property TargetAgreementIntent. 
        /// <para>
        /// Allows filtering on the <c>TargetAgreementIntent</c> of an offer.
        /// </para>
        /// </summary>
        public OfferTargetAgreementIntentFilter TargetAgreementIntent { get; set; }

        /// <summary>
        /// Checks to see if the TargetAgreementIntent property is set.
        /// </summary>
        internal bool IsSetTargetAgreementIntent() => this.TargetAgreementIntent != null;

        /// <summary>
        /// Gets and sets the property Targeting. 
        /// <para>
        /// Allows filtering on the <c>Targeting</c> of an offer.
        /// </para>
        /// </summary>
        public OfferTargetingFilter Targeting { get; set; }

        /// <summary>
        /// Checks to see if the Targeting property is set.
        /// </summary>
        internal bool IsSetTargeting() => this.Targeting != null;
    }
}
