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
    /// Container for the parameters to the PutGeofence operation.
    /// Stores a geofence geometry in a given geofence collection, or updates the geometry
    /// of an existing geofence if a geofence ID is included in the request.
    /// </summary>
    public partial class PutGeofenceRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private string _geofenceId;
        private Dictionary<string, string> _geofenceProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private GeofenceGeometry _geometry;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The geofence collection to store the geofence in.
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
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// An identifier for the geofence. For example, <c>ExampleGeofence-1</c>.
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
        /// Associates one of more properties with the geofence. A property is a key-value pair
        /// stored with the geofence and added to any geofence event triggered with that geofence.
        /// </para>
        ///  
        /// <para>
        /// Format: <c>"key" : "value"</c> 
        /// </para>
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
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Contains the details to specify the position of the geofence. Can be either a polygon
        /// or a circle. Including both will return a validation error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each <a href="https://docs.aws.amazon.com/location-geofences/latest/APIReference/API_GeofenceGeometry.html">
        /// geofence polygon</a> can have a maximum of 1,000 vertices.
        /// </para>
        ///  </note>
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