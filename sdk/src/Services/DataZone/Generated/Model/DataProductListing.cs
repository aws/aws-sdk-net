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
    /// The data product listing.
    /// </summary>
    public partial class DataProductListing
    {
        private DateTime? _createdAt;
        private string _dataProductId;
        private string _dataProductRevision;
        private string _forms;
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private List<ListingSummary> _items = AWSConfigs.InitializeCollections ? new List<ListingSummary>() : null;
        private string _owningProjectId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the data product listing was created.
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
        /// Gets and sets the property DataProductId. 
        /// <para>
        /// The ID of the data product listing.
        /// </para>
        /// </summary>
        public string DataProductId
        {
            get { return this._dataProductId; }
            set { this._dataProductId = value; }
        }

        // Check to see if DataProductId property is set
        internal bool IsSetDataProductId()
        {
            return this._dataProductId != null;
        }

        /// <summary>
        /// Gets and sets the property DataProductRevision. 
        /// <para>
        /// The revision of the data product listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DataProductRevision
        {
            get { return this._dataProductRevision; }
            set { this._dataProductRevision = value; }
        }

        // Check to see if DataProductRevision property is set
        internal bool IsSetDataProductRevision()
        {
            return this._dataProductRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The metadata forms of the data product listing.
        /// </para>
        /// </summary>
        public string Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms of the data product listing.
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
        /// The data assets of the data product listing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListingSummary> Items
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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the owning project of the data product listing.
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