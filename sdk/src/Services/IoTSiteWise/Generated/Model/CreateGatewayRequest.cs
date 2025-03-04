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
    /// Container for the parameters to the CreateGateway operation.
    /// Creates a gateway, which is a virtual or edge device that delivers industrial data
    /// streams from local servers to IoT SiteWise. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gateway-connector.html">Ingesting
    /// data using a gateway</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class CreateGatewayRequest : AmazonIoTSiteWiseRequest
    {
        private string _gatewayName;
        private GatewayPlatform _gatewayPlatform;
        private string _gatewayVersion;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// A unique name for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayPlatform. 
        /// <para>
        /// The gateway's platform. You can only specify one platform in a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayPlatform GatewayPlatform
        {
            get { return this._gatewayPlatform; }
            set { this._gatewayPlatform = value; }
        }

        // Check to see if GatewayPlatform property is set
        internal bool IsSetGatewayPlatform()
        {
            return this._gatewayPlatform != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayVersion. 
        /// <para>
        /// The version of the gateway to create. Specify <c>3</c> to create an MQTT-enabled,
        /// V3 gateway and <c>2</c> To create a Classic streams, V2 gateway. If the version isn't
        /// specified, a Classic streams, V2 gateway is created by default.
        /// </para>
        ///  
        /// <para>
        ///  We recommend creating an MQTT-enabled, V3 gateway for self-hosted gateways. SiteWise
        /// Edge gateways on Siemens Industrial Edge should use gateway version <c>2</c>. For
        /// more information on gateway versions, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gw-self-host-gg2.html">
        /// Self-host a SiteWise Edge gateway with IoT Greengrass V2</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GatewayVersion
        {
            get { return this._gatewayVersion; }
            set { this._gatewayVersion = value; }
        }

        // Check to see if GatewayVersion property is set
        internal bool IsSetGatewayVersion()
        {
            return this._gatewayVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the gateway. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}