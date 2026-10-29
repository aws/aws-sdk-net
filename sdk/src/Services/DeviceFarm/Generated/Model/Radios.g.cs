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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the set of radios and their states on a device. Examples of radios include
    /// Wi-Fi, GPS, Bluetooth, and NFC.
    /// </summary>
    public partial class Radios
    {
        /// <summary>
        /// Gets and sets the property Bluetooth. 
        /// <para>
        /// True if Bluetooth is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Bluetooth { get; set; }

        /// <summary>
        /// Checks to see if the Bluetooth property is set.
        /// </summary>
        internal bool IsSetBluetooth() => this.Bluetooth.HasValue;

        /// <summary>
        /// Gets and sets the property Gps. 
        /// <para>
        /// True if GPS is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Gps { get; set; }

        /// <summary>
        /// Checks to see if the Gps property is set.
        /// </summary>
        internal bool IsSetGps() => this.Gps.HasValue;

        /// <summary>
        /// Gets and sets the property Nfc. 
        /// <para>
        /// True if NFC is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Nfc { get; set; }

        /// <summary>
        /// Checks to see if the Nfc property is set.
        /// </summary>
        internal bool IsSetNfc() => this.Nfc.HasValue;

        /// <summary>
        /// Gets and sets the property Wifi. 
        /// <para>
        /// True if Wi-Fi is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Wifi { get; set; }

        /// <summary>
        /// Checks to see if the Wifi property is set.
        /// </summary>
        internal bool IsSetWifi() => this.Wifi.HasValue;
    }
}
