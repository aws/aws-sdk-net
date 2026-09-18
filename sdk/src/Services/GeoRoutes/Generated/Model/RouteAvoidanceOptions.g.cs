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
    /// Specifies options for areas to avoid when calculating the route. This is a best-effort
    /// avoidance setting, meaning the router will try to honor the avoidance preferences
    /// but may still include restricted areas if no feasible alternative route exists. If
    /// avoidance options are not followed, the response will indicate that the avoidance
    /// criteria were violated.
    /// </summary>
    public partial class RouteAvoidanceOptions
    {
        /// <summary>
        /// Gets and sets the property Areas. 
        /// <para>
        ///  Areas to be avoided. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteAvoidanceArea> Areas { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteAvoidanceArea>() : null;

        /// <summary>
        /// Checks to see if the Areas property is set.
        /// </summary>
        internal bool IsSetAreas() => this.Areas != null && (this.Areas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CarShuttleTrains. 
        /// <para>
        ///  Avoid car-shuttle-trains while calculating the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? CarShuttleTrains { get; set; }

        /// <summary>
        /// Checks to see if the CarShuttleTrains property is set.
        /// </summary>
        internal bool IsSetCarShuttleTrains() => this.CarShuttleTrains.HasValue;

        /// <summary>
        /// Gets and sets the property ControlledAccessHighways. 
        /// <para>
        /// Avoid controlled access highways while calculating the route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? ControlledAccessHighways { get; set; }

        /// <summary>
        /// Checks to see if the ControlledAccessHighways property is set.
        /// </summary>
        internal bool IsSetControlledAccessHighways() => this.ControlledAccessHighways.HasValue;

        /// <summary>
        /// Gets and sets the property DirtRoads. 
        /// <para>
        ///  Avoid dirt roads while calculating the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? DirtRoads { get; set; }

        /// <summary>
        /// Checks to see if the DirtRoads property is set.
        /// </summary>
        internal bool IsSetDirtRoads() => this.DirtRoads.HasValue;

        /// <summary>
        /// Gets and sets the property Ferries. 
        /// <para>
        /// Avoid ferries while calculating the route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Ferries { get; set; }

        /// <summary>
        /// Checks to see if the Ferries property is set.
        /// </summary>
        internal bool IsSetFerries() => this.Ferries.HasValue;

        /// <summary>
        /// Gets and sets the property SeasonalClosure. 
        /// <para>
        ///  Avoid roads that have seasonal closure while calculating the route. Not supported
        /// in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? SeasonalClosure { get; set; }

        /// <summary>
        /// Checks to see if the SeasonalClosure property is set.
        /// </summary>
        internal bool IsSetSeasonalClosure() => this.SeasonalClosure.HasValue;

        /// <summary>
        /// Gets and sets the property TollRoads. 
        /// <para>
        /// Avoids roads where the specified toll transponders are the only mode of payment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? TollRoads { get; set; }

        /// <summary>
        /// Checks to see if the TollRoads property is set.
        /// </summary>
        internal bool IsSetTollRoads() => this.TollRoads.HasValue;

        /// <summary>
        /// Gets and sets the property TollTransponders. 
        /// <para>
        ///  Avoids roads where the specified toll transponders are the only mode of payment.
        /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? TollTransponders { get; set; }

        /// <summary>
        /// Checks to see if the TollTransponders property is set.
        /// </summary>
        internal bool IsSetTollTransponders() => this.TollTransponders.HasValue;

        /// <summary>
        /// Gets and sets the property TruckRoadTypes. 
        /// <para>
        ///  Truck road type identifiers. <c>BK1</c> through <c>BK4</c> apply only to Sweden.
        /// <c>A2,A4,B2,B4,C,D,ET2,ET4</c> apply only to Mexico. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// There are currently no other supported values as of 26th April 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public List<string> TruckRoadTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TruckRoadTypes property is set.
        /// </summary>
        internal bool IsSetTruckRoadTypes() => this.TruckRoadTypes != null && (this.TruckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tunnels. 
        /// <para>
        ///  Avoid tunnels while calculating the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Tunnels { get; set; }

        /// <summary>
        /// Checks to see if the Tunnels property is set.
        /// </summary>
        internal bool IsSetTunnels() => this.Tunnels.HasValue;

        /// <summary>
        /// Gets and sets the property UTurns. 
        /// <para>
        ///  Avoid U-turns for calculation on highways and motorways. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? UTurns { get; set; }

        /// <summary>
        /// Checks to see if the UTurns property is set.
        /// </summary>
        internal bool IsSetUTurns() => this.UTurns.HasValue;

        /// <summary>
        /// Gets and sets the property ZoneCategories. 
        /// <para>
        ///  Zone categories to be avoided. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<RouteAvoidanceZoneCategory> ZoneCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteAvoidanceZoneCategory>() : null;

        /// <summary>
        /// Checks to see if the ZoneCategories property is set.
        /// </summary>
        internal bool IsSetZoneCategories() => this.ZoneCategories != null && (this.ZoneCategories.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
