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
    /// Trace content for your wireless devices, gateways, and multicast groups.
    /// </summary>
    public partial class TraceContent
    {
        /// <summary>
        /// Gets and sets the property LogLevel.
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property MulticastFrameInfo.
        /// </summary>
        public MulticastFrameInfo MulticastFrameInfo { get; set; }

        /// <summary>
        /// Checks to see if the MulticastFrameInfo property is set.
        /// </summary>
        internal bool IsSetMulticastFrameInfo() => this.MulticastFrameInfo != null;

        /// <summary>
        /// Gets and sets the property WirelessDeviceFrameInfo.
        /// </summary>
        public WirelessDeviceFrameInfo WirelessDeviceFrameInfo { get; set; }

        /// <summary>
        /// Checks to see if the WirelessDeviceFrameInfo property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceFrameInfo() => this.WirelessDeviceFrameInfo != null;
    }
}
