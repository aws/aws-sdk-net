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
    /// UpdateWirelessGatewayTaskCreate object.
    /// </summary>
    public partial class UpdateWirelessGatewayTaskCreate
    {
        private LoRaWANUpdateGatewayTaskCreate _loRaWAN;
        private string _updateDataRole;
        private string _updateDataSource;

        /// <summary>
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// The properties that relate to the LoRaWAN wireless gateway.
        /// </para>
        /// </summary>
        public LoRaWANUpdateGatewayTaskCreate LoRaWAN
        {
            get { return this._loRaWAN; }
            set { this._loRaWAN = value; }
        }

        // Check to see if LoRaWAN property is set
        internal bool IsSetLoRaWAN()
        {
            return this._loRaWAN != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDataRole. 
        /// <para>
        /// The IAM role used to read data from the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string UpdateDataRole
        {
            get { return this._updateDataRole; }
            set { this._updateDataRole = value; }
        }

        // Check to see if UpdateDataRole property is set
        internal bool IsSetUpdateDataRole()
        {
            return this._updateDataRole != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDataSource. 
        /// <para>
        /// The link to the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string UpdateDataSource
        {
            get { return this._updateDataSource; }
            set { this._updateDataSource = value; }
        }

        // Check to see if UpdateDataSource property is set
        internal bool IsSetUpdateDataSource()
        {
            return this._updateDataSource != null;
        }

    }
}