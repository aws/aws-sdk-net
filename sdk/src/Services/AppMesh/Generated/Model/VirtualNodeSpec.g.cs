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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the specification of a virtual node.
    /// </summary>
    public partial class VirtualNodeSpec
    {
        /// <summary>
        /// Gets and sets the property BackendDefaults. 
        /// <para>
        /// A reference to an object that represents the defaults for backends.
        /// </para>
        /// </summary>
        public BackendDefaults BackendDefaults { get; set; }

        /// <summary>
        /// Checks to see if the BackendDefaults property is set.
        /// </summary>
        internal bool IsSetBackendDefaults() => this.BackendDefaults != null;

        /// <summary>
        /// Gets and sets the property Backends. 
        /// <para>
        /// The backends that the virtual node is expected to send outbound traffic to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Backend> Backends { get; set; } = AWSConfigs.InitializeCollections ? new List<Backend>() : null;

        /// <summary>
        /// Checks to see if the Backends property is set.
        /// </summary>
        internal bool IsSetBackends() => this.Backends != null && (this.Backends.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listener that the virtual node is expected to receive inbound traffic from. You
        /// can specify one listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Listener> Listeners { get; set; } = AWSConfigs.InitializeCollections ? new List<Listener>() : null;

        /// <summary>
        /// Checks to see if the Listeners property is set.
        /// </summary>
        internal bool IsSetListeners() => this.Listeners != null && (this.Listeners.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The inbound and outbound access logging information for the virtual node.
        /// </para>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property ServiceDiscovery. 
        /// <para>
        /// The service discovery information for the virtual node. If your virtual node does
        /// not expect ingress traffic, you can omit this parameter. If you specify a <c>listener</c>,
        /// then you must specify service discovery information.
        /// </para>
        /// </summary>
        public ServiceDiscovery ServiceDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDiscovery property is set.
        /// </summary>
        internal bool IsSetServiceDiscovery() => this.ServiceDiscovery != null;
    }
}
