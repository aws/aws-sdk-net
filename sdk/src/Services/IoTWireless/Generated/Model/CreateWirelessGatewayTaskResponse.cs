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
    /// This is the response object from the CreateWirelessGatewayTask operation.
    /// </summary>
    public partial class CreateWirelessGatewayTaskResponse : AmazonWebServiceResponse
    {
        private WirelessGatewayTaskStatus _status;
        private string _wirelessGatewayTaskDefinitionId;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        public WirelessGatewayTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewayTaskDefinitionId. 
        /// <para>
        /// The ID of the WirelessGatewayTaskDefinition.
        /// </para>
        /// </summary>
        [AWSProperty(Max=36)]
        public string WirelessGatewayTaskDefinitionId
        {
            get { return this._wirelessGatewayTaskDefinitionId; }
            set { this._wirelessGatewayTaskDefinitionId = value; }
        }

        // Check to see if WirelessGatewayTaskDefinitionId property is set
        internal bool IsSetWirelessGatewayTaskDefinitionId()
        {
            return this._wirelessGatewayTaskDefinitionId != null;
        }

    }
}