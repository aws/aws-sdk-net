/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the specification of a virtual node.
    /// </summary>
    public partial class VirtualNodeSpec
    {
        private List<string> _backends = new List<string>();
        private List<Listener> _listeners = new List<Listener>();
        private ServiceDiscovery _serviceDiscovery;

        /// <summary>
        /// Gets and sets the property Backends. 
        /// <para>
        /// The backends to which the virtual node is expected to send outbound traffic.
        /// </para>
        /// </summary>
        public List<string> Backends
        {
            get { return this._backends; }
            set { this._backends = value; }
        }

        // Check to see if Backends property is set
        internal bool IsSetBackends()
        {
            return this._backends != null && this._backends.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listeners from which the virtual node is expected to receive inbound traffic.
        /// </para>
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && this._listeners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceDiscovery. 
        /// <para>
        /// The service discovery information for the virtual node.
        /// </para>
        /// </summary>
        public ServiceDiscovery ServiceDiscovery
        {
            get { return this._serviceDiscovery; }
            set { this._serviceDiscovery = value; }
        }

        // Check to see if ServiceDiscovery property is set
        internal bool IsSetServiceDiscovery()
        {
            return this._serviceDiscovery != null;
        }

    }
}