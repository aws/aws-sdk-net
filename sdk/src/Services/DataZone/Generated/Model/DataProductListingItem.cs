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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The asset of the data product listing.
    /// </summary>
    public partial class DataProductListingItem
    {
        private DataProductListingItemAdditionalAttributes _additionalAttributes;
        private DateTime? _createdAt;
        private string _description;
        private string _entityId;
        private string _entityRevision;
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private List<ListingSummaryItem> _items = AWSConfigs.InitializeCollections ? new List<ListingSummaryItem>() : null;
        private string _listingCreatedBy;
        private string _listingId;
        private string _listingRevision;
        private string _listingUpdatedBy;
        private string _name;
        private string _owningProjectId;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional attributes of the asset of the data product.
        /// </para>
        /// </summary>
        public DataProductListingItemAdditionalAttributes AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the asset of the data product listing was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity ID of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        public string EntityId
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
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The revision of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EntityRevision
        {
            get { return this._entityRevision; }
            set { this._entityRevision = value; }
        }

        // Check to see if EntityRevision property is set
        internal bool IsSetEntityRevision()
        {
            return this._entityRevision != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms of the asset of the asset of the data product. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The data of the asset of the data product. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListingSummaryItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListingCreatedBy. 
        /// <para>
        /// The timestamp at which the listing was created.
        /// </para>
        /// </summary>
        public string ListingCreatedBy
        {
            get { return this._listingCreatedBy; }
            set { this._listingCreatedBy = value; }
        }

        // Check to see if ListingCreatedBy property is set
        internal bool IsSetListingCreatedBy()
        {
            return this._listingCreatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The ID of the listing.
        /// </para>
        /// </summary>
        public string ListingId
        {
            get { return this._listingId; }
            set { this._listingId = value; }
        }

        // Check to see if ListingId property is set
        internal bool IsSetListingId()
        {
            return this._listingId != null;
        }

        /// <summary>
        /// Gets and sets the property ListingRevision. 
        /// <para>
        /// The revision of the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ListingRevision
        {
            get { return this._listingRevision; }
            set { this._listingRevision = value; }
        }

        // Check to see if ListingRevision property is set
        internal bool IsSetListingRevision()
        {
            return this._listingRevision != null;
        }

        /// <summary>
        /// Gets and sets the property ListingUpdatedBy. 
        /// <para>
        /// The user who updated the listing.
        /// </para>
        /// </summary>
        public string ListingUpdatedBy
        {
            get { return this._listingUpdatedBy; }
            set { this._listingUpdatedBy = value; }
        }

        // Check to see if ListingUpdatedBy property is set
        internal bool IsSetListingUpdatedBy()
        {
            return this._listingUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the owning project of the asset of the data product. 
        /// </para>
        /// </summary>
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

    }
}