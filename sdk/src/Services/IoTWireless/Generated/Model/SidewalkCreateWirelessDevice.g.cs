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
    /// Sidewalk object for creating a wireless device.
    /// </summary>
    public partial class SidewalkCreateWirelessDevice
    {
        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// The ID of the Sidewalk device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DeviceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProfileId property is set.
        /// </summary>
        internal bool IsSetDeviceProfileId() => this.DeviceProfileId != null;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The Positioning object of the Sidewalk device.
        /// </para>
        /// </summary>
        public SidewalkPositioning Positioning { get; set; }

        /// <summary>
        /// Checks to see if the Positioning property is set.
        /// </summary>
        internal bool IsSetPositioning() => this.Positioning != null;

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SidewalkManufacturingSn { get; set; }

        /// <summary>
        /// Checks to see if the SidewalkManufacturingSn property is set.
        /// </summary>
        internal bool IsSetSidewalkManufacturingSn() => this.SidewalkManufacturingSn != null;
    }
}
