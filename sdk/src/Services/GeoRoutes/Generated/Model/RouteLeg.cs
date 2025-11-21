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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// A leg is a section of a route from one waypoint to the next. A leg could be of type
    /// Vehicle, Pedestrian or Ferry. Legs of different types could occur together within
    /// a single route. For example, a car employing the use of a Ferry will contain Vehicle
    /// legs corresponding to journey on land, and Ferry legs corresponding to the journey
    /// via Ferry.
    /// </summary>
    public partial class RouteLeg
    {
        private RouteFerryLegDetails _ferryLegDetails;
        private RouteLegGeometry _geometry;
        private string _language;
        private RoutePedestrianLegDetails _pedestrianLegDetails;
        private RouteLegTravelMode _travelMode;
        private RouteLegType _type;
        private RouteVehicleLegDetails _vehicleLegDetails;

        /// <summary>
        /// Gets and sets the property FerryLegDetails. 
        /// <para>
        /// FerryLegDetails is populated when the Leg type is Ferry, and provides additional information
        /// that is specific
        /// </para>
        /// </summary>
        public RouteFerryLegDetails FerryLegDetails
        {
            get { return this._ferryLegDetails; }
            set { this._ferryLegDetails = value; }
        }

        // Check to see if FerryLegDetails property is set
        internal bool IsSetFerryLegDetails()
        {
            return this._ferryLegDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Geometry of the area to be avoided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteLegGeometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// List of languages for instructions within steps in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property PedestrianLegDetails. 
        /// <para>
        /// Details related to the pedestrian leg.
        /// </para>
        /// </summary>
        public RoutePedestrianLegDetails PedestrianLegDetails
        {
            get { return this._pedestrianLegDetails; }
            set { this._pedestrianLegDetails = value; }
        }

        // Check to see if PedestrianLegDetails property is set
        internal bool IsSetPedestrianLegDetails()
        {
            return this._pedestrianLegDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Car</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteLegTravelMode TravelMode
        {
            get { return this._travelMode; }
            set { this._travelMode = value; }
        }

        // Check to see if TravelMode property is set
        internal bool IsSetTravelMode()
        {
            return this._travelMode != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteLegType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VehicleLegDetails. 
        /// <para>
        /// Details related to the vehicle leg.
        /// </para>
        /// </summary>
        public RouteVehicleLegDetails VehicleLegDetails
        {
            get { return this._vehicleLegDetails; }
            set { this._vehicleLegDetails = value; }
        }

        // Check to see if VehicleLegDetails property is set
        internal bool IsSetVehicleLegDetails()
        {
            return this._vehicleLegDetails != null;
        }

    }
}