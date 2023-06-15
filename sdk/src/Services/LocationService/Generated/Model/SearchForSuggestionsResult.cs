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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains a place suggestion resulting from a place suggestion query that is run on
    /// a place index resource.
    /// </summary>
    public partial class SearchForSuggestionsResult
    {
        private List<string> _categories = new List<string>();
        private string _placeId;
        private List<string> _supplementalCategories = new List<string>();
        private string _text;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The Amazon Location categories that describe the Place.
        /// </para>
        ///  
        /// <para>
        /// For more information about using categories, including a list of Amazon Location categories,
        /// see <a href="https://docs.aws.amazon.com/location/latest/developerguide/category-filtering.html">Categories
        /// and filtering</a>, in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && this._categories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The unique identifier of the Place. You can use this with the <code>GetPlace</code>
        /// operation to find the place again later, or to get full information for the Place.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetPlace</code> request must use the same <code>PlaceIndex</code> resource
        /// as the <code>SearchPlaceIndexForSuggestions</code> that generated the Place ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <code>SearchPlaceIndexForSuggestions</code> operations, the <code>PlaceId</code>
        /// is returned by place indexes that use Esri, Grab, or HERE as data providers.
        /// </para>
        ///  </note>
        /// </summary>
        public string PlaceId
        {
            get { return this._placeId; }
            set { this._placeId = value; }
        }

        // Check to see if PlaceId property is set
        internal bool IsSetPlaceId()
        {
            return this._placeId != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalCategories. 
        /// <para>
        /// Categories from the data provider that describe the Place that are not mapped to any
        /// Amazon Location categories.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SupplementalCategories
        {
            get { return this._supplementalCategories; }
            set { this._supplementalCategories = value; }
        }

        // Check to see if SupplementalCategories property is set
        internal bool IsSetSupplementalCategories()
        {
            return this._supplementalCategories != null && this._supplementalCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text of the place suggestion, typically formatted as an address string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}