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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for the source of the flow.
    /// </summary>
    public partial class Source
    {
        /// <summary>
        /// Gets and sets the property ConnectedRouterOutputArn. 
        /// <para>
        /// The ARN of the router output that's currently connected to this source.
        /// </para>
        /// </summary>
        public string ConnectedRouterOutputArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedRouterOutputArn property is set.
        /// </summary>
        internal bool IsSetConnectedRouterOutputArn() => this.ConnectedRouterOutputArn != null;

        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. 
        /// <para>
        ///  Percentage from 0-100 of the data transfer cost to be billed to the subscriber.
        /// </para>
        /// </summary>
        public int? DataTransferSubscriberFeePercent { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferSubscriberFeePercent property is set.
        /// </summary>
        internal bool IsSetDataTransferSubscriberFeePercent() => this.DataTransferSubscriberFeePercent.HasValue;

        /// <summary>
        /// Gets and sets the property Decryption. 
        /// <para>
        ///  The type of encryption that is used on the content ingested from this source.
        /// </para>
        /// </summary>
        public Encryption Decryption { get; set; }

        /// <summary>
        /// Checks to see if the Decryption property is set.
        /// </summary>
        internal bool IsSetDecryption() => this.Decryption != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description for the source. This value is not used or seen outside of the current
        /// MediaConnect account.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The ARN of the entitlement that allows you to subscribe to content that comes from
        /// another Amazon Web Services account. The entitlement is set by the content originator
        /// and the ARN is generated as part of the originator's flow.
        /// </para>
        /// </summary>
        public string EntitlementArn { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementArn property is set.
        /// </summary>
        internal bool IsSetEntitlementArn() => this.EntitlementArn != null;

        /// <summary>
        /// Gets and sets the property GatewayBridgeSource. 
        /// <para>
        ///  The source configuration for cloud flows receiving a stream from a bridge.
        /// </para>
        /// </summary>
        public GatewayBridgeSource GatewayBridgeSource { get; set; }

        /// <summary>
        /// Checks to see if the GatewayBridgeSource property is set.
        /// </summary>
        internal bool IsSetGatewayBridgeSource() => this.GatewayBridgeSource != null;

        /// <summary>
        /// Gets and sets the property IngestIp. 
        /// <para>
        ///  The IP address that the flow will be listening on for incoming content.
        /// </para>
        /// </summary>
        public string IngestIp { get; set; }

        /// <summary>
        /// Checks to see if the IngestIp property is set.
        /// </summary>
        internal bool IsSetIngestIp() => this.IngestIp != null;

        /// <summary>
        /// Gets and sets the property IngestPort. 
        /// <para>
        ///  The port that the flow will be listening on for incoming content.
        /// </para>
        /// </summary>
        public int? IngestPort { get; set; }

        /// <summary>
        /// Checks to see if the IngestPort property is set.
        /// </summary>
        internal bool IsSetIngestPort() => this.IngestPort.HasValue;

        /// <summary>
        /// Gets and sets the property MediaStreamSourceConfigurations. 
        /// <para>
        ///  The media streams that are associated with the source, and the parameters for those
        /// associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamSourceConfiguration> MediaStreamSourceConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaStreamSourceConfiguration>() : null;

        /// <summary>
        /// Checks to see if the MediaStreamSourceConfigurations property is set.
        /// </summary>
        internal bool IsSetMediaStreamSourceConfigurations() => this.MediaStreamSourceConfigurations != null && (this.MediaStreamSourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PeerIpAddress. 
        /// <para>
        /// The IP address of the device that is currently sending content to this source. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// For sources that use protocols where you specify the origin (such as SRT Caller),
        /// this value matches the configured origin address. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For sources that use listener protocols (such as SRT Listener or RTP), this value
        /// shows the address of the connected sender. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Peer IP addresses aren't available for entitlements and CDI/ST2110 sources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The peer IP address might not be visible for flows that haven't been started yet,
        /// or flows that were started before May 2025. In these cases, restart your flow to see
        /// the peer IP address.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string PeerIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerIpAddress property is set.
        /// </summary>
        internal bool IsSetPeerIpAddress() => this.PeerIpAddress != null;

        /// <summary>
        /// Gets and sets the property RouterIntegrationState. 
        /// <para>
        /// Indicates if router integration is enabled or disabled on the flow source.
        /// </para>
        /// </summary>
        public State RouterIntegrationState { get; set; }

        /// <summary>
        /// Checks to see if the RouterIntegrationState property is set.
        /// </summary>
        internal bool IsSetRouterIntegrationState() => this.RouterIntegrationState != null;

        /// <summary>
        /// Gets and sets the property RouterIntegrationTransitDecryption. 
        /// <para>
        /// The decryption configuration for the flow source when router integration is enabled.
        /// </para>
        /// </summary>
        public FlowTransitEncryption RouterIntegrationTransitDecryption { get; set; }

        /// <summary>
        /// Checks to see if the RouterIntegrationTransitDecryption property is set.
        /// </summary>
        internal bool IsSetRouterIntegrationTransitDecryption() => this.RouterIntegrationTransitDecryption != null;

        /// <summary>
        /// Gets and sets the property SenderControlPort. 
        /// <para>
        ///  The port that the flow uses to send outbound requests to initiate connection with
        /// the sender.
        /// </para>
        /// </summary>
        public int? SenderControlPort { get; set; }

        /// <summary>
        /// Checks to see if the SenderControlPort property is set.
        /// </summary>
        internal bool IsSetSenderControlPort() => this.SenderControlPort.HasValue;

        /// <summary>
        /// Gets and sets the property SenderIpAddress. 
        /// <para>
        ///  The IP address that the flow communicates with to initiate connection with the sender.
        /// </para>
        /// </summary>
        public string SenderIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the SenderIpAddress property is set.
        /// </summary>
        internal bool IsSetSenderIpAddress() => this.SenderIpAddress != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        ///  The ARN of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        ///  Attributes related to the transport stream that are used in the source.
        /// </para>
        /// </summary>
        public Transport Transport { get; set; }

        /// <summary>
        /// Checks to see if the Transport property is set.
        /// </summary>
        internal bool IsSetTransport() => this.Transport != null;

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. 
        /// <para>
        ///  The name of the VPC interface that is used for this source.
        /// </para>
        /// </summary>
        public string VpcInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VpcInterfaceName property is set.
        /// </summary>
        internal bool IsSetVpcInterfaceName() => this.VpcInterfaceName != null;

        /// <summary>
        /// Gets and sets the property WhitelistCidr. 
        /// <para>
        ///  The range of IP addresses that should be allowed to contribute content to your source.
        /// These IP addresses should be in the form of a Classless Inter-Domain Routing (CIDR)
        /// block; for example, 10.0.0.0/16.
        /// </para>
        /// </summary>
        public string WhitelistCidr { get; set; }

        /// <summary>
        /// Checks to see if the WhitelistCidr property is set.
        /// </summary>
        internal bool IsSetWhitelistCidr() => this.WhitelistCidr != null;
    }
}
