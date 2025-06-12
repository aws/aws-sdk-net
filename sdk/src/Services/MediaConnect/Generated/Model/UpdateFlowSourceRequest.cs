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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Container for the parameters to the UpdateFlowSource operation.
    /// Updates the source of a flow.
    /// </summary>
    public partial class UpdateFlowSourceRequest : AmazonMediaConnectRequest
    {
        private UpdateEncryption _decryption;
        private string _description;
        private string _entitlementArn;
        private string _flowArn;
        private UpdateGatewayBridgeSourceRequest _gatewayBridgeSource;
        private int? _ingestPort;
        private int? _maxBitrate;
        private int? _maxLatency;
        private int? _maxSyncBuffer;
        private List<MediaStreamSourceConfigurationRequest> _mediaStreamSourceConfigurations = AWSConfigs.InitializeCollections ? new List<MediaStreamSourceConfigurationRequest>() : null;
        private int? _minLatency;
        private Protocol _protocol;
        private int? _senderControlPort;
        private string _senderIpAddress;
        private string _sourceArn;
        private string _sourceListenerAddress;
        private int? _sourceListenerPort;
        private string _streamId;
        private string _vpcInterfaceName;
        private string _whitelistCidr;

        /// <summary>
        /// Gets and sets the property Decryption. 
        /// <para>
        /// The type of encryption that is used on the content ingested from the source. 
        /// </para>
        /// </summary>
        public UpdateEncryption Decryption
        {
            get { return this._decryption; }
            set { this._decryption = value; }
        }

        // Check to see if Decryption property is set
        internal bool IsSetDecryption()
        {
            return this._decryption != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the source. This description is not visible outside of the current
        /// Amazon Web Services account. 
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
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entitlement that allows you to subscribe to
        /// the flow. The entitlement is set by the content originator, and the ARN is generated
        /// as part of the originator's flow. 
        /// </para>
        /// </summary>
        public string EntitlementArn
        {
            get { return this._entitlementArn; }
            set { this._entitlementArn = value; }
        }

        // Check to see if EntitlementArn property is set
        internal bool IsSetEntitlementArn()
        {
            return this._entitlementArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayBridgeSource. 
        /// <para>
        /// The source configuration for cloud flows receiving a stream from a bridge. 
        /// </para>
        /// </summary>
        public UpdateGatewayBridgeSourceRequest GatewayBridgeSource
        {
            get { return this._gatewayBridgeSource; }
            set { this._gatewayBridgeSource = value; }
        }

        // Check to see if GatewayBridgeSource property is set
        internal bool IsSetGatewayBridgeSource()
        {
            return this._gatewayBridgeSource != null;
        }

        /// <summary>
        /// Gets and sets the property IngestPort. 
        /// <para>
        /// The port that the flow listens on for incoming content. If the protocol of the source
        /// is Zixi, the port must be set to 2088. 
        /// </para>
        /// </summary>
        public int? IngestPort
        {
            get { return this._ingestPort; }
            set { this._ingestPort = value; }
        }

        // Check to see if IngestPort property is set
        internal bool IsSetIngestPort()
        {
            return this._ingestPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. 
        /// <para>
        /// The maximum bitrate for RIST, RTP, and RTP-FEC streams. 
        /// </para>
        /// </summary>
        public int? MaxBitrate
        {
            get { return this._maxBitrate; }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLatency. 
        /// <para>
        /// The maximum latency in milliseconds. This parameter applies only to RIST-based and
        /// Zixi-based streams. 
        /// </para>
        /// </summary>
        public int? MaxLatency
        {
            get { return this._maxLatency; }
            set { this._maxLatency = value; }
        }

        // Check to see if MaxLatency property is set
        internal bool IsSetMaxLatency()
        {
            return this._maxLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSyncBuffer. 
        /// <para>
        /// The size of the buffer (in milliseconds) to use to sync incoming source data. 
        /// </para>
        /// </summary>
        public int? MaxSyncBuffer
        {
            get { return this._maxSyncBuffer; }
            set { this._maxSyncBuffer = value; }
        }

        // Check to see if MaxSyncBuffer property is set
        internal bool IsSetMaxSyncBuffer()
        {
            return this._maxSyncBuffer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaStreamSourceConfigurations. 
        /// <para>
        /// The media stream that is associated with the source, and the parameters for that association.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamSourceConfigurationRequest> MediaStreamSourceConfigurations
        {
            get { return this._mediaStreamSourceConfigurations; }
            set { this._mediaStreamSourceConfigurations = value; }
        }

        // Check to see if MediaStreamSourceConfigurations property is set
        internal bool IsSetMediaStreamSourceConfigurations()
        {
            return this._mediaStreamSourceConfigurations != null && (this._mediaStreamSourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public int? MinLatency
        {
            get { return this._minLatency; }
            set { this._minLatency = value; }
        }

        // Check to see if MinLatency property is set
        internal bool IsSetMinLatency()
        {
            return this._minLatency.HasValue; 
        }

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
        /// Gets and sets the property SenderControlPort. 
        /// <para>
        /// The port that the flow uses to send outbound requests to initiate connection with
        /// the sender. 
        /// </para>
        /// </summary>
        public int? SenderControlPort
        {
            get { return this._senderControlPort; }
            set { this._senderControlPort = value; }
        }

        // Check to see if SenderControlPort property is set
        internal bool IsSetSenderControlPort()
        {
            return this._senderControlPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SenderIpAddress. 
        /// <para>
        /// The IP address that the flow communicates with to initiate connection with the sender.
        /// 
        /// </para>
        /// </summary>
        public string SenderIpAddress
        {
            get { return this._senderIpAddress; }
            set { this._senderIpAddress = value; }
        }

        // Check to see if SenderIpAddress property is set
        internal bool IsSetSenderIpAddress()
        {
            return this._senderIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the source that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceListenerAddress. 
        /// <para>
        /// The source IP or domain name for SRT-caller protocol. 
        /// </para>
        /// </summary>
        public string SourceListenerAddress
        {
            get { return this._sourceListenerAddress; }
            set { this._sourceListenerAddress = value; }
        }

        // Check to see if SourceListenerAddress property is set
        internal bool IsSetSourceListenerAddress()
        {
            return this._sourceListenerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceListenerPort. 
        /// <para>
        /// Source port for SRT-caller protocol. 
        /// </para>
        /// </summary>
        public int? SourceListenerPort
        {
            get { return this._sourceListenerPort; }
            set { this._sourceListenerPort = value; }
        }

        // Check to see if SourceListenerPort property is set
        internal bool IsSetSourceListenerPort()
        {
            return this._sourceListenerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID that you want to use for this transport. This parameter applies only
        /// to Zixi and SRT caller-based streams. 
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. 
        /// <para>
        /// The name of the VPC interface that you want to send your output to.
        /// </para>
        /// </summary>
        public string VpcInterfaceName
        {
            get { return this._vpcInterfaceName; }
            set { this._vpcInterfaceName = value; }
        }

        // Check to see if VpcInterfaceName property is set
        internal bool IsSetVpcInterfaceName()
        {
            return this._vpcInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property WhitelistCidr. 
        /// <para>
        /// The range of IP addresses that are allowed to contribute content to your source. Format
        /// the IP addresses as a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// 
        /// </para>
        /// </summary>
        public string WhitelistCidr
        {
            get { return this._whitelistCidr; }
            set { this._whitelistCidr = value; }
        }

        // Check to see if WhitelistCidr property is set
        internal bool IsSetWhitelistCidr()
        {
            return this._whitelistCidr != null;
        }

    }
}