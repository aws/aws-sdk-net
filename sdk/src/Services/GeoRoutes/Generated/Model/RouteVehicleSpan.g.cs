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
    /// Span computed for the requested SpanAdditionalFeatures.
    /// </summary>
    public partial class RouteVehicleSpan
    {
        /// <summary>
        /// Gets and sets the property BestCaseDuration. 
        /// <para>
        /// Duration of the computed span without traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? BestCaseDuration { get; set; }

        /// <summary>
        /// Checks to see if the BestCaseDuration property is set.
        /// </summary>
        internal bool IsSetBestCaseDuration() => this.BestCaseDuration.HasValue;

        /// <summary>
        /// Gets and sets the property CarAccess. 
        /// <para>
        /// Access attributes for a car corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<string> CarAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CarAccess property is set.
        /// </summary>
        internal bool IsSetCarAccess() => this.CarAccess != null && (this.CarAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// 3 letter Country code corresponding to the Span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the computed span. This feature doesn't split a span, but is always computed
        /// on a span split by other properties.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the computed span. This feature doesn't split a span, but is always computed
        /// on a span split by other properties.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DynamicSpeed. 
        /// <para>
        /// Dynamic speed details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        public RouteSpanDynamicSpeedDetails DynamicSpeed { get; set; }

        /// <summary>
        /// Checks to see if the DynamicSpeed property is set.
        /// </summary>
        internal bool IsSetDynamicSpeed() => this.DynamicSpeed != null;

        /// <summary>
        /// Gets and sets the property FunctionalClassification. 
        /// <para>
        /// A numerical value indicating the functional classification of the road segment corresponding
        /// to the span.
        /// </para>
        ///  
        /// <para>
        /// Classification values are part of the hierarchical network that helps determine a
        /// logical and efficient route, and have the following definitions:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Roads that allow for high volume, maximum speed traffic movement between and through
        /// major metropolitan areas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that are used to channel traffic to functional class 1 roads for travel between
        /// and through cities in the shortest amount of time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that intersect functional class 2 roads and provide a high volume of traffic
        /// movement at a lower level of mobility than functional class 2 roads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that provide for a high volume of traffic movement at moderate speeds between
        /// neighborhoods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads with volume and traffic movement below the level of any other functional class.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5)]
        public int? FunctionalClassification { get; set; }

        /// <summary>
        /// Checks to see if the FunctionalClassification property is set.
        /// </summary>
        internal bool IsSetFunctionalClassification() => this.FunctionalClassification.HasValue;

        /// <summary>
        /// Gets and sets the property Gate. 
        /// <para>
        /// Attributes corresponding to a gate. The gate is present at the end of the returned
        /// span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteSpanGateAttribute Gate { get; set; }

        /// <summary>
        /// Checks to see if the Gate property is set.
        /// </summary>
        internal bool IsSetGate() => this.Gate != null;

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this span.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GeometryOffset { get; set; }

        /// <summary>
        /// Checks to see if the GeometryOffset property is set.
        /// </summary>
        internal bool IsSetGeometryOffset() => this.GeometryOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        /// Incidents corresponding to the span. These index into the Incidents in the parent
        /// Leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Incidents { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Incidents property is set.
        /// </summary>
        internal bool IsSetIncidents() => this.Incidents != null && (this.Incidents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Provides an array of names of the vehicle span in available languages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalizedString> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// Notices are additional information returned that indicate issues that occurred during
        /// route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Notices { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Notices property is set.
        /// </summary>
        internal bool IsSetNotices() => this.Notices != null && (this.Notices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RailwayCrossing. 
        /// <para>
        /// Attributes corresponding to a railway crossing. The gate is present at the end of
        /// the returned span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteSpanRailwayCrossingAttribute RailwayCrossing { get; set; }

        /// <summary>
        /// Checks to see if the RailwayCrossing property is set.
        /// </summary>
        internal bool IsSetRailwayCrossing() => this.RailwayCrossing != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// 2-3 letter Region code corresponding to the Span. This is either a province or a state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RoadAttributes. 
        /// <para>
        /// Attributes for the road segment corresponding to the span. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 12)]
        public List<string> RoadAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RoadAttributes property is set.
        /// </summary>
        internal bool IsSetRoadAttributes() => this.RoadAttributes != null && (this.RoadAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteNumbers. 
        /// <para>
        /// Designated route name or number corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteNumber> RouteNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;

        /// <summary>
        /// Checks to see if the RouteNumbers property is set.
        /// </summary>
        internal bool IsSetRouteNumbers() => this.RouteNumbers != null && (this.RouteNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScooterAccess. 
        /// <para>
        /// Access attributes for a scooter corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<string> ScooterAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScooterAccess property is set.
        /// </summary>
        internal bool IsSetScooterAccess() => this.ScooterAccess != null && (this.ScooterAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpeedLimit. 
        /// <para>
        /// Speed limit details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        public RouteSpanSpeedLimitDetails SpeedLimit { get; set; }

        /// <summary>
        /// Checks to see if the SpeedLimit property is set.
        /// </summary>
        internal bool IsSetSpeedLimit() => this.SpeedLimit != null;

        /// <summary>
        /// Gets and sets the property TollSystems. 
        /// <para>
        /// Toll systems are authorities that collect payments for the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> TollSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the TollSystems property is set.
        /// </summary>
        internal bool IsSetTollSystems() => this.TollSystems != null && (this.TollSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TruckAccess. 
        /// <para>
        /// Access attributes for a truck corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<string> TruckAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TruckAccess property is set.
        /// </summary>
        internal bool IsSetTruckAccess() => this.TruckAccess != null && (this.TruckAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TruckRoadTypes. 
        /// <para>
        /// Truck road type identifiers. <c>BK1</c> through <c>BK4</c> apply only to Sweden. <c>A2,A4,B2,B4,C,D,ET2,ET4</c>
        /// apply only to Mexico.
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
        public List<int> TruckRoadTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the TruckRoadTypes property is set.
        /// </summary>
        internal bool IsSetTruckRoadTypes() => this.TruckRoadTypes != null && (this.TruckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TypicalDuration. 
        /// <para>
        /// Duration of the computed span under typical traffic congestion. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? TypicalDuration { get; set; }

        /// <summary>
        /// Checks to see if the TypicalDuration property is set.
        /// </summary>
        internal bool IsSetTypicalDuration() => this.TypicalDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Zones. 
        /// <para>
        /// Zones corresponding to this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Zones { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Zones property is set.
        /// </summary>
        internal bool IsSetZones() => this.Zones != null && (this.Zones.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
