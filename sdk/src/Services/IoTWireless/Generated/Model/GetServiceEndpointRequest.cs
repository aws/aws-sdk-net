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
    /// Container for the parameters to the GetServiceEndpoint operation.
    /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
    /// or LoRaWAN Network Server (LNS) connections.
    /// </summary>
    public partial class GetServiceEndpointRequest : AmazonIoTWirelessRequest
    {
        private WirelessGatewayServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The service type for which to get endpoint information about. Can be <c>CUPS</c> for
        /// the Configuration and Update Server endpoint, or <c>LNS</c> for the LoRaWAN Network
        /// Server endpoint.
        /// </para>
        /// </summary>
        public WirelessGatewayServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}