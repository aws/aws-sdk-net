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
    /// This is the response object from the GetResponderGateway operation.
    /// </summary>
    public partial class GetResponderGatewayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActiveLinksCount. 
        /// <para>
        /// The count of active links for the responder gateway.
        /// </para>
        /// </summary>
        public int? ActiveLinksCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveLinksCount property is set.
        /// </summary>
        internal bool IsSetActiveLinksCount() => this.ActiveLinksCount.HasValue;

        /// <summary>
        /// Gets and sets the property ClientRoutingPolicy. 
        /// <para>
        /// The client routing policy of the gateway. This policy controls which Availability
        /// Zones RTB Fabric uses to reach the gateway for the requester gateways that send traffic
        /// to it. RTB Fabric omits this member if the gateway has never had a client routing
        /// policy. An omitted value means that the gateway uses <c>AVAILABILITY_ZONE_AFFINITY</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/working-with-responder-gateways.html#configuring-availability-zone-affinity">Configuring
        /// Availability Zone affinity</a> in the <i>Amazon Web Services RTB Fabric User Guide</i>.
        /// </para>
        /// </summary>
        public ClientRoutingPolicy ClientRoutingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ClientRoutingPolicy property is set.
        /// </summary>
        internal bool IsSetClientRoutingPolicy() => this.ClientRoutingPolicy != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the responder gateway was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the responder gateway.
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
        /// The domain name of the responder gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ExternalInboundEndpoint. 
        /// <para>
        /// The external inbound endpoint for the responder gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ExternalInboundEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ExternalInboundEndpoint property is set.
        /// </summary>
        internal bool IsSetExternalInboundEndpoint() => this.ExternalInboundEndpoint != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of gateway. Valid values are <c>EXTERNAL</c> or <c>INTERNAL</c>.
        /// </para>
        /// </summary>
        public GatewayType GatewayType { get; set; }

        /// <summary>
        /// Checks to see if the GatewayType property is set.
        /// </summary>
        internal bool IsSetGatewayType() => this.GatewayType != null;

        /// <summary>
        /// Gets and sets the property LinksRequestedCount. 
        /// <para>
        /// The count of requested links waiting for the responder gateway to accept or reject.
        /// </para>
        /// </summary>
        public int? LinksRequestedCount { get; set; }

        /// <summary>
        /// Checks to see if the LinksRequestedCount property is set.
        /// </summary>
        internal bool IsSetLinksRequestedCount() => this.LinksRequestedCount.HasValue;

        /// <summary>
        /// Gets and sets the property ListenerConfig. 
        /// <para>
        /// The listener configuration for the responder gateway.
        /// </para>
        /// </summary>
        public ListenerConfig ListenerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ListenerConfig property is set.
        /// </summary>
        internal bool IsSetListenerConfig() => this.ListenerConfig != null;

        /// <summary>
        /// Gets and sets the property ManagedEndpointConfiguration. 
        /// <para>
        /// The configuration of the managed endpoint.
        /// </para>
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
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponderGatewayStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The unique identifiers of the subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs for the tag or tags assigned to the specified resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalLinksCount. 
        /// <para>
        /// The total count of links for the responder gateway.
        /// </para>
        /// </summary>
        public int? TotalLinksCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalLinksCount property is set.
        /// </summary>
        internal bool IsSetTotalLinksCount() => this.TotalLinksCount.HasValue;

        /// <summary>
        /// Gets and sets the property TrustStoreConfiguration. 
        /// <para>
        /// The configuration of the trust store.
        /// </para>
        /// </summary>
        public TrustStoreConfiguration TrustStoreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreConfiguration property is set.
        /// </summary>
        internal bool IsSetTrustStoreConfiguration() => this.TrustStoreConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the responder gateway was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the Virtual Private Cloud (VPC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
