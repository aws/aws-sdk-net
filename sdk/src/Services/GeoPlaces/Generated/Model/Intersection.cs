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
    /// All Intersections that are near the provided address.
    /// </summary>
    public partial class Intersection
    {
        private List<AccessPoint> _accessPoints = AWSConfigs.InitializeCollections ? new List<AccessPoint>() : null;
        private Address _address;
        private long? _distance;
        private List<double> _mapView = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private string _placeId;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private long? _routeDistance;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccessPoints. 
        /// <para>
        /// Position of the access point represented by longitude and latitude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AccessPoint> AccessPoints
        {
            get { return this._accessPoints; }
            set { this._accessPoints = value; }
        }

        // Check to see if AccessPoints property is set
        internal bool IsSetAccessPoints()
        {
            return this._accessPoints != null && (this._accessPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance in meters from the QueryPosition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Distance
        {
            get { return this._distance; }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapView. 
        /// <para>
        /// The bounding box enclosing the geometric shape (area or line) that an individual result
        /// covers.
        /// </para>
        ///  
        /// <para>
        /// The bounding box formed is defined as a set of four coordinates: <c>[{westward lng},
        /// {southern lat}, {eastward lng}, {northern lat}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=4)]
        public List<double> MapView
        {
            get { return this._mapView; }
            set { this._mapView = value; }
        }

        // Check to see if MapView property is set
        internal bool IsSetMapView()
        {
            return this._mapView != null && (this._mapView.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=500)]
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
        /// Gets and sets the property Position. 
        /// <para>
        /// The position, in longitude and latitude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteDistance. 
        /// <para>
        /// The distance from the routing position of the nearby address to the street result.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? RouteDistance
        {
            get { return this._routeDistance; }
            set { this._routeDistance = value; }
        }

        // Check to see if RouteDistance property is set
        internal bool IsSetRouteDistance()
        {
            return this._routeDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The localized display name of this result item based on request parameter <c>language</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}