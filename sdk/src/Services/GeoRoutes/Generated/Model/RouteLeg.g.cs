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
        /// <summary>
        /// Gets and sets the property FerryLegDetails. 
        /// <para>
        ///  FerryLegDetails is populated when the Leg type is Ferry, and provides additional
        /// information that is specific to ferry travel. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteFerryLegDetails FerryLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the FerryLegDetails property is set.
        /// </summary>
        internal bool IsSetFerryLegDetails() => this.FerryLegDetails != null;

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Geometry of the area to be avoided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteLegGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        ///  List of languages for instructions within steps in the response. Not supported in
        /// <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property PedestrianLegDetails. 
        /// <para>
        /// Details related to the pedestrian leg.
        /// </para>
        /// </summary>
        public RoutePedestrianLegDetails PedestrianLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the PedestrianLegDetails property is set.
        /// </summary>
        internal bool IsSetPedestrianLegDetails() => this.PedestrianLegDetails != null;

        /// <summary>
        /// Gets and sets the property RentalLegDetails. 
        /// <para>
        /// Details related to the rental leg.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteRentalLegDetails RentalLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the RentalLegDetails property is set.
        /// </summary>
        internal bool IsSetRentalLegDetails() => this.RentalLegDetails != null;

        /// <summary>
        /// Gets and sets the property TaxiLegDetails. 
        /// <para>
        /// Details related to the taxi leg.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteTaxiLegDetails TaxiLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaxiLegDetails property is set.
        /// </summary>
        internal bool IsSetTaxiLegDetails() => this.TaxiLegDetails != null;

        /// <summary>
        /// Gets and sets the property TransitLegDetails. 
        /// <para>
        /// Details related to the transit leg.
        /// </para>
        /// </summary>
        public RouteTransitLegDetails TransitLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the TransitLegDetails property is set.
        /// </summary>
        internal bool IsSetTransitLegDetails() => this.TransitLegDetails != null;

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteLegTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteLegType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VehicleLegDetails. 
        /// <para>
        /// Details related to the vehicle leg.
        /// </para>
        /// </summary>
        public RouteVehicleLegDetails VehicleLegDetails { get; set; }

        /// <summary>
        /// Checks to see if the VehicleLegDetails property is set.
        /// </summary>
        internal bool IsSetVehicleLegDetails() => this.VehicleLegDetails != null;
    }
}
