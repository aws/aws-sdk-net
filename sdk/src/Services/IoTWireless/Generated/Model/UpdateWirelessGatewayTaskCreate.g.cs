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
    /// UpdateWirelessGatewayTaskCreate object.
    /// </summary>
    public partial class UpdateWirelessGatewayTaskCreate
    {
        /// <summary>
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// The properties that relate to the LoRaWAN wireless gateway.
        /// </para>
        /// </summary>
        public LoRaWANUpdateGatewayTaskCreate LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property UpdateDataRole. 
        /// <para>
        /// The IAM role used to read data from the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string UpdateDataRole { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDataRole property is set.
        /// </summary>
        internal bool IsSetUpdateDataRole() => this.UpdateDataRole != null;

        /// <summary>
        /// Gets and sets the property UpdateDataSource. 
        /// <para>
        /// The link to the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string UpdateDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDataSource() => this.UpdateDataSource != null;
    }
}
