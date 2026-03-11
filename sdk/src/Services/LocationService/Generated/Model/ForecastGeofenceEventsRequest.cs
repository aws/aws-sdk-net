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
    /// This action forecasts future geofence events that are likely to occur within a specified
    /// time horizon if a device continues moving at its current speed. Each forecasted event
    /// is associated with a geofence from a provided geofence collection. A forecast event
    /// can have one of the following states:
    /// 
    ///  
    /// <para>
    ///  <c>ENTER</c>: The device position is outside the referenced geofence, but the device
    /// may cross into the geofence during the forecasting time horizon if it maintains its
    /// current speed.
    /// </para>
    ///  
    /// <para>
    ///  <c>EXIT</c>: The device position is inside the referenced geofence, but the device
    /// may leave the geofence during the forecasted time horizon if the device maintains
    /// it's current speed.
    /// </para>
    ///  
    /// <para>
    ///  <c>IDLE</c>:The device is inside the geofence, and it will remain inside the geofence
    /// through the end of the time horizon if the device maintains it's current speed.
    /// </para>
    ///  <note> 
    /// <para>
    /// Heading direction is not considered in the current version. The API takes a conservative
    /// approach and includes events that can occur for any heading.
    /// </para>
    ///  </note>
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
        /// Represents the device's state, including its current position and speed. When speed
        /// is omitted, this API performs a <i>containment check</i>. The <i>containment check</i>
        /// operation returns <c>IDLE</c> events for geofences where the device is currently inside
        /// of, but no other events.
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
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The forward-looking time window for forecasting, specified in minutes. The API only
        /// returns events that are predicted to occur within this time horizon. When no value
        /// is specified, this API performs a <i>containment check</i>. The <i>containment check</i>
        /// operation returns <c>IDLE</c> events for geofences where the device is currently inside
        /// of, but no other events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? TimeHorizonMinutes
        {
            get { return this._timeHorizonMinutes; }
            set { this._timeHorizonMinutes = value; }
        }

        // Check to see if TimeHorizonMinutes property is set
        internal bool IsSetTimeHorizonMinutes()
        {
            return this._timeHorizonMinutes.HasValue; 
        }

    }
}