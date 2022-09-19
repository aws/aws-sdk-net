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
        private int? _ingestPort;
        private int? _maxBitrate;
        private int? _maxLatency;
        private int? _maxSyncBuffer;
        private List<MediaStreamSourceConfigurationRequest> _mediaStreamSourceConfigurations = new List<MediaStreamSourceConfigurationRequest>();
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
        /// Gets and sets the property Decryption. The type of encryption used on the content
        /// ingested from this source.
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
        /// Gets and sets the property Description. A description for the source. This value is
        /// not used or seen outside of the current AWS Elemental MediaConnect account.
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
        /// Gets and sets the property EntitlementArn. The ARN of the entitlement that allows
        /// you to subscribe to this flow. The entitlement is set by the flow originator, and
        /// the ARN is generated as part of the originator's flow.
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
        /// Gets and sets the property FlowArn. The flow that is associated with the source that
        /// you want to update.
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
        /// Gets and sets the property IngestPort. The port that the flow will be listening on
        /// for incoming content.
        /// </summary>
        public int IngestPort
        {
            get { return this._ingestPort.GetValueOrDefault(); }
            set { this._ingestPort = value; }
        }

        // Check to see if IngestPort property is set
        internal bool IsSetIngestPort()
        {
            return this._ingestPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. The smoothing max bitrate for RIST, RTP, and
        /// RTP-FEC streams.
        /// </summary>
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLatency. The maximum latency in milliseconds. This parameter
        /// applies only to RIST-based, Zixi-based, and Fujitsu-based streams.
        /// </summary>
        public int MaxLatency
        {
            get { return this._maxLatency.GetValueOrDefault(); }
            set { this._maxLatency = value; }
        }

        // Check to see if MaxLatency property is set
        internal bool IsSetMaxLatency()
        {
            return this._maxLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSyncBuffer. The size of the buffer (in milliseconds)
        /// to use to sync incoming source data.
        /// </summary>
        public int MaxSyncBuffer
        {
            get { return this._maxSyncBuffer.GetValueOrDefault(); }
            set { this._maxSyncBuffer = value; }
        }

        // Check to see if MaxSyncBuffer property is set
        internal bool IsSetMaxSyncBuffer()
        {
            return this._maxSyncBuffer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaStreamSourceConfigurations. The media streams that
        /// are associated with the source, and the parameters for those associations.
        /// </summary>
        public List<MediaStreamSourceConfigurationRequest> MediaStreamSourceConfigurations
        {
            get { return this._mediaStreamSourceConfigurations; }
            set { this._mediaStreamSourceConfigurations = value; }
        }

        // Check to see if MediaStreamSourceConfigurations property is set
        internal bool IsSetMediaStreamSourceConfigurations()
        {
            return this._mediaStreamSourceConfigurations != null && this._mediaStreamSourceConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MinLatency. The minimum latency in milliseconds for SRT-based
        /// streams. In streams that use the SRT protocol, this value that you set on your MediaConnect
        /// source or output represents the minimal potential latency of that connection. The
        /// latency of the stream is set to the highest number between the sender’s minimum latency
        /// and the receiver’s minimum latency.
        /// </summary>
        public int MinLatency
        {
            get { return this._minLatency.GetValueOrDefault(); }
            set { this._minLatency = value; }
        }

        // Check to see if MinLatency property is set
        internal bool IsSetMinLatency()
        {
            return this._minLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. The protocol that is used by the source.
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
        /// Gets and sets the property SenderControlPort. The port that the flow uses to send
        /// outbound requests to initiate connection with the sender.
        /// </summary>
        public int SenderControlPort
        {
            get { return this._senderControlPort.GetValueOrDefault(); }
            set { this._senderControlPort = value; }
        }

        // Check to see if SenderControlPort property is set
        internal bool IsSetSenderControlPort()
        {
            return this._senderControlPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SenderIpAddress. The IP address that the flow communicates
        /// with to initiate connection with the sender.
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
        /// Gets and sets the property SourceArn. The ARN of the source that you want to update.
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
        /// Gets and sets the property SourceListenerAddress. Source IP or domain name for SRT-caller
        /// protocol.
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
        /// Gets and sets the property SourceListenerPort. Source port for SRT-caller protocol.
        /// </summary>
        public int SourceListenerPort
        {
            get { return this._sourceListenerPort.GetValueOrDefault(); }
            set { this._sourceListenerPort = value; }
        }

        // Check to see if SourceListenerPort property is set
        internal bool IsSetSourceListenerPort()
        {
            return this._sourceListenerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. The stream ID that you want to use for this transport.
        /// This parameter applies only to Zixi-based streams.
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
        /// Gets and sets the property VpcInterfaceName. The name of the VPC interface to use
        /// for this source.
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
        /// Gets and sets the property WhitelistCidr. The range of IP addresses that should be
        /// allowed to contribute content to your source. These IP addresses should be in the
        /// form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
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