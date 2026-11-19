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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// A requested responder gateway configuration.
    /// </summary>
    public partial class ResponderGatewayConfigParameters
    {
        /// <summary>
        /// Gets and sets the property ClientRoutingPolicy. 
        /// <para>
        /// The gateway's client routing policy.
        /// </para>
        /// </summary>
        public ClientRoutingPolicy ClientRoutingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ClientRoutingPolicy property is set.
        /// </summary>
        internal bool IsSetClientRoutingPolicy() => this.ClientRoutingPolicy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The gateway's description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The gateway's domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ListenerConfig.
        /// </summary>
        public ListenerConfig ListenerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ListenerConfig property is set.
        /// </summary>
        internal bool IsSetListenerConfig() => this.ListenerConfig != null;

        /// <summary>
        /// Gets and sets the property ManagedEndpointConfiguration.
        /// </summary>
        public ManagedEndpointConfiguration ManagedEndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedEndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedEndpointConfiguration() => this.ManagedEndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The networking port.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The networking protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property TrustStoreConfiguration.
        /// </summary>
        public TrustStoreConfiguration TrustStoreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreConfiguration property is set.
        /// </summary>
        internal bool IsSetTrustStoreConfiguration() => this.TrustStoreConfiguration != null;
    }
}
