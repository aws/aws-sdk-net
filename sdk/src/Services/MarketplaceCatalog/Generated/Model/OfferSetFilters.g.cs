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
    /// Object containing all the filter fields for offer sets entity. Client can add a maximum
    /// of 8 filters in a single <c>ListEntities</c> request.
    /// </summary>
    public partial class OfferSetFilters
    {
        /// <summary>
        /// Gets and sets the property AssociatedOfferIds. 
        /// <para>
        /// Allows filtering on the <c>AssociatedOfferIds</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetAssociatedOfferIdsFilter AssociatedOfferIds { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedOfferIds property is set.
        /// </summary>
        internal bool IsSetAssociatedOfferIds() => this.AssociatedOfferIds != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on <c>EntityId</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Allows filtering on the <c>LastModifiedDate</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetLastModifiedDateFilter LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <c>Name</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetNameFilter Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// Allows filtering on the <c>ReleaseDate</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetReleaseDateFilter ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate != null;

        /// <summary>
        /// Gets and sets the property SolutionId. 
        /// <para>
        /// Allows filtering on the <c>SolutionId</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetSolutionIdFilter SolutionId { get; set; }

        /// <summary>
        /// Checks to see if the SolutionId property is set.
        /// </summary>
        internal bool IsSetSolutionId() => this.SolutionId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Allows filtering on the <c>State</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetStateFilter State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
