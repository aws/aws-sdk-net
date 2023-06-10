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
    /// Attributes related to the transport stream that are used in a source or output.
    /// </summary>
    public partial class Transport
    {
        private List<string> _cidrAllowList = new List<string>();
        private int? _maxBitrate;
        private int? _maxLatency;
        private int? _maxSyncBuffer;
        private int? _minLatency;
        private Protocol _protocol;
        private string _remoteId;
        private int? _senderControlPort;
        private string _senderIpAddress;
        private int? _smoothingLatency;
        private string _sourceListenerAddress;
        private int? _sourceListenerPort;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property CidrAllowList. The range of IP addresses that should be
        /// allowed to initiate output requests to this flow. These IP addresses should be in
        /// the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </summary>
        public List<string> CidrAllowList
        {
            get { return this._cidrAllowList; }
            set { this._cidrAllowList = value; }
        }

        // Check to see if CidrAllowList property is set
        internal bool IsSetCidrAllowList()
        {
            return this._cidrAllowList != null && this._cidrAllowList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. The smoothing max bitrate (in bps) for RIST,
        /// RTP, and RTP-FEC streams.
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
        /// Gets and sets the property Protocol. The protocol that is used by the source or output.
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
        /// Gets and sets the property RemoteId. The remote ID for the Zixi-pull stream.
        /// </summary>
        public string RemoteId
        {
            get { return this._remoteId; }
            set { this._remoteId = value; }
        }

        // Check to see if RemoteId property is set
        internal bool IsSetRemoteId()
        {
            return this._remoteId != null;
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
        /// Gets and sets the property SmoothingLatency. The smoothing latency in milliseconds
        /// for RIST, RTP, and RTP-FEC streams.
        /// </summary>
        public int SmoothingLatency
        {
            get { return this._smoothingLatency.GetValueOrDefault(); }
            set { this._smoothingLatency = value; }
        }

        // Check to see if SmoothingLatency property is set
        internal bool IsSetSmoothingLatency()
        {
            return this._smoothingLatency.HasValue; 
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
        /// This parameter applies only to Zixi and SRT caller-based streams.
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

    }
}