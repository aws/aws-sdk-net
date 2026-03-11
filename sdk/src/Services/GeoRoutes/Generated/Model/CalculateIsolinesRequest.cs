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
    /// Container for the parameters to the CalculateIsolines operation.
    /// Use the <c>CalculateIsolines</c> action to find service areas that can be reached
    /// in a given threshold of time, distance.
    /// </summary>
    public partial class CalculateIsolinesRequest : AmazonGeoRoutesRequest
    {
        private IsolineAllowOptions _allow;
        private string _arrivalTime;
        private IsolineAvoidanceOptions _avoid;
        private bool? _departNow;
        private string _departureTime;
        private List<double> _destination = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private IsolineDestinationOptions _destinationOptions;
        private GeometryFormat _isolineGeometryFormat;
        private IsolineGranularityOptions _isolineGranularity;
        private string _key;
        private IsolineOptimizationObjective _optimizeIsolineFor;
        private RoutingObjective _optimizeRoutingFor;
        private List<double> _origin = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private IsolineOriginOptions _originOptions;
        private IsolineThresholds _thresholds;
        private IsolineTrafficOptions _traffic;
        private IsolineTravelMode _travelMode;
        private IsolineTravelModeOptions _travelModeOptions;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Features that are allowed while calculating an isoline.
        /// </para>
        /// </summary>
        public IsolineAllowOptions Allow
        {
            get { return this._allow; }
            set { this._allow = value; }
        }

        // Check to see if Allow property is set
        internal bool IsSetAllow()
        {
            return this._allow != null;
        }

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Time of arrival at the destination.
        /// </para>
        ///  
        /// <para>
        /// Time format: <c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ArrivalTime
        {
            get { return this._arrivalTime; }
            set { this._arrivalTime = value; }
        }

        // Check to see if ArrivalTime property is set
        internal bool IsSetArrivalTime()
        {
            return this._arrivalTime != null;
        }

        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        /// Features that are avoided while calculating a route. Avoidance is on a best-case basis.
        /// If an avoidance can't be satisfied for a particular case, it violates the avoidance
        /// and the returned response produces a notice for the violation.
        /// </para>
        /// </summary>
        public IsolineAvoidanceOptions Avoid
        {
            get { return this._avoid; }
            set { this._avoid = value; }
        }

        // Check to see if Avoid property is set
        internal bool IsSetAvoid()
        {
            return this._avoid != null;
        }

        /// <summary>
        /// Gets and sets the property DepartNow. 
        /// <para>
        /// Uses the current time as the time of departure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? DepartNow
        {
            get { return this._departNow; }
            set { this._departNow = value; }
        }

        // Check to see if DepartNow property is set
        internal bool IsSetDepartNow()
        {
            return this._departNow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Time of departure from thr origin.
        /// </para>
        ///  
        /// <para>
        /// Time format:<c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DepartureTime
        {
            get { return this._departureTime; }
            set { this._departureTime = value; }
        }

        // Check to see if DepartureTime property is set
        internal bool IsSetDepartureTime()
        {
            return this._departureTime != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The final position for the route. In the World Geodetic System (WGS 84) format: <c>[longitude,
        /// latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null && (this._destination.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// Destination related options.
        /// </para>
        /// </summary>
        public IsolineDestinationOptions DestinationOptions
        {
            get { return this._destinationOptions; }
            set { this._destinationOptions = value; }
        }

        // Check to see if DestinationOptions property is set
        internal bool IsSetDestinationOptions()
        {
            return this._destinationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IsolineGeometryFormat. 
        /// <para>
        /// The format of the returned IsolineGeometry. 
        /// </para>
        ///  
        /// <para>
        /// Default Value:<c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        public GeometryFormat IsolineGeometryFormat
        {
            get { return this._isolineGeometryFormat; }
            set { this._isolineGeometryFormat = value; }
        }

        // Check to see if IsolineGeometryFormat property is set
        internal bool IsSetIsolineGeometryFormat()
        {
            return this._isolineGeometryFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IsolineGranularity. 
        /// <para>
        /// Defines the granularity of the returned Isoline.
        /// </para>
        /// </summary>
        public IsolineGranularityOptions IsolineGranularity
        {
            get { return this._isolineGranularity; }
            set { this._isolineGranularity = value; }
        }

        // Check to see if IsolineGranularity property is set
        internal bool IsSetIsolineGranularity()
        {
            return this._isolineGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizeIsolineFor. 
        /// <para>
        /// Specifies the optimization criteria for when calculating an isoline. AccurateCalculation
        /// generates an isoline of higher granularity that is more precise. FastCalculation generates
        /// an isoline faster by reducing the granularity, and in turn the quality of the isoline.
        /// BalancedCalculation generates an isoline by balancing between quality and performance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>BalancedCalculation</c> 
        /// </para>
        /// </summary>
        public IsolineOptimizationObjective OptimizeIsolineFor
        {
            get { return this._optimizeIsolineFor; }
            set { this._optimizeIsolineFor = value; }
        }

        // Check to see if OptimizeIsolineFor property is set
        internal bool IsSetOptimizeIsolineFor()
        {
            return this._optimizeIsolineFor != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizeRoutingFor. 
        /// <para>
        /// Specifies the optimization criteria for calculating a route.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>FastestRoute</c> 
        /// </para>
        /// </summary>
        public RoutingObjective OptimizeRoutingFor
        {
            get { return this._optimizeRoutingFor; }
            set { this._optimizeRoutingFor = value; }
        }

        // Check to see if OptimizeRoutingFor property is set
        internal bool IsSetOptimizeRoutingFor()
        {
            return this._optimizeRoutingFor != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The start position for the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null && (this._origin.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginOptions. 
        /// <para>
        /// Origin related options.
        /// </para>
        /// </summary>
        public IsolineOriginOptions OriginOptions
        {
            get { return this._originOptions; }
            set { this._originOptions = value; }
        }

        // Check to see if OriginOptions property is set
        internal bool IsSetOriginOptions()
        {
            return this._originOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Thresholds. 
        /// <para>
        /// Threshold to be used for the isoline calculation. Up to 3 thresholds per provided
        /// type can be requested.
        /// </para>
        ///  
        /// <para>
        ///  You incur a calculation charge for each threshold. Using a large amount of thresholds
        /// in a request can lead you to incur unexpected charges. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html`">
        /// Amazon Location's pricing page</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IsolineThresholds Thresholds
        {
            get { return this._thresholds; }
            set { this._thresholds = value; }
        }

        // Check to see if Thresholds property is set
        internal bool IsSetThresholds()
        {
            return this._thresholds != null;
        }

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Traffic related options.
        /// </para>
        /// </summary>
        public IsolineTrafficOptions Traffic
        {
            get { return this._traffic; }
            set { this._traffic = value; }
        }

        // Check to see if Traffic property is set
        internal bool IsSetTraffic()
        {
            return this._traffic != null;
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The mode <c>Scooter</c> also applies to motorcycles, set to <c>Scooter</c> when wanted
        /// to calculate options for motorcycles.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default Value: <c>Car</c> 
        /// </para>
        /// </summary>
        public IsolineTravelMode TravelMode
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
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        /// Travel mode related options for the provided travel mode.
        /// </para>
        /// </summary>
        public IsolineTravelModeOptions TravelModeOptions
        {
            get { return this._travelModeOptions; }
            set { this._travelModeOptions = value; }
        }

        // Check to see if TravelModeOptions property is set
        internal bool IsSetTravelModeOptions()
        {
            return this._travelModeOptions != null;
        }

    }
}