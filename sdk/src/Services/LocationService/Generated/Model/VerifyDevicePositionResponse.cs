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
    /// This is the response object from the VerifyDevicePosition operation.
    /// </summary>
    public partial class VerifyDevicePositionResponse : AmazonWebServiceResponse
    {
        private string _deviceId;
        private DistanceUnit _distanceUnit;
        private InferredState _inferredState;
        private DateTime? _receivedTime;
        private DateTime? _sampleTime;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit for the verification response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property InferredState. 
        /// <para>
        /// The inferred state of the device, given the provided position, IP address, cellular
        /// signals, and Wi-Fi- access points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferredState InferredState
        {
            get { return this._inferredState; }
            set { this._inferredState = value; }
        }

        // Check to see if InferredState property is set
        internal bool IsSetInferredState()
        {
            return this._inferredState != null;
        }

        /// <summary>
        /// Gets and sets the property ReceivedTime. 
        /// <para>
        /// The timestamp for when the tracker resource received the device position in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DateTime? ReceivedTime
        {
            get { return this._receivedTime; }
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
        /// The timestamp at which the device's position was determined. Uses <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DateTime? SampleTime
        {
            get { return this._sampleTime; }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

    }
}