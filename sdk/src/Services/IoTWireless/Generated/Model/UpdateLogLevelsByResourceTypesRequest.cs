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
    /// Container for the parameters to the UpdateLogLevelsByResourceTypes operation.
    /// Set default log level, or log levels by resource types, could be for wireless device
    /// log options or wireless gateways log options. This is to control the log messages
    /// that will be displayed in CloudWatch.
    /// </summary>
    public partial class UpdateLogLevelsByResourceTypesRequest : AmazonIoTWirelessRequest
    {
        private LogLevel _defaultLogLevel;
        private List<WirelessDeviceLogOption> _wirelessDeviceLogOptions = new List<WirelessDeviceLogOption>();
        private List<WirelessGatewayLogOption> _wirelessGatewayLogOptions = new List<WirelessGatewayLogOption>();

        /// <summary>
        /// Gets and sets the property DefaultLogLevel.
        /// </summary>
        public LogLevel DefaultLogLevel
        {
            get { return this._defaultLogLevel; }
            set { this._defaultLogLevel = value; }
        }

        // Check to see if DefaultLogLevel property is set
        internal bool IsSetDefaultLogLevel()
        {
            return this._defaultLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceLogOptions.
        /// </summary>
        public List<WirelessDeviceLogOption> WirelessDeviceLogOptions
        {
            get { return this._wirelessDeviceLogOptions; }
            set { this._wirelessDeviceLogOptions = value; }
        }

        // Check to see if WirelessDeviceLogOptions property is set
        internal bool IsSetWirelessDeviceLogOptions()
        {
            return this._wirelessDeviceLogOptions != null && this._wirelessDeviceLogOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewayLogOptions.
        /// </summary>
        public List<WirelessGatewayLogOption> WirelessGatewayLogOptions
        {
            get { return this._wirelessGatewayLogOptions; }
            set { this._wirelessGatewayLogOptions = value; }
        }

        // Check to see if WirelessGatewayLogOptions property is set
        internal bool IsSetWirelessGatewayLogOptions()
        {
            return this._wirelessGatewayLogOptions != null && this._wirelessGatewayLogOptions.Count > 0; 
        }

    }
}