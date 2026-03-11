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
    /// Object containing all the filter fields for offer sets entity. Client can add a maximum
    /// of 8 filters in a single <c>ListEntities</c> request.
    /// </summary>
    public partial class OfferSetFilters
    {
        private OfferSetAssociatedOfferIdsFilter _associatedOfferIds;
        private OfferSetEntityIdFilter _entityId;
        private OfferSetLastModifiedDateFilter _lastModifiedDate;
        private OfferSetNameFilter _name;
        private OfferSetReleaseDateFilter _releaseDate;
        private OfferSetSolutionIdFilter _solutionId;
        private OfferSetStateFilter _state;

        /// <summary>
        /// Gets and sets the property AssociatedOfferIds. 
        /// <para>
        /// Allows filtering on the <c>AssociatedOfferIds</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetAssociatedOfferIdsFilter AssociatedOfferIds
        {
            get { return this._associatedOfferIds; }
            set { this._associatedOfferIds = value; }
        }

        // Check to see if AssociatedOfferIds property is set
        internal bool IsSetAssociatedOfferIds()
        {
            return this._associatedOfferIds != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on <c>EntityId</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetEntityIdFilter EntityId
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
        /// Allows filtering on the <c>LastModifiedDate</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetLastModifiedDateFilter LastModifiedDate
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <c>Name</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetNameFilter Name
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
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// Allows filtering on the <c>ReleaseDate</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetReleaseDateFilter ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionId. 
        /// <para>
        /// Allows filtering on the <c>SolutionId</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetSolutionIdFilter SolutionId
        {
            get { return this._solutionId; }
            set { this._solutionId = value; }
        }

        // Check to see if SolutionId property is set
        internal bool IsSetSolutionId()
        {
            return this._solutionId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Allows filtering on the <c>State</c> of an offer set.
        /// </para>
        /// </summary>
        public OfferSetStateFilter State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}