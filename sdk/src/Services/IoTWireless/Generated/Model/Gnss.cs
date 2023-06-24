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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Global navigation satellite system (GNSS) object used for positioning.
    /// </summary>
    public partial class Gnss
    {
        private float? _assistAltitude;
        private List<float> _assistPosition = new List<float>();
        private float? _captureTime;
        private float? _captureTimeAccuracy;
        private string _payload;
        private bool? _use2DSolver;

        /// <summary>
        /// Gets and sets the property AssistAltitude. 
        /// <para>
        /// Optional assistance altitude, which is the altitude of the device at capture time,
        /// specified in meters above the WGS84 reference ellipsoid.
        /// </para>
        /// </summary>
        public float AssistAltitude
        {
            get { return this._assistAltitude.GetValueOrDefault(); }
            set { this._assistAltitude = value; }
        }

        // Check to see if AssistAltitude property is set
        internal bool IsSetAssistAltitude()
        {
            return this._assistAltitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssistPosition. 
        /// <para>
        /// Optional assistance position information, specified using latitude and longitude values
        /// in degrees. The coordinates are inside the WGS84 reference frame.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<float> AssistPosition
        {
            get { return this._assistPosition; }
            set { this._assistPosition = value; }
        }

        // Check to see if AssistPosition property is set
        internal bool IsSetAssistPosition()
        {
            return this._assistPosition != null && this._assistPosition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptureTime. 
        /// <para>
        /// Optional parameter that gives an estimate of the time when the GNSS scan information
        /// is taken, in seconds GPS time (GPST). If capture time is not specified, the local
        /// server time is used.
        /// </para>
        /// </summary>
        public float CaptureTime
        {
            get { return this._captureTime.GetValueOrDefault(); }
            set { this._captureTime = value; }
        }

        // Check to see if CaptureTime property is set
        internal bool IsSetCaptureTime()
        {
            return this._captureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaptureTimeAccuracy. 
        /// <para>
        /// Optional value that gives the capture time estimate accuracy, in seconds. If capture
        /// time accuracy is not specified, default value of 300 is used.
        /// </para>
        /// </summary>
        public float CaptureTimeAccuracy
        {
            get { return this._captureTimeAccuracy.GetValueOrDefault(); }
            set { this._captureTimeAccuracy = value; }
        }

        // Check to see if CaptureTimeAccuracy property is set
        internal bool IsSetCaptureTimeAccuracy()
        {
            return this._captureTimeAccuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Payload that contains the GNSS scan result, or NAV message, in hexadecimal notation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Use2DSolver. 
        /// <para>
        /// Optional parameter that forces 2D solve, which modifies the positioning algorithm
        /// to a 2D solution problem. When this parameter is specified, the assistance altitude
        /// should have an accuracy of at least 10 meters.
        /// </para>
        /// </summary>
        public bool Use2DSolver
        {
            get { return this._use2DSolver.GetValueOrDefault(); }
            set { this._use2DSolver = value; }
        }

        // Check to see if Use2DSolver property is set
        internal bool IsSetUse2DSolver()
        {
            return this._use2DSolver.HasValue; 
        }

    }
}