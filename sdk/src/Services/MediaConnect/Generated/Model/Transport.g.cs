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
    /// Attributes related to the transport stream that are used in a source or output.
    /// </summary>
    public partial class Transport
    {
        /// <summary>
        /// Gets and sets the property CidrAllowList. 
        /// <para>
        ///  The range of IP addresses that should be allowed to initiate output requests to this
        /// flow. These IP addresses should be in the form of a Classless Inter-Domain Routing
        /// (CIDR) block; for example, 10.0.0.0/16
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrAllowList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CidrAllowList property is set.
        /// </summary>
        internal bool IsSetCidrAllowList() => this.CidrAllowList != null && (this.CidrAllowList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxBitrate. 
        /// <para>
        ///  The smoothing max bitrate (in bps) for RIST, RTP, and RTP-FEC streams.
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
        ///  The maximum latency in milliseconds. This parameter applies only to RIST-based and
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
        ///  The size of the buffer (in milliseconds) to use to sync incoming source data.
        /// </para>
        /// </summary>
        public int? MaxSyncBuffer { get; set; }

        /// <summary>
        /// Checks to see if the MaxSyncBuffer property is set.
        /// </summary>
        internal bool IsSetMaxSyncBuffer() => this.MaxSyncBuffer.HasValue;

        /// <summary>
        /// Gets and sets the property MinLatency. 
        /// <para>
        ///  The minimum latency in milliseconds for SRT-based streams. In streams that use the
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
        /// Gets and sets the property NdiOutputTimecodeSource. 
        /// <para>
        /// The timecode source for NDI output frames. For NDI outputs, this field is always present
        /// and defaults to <c>EMBEDDED_TIMECODE</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EMBEDDED_TIMECODE</c> - Preserves timecodes from the input transport stream. The
        /// timecodes must be embedded in the video stream as SEI timing messages. If no embedded
        /// timecode is detected, MediaConnect uses the UTC system time instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UTC_SYSTEM_TIME</c> - Generates timecodes based on the system clock time when
        /// each frame is sent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NdiOutputTimecodeSource NdiOutputTimecodeSource { get; set; }

        /// <summary>
        /// Checks to see if the NdiOutputTimecodeSource property is set.
        /// </summary>
        internal bool IsSetNdiOutputTimecodeSource() => this.NdiOutputTimecodeSource != null;

        /// <summary>
        /// Gets and sets the property NdiProgramName. 
        /// <para>
        /// A suffix for the name of the NDI® sender that the flow creates. If a custom name isn't
        /// specified, MediaConnect uses the output name. 
        /// </para>
        /// </summary>
        public string NdiProgramName { get; set; }

        /// <summary>
        /// Checks to see if the NdiProgramName property is set.
        /// </summary>
        internal bool IsSetNdiProgramName() => this.NdiProgramName != null;

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
        /// Gets and sets the property NdiSpeedHqQuality. 
        /// <para>
        /// A quality setting for the NDI Speed HQ encoder. 
        /// </para>
        /// </summary>
        public int? NdiSpeedHqQuality { get; set; }

        /// <summary>
        /// Checks to see if the NdiSpeedHqQuality property is set.
        /// </summary>
        internal bool IsSetNdiSpeedHqQuality() => this.NdiSpeedHqQuality.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        ///  The protocol that is used by the source or output.
        /// </para>
        ///  <note> 
        /// <para>
        /// Elemental MediaConnect no longer supports the Fujitsu QoS protocol. This reference
        /// is maintained for legacy purposes only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RemoteId. 
        /// <para>
        ///  The remote ID for the Zixi-pull stream.
        /// </para>
        /// </summary>
        public string RemoteId { get; set; }

        /// <summary>
        /// Checks to see if the RemoteId property is set.
        /// </summary>
        internal bool IsSetRemoteId() => this.RemoteId != null;

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
        /// Gets and sets the property SmoothingLatency. 
        /// <para>
        ///  The smoothing latency in milliseconds for RIST, RTP, and RTP-FEC streams.
        /// </para>
        /// </summary>
        public int? SmoothingLatency { get; set; }

        /// <summary>
        /// Checks to see if the SmoothingLatency property is set.
        /// </summary>
        internal bool IsSetSmoothingLatency() => this.SmoothingLatency.HasValue;

        /// <summary>
        /// Gets and sets the property SourceListenerAddress. 
        /// <para>
        ///  Source IP or domain name for SRT-caller protocol.
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
        ///  Source port for SRT-caller protocol.
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
        ///  The stream ID that you want to use for this transport. This parameter applies only
        /// to Zixi and SRT caller-based streams.
        /// </para>
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
