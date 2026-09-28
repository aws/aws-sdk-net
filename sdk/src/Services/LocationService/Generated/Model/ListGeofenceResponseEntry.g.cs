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
    /// Contains a list of geofences stored in a given geofence collection.
    /// 
    ///  <note> 
    /// <para>
    /// The returned geometry will always match the geometry format used when the geofence
    /// was created.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListGeofenceResponseEntry
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the geofence was stored in a geofence collection in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The geofence identifier.
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
        /// User defined properties of the geofence. A property is a key-value pair stored with
        /// the geofence and added to any geofence event triggered with that geofence.
        /// </para>
        ///  
        /// <para>
        /// Format: <c>"key" : "value"</c> 
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
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Contains the geofence geometry details describing the position of the geofence. Can
        /// be a circle, a polygon, or a multipolygon.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeofenceGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Identifies the state of the geofence. A geofence will hold one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> — The geofence has been indexed by the system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> — The geofence is being processed by the system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> — The geofence failed to be indexed by the system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> — The geofence has been deleted from the system index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> — The geofence is being deleted from the system index.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp for when the geofence was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
