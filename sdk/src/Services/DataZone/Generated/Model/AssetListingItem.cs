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
    /// The details of an asset published in an Amazon DataZone catalog.
    /// </summary>
    public partial class AssetListingItem
    {
        private AssetListingItemAdditionalAttributes _additionalAttributes;
        private DateTime? _createdAt;
        private string _description;
        private string _entityId;
        private string _entityRevision;
        private string _entityType;
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private List<DetailedGlossaryTerm> _governedGlossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private string _listingCreatedBy;
        private string _listingId;
        private string _listingRevision;
        private string _listingUpdatedBy;
        private string _name;
        private string _owningProjectId;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional attributes of an asset published in an Amazon DataZone catalog.
        /// </para>
        /// </summary>
        public AssetListingItemAdditionalAttributes AdditionalAttributes
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
        /// The timestamp of when an asset published in an Amazon DataZone catalog was created.
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
        /// The description of an asset published in an Amazon DataZone catalog.
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
        /// The identifier of the inventory asset.
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
        /// The revision of the inventory asset.
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
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// Glossary terms attached to the inventory asset.
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
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms associated with an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DetailedGlossaryTerm> GovernedGlossaryTerms
        {
            get { return this._governedGlossaryTerms; }
            set { this._governedGlossaryTerms = value; }
        }

        // Check to see if GovernedGlossaryTerms property is set
        internal bool IsSetGovernedGlossaryTerms()
        {
            return this._governedGlossaryTerms != null && (this._governedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListingCreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the listing.
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
        /// The identifier of the listing (asset published in Amazon DataZone catalog).
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
        /// The revision of the listing (asset published in Amazon DataZone catalog).
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
        /// The Amazon DataZone user who updated the listing.
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
        /// The name of the inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        /// The identifier of the project that owns the inventory asset.
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