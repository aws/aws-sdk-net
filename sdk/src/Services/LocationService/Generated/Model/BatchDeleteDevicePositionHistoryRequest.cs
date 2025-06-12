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
    /// Container for the parameters to the BatchDeleteDevicePositionHistory operation.
    /// Deletes the position history of one or more devices from a tracker resource.
    /// </summary>
    public partial class BatchDeleteDevicePositionHistoryRequest : AmazonLocationServiceRequest
    {
        private List<string> _deviceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property DeviceIds. 
        /// <para>
        /// Devices whose position history you want to delete.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, for two devices: <c>“DeviceIds” : [DeviceId1,DeviceId2]</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> DeviceIds
        {
            get { return this._deviceIds; }
            set { this._deviceIds = value; }
        }

        // Check to see if DeviceIds property is set
        internal bool IsSetDeviceIds()
        {
            return this._deviceIds != null && (this._deviceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to delete the device position history from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

    }
}