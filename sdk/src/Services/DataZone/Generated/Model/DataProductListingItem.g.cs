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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The asset of the data product listing.
    /// </summary>
    public partial class DataProductListingItem
    {
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional attributes of the asset of the data product.
        /// </para>
        /// </summary>
        public DataProductListingItemAdditionalAttributes AdditionalAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the asset of the data product listing was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity ID of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The revision of the asset of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EntityRevision { get; set; }

        /// <summary>
        /// Checks to see if the EntityRevision property is set.
        /// </summary>
        internal bool IsSetEntityRevision() => this.EntityRevision != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms of the asset of the asset of the data product. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The data of the asset of the data product. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListingSummaryItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<ListingSummaryItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListingCreatedBy. 
        /// <para>
        /// The timestamp at which the listing was created.
        /// </para>
        /// </summary>
        public string ListingCreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the ListingCreatedBy property is set.
        /// </summary>
        internal bool IsSetListingCreatedBy() => this.ListingCreatedBy != null;

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The ID of the listing.
        /// </para>
        /// </summary>
        public string ListingId { get; set; }

        /// <summary>
        /// Checks to see if the ListingId property is set.
        /// </summary>
        internal bool IsSetListingId() => this.ListingId != null;

        /// <summary>
        /// Gets and sets the property ListingRevision. 
        /// <para>
        /// The revision of the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ListingRevision { get; set; }

        /// <summary>
        /// Checks to see if the ListingRevision property is set.
        /// </summary>
        internal bool IsSetListingRevision() => this.ListingRevision != null;

        /// <summary>
        /// Gets and sets the property ListingUpdatedBy. 
        /// <para>
        /// The user who updated the listing.
        /// </para>
        /// </summary>
        public string ListingUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the ListingUpdatedBy property is set.
        /// </summary>
        internal bool IsSetListingUpdatedBy() => this.ListingUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset of the data product. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the owning project of the asset of the data product. 
        /// </para>
        /// </summary>
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;
    }
}
