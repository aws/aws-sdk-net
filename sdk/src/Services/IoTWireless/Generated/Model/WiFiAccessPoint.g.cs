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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Wi-Fi access point.
    /// </summary>
    public partial class WiFiAccessPoint
    {
        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// Wi-Fi MAC Address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 17)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property Rss. 
        /// <para>
        /// Received signal strength (dBm) of the WLAN measurement data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -128, Max = 0)]
        public int? Rss { get; set; }

        /// <summary>
        /// Checks to see if the Rss property is set.
        /// </summary>
        internal bool IsSetRss() => this.Rss.HasValue;
    }
}
