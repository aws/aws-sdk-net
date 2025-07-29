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
    /// A forecasted event represents a geofence event in relation to the requested device
    /// state, that may occur given the provided device state and time horizon.
    /// </summary>
    public partial class ForecastedEvent
    {
        private string _eventId;
        private ForecastedGeofenceEventType _eventType;
        private DateTime? _forecastedBreachTime;
        private string _geofenceId;
        private Dictionary<string, string> _geofenceProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _isDeviceInGeofence;
        private double? _nearestDistance;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The forecasted event identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type, forecasting three states for which a device can be in relative to
        /// a geofence:
        /// </para>
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
        [AWSProperty(Required=true)]
        public ForecastedGeofenceEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastedBreachTime. 
        /// <para>
        /// The forecasted time the device will breach the geofence in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime? ForecastedBreachTime
        {
            get { return this._forecastedBreachTime; }
            set { this._forecastedBreachTime = value; }
        }

        // Check to see if ForecastedBreachTime property is set
        internal bool IsSetForecastedBreachTime()
        {
            return this._forecastedBreachTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The geofence identifier pertaining to the forecasted event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string GeofenceId
        {
            get { return this._geofenceId; }
            set { this._geofenceId = value; }
        }

        // Check to see if GeofenceId property is set
        internal bool IsSetGeofenceId()
        {
            return this._geofenceId != null;
        }

        /// <summary>
        /// Gets and sets the property GeofenceProperties. 
        /// <para>
        /// The geofence properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=3)]
        public Dictionary<string, string> GeofenceProperties
        {
            get { return this._geofenceProperties; }
            set { this._geofenceProperties = value; }
        }

        // Check to see if GeofenceProperties property is set
        internal bool IsSetGeofenceProperties()
        {
            return this._geofenceProperties != null && (this._geofenceProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsDeviceInGeofence. 
        /// <para>
        /// Indicates if the device is located within the geofence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsDeviceInGeofence
        {
            get { return this._isDeviceInGeofence; }
            set { this._isDeviceInGeofence = value; }
        }

        // Check to see if IsDeviceInGeofence property is set
        internal bool IsSetIsDeviceInGeofence()
        {
            return this._isDeviceInGeofence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NearestDistance. 
        /// <para>
        /// The closest distance from the device's position to the geofence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? NearestDistance
        {
            get { return this._nearestDistance; }
            set { this._nearestDistance = value; }
        }

        // Check to see if NearestDistance property is set
        internal bool IsSetNearestDistance()
        {
            return this._nearestDistance.HasValue; 
        }

    }
}