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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Describe the endpoint with an Id, a name, and the relevant capabilities for reporting
    /// state
    /// </summary>
    public partial class StateEndpoint
    {
        private List<StateCapability> _capabilities = AWSConfigs.InitializeCollections ? new List<StateCapability>() : null;
        private string _endpointId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Describe the endpoint with an id, a name, and the relevant capabilities for the reporting
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<StateCapability> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// Numeric identifier of the endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

    }
}