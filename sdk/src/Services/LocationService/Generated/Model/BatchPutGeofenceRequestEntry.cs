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
    /// Contains geofence details.
    /// </summary>
    public partial class BatchPutGeofenceRequestEntry
    {
        private string _geofenceId;
        private GeofenceGeometry _geometry;

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The identifier for the geofence to be stored in a given geofence collection.
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
        /// The geometry details for the geofence.
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

    }
}