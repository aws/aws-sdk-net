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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a Greengrass core device, which is an IoT thing that runs
    /// the IoT Greengrass Core software.
    /// </summary>
    public partial class CoreDevice
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The computer architecture of the core device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CoreDeviceThingName { get; set; }

        /// <summary>
        /// Checks to see if the CoreDeviceThingName property is set.
        /// </summary>
        internal bool IsSetCoreDeviceThingName() => this.CoreDeviceThingName != null;

        /// <summary>
        /// Gets and sets the property LastStatusUpdateTimestamp. 
        /// <para>
        /// The time at which the core device's status last updated, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastStatusUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastStatusUpdateTimestamp() => this.LastStatusUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform that the core device runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime for the core device. The runtime can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws_nucleus_classic</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws_nucleus_lite</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core device. Core devices can have the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEALTHY</c> – The IoT Greengrass Core software and all components run on the core
        /// device without issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> – The IoT Greengrass Core software or a component is in a failed
        /// state on the core device.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CoreDeviceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
