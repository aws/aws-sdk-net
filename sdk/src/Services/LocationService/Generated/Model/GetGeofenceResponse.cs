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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the GetGeofence operation.
    /// </summary>
    public partial class GetGeofenceResponse : AmazonWebServiceResponse
    {
        private DateTime? _createTime;
        private string _geofenceId;
        private GeofenceGeometry _geometry;
        private string _status;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the geofence collection was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The geofence identifier.
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
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Contains the geofence geometry details describing a polygon.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeofenceGeometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Identifies the state of the geofence. A geofence will hold one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> — The geofence has been indexed by the system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code> — The geofence is being processed by the system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> — The geofence failed to be indexed by the system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> — The geofence has been deleted from the system index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> — The geofence is being deleted from the system index.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp for when the geofence collection was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}