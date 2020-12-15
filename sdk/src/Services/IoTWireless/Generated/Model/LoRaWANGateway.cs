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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWANGateway object.
    /// </summary>
    public partial class LoRaWANGateway
    {
        private string _gatewayEui;
        private string _rfRegion;

        /// <summary>
        /// Gets and sets the property GatewayEui. 
        /// <para>
        /// The gateway's EUI value.
        /// </para>
        /// </summary>
        public string GatewayEui
        {
            get { return this._gatewayEui; }
            set { this._gatewayEui = value; }
        }

        // Check to see if GatewayEui property is set
        internal bool IsSetGatewayEui()
        {
            return this._gatewayEui != null;
        }

        /// <summary>
        /// Gets and sets the property RfRegion. 
        /// <para>
        /// The frequency band (RFRegion) value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

    }
}