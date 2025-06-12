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
    /// This is the response object from the GetLogLevelsByResourceTypes operation.
    /// </summary>
    public partial class GetLogLevelsByResourceTypesResponse : AmazonWebServiceResponse
    {
        private LogLevel _defaultLogLevel;
        private List<FuotaTaskLogOption> _fuotaTaskLogOptions = AWSConfigs.InitializeCollections ? new List<FuotaTaskLogOption>() : null;
        private List<WirelessDeviceLogOption> _wirelessDeviceLogOptions = AWSConfigs.InitializeCollections ? new List<WirelessDeviceLogOption>() : null;
        private List<WirelessGatewayLogOption> _wirelessGatewayLogOptions = AWSConfigs.InitializeCollections ? new List<WirelessGatewayLogOption>() : null;

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
        /// Gets and sets the property FuotaTaskLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FuotaTaskLogOption> FuotaTaskLogOptions
        {
            get { return this._fuotaTaskLogOptions; }
            set { this._fuotaTaskLogOptions = value; }
        }

        // Check to see if FuotaTaskLogOptions property is set
        internal bool IsSetFuotaTaskLogOptions()
        {
            return this._fuotaTaskLogOptions != null && (this._fuotaTaskLogOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WirelessDeviceLogOption> WirelessDeviceLogOptions
        {
            get { return this._wirelessDeviceLogOptions; }
            set { this._wirelessDeviceLogOptions = value; }
        }

        // Check to see if WirelessDeviceLogOptions property is set
        internal bool IsSetWirelessDeviceLogOptions()
        {
            return this._wirelessDeviceLogOptions != null && (this._wirelessDeviceLogOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewayLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WirelessGatewayLogOption> WirelessGatewayLogOptions
        {
            get { return this._wirelessGatewayLogOptions; }
            set { this._wirelessGatewayLogOptions = value; }
        }

        // Check to see if WirelessGatewayLogOptions property is set
        internal bool IsSetWirelessGatewayLogOptions()
        {
            return this._wirelessGatewayLogOptions != null && (this._wirelessGatewayLogOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}