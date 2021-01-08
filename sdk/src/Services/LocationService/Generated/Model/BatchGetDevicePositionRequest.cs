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
    /// Container for the parameters to the BatchGetDevicePosition operation.
    /// A batch request to retrieve device positions.
    /// 
    ///  <note> 
    /// <para>
    /// The response will return the device positions from the last 24 hours.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchGetDevicePositionRequest : AmazonLocationServiceRequest
    {
        private List<string> _deviceIds = new List<string>();
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property DeviceIds. 
        /// <para>
        /// Devices whose position you want to retrieve.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, for two devices: <code>device-ids=DeviceId1&amp;device-ids=DeviceId2</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> DeviceIds
        {
            get { return this._deviceIds; }
            set { this._deviceIds = value; }
        }

        // Check to see if DeviceIds property is set
        internal bool IsSetDeviceIds()
        {
            return this._deviceIds != null && this._deviceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The tracker resource retrieving the device position.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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