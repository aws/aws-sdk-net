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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the ForecastGeofenceEvents operation.
    /// Evaluates device positions against geofence geometries from a given geofence collection.
    /// The event forecasts three states for which a device can be in relative to a geofence:
    /// 
    ///  
    /// <para>
    ///  <c>ENTER</c>: If a device is outside of a geofence, but would breach the fence if
    /// the device is moving at its current speed within time horizon window.
    /// </para>
    ///  
    /// <para>
    ///  <c>EXIT</c>: If a device is inside of a geofence, but would breach the fence if the
    /// device is moving at its current speed within time horizon window.
    /// </para>
    ///  
    /// <para>
    ///  <c>IDLE</c>: If a device is inside of a geofence, and the device is not moving.
    /// </para>
    /// </summary>
    public partial class ForecastGeofenceEventsRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private ForecastGeofenceEventsDeviceState _deviceState;
        private DistanceUnit _distanceUnit;
        private int? _maxResults;
        private string _nextToken;
        private SpeedUnit _speedUnit;
        private double? _timeHorizonMinutes;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The name of the geofence collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CollectionName
        {
            get { return this._collectionName; }
            set { this._collectionName = value; }
        }

        // Check to see if CollectionName property is set
        internal bool IsSetCollectionName()
        {
            return this._collectionName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceState. 
        /// <para>
        /// The device's state, including current position and speed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ForecastGeofenceEventsDeviceState DeviceState
        {
            get { return this._deviceState; }
            set { this._deviceState = value; }
        }

        // Check to see if DeviceState property is set
        internal bool IsSetDeviceState()
        {
            return this._deviceState != null;
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit used for the <c>NearestDistance</c> property returned in a forecasted
        /// event. The measurement system must match for <c>DistanceUnit</c> and <c>SpeedUnit</c>;
        /// if <c>Kilometers</c> is specified for <c>DistanceUnit</c>, then <c>SpeedUnit</c> must
        /// be <c>KilometersPerHour</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Kilometers</c> 
        /// </para>
        /// </summary>
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of resources returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>20</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>null</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SpeedUnit. 
        /// <para>
        /// The speed unit for the device captured by the device state. The measurement system
        /// must match for <c>DistanceUnit</c> and <c>SpeedUnit</c>; if <c>Kilometers</c> is specified
        /// for <c>DistanceUnit</c>, then <c>SpeedUnit</c> must be <c>KilometersPerHour</c>.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>KilometersPerHour</c>.
        /// </para>
        /// </summary>
        public SpeedUnit SpeedUnit
        {
            get { return this._speedUnit; }
            set { this._speedUnit = value; }
        }

        // Check to see if SpeedUnit property is set
        internal bool IsSetSpeedUnit()
        {
            return this._speedUnit != null;
        }

        /// <summary>
        /// Gets and sets the property TimeHorizonMinutes. 
        /// <para>
        /// Specifies the time horizon in minutes for the forecasted events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double TimeHorizonMinutes
        {
            get { return this._timeHorizonMinutes.GetValueOrDefault(); }
            set { this._timeHorizonMinutes = value; }
        }

        // Check to see if TimeHorizonMinutes property is set
        internal bool IsSetTimeHorizonMinutes()
        {
            return this._timeHorizonMinutes.HasValue; 
        }

    }
}