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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private bool? _bluetooth;
        private bool? _gps;
        private bool? _nfc;
        private bool? _wifi;

        /// <summary>
        /// Gets and sets the property Bluetooth. 
        /// <para>
        /// True if Bluetooth is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Bluetooth
        {
            get { return this._bluetooth; }
            set { this._bluetooth = value; }
        }

        // Check to see if Bluetooth property is set
        internal bool IsSetBluetooth()
        {
            return this._bluetooth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gps. 
        /// <para>
        /// True if GPS is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Gps
        {
            get { return this._gps; }
            set { this._gps = value; }
        }

        // Check to see if Gps property is set
        internal bool IsSetGps()
        {
            return this._gps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Nfc. 
        /// <para>
        /// True if NFC is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Nfc
        {
            get { return this._nfc; }
            set { this._nfc = value; }
        }

        // Check to see if Nfc property is set
        internal bool IsSetNfc()
        {
            return this._nfc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Wifi. 
        /// <para>
        /// True if Wi-Fi is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? Wifi
        {
            get { return this._wifi; }
            set { this._wifi = value; }
        }

        // Check to see if Wifi property is set
        internal bool IsSetWifi()
        {
            return this._wifi.HasValue; 
        }

    }
}