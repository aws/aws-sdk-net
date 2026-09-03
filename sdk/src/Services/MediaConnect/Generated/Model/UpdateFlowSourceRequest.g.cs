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
    /// Container for the parameters to the UpdateFlowSource operation. Updates the source
    /// of a flow. <note> <para> Because <c>UpdateFlowSources</c> and <c>UpdateFlow</c> are
    /// separate operations, you can't change both the source type AND the flow size in a
    /// single request. </para> <ul> <li> <para> If you have a <c>MEDIUM</c> flow and you
    /// want to change the flow source to NDI®: </para> <ul> <li> <para> First, use the <c>UpdateFlow</c>
    /// operation to upgrade the flow size to <c>LARGE</c>. </para> </li> <li> <para> After
    /// that, you can then use the <c>UpdateFlowSource</c> operation to configure the NDI
    /// source. </para> </li> </ul> </li> <li> <para> If you're switching from an NDI source
    /// to a transport stream (TS) source and want to downgrade the flow size: </para> <ul>
    /// <li> <para> First, use the <c>UpdateFlowSource</c> operation to change the flow source
    /// type. </para> </li> <li> <para> After that, you can then use the <c>UpdateFlow</c>
    /// operation to downgrade the flow size to <c>MEDIUM</c>. </para> </li> </ul> </li> </ul>
    /// </note>
    /// </summary>
    public partial class UpdateFlowSourceRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Decryption. 
        /// <para>
        /// The type of encryption that is used on the content ingested from the source. 
        /// </para>
        /// </summary>
        public UpdateEncryption Decryption { get; set; }

        /// <summary>
        /// Checks to see if the Decryption property is set.
        /// </summary>
        internal bool IsSetDecryption() => this.Decryption != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the source. This description is not visible outside of the current
        /// Amazon Web Services account. 
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
        /// The Amazon Resource Name (ARN) of the entitlement that allows you to subscribe to
        /// the flow. The entitlement is set by the content originator, and the ARN is generated
        /// as part of the originator's flow. 
        /// </para>
        /// </summary>
        public string EntitlementArn { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementArn property is set.
        /// </summary>
        internal bool IsSetEntitlementArn() => this.EntitlementArn != null;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property GatewayBridgeSource. 
        /// <para>
        /// The source configuration for cloud flows receiving a stream from a bridge. 
        /// </para>
        /// </summary>
        public UpdateGatewayBridgeSourceRequest GatewayBridgeSource { get; set; }

        /// <summary>
        /// Checks to see if the GatewayBridgeSource property is set.
        /// </summary>
        internal bool IsSetGatewayBridgeSource() => this.GatewayBridgeSource != null;

        /// <summary>
        /// Gets and sets the property IngestPort. 
        /// <para>
        /// The port that the flow listens on for incoming content. If the protocol of the source
        /// is Zixi, the port must be set to 2088. 
        /// </para>
        /// </summary>
        public int? IngestPort { get; set; }

        /// <summary>
        /// Checks to see if the IngestPort property is set.
        /// </summary>
        internal bool IsSetIngestPort() => this.IngestPort.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBitrate. 
        /// <para>
        /// The maximum bitrate for RIST, RTP, and RTP-FEC streams. 
        /// </para>
        /// </summary>
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLatency. 
        /// <para>
        /// The maximum latency in milliseconds. This parameter applies only to RIST-based and
        /// Zixi-based streams. 
        /// </para>
        /// </summary>
        public int? MaxLatency { get; set; }

        /// <summary>
        /// Checks to see if the MaxLatency property is set.
        /// </summary>
        internal bool IsSetMaxLatency() => this.MaxLatency.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSyncBuffer. 
        /// <para>
        /// The size of the buffer (in milliseconds) to use to sync incoming source data. 
        /// </para>
        /// </summary>
        public int? MaxSyncBuffer { get; set; }

        /// <summary>
        /// Checks to see if the MaxSyncBuffer property is set.
        /// </summary>
        internal bool IsSetMaxSyncBuffer() => this.MaxSyncBuffer.HasValue;

        /// <summary>
        /// Gets and sets the property MediaStreamSourceConfigurations. 
        /// <para>
        /// The media stream that is associated with the source, and the parameters for that association.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamSourceConfigurationRequest> MediaStreamSourceConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaStreamSourceConfigurationRequest>() : null;

        /// <summary>
        /// Checks to see if the MediaStreamSourceConfigurations property is set.
        /// </summary>
        internal bool IsSetMediaStreamSourceConfigurations() => this.MediaStreamSourceConfigurations != null && (this.MediaStreamSourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MinLatency. 
        /// <para>
        /// The minimum latency in milliseconds for SRT-based streams. In streams that use the
        /// SRT protocol, this value that you set on your MediaConnect source or output represents
        /// the minimal potential latency of that connection. The latency of the stream is set
        /// to the highest number between the sender’s minimum latency and the receiver’s minimum
        /// latency. 
        /// </para>
        /// </summary>
        public int? MinLatency { get; set; }

        /// <summary>
        /// Checks to see if the MinLatency property is set.
        /// </summary>
        internal bool IsSetMinLatency() => this.MinLatency.HasValue;

        /// <summary>
        /// Gets and sets the property NdiSourceSettings. 
        /// <para>
        ///  The settings for the NDI source. This includes the exact name of the upstream NDI
        /// sender that you want to connect to your source. 
        /// </para>
        /// </summary>
        public NdiSourceSettings NdiSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the NdiSourceSettings property is set.
        /// </summary>
        internal bool IsSetNdiSourceSettings() => this.NdiSourceSettings != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol that the source uses to deliver the content to MediaConnect. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Elemental MediaConnect no longer supports the Fujitsu QoS protocol. This reference
        /// is maintained for legacy purposes only.
        /// </para>
        ///  </note>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RouterIntegrationState. 
        /// <para>
        /// Indicates whether to enable or disable router integration for this flow source.
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
        /// The encryption configuration for the flow source when router integration is enabled.
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
        /// The port that the flow uses to send outbound requests to initiate connection with
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
        /// The IP address that the flow communicates with to initiate connection with the sender.
        /// 
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
        /// The ARN of the source that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceListenerAddress. 
        /// <para>
        /// The source IP or domain name for SRT-caller protocol. 
        /// </para>
        /// </summary>
        public string SourceListenerAddress { get; set; }

        /// <summary>
        /// Checks to see if the SourceListenerAddress property is set.
        /// </summary>
        internal bool IsSetSourceListenerAddress() => this.SourceListenerAddress != null;

        /// <summary>
        /// Gets and sets the property SourceListenerPort. 
        /// <para>
        /// Source port for SRT-caller protocol. 
        /// </para>
        /// </summary>
        public int? SourceListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the SourceListenerPort property is set.
        /// </summary>
        internal bool IsSetSourceListenerPort() => this.SourceListenerPort.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID that you want to use for this transport. This parameter applies only
        /// to Zixi and SRT caller-based streams. 
        /// </para>
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. 
        /// <para>
        /// The name of the VPC interface that you want to send your output to.
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
        /// The range of IP addresses that are allowed to contribute content to your source. Format
        /// the IP addresses as a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// 
        /// </para>
        /// </summary>
        public string WhitelistCidr { get; set; }

        /// <summary>
        /// Checks to see if the WhitelistCidr property is set.
        /// </summary>
        internal bool IsSetWhitelistCidr() => this.WhitelistCidr != null;
    }
}
