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
    /// Container for the parameters to the BatchEvaluateGeofences operation.
    /// Evaluates device positions against the geofence geometries from a given geofence collection.
    /// 
    ///  
    /// <para>
    /// This operation always returns an empty response because geofences are asynchronously
    /// evaluated. The evaluation determines if the device has entered or exited a geofenced
    /// area, and then publishes one of the following events to Amazon EventBridge:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ENTER</c> if Amazon Location determines that the tracked device has entered a
    /// geofenced area.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EXIT</c> if Amazon Location determines that the tracked device has exited a geofenced
    /// area.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The last geofence that a device was observed within is tracked for 30 days after the
    /// most recent device position update.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Geofence evaluation uses the given device position. It does not account for the optional
    /// <c>Accuracy</c> of a <c>DevicePositionUpdate</c>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// The <c>DeviceID</c> is used as a string to represent the device. You do not need to
    /// have a <c>Tracker</c> associated with the <c>DeviceID</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchEvaluateGeofencesRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private List<DevicePositionUpdate> _devicePositionUpdates = AWSConfigs.InitializeCollections ? new List<DevicePositionUpdate>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._devicePositionUpdates != null && (this._devicePositionUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}