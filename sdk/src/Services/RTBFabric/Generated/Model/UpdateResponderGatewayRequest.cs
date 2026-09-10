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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
    /// Container for the parameters to the UpdateResponderGateway operation.
    /// Updates the description, Auto Scaling group managed endpoint configuration, trust
    /// store configuration, and client routing policy of a responder gateway. This operation
    /// also updates the <c>protocols</c> list in the listener configuration.
    /// 
    ///  
    /// <para>
    /// You cannot change the <c>domainName</c>, <c>port</c>, and <c>protocol</c> values that
    /// you set when you create a responder gateway. To change any of them, delete the gateway
    /// and create a new one.
    /// </para>
    /// </summary>
    public partial class UpdateResponderGatewayRequest : AmazonRTBFabricRequest
    {
        private ClientRoutingPolicy _clientRoutingPolicy;
        private string _clientToken;
        private string _description;
        private string _domainName;
        private string _gatewayId;
        private ListenerConfig _listenerConfig;
        private ManagedEndpointConfiguration _managedEndpointConfiguration;
        private int? _port;
        private Protocol _protocol;
        private TrustStoreConfiguration _trustStoreConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRoutingPolicy. 
        /// <para>
        /// The client routing policy of the gateway. This policy controls which Availability
        /// Zones RTB Fabric uses to reach the gateway for the requester gateways that send traffic
        /// to it. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABILITY_ZONE_AFFINITY</c>: RTB Fabric routes each requester's traffic to
        /// gateway capacity in the requester's own Availability Zone when the gateway has capacity
        /// available there. Otherwise, RTB Fabric routes the traffic to gateway capacity in the
        /// other Availability Zones of the gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANY_AVAILABILITY_ZONE</c>: RTB Fabric routes each requester's traffic to gateway
        /// capacity in every Availability Zone that the subnets of the gateway span. The Availability
        /// Zone that the requester is in does not change this.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, the gateway keeps its current client routing policy.
        /// Changing the policy sets the gateway status to <c>PENDING_UPDATE</c> until the change
        /// is complete. RTB Fabric does not support partial Availability Zone affinity, so <c>PARTIAL_AVAILABILITY_ZONE_AFFINITY</c>
        /// is not a valid value. For more information, see <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/working-with-responder-gateways.html#configuring-availability-zone-affinity">Configuring
        /// Availability Zone affinity</a> in the <i>Amazon Web Services RTB Fabric User Guide</i>.
        /// </para>
        /// </summary>
        public ClientRoutingPolicy ClientRoutingPolicy
        {
            get { return this._clientRoutingPolicy; }
            set { this._clientRoutingPolicy = value; }
        }

        // Check to see if ClientRoutingPolicy property is set
        internal bool IsSetClientRoutingPolicy()
        {
            return this._clientRoutingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>clientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the responder gateway.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Domain name for the responder gateway. This operation does not change the domain name
        /// of an existing gateway. To use a different domain name, delete the gateway and create
        /// a new one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=32)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerConfig. 
        /// <para>
        /// The listener configuration for the responder gateway.
        /// </para>
        /// </summary>
        public ListenerConfig ListenerConfig
        {
            get { return this._listenerConfig; }
            set { this._listenerConfig = value; }
        }

        // Check to see if ListenerConfig property is set
        internal bool IsSetListenerConfig()
        {
            return this._listenerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedEndpointConfiguration. 
        /// <para>
        /// The configuration for the managed endpoint.
        /// </para>
        /// </summary>
        public ManagedEndpointConfiguration ManagedEndpointConfiguration
        {
            get { return this._managedEndpointConfiguration; }
            set { this._managedEndpointConfiguration = value; }
        }

        // Check to see if ManagedEndpointConfiguration property is set
        internal bool IsSetManagedEndpointConfiguration()
        {
            return this._managedEndpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Networking port to use. This operation does not change the port of an existing gateway.
        /// To use a different port, delete the gateway and create a new one.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Networking protocol to use. This operation does not change the protocol of an existing
        /// gateway. To use a different protocol, delete the gateway and create a new one.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreConfiguration. 
        /// <para>
        /// The configuration of the trust store.
        /// </para>
        /// </summary>
        public TrustStoreConfiguration TrustStoreConfiguration
        {
            get { return this._trustStoreConfiguration; }
            set { this._trustStoreConfiguration = value; }
        }

        // Check to see if TrustStoreConfiguration property is set
        internal bool IsSetTrustStoreConfiguration()
        {
            return this._trustStoreConfiguration != null;
        }

    }
}