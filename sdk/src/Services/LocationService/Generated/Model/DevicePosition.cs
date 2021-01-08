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
    /// Contains the device position details.
    /// </summary>
    public partial class DevicePosition
    {
        private string _deviceId;
        private List<double> _position = new List<double>();
        private DateTime? _receivedTime;
        private DateTime? _sampleTime;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device whose position you retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The last known device position.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && this._position.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReceivedTime. 
        /// <para>
        /// The timestamp for when the tracker resource recieved the position in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ReceivedTime
        {
            get { return this._receivedTime.GetValueOrDefault(); }
            set { this._receivedTime = value; }
        }

        // Check to see if ReceivedTime property is set
        internal bool IsSetReceivedTime()
        {
            return this._receivedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The timestamp for when the position was detected and sampled in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime SampleTime
        {
            get { return this._sampleTime.GetValueOrDefault(); }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

    }
}