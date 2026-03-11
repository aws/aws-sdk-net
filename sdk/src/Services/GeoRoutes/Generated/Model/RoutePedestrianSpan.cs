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
    public partial class RoutePedestrianSpan
    {
        private long? _bestCaseDuration;
        private string _country;
        private long? _distance;
        private long? _duration;
        private RouteSpanDynamicSpeedDetails _dynamicSpeed;
        private int? _functionalClassification;
        private int? _geometryOffset;
        private List<int> _incidents = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<LocalizedString> _names = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private List<string> _pedestrianAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;
        private List<string> _roadAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RouteNumber> _routeNumbers = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;
        private RouteSpanSpeedLimitDetails _speedLimit;
        private long? _typicalDuration;

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
        /// Provides an array of names of the pedestrian span in available languages.
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
        /// Gets and sets the property PedestrianAccess. 
        /// <para>
        /// Access attributes for a pedestrian corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<string> PedestrianAccess
        {
            get { return this._pedestrianAccess; }
            set { this._pedestrianAccess = value; }
        }

        // Check to see if PedestrianAccess property is set
        internal bool IsSetPedestrianAccess()
        {
            return this._pedestrianAccess != null && (this._pedestrianAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}