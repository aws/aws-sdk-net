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
    /// This is the response object from the GetLogLevelsByResourceTypes operation.
    /// </summary>
    public partial class GetLogLevelsByResourceTypesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DefaultLogLevel.
        /// </summary>
        public LogLevel DefaultLogLevel { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLogLevel property is set.
        /// </summary>
        internal bool IsSetDefaultLogLevel() => this.DefaultLogLevel != null;

        /// <summary>
        /// Gets and sets the property FuotaTaskLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FuotaTaskLogOption> FuotaTaskLogOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<FuotaTaskLogOption>() : null;

        /// <summary>
        /// Checks to see if the FuotaTaskLogOptions property is set.
        /// </summary>
        internal bool IsSetFuotaTaskLogOptions() => this.FuotaTaskLogOptions != null && (this.FuotaTaskLogOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WirelessDeviceLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WirelessDeviceLogOption> WirelessDeviceLogOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<WirelessDeviceLogOption>() : null;

        /// <summary>
        /// Checks to see if the WirelessDeviceLogOptions property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceLogOptions() => this.WirelessDeviceLogOptions != null && (this.WirelessDeviceLogOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WirelessGatewayLogOptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WirelessGatewayLogOption> WirelessGatewayLogOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<WirelessGatewayLogOption>() : null;

        /// <summary>
        /// Checks to see if the WirelessGatewayLogOptions property is set.
        /// </summary>
        internal bool IsSetWirelessGatewayLogOptions() => this.WirelessGatewayLogOptions != null && (this.WirelessGatewayLogOptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
