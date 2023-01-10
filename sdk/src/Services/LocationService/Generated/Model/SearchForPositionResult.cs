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
    /// Contains a search result from a position search query that is run on a place index
    /// resource.
    /// </summary>
    public partial class SearchForPositionResult
    {
        private double? _distance;
        private Place _place;
        private string _placeId;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance in meters of a great-circle arc between the query position and the result.
        /// </para>
        ///  <note> 
        /// <para>
        /// A great-circle arc is the shortest path on a sphere, in this case the Earth. This
        /// returns the shortest distance between two locations.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// For <code>SearchPlaceIndexForPosition</code> operations, the <code>PlaceId</code>
        /// is returned only by place indexes that use HERE or Grab as a data provider.
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

    }
}