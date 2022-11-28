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
    /// Wi-Fi access point.
    /// </summary>
    public partial class WiFiAccessPoint
    {
        private string _macAddress;
        private int? _rss;

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// Wi-Fi MAC Address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=17)]
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Rss. 
        /// <para>
        /// Recived signal strength of the WLAN measurement data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-128, Max=0)]
        public int Rss
        {
            get { return this._rss.GetValueOrDefault(); }
            set { this._rss = value; }
        }

        // Check to see if Rss property is set
        internal bool IsSetRss()
        {
            return this._rss.HasValue; 
        }

    }
}