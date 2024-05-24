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
    /// Trace content for your wireless devices, gateways, and multicast groups.
    /// </summary>
    public partial class TraceContent
    {
        private LogLevel _logLevel;
        private MulticastFrameInfo _multicastFrameInfo;
        private WirelessDeviceFrameInfo _wirelessDeviceFrameInfo;

        /// <summary>
        /// Gets and sets the property LogLevel.
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastFrameInfo.
        /// </summary>
        public MulticastFrameInfo MulticastFrameInfo
        {
            get { return this._multicastFrameInfo; }
            set { this._multicastFrameInfo = value; }
        }

        // Check to see if MulticastFrameInfo property is set
        internal bool IsSetMulticastFrameInfo()
        {
            return this._multicastFrameInfo != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceFrameInfo.
        /// </summary>
        public WirelessDeviceFrameInfo WirelessDeviceFrameInfo
        {
            get { return this._wirelessDeviceFrameInfo; }
            set { this._wirelessDeviceFrameInfo = value; }
        }

        // Check to see if WirelessDeviceFrameInfo property is set
        internal bool IsSetWirelessDeviceFrameInfo()
        {
            return this._wirelessDeviceFrameInfo != null;
        }

    }
}