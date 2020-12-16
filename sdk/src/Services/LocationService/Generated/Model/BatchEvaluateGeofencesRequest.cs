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
    /// Container for the parameters to the BatchEvaluateGeofences operation.
    /// Used in geofence monitoring. Evaluates device positions against the position of geofences
    /// in a given geofence collection.
    /// </summary>
    public partial class BatchEvaluateGeofencesRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private List<DevicePositionUpdate> _devicePositionUpdates = new List<DevicePositionUpdate>();

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The geofence collection used in evaluating the position of devices against its geofences.
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
        /// Gets and sets the property DevicePositionUpdates. 
        /// <para>
        /// Contains device details for each device to be evaluated against the given geofence
        /// collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<DevicePositionUpdate> DevicePositionUpdates
        {
            get { return this._devicePositionUpdates; }
            set { this._devicePositionUpdates = value; }
        }

        // Check to see if DevicePositionUpdates property is set
        internal bool IsSetDevicePositionUpdates()
        {
            return this._devicePositionUpdates != null && this._devicePositionUpdates.Count > 0; 
        }

    }
}