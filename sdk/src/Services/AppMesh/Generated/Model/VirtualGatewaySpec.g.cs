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
    /// An object that represents the specification of a service mesh resource.
    /// </summary>
    public partial class VirtualGatewaySpec
    {
        /// <summary>
        /// Gets and sets the property BackendDefaults. 
        /// <para>
        /// A reference to an object that represents the defaults for backends.
        /// </para>
        /// </summary>
        public VirtualGatewayBackendDefaults BackendDefaults { get; set; }

        /// <summary>
        /// Checks to see if the BackendDefaults property is set.
        /// </summary>
        internal bool IsSetBackendDefaults() => this.BackendDefaults != null;

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listeners that the mesh endpoint is expected to receive inbound traffic from.
        /// You can specify one listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<VirtualGatewayListener> Listeners { get; set; } = AWSConfigs.InitializeCollections ? new List<VirtualGatewayListener>() : null;

        /// <summary>
        /// Checks to see if the Listeners property is set.
        /// </summary>
        internal bool IsSetListeners() => this.Listeners != null && (this.Listeners.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Logging.
        /// </summary>
        public VirtualGatewayLogging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;
    }
}
