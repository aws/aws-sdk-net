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
    /// Options related to intermodal routing.
    /// 
    ///  <note> 
    /// <para>
    /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RouteIntermodalOptions
    {
        private List<string> _accessibilityAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxTransfers;
        private RouteIntermodalPedestrianOptions _pedestrian;
        private RouteIntermodalRentalOptions _rental;
        private RouteIntermodalTaxiOptions _taxi;
        private RouteIntermodalTransitOptions _transit;
        private RouteIntermodalVehicleOptions _vehicle;

        /// <summary>
        /// Gets and sets the property AccessibilityAttributes. 
        /// <para>
        /// Accessibility attributes to consider when calculating the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> AccessibilityAttributes
        {
            get { return this._accessibilityAttributes; }
            set { this._accessibilityAttributes = value; }
        }

        // Check to see if AccessibilityAttributes property is set
        internal bool IsSetAccessibilityAttributes()
        {
            return this._accessibilityAttributes != null && (this._accessibilityAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxTransfers. 
        /// <para>
        /// Maximum number of transfers allowed when calculating the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public int? MaxTransfers
        {
            get { return this._maxTransfers; }
            set { this._maxTransfers = value; }
        }

        // Check to see if MaxTransfers property is set
        internal bool IsSetMaxTransfers()
        {
            return this._maxTransfers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pedestrian. 
        /// <para>
        /// Options for the pedestrian leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalPedestrianOptions Pedestrian
        {
            get { return this._pedestrian; }
            set { this._pedestrian = value; }
        }

        // Check to see if Pedestrian property is set
        internal bool IsSetPedestrian()
        {
            return this._pedestrian != null;
        }

        /// <summary>
        /// Gets and sets the property Rental. 
        /// <para>
        /// Options for the rental leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalRentalOptions Rental
        {
            get { return this._rental; }
            set { this._rental = value; }
        }

        // Check to see if Rental property is set
        internal bool IsSetRental()
        {
            return this._rental != null;
        }

        /// <summary>
        /// Gets and sets the property Taxi. 
        /// <para>
        /// Options for the taxi leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalTaxiOptions Taxi
        {
            get { return this._taxi; }
            set { this._taxi = value; }
        }

        // Check to see if Taxi property is set
        internal bool IsSetTaxi()
        {
            return this._taxi != null;
        }

        /// <summary>
        /// Gets and sets the property Transit. 
        /// <para>
        /// Options for the transit leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalTransitOptions Transit
        {
            get { return this._transit; }
            set { this._transit = value; }
        }

        // Check to see if Transit property is set
        internal bool IsSetTransit()
        {
            return this._transit != null;
        }

        /// <summary>
        /// Gets and sets the property Vehicle. 
        /// <para>
        /// Options for the vehicle leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalVehicleOptions Vehicle
        {
            get { return this._vehicle; }
            set { this._vehicle = value; }
        }

        // Check to see if Vehicle property is set
        internal bool IsSetVehicle()
        {
            return this._vehicle != null;
        }

    }
}