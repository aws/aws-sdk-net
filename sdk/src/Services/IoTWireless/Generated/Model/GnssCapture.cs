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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// A single GNSS scan capture containing the scan payload and optional capture time.
    /// </summary>
    public partial class GnssCapture
    {
        private float? _captureTime;
        private string _payload;

        /// <summary>
        /// Gets and sets the property CaptureTime. 
        /// <para>
        /// Optional parameter that gives an estimate of the time when the GNSS scan information
        /// is taken, in seconds GPS time (GPST). If capture time is not specified, the local
        /// server time is used.
        /// </para>
        /// </summary>
        public float? CaptureTime
        {
            get { return this._captureTime; }
            set { this._captureTime = value; }
        }

        // Check to see if CaptureTime property is set
        internal bool IsSetCaptureTime()
        {
            return this._captureTime.HasValue; 
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

    }
}