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
    /// The summary of the listing of the data product.
    /// </summary>
    public partial class ListingSummary
    {
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private string _listingId;
        private string _listingRevision;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms of the data product.
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
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The ID of the data product listing.
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
        /// The revision of the data product listing.
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

    }
}