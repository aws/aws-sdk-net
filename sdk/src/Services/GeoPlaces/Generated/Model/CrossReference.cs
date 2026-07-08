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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// A reference to a third-party supplier's identifier for a place, enabling correlation
    /// of places across external systems.
    /// </summary>
    public partial class CrossReference
    {
        private string _source;
        private List<Category> _sourceCategories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private string _sourcePlaceId;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The name of the third-party data supplier (for example, <c>Yelp</c> or <c>TripAdvisor</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCategories. 
        /// <para>
        /// The list of place category identifiers this supplier reference relates to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Category> SourceCategories
        {
            get { return this._sourceCategories; }
            set { this._sourceCategories = value; }
        }

        // Check to see if SourceCategories property is set
        internal bool IsSetSourceCategories()
        {
            return this._sourceCategories != null && (this._sourceCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePlaceId. 
        /// <para>
        /// The place identifier assigned by the third-party supplier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string SourcePlaceId
        {
            get { return this._sourcePlaceId; }
            set { this._sourcePlaceId = value; }
        }

        // Check to see if SourcePlaceId property is set
        internal bool IsSetSourcePlaceId()
        {
            return this._sourcePlaceId != null;
        }

    }
}