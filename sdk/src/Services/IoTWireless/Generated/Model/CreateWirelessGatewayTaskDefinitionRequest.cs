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
    /// Container for the parameters to the CreateWirelessGatewayTaskDefinition operation.
    /// Creates a gateway task definition.
    /// </summary>
    public partial class CreateWirelessGatewayTaskDefinitionRequest : AmazonIoTWirelessRequest
    {
        private bool? _autoCreateTasks;
        private string _clientRequestToken;
        private string _name;
        private UpdateWirelessGatewayTaskCreate _update;

        /// <summary>
        /// Gets and sets the property AutoCreateTasks. 
        /// <para>
        /// Whether to automatically create tasks using this task definition for all gateways
        /// with the specified current version. If <code>false</code>, the task must me created
        /// by calling <code>CreateWirelessGatewayTask</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AutoCreateTasks
        {
            get { return this._autoCreateTasks.GetValueOrDefault(); }
            set { this._autoCreateTasks = value; }
        }

        // Check to see if AutoCreateTasks property is set
        internal bool IsSetAutoCreateTasks()
        {
            return this._autoCreateTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each resource must have a unique client request token. If you try to create a new
        /// resource with the same token as a resource that already exists, an exception occurs.
        /// If you omit this value, AWS SDKs will automatically generate a unique client request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// Information about the gateways to update.
        /// </para>
        /// </summary>
        public UpdateWirelessGatewayTaskCreate Update
        {
            get { return this._update; }
            set { this._update = value; }
        }

        // Check to see if Update property is set
        internal bool IsSetUpdate()
        {
            return this._update != null;
        }

    }
}