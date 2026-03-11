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
    /// Container for the parameters to the DescribeGatewayCapabilityConfiguration operation.
    /// Each gateway capability defines data sources for a gateway. This is the namespace
    /// of the gateway capability.
    /// 
    ///  
    /// <para>
    /// . The namespace follows the format <c>service:capability:version</c>, where:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>service</c> - The service providing the capability, or <c>iotsitewise</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>capability</c> - The specific capability type. Options include: <c>opcuacollector</c>
    /// for the OPC UA data source collector, or <c>publisher</c> for data publisher capability.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>version</c> - The version number of the capability. Option include <c>2</c> for
    /// Classic streams, V2 gateways, and <c>3</c> for MQTT-enabled, V3 gateways.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After updating a capability configuration, the sync status becomes <c>OUT_OF_SYNC</c>
    /// until the gateway processes the configuration.Use <c>DescribeGatewayCapabilityConfiguration</c>
    /// to check the sync status and verify the configuration was applied.
    /// </para>
    ///  
    /// <para>
    /// A gateway can have multiple capability configurations with different namespaces.
    /// </para>
    /// </summary>
    public partial class DescribeGatewayCapabilityConfigurationRequest : AmazonIoTSiteWiseRequest
    {
        private string _capabilityNamespace;
        private string _gatewayId;

        /// <summary>
        /// Gets and sets the property CapabilityNamespace. 
        /// <para>
        /// The namespace of the capability configuration. For example, if you configure OPC UA
        /// sources for an MQTT-enabled gateway, your OPC-UA capability configuration has the
        /// namespace <c>iotsitewise:opcuacollector:3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string CapabilityNamespace
        {
            get { return this._capabilityNamespace; }
            set { this._capabilityNamespace = value; }
        }

        // Check to see if CapabilityNamespace property is set
        internal bool IsSetCapabilityNamespace()
        {
            return this._capabilityNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the gateway that defines the capability configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

    }
}