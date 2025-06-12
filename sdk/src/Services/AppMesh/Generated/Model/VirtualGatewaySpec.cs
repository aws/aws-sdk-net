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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the specification of a service mesh resource.
    /// </summary>
    public partial class VirtualGatewaySpec
    {
        private VirtualGatewayBackendDefaults _backendDefaults;
        private List<VirtualGatewayListener> _listeners = AWSConfigs.InitializeCollections ? new List<VirtualGatewayListener>() : null;
        private VirtualGatewayLogging _logging;

        /// <summary>
        /// Gets and sets the property BackendDefaults. 
        /// <para>
        /// A reference to an object that represents the defaults for backends.
        /// </para>
        /// </summary>
        public VirtualGatewayBackendDefaults BackendDefaults
        {
            get { return this._backendDefaults; }
            set { this._backendDefaults = value; }
        }

        // Check to see if BackendDefaults property is set
        internal bool IsSetBackendDefaults()
        {
            return this._backendDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listeners that the mesh endpoint is expected to receive inbound traffic from.
        /// You can specify one listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VirtualGatewayListener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && (this._listeners.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Logging.
        /// </summary>
        public VirtualGatewayLogging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

    }
}