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
    /// LoRaWANGatewayVersion object.
    /// </summary>
    public partial class LoRaWANGatewayVersion
    {
        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model number of the wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The version of the wireless gateway firmware.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property Station. 
        /// <para>
        /// The basic station version of the wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Station { get; set; }

        /// <summary>
        /// Checks to see if the Station property is set.
        /// </summary>
        internal bool IsSetStation() => this.Station != null;
    }
}
