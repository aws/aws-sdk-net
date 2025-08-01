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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains details for a gateway that runs on IoT Greengrass V2. To create a gateway
    /// that runs on IoT Greengrass V2, you must deploy the IoT SiteWise Edge component to
    /// your gateway device. Your <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/device-service-role.html">Greengrass
    /// device role</a> must use the <c>AWSIoTSiteWiseEdgeAccess</c> policy. For more information,
    /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/sw-gateways.html">Using
    /// IoT SiteWise at the edge</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class GreengrassV2
    {
        private CoreDeviceOperatingSystem _coreDeviceOperatingSystem;
        private string _coreDeviceThingName;

        /// <summary>
        /// Gets and sets the property CoreDeviceOperatingSystem. 
        /// <para>
        /// The operating system of the core device in IoT Greengrass V2. Specifying the operating
        /// system is required for MQTT-enabled, V3 gateways (<c>gatewayVersion</c> <c>3</c>)
        /// and not applicable for Classic stream, V2 gateways (<c>gatewayVersion</c> <c>2</c>).
        /// </para>
        /// </summary>
        public CoreDeviceOperatingSystem CoreDeviceOperatingSystem
        {
            get { return this._coreDeviceOperatingSystem; }
            set { this._coreDeviceOperatingSystem = value; }
        }

        // Check to see if CoreDeviceOperatingSystem property is set
        internal bool IsSetCoreDeviceOperatingSystem()
        {
            return this._coreDeviceOperatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the IoT thing for your IoT Greengrass V2 core device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CoreDeviceThingName
        {
            get { return this._coreDeviceThingName; }
            set { this._coreDeviceThingName = value; }
        }

        // Check to see if CoreDeviceThingName property is set
        internal bool IsSetCoreDeviceThingName()
        {
            return this._coreDeviceThingName != null;
        }

    }
}