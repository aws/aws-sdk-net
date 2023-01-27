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
    /// Contains a search result from a text search query that is run on a place index resource.
    /// </summary>
    public partial class SearchForTextResult
    {
        private double? _distance;
        private Place _place;
        private string _placeId;
        private double? _relevance;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance in meters of a great-circle arc between the bias position specified and
        /// the result. <code>Distance</code> will be returned only if a bias position was specified
        /// in the query.
        /// </para>
        ///  <note> 
        /// <para>
        /// A great-circle arc is the shortest path on a sphere, in this case the Earth. This
        /// returns the shortest distance between two locations.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Distance
        {
            get { return this._distance.GetValueOrDefault(); }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// Details about the search result, such as its address and position.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Place Place
        {
            get { return this._place; }
            set { this._place = value; }
        }

        // Check to see if Place property is set
        internal bool IsSetPlace()
        {
            return this._place != null;
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The unique identifier of the place. You can use this with the <code>GetPlace</code>
        /// operation to find the place again later.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <code>SearchPlaceIndexForText</code> operations, the <code>PlaceId</code> is returned
        /// only by place indexes that use HERE or Grab as a data provider.
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
        /// Gets and sets the property Relevance. 
        /// <para>
        /// The relative confidence in the match for a result among the results returned. For
        /// example, if more fields for an address match (including house number, street, city,
        /// country/region, and postal code), the relevance score is closer to 1.
        /// </para>
        ///  
        /// <para>
        /// Returned only when the partner selected is Esri or Grab.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double Relevance
        {
            get { return this._relevance.GetValueOrDefault(); }
            set { this._relevance = value; }
        }

        // Check to see if Relevance property is set
        internal bool IsSetRelevance()
        {
            return this._relevance.HasValue; 
        }

    }
}