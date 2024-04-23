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
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _placeId;
        private List<string> _supplementalCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The unique identifier of the Place. You can use this with the <c>GetPlace</c> operation
        /// to find the place again later, or to get full information for the Place.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetPlace</c> request must use the same <c>PlaceIndex</c> resource as the <c>SearchPlaceIndexForSuggestions</c>
        /// that generated the Place ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <c>SearchPlaceIndexForSuggestions</c> operations, the <c>PlaceId</c> is returned
        /// by place indexes that use Esri, Grab, or HERE as data providers.
        /// </para>
        ///  </note> 
        /// <para>
        /// While you can use PlaceID in subsequent requests, PlaceID is not intended to be a
        /// permanent identifier and the ID can change between consecutive API calls. Please see
        /// the following PlaceID behaviour for each data provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Esri: Place IDs will change every quarter at a minimum. The typical time period for
        /// these changes would be March, June, September, and December. Place IDs might also
        /// change between the typical quarterly change but that will be much less frequent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HERE: We recommend that you cache data for no longer than a week to keep your data
        /// data fresh. You can assume that less than 1% ID shifts will release over release which
        /// is approximately 1 - 2 times per week.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grab: Place IDs can expire or become invalid in the following situations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data operations: The POI may be removed from Grab POI database by Grab Map Ops based
        /// on the ground-truth, such as being closed in the real world, being detected as a duplicate
        /// POI, or having incorrect information. Grab will synchronize data to the Waypoint environment
        /// on weekly basis.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Interpolated POI: Interpolated POI is a temporary POI generated in real time when
        /// serving a request, and it will be marked as derived in the <c>place.result_type</c>
        /// field in the response. The information of interpolated POIs will be retained for at
        /// least 30 days, which means that within 30 days, you are able to obtain POI details
        /// by Place ID from Place Details API. After 30 days, the interpolated POIs(both Place
        /// ID and details) may expire and inaccessible from the Places Details API.
        /// </para>
        ///  </li> </ul> </li> </ul>
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
            return this._supplementalCategories != null && (this._supplementalCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
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