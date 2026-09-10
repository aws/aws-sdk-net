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
    /// Container for the parameters to the CreateResponderGateway operation.
    /// Creates a responder gateway.
    /// 
    ///  <important> 
    /// <para>
    /// A domain name or managed endpoint is required.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateResponderGatewayRequest : AmazonRTBFabricRequest
    {
        private ClientRoutingPolicy _clientRoutingPolicy;
        private string _clientToken;
        private string _description;
        private string _domainName;
        private GatewayType _gatewayType;
        private ListenerConfig _listenerConfig;
        private ManagedEndpointConfiguration _managedEndpointConfiguration;
        private int? _port;
        private Protocol _protocol;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TrustStoreConfiguration _trustStoreConfiguration;
        private string _vpcId;

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
        /// If you don't specify a value, RTB Fabric uses <c>AVAILABILITY_ZONE_AFFINITY</c>. To
        /// get the behavior of <c>ANY_AVAILABILITY_ZONE</c>, create the gateway with subnets
        /// in more than one Availability Zone. RTB Fabric does not support partial Availability
        /// Zone affinity, so <c>PARTIAL_AVAILABILITY_ZONE_AFFINITY</c> is not a valid value.
        /// For more information, see <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/working-with-responder-gateways.html#configuring-availability-zone-affinity">Configuring
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
        [AWSProperty(Min=0, Max=255)]
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
        /// The domain name for the responder gateway.
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
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of gateway. Valid values are <c>EXTERNAL</c> or <c>INTERNAL</c>.
        /// </para>
        /// </summary>
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerConfig.
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
        /// The networking port to use.
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
        /// The networking protocol to use.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Unique identifiers of the subnets. A service quota for your account sets the number
        /// of Availability Zones that your subnets can span. By default, this quota is one Availability
        /// Zone. To span more Availability Zones, request a quota increase.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the Virtual Private Cloud (VPC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=21)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}