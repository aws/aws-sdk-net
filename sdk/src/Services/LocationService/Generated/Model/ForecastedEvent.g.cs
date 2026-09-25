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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// A forecasted event represents a geofence event in relation to the requested device
    /// state, that may occur given the provided device state and time horizon.
    /// </summary>
    public partial class ForecastedEvent
    {
        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The forecasted event identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

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
        [AWSProperty(Required = true)]
        public ForecastedGeofenceEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ForecastedBreachTime. 
        /// <para>
        /// The forecasted time the device will breach the geofence in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public DateTime? ForecastedBreachTime { get; set; }

        /// <summary>
        /// Checks to see if the ForecastedBreachTime property is set.
        /// </summary>
        internal bool IsSetForecastedBreachTime() => this.ForecastedBreachTime.HasValue;

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The geofence identifier pertaining to the forecasted event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string GeofenceId { get; set; }

        /// <summary>
        /// Checks to see if the GeofenceId property is set.
        /// </summary>
        internal bool IsSetGeofenceId() => this.GeofenceId != null;

        /// <summary>
        /// Gets and sets the property GeofenceProperties. 
        /// <para>
        /// The geofence properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3)]
        public Dictionary<string, string> GeofenceProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the GeofenceProperties property is set.
        /// </summary>
        internal bool IsSetGeofenceProperties() => this.GeofenceProperties != null && (this.GeofenceProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsDeviceInGeofence. 
        /// <para>
        /// Indicates if the device is located within the geofence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsDeviceInGeofence { get; set; }

        /// <summary>
        /// Checks to see if the IsDeviceInGeofence property is set.
        /// </summary>
        internal bool IsSetIsDeviceInGeofence() => this.IsDeviceInGeofence.HasValue;

        /// <summary>
        /// Gets and sets the property NearestDistance. 
        /// <para>
        /// The closest distance from the device's position to the geofence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? NearestDistance { get; set; }

        /// <summary>
        /// Checks to see if the NearestDistance property is set.
        /// </summary>
        internal bool IsSetNearestDistance() => this.NearestDistance.HasValue;
    }
}
