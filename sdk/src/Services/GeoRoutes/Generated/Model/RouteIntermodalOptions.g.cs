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
        /// <summary>
        /// Gets and sets the property AccessibilityAttributes. 
        /// <para>
        /// Accessibility attributes to consider when calculating the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> AccessibilityAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccessibilityAttributes property is set.
        /// </summary>
        internal bool IsSetAccessibilityAttributes() => this.AccessibilityAttributes != null && (this.AccessibilityAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxTransfers. 
        /// <para>
        /// Maximum number of transfers allowed when calculating the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6)]
        public int? MaxTransfers { get; set; }

        /// <summary>
        /// Checks to see if the MaxTransfers property is set.
        /// </summary>
        internal bool IsSetMaxTransfers() => this.MaxTransfers.HasValue;

        /// <summary>
        /// Gets and sets the property Pedestrian. 
        /// <para>
        /// Options for the pedestrian leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalPedestrianOptions Pedestrian { get; set; }

        /// <summary>
        /// Checks to see if the Pedestrian property is set.
        /// </summary>
        internal bool IsSetPedestrian() => this.Pedestrian != null;

        /// <summary>
        /// Gets and sets the property Rental. 
        /// <para>
        /// Options for the rental leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalRentalOptions Rental { get; set; }

        /// <summary>
        /// Checks to see if the Rental property is set.
        /// </summary>
        internal bool IsSetRental() => this.Rental != null;

        /// <summary>
        /// Gets and sets the property Taxi. 
        /// <para>
        /// Options for the taxi leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalTaxiOptions Taxi { get; set; }

        /// <summary>
        /// Checks to see if the Taxi property is set.
        /// </summary>
        internal bool IsSetTaxi() => this.Taxi != null;

        /// <summary>
        /// Gets and sets the property Transit. 
        /// <para>
        /// Options for the transit leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalTransitOptions Transit { get; set; }

        /// <summary>
        /// Checks to see if the Transit property is set.
        /// </summary>
        internal bool IsSetTransit() => this.Transit != null;

        /// <summary>
        /// Gets and sets the property Vehicle. 
        /// <para>
        /// Options for the vehicle leg of the intermodal route.
        /// </para>
        /// </summary>
        public RouteIntermodalVehicleOptions Vehicle { get; set; }

        /// <summary>
        /// Checks to see if the Vehicle property is set.
        /// </summary>
        internal bool IsSetVehicle() => this.Vehicle != null;
    }
}
