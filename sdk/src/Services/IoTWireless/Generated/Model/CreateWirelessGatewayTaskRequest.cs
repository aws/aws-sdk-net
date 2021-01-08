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
    /// Container for the parameters to the CreateWirelessGatewayTask operation.
    /// Creates a task for a wireless gateway.
    /// </summary>
    public partial class CreateWirelessGatewayTaskRequest : AmazonIoTWirelessRequest
    {
        private string _id;
        private string _wirelessGatewayTaskDefinitionId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewayTaskDefinitionId. 
        /// <para>
        /// The ID of the WirelessGatewayTaskDefinition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=36)]
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