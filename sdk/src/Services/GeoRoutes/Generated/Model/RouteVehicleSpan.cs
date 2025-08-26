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
    /// Span computed for the requested SpanAdditionalFeatures.
    /// </summary>
    public partial class RouteVehicleSpan
    {
        private long? _bestCaseDuration;
        private List<string> _carAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _country;
        private long? _distance;
        private long? _duration;
        private RouteSpanDynamicSpeedDetails _dynamicSpeed;
        private int? _functionalClassification;
        private RouteSpanGateAttribute _gate;
        private int? _geometryOffset;
        private List<int> _incidents = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<LocalizedString> _names = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private List<int> _notices = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private RouteSpanRailwayCrossingAttribute _railwayCrossing;
        private string _region;
        private List<string> _roadAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RouteNumber> _routeNumbers = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;
        private List<string> _scooterAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RouteSpanSpeedLimitDetails _speedLimit;
        private List<int> _tollSystems = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _truckAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _truckRoadTypes = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private long? _typicalDuration;
        private List<int> _zones = AWSConfigs.InitializeCollections ? new List<int>() : null;

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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? BestCaseDuration
        {
            get { return this._bestCaseDuration; }
            set { this._bestCaseDuration = value; }
        }

        // Check to see if BestCaseDuration property is set
        internal bool IsSetBestCaseDuration()
        {
            return this._bestCaseDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CarAccess. 
        /// <para>
        /// Access attributes for a car corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> CarAccess
        {
            get { return this._carAccess; }
            set { this._carAccess = value; }
        }

        // Check to see if CarAccess property is set
        internal bool IsSetCarAccess()
        {
            return this._carAccess != null && (this._carAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// 3 letter Country code corresponding to the Span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=3)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the computed span. This feature doesn't split a span, but is always computed
        /// on a span split by other properties.
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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DynamicSpeed. 
        /// <para>
        /// Dynamic speed details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        public RouteSpanDynamicSpeedDetails DynamicSpeed
        {
            get { return this._dynamicSpeed; }
            set { this._dynamicSpeed = value; }
        }

        // Check to see if DynamicSpeed property is set
        internal bool IsSetDynamicSpeed()
        {
            return this._dynamicSpeed != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionalClassification. 
        /// <para>
        /// Functional classification of the road segment corresponding to the span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=5)]
        public int? FunctionalClassification
        {
            get { return this._functionalClassification; }
            set { this._functionalClassification = value; }
        }

        // Check to see if FunctionalClassification property is set
        internal bool IsSetFunctionalClassification()
        {
            return this._functionalClassification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gate. 
        /// <para>
        /// Attributes corresponding to a gate. The gate is present at the end of the returned
        /// span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteSpanGateAttribute Gate
        {
            get { return this._gate; }
            set { this._gate = value; }
        }

        // Check to see if Gate property is set
        internal bool IsSetGate()
        {
            return this._gate != null;
        }

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this span.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? GeometryOffset
        {
            get { return this._geometryOffset; }
            set { this._geometryOffset = value; }
        }

        // Check to see if GeometryOffset property is set
        internal bool IsSetGeometryOffset()
        {
            return this._geometryOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        /// Incidents corresponding to the span. These index into the Incidents in the parent
        /// Leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Incidents
        {
            get { return this._incidents; }
            set { this._incidents = value; }
        }

        // Check to see if Incidents property is set
        internal bool IsSetIncidents()
        {
            return this._incidents != null && (this._incidents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Provides an array of names of the vehicle span in available languages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalizedString> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// Notices are additional information returned that indicate issues that occurred during
        /// route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Notices
        {
            get { return this._notices; }
            set { this._notices = value; }
        }

        // Check to see if Notices property is set
        internal bool IsSetNotices()
        {
            return this._notices != null && (this._notices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RailwayCrossing. 
        /// <para>
        /// Attributes corresponding to a railway crossing. The gate is present at the end of
        /// the returned span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteSpanRailwayCrossingAttribute RailwayCrossing
        {
            get { return this._railwayCrossing; }
            set { this._railwayCrossing = value; }
        }

        // Check to see if RailwayCrossing property is set
        internal bool IsSetRailwayCrossing()
        {
            return this._railwayCrossing != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// 2-3 letter Region code corresponding to the Span. This is either a province or a state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=3)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RoadAttributes. 
        /// <para>
        /// Attributes for the road segment corresponding to the span. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<string> RoadAttributes
        {
            get { return this._roadAttributes; }
            set { this._roadAttributes = value; }
        }

        // Check to see if RoadAttributes property is set
        internal bool IsSetRoadAttributes()
        {
            return this._roadAttributes != null && (this._roadAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteNumbers. 
        /// <para>
        /// Designated route name or number corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteNumber> RouteNumbers
        {
            get { return this._routeNumbers; }
            set { this._routeNumbers = value; }
        }

        // Check to see if RouteNumbers property is set
        internal bool IsSetRouteNumbers()
        {
            return this._routeNumbers != null && (this._routeNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScooterAccess. 
        /// <para>
        /// Access attributes for a scooter corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> ScooterAccess
        {
            get { return this._scooterAccess; }
            set { this._scooterAccess = value; }
        }

        // Check to see if ScooterAccess property is set
        internal bool IsSetScooterAccess()
        {
            return this._scooterAccess != null && (this._scooterAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpeedLimit. 
        /// <para>
        /// Speed limit details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        public RouteSpanSpeedLimitDetails SpeedLimit
        {
            get { return this._speedLimit; }
            set { this._speedLimit = value; }
        }

        // Check to see if SpeedLimit property is set
        internal bool IsSetSpeedLimit()
        {
            return this._speedLimit != null;
        }

        /// <summary>
        /// Gets and sets the property TollSystems. 
        /// <para>
        /// Toll systems are authorities that collect payments for the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> TollSystems
        {
            get { return this._tollSystems; }
            set { this._tollSystems = value; }
        }

        // Check to see if TollSystems property is set
        internal bool IsSetTollSystems()
        {
            return this._tollSystems != null && (this._tollSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TruckAccess. 
        /// <para>
        /// Access attributes for a truck corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> TruckAccess
        {
            get { return this._truckAccess; }
            set { this._truckAccess = value; }
        }

        // Check to see if TruckAccess property is set
        internal bool IsSetTruckAccess()
        {
            return this._truckAccess != null && (this._truckAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> TruckRoadTypes
        {
            get { return this._truckRoadTypes; }
            set { this._truckRoadTypes = value; }
        }

        // Check to see if TruckRoadTypes property is set
        internal bool IsSetTruckRoadTypes()
        {
            return this._truckRoadTypes != null && (this._truckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? TypicalDuration
        {
            get { return this._typicalDuration; }
            set { this._typicalDuration = value; }
        }

        // Check to see if TypicalDuration property is set
        internal bool IsSetTypicalDuration()
        {
            return this._typicalDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Zones. 
        /// <para>
        /// Zones corresponding to this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Zones
        {
            get { return this._zones; }
            set { this._zones = value; }
        }

        // Check to see if Zones property is set
        internal bool IsSetZones()
        {
            return this._zones != null && (this._zones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}