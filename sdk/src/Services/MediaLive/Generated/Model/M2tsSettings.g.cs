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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// M2ts Settings
    /// </summary>
    public partial class M2tsSettings
    {
        /// <summary>
        /// Gets and sets the property AbsentInputAudioBehavior. When set to drop, output audio
        /// streams will be removed from the program if the selected input audio stream is removed
        /// from the input. This allows the output audio configuration to dynamically change based
        /// on input configuration. If this is set to encodeSilence, all output audio streams
        /// will output encoded silence when not connected to an active input stream.
        /// </summary>
        public M2tsAbsentInputAudioBehavior AbsentInputAudioBehavior { get; set; }

        /// <summary>
        /// Checks to see if the AbsentInputAudioBehavior property is set.
        /// </summary>
        internal bool IsSetAbsentInputAudioBehavior() => this.AbsentInputAudioBehavior != null;

        /// <summary>
        /// Gets and sets the property Arib. When set to enabled, uses ARIB-compliant field muxing
        /// and removes video descriptor.
        /// </summary>
        public M2tsArib Arib { get; set; }

        /// <summary>
        /// Checks to see if the Arib property is set.
        /// </summary>
        internal bool IsSetArib() => this.Arib != null;

        /// <summary>
        /// Gets and sets the property AribCaptionsPid. Packet Identifier (PID) for ARIB Captions
        /// in the transport stream. Can be entered as a decimal or hexadecimal value. Valid values
        /// are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string AribCaptionsPid { get; set; }

        /// <summary>
        /// Checks to see if the AribCaptionsPid property is set.
        /// </summary>
        internal bool IsSetAribCaptionsPid() => this.AribCaptionsPid != null;

        /// <summary>
        /// Gets and sets the property AribCaptionsPidControl. If set to auto, pid number used
        /// for ARIB Captions will be auto-selected from unused pids. If set to useConfigured,
        /// ARIB Captions will be on the configured pid number.
        /// </summary>
        public M2tsAribCaptionsPidControl AribCaptionsPidControl { get; set; }

        /// <summary>
        /// Checks to see if the AribCaptionsPidControl property is set.
        /// </summary>
        internal bool IsSetAribCaptionsPidControl() => this.AribCaptionsPidControl != null;

        /// <summary>
        /// Gets and sets the property AudioBufferModel. When set to dvb, uses DVB buffer model
        /// for Dolby Digital audio. When set to atsc, the ATSC model is used.
        /// </summary>
        public M2tsAudioBufferModel AudioBufferModel { get; set; }

        /// <summary>
        /// Checks to see if the AudioBufferModel property is set.
        /// </summary>
        internal bool IsSetAudioBufferModel() => this.AudioBufferModel != null;

        /// <summary>
        /// Gets and sets the property AudioFramesPerPes. The number of audio frames to insert
        /// for each PES packet.
        /// </summary>
        public int? AudioFramesPerPes { get; set; }

        /// <summary>
        /// Checks to see if the AudioFramesPerPes property is set.
        /// </summary>
        internal bool IsSetAudioFramesPerPes() => this.AudioFramesPerPes.HasValue;

        /// <summary>
        /// Gets and sets the property AudioPids. Packet Identifier (PID) of the elementary audio
        /// stream(s) in the transport stream. Multiple values are accepted, and can be entered
        /// in ranges and/or by comma separation. Can be entered as decimal or hexadecimal values.
        /// Each PID specified must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string AudioPids { get; set; }

        /// <summary>
        /// Checks to see if the AudioPids property is set.
        /// </summary>
        internal bool IsSetAudioPids() => this.AudioPids != null;

        /// <summary>
        /// Gets and sets the property AudioStreamType. When set to atsc, uses stream type = 0x81
        /// for AC3 and stream type = 0x87 for EAC3. When set to dvb, uses stream type = 0x06.
        /// </summary>
        public M2tsAudioStreamType AudioStreamType { get; set; }

        /// <summary>
        /// Checks to see if the AudioStreamType property is set.
        /// </summary>
        internal bool IsSetAudioStreamType() => this.AudioStreamType != null;

        /// <summary>
        /// Gets and sets the property Bitrate. The output bitrate of the transport stream in
        /// bits per second. Setting to 0 lets the muxer automatically determine the appropriate
        /// bitrate.
        /// </summary>
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BufferModel. Controls the timing accuracy for output network
        /// traffic. Leave as MULTIPLEX to ensure accurate network packet timing. Or set to NONE,
        /// which might result in lower latency but will result in more variability in output
        /// network packet timing. This variability might cause interruptions, jitter, or bursty
        /// behavior in your playback or receiving devices.
        /// </summary>
        public M2tsBufferModel BufferModel { get; set; }

        /// <summary>
        /// Checks to see if the BufferModel property is set.
        /// </summary>
        internal bool IsSetBufferModel() => this.BufferModel != null;

        /// <summary>
        /// Gets and sets the property CcDescriptor. When set to enabled, generates captionServiceDescriptor
        /// in PMT.
        /// </summary>
        public M2tsCcDescriptor CcDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the CcDescriptor property is set.
        /// </summary>
        internal bool IsSetCcDescriptor() => this.CcDescriptor != null;

        /// <summary>
        /// Gets and sets the property DvbNitSettings. Inserts DVB Network Information Table (NIT)
        /// at the specified table repetition interval.
        /// </summary>
        public DvbNitSettings DvbNitSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbNitSettings property is set.
        /// </summary>
        internal bool IsSetDvbNitSettings() => this.DvbNitSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSdtSettings. Inserts DVB Service Description Table (SDT)
        /// at the specified table repetition interval.
        /// </summary>
        public DvbSdtSettings DvbSdtSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSdtSettings property is set.
        /// </summary>
        internal bool IsSetDvbSdtSettings() => this.DvbSdtSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSubPids. Packet Identifier (PID) for input source DVB
        /// Subtitle data to this output. Multiple values are accepted, and can be entered in
        /// ranges and/or by comma separation. Can be entered as decimal or hexadecimal values.
        /// Each PID specified must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string DvbSubPids { get; set; }

        /// <summary>
        /// Checks to see if the DvbSubPids property is set.
        /// </summary>
        internal bool IsSetDvbSubPids() => this.DvbSubPids != null;

        /// <summary>
        /// Gets and sets the property DvbTdtSettings. Inserts DVB Time and Date Table (TDT) at
        /// the specified table repetition interval.
        /// </summary>
        public DvbTdtSettings DvbTdtSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbTdtSettings property is set.
        /// </summary>
        internal bool IsSetDvbTdtSettings() => this.DvbTdtSettings != null;

        /// <summary>
        /// Gets and sets the property DvbTeletextPid. Packet Identifier (PID) for input source
        /// DVB Teletext data to this output. Can be entered as a decimal or hexadecimal value.
        /// Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string DvbTeletextPid { get; set; }

        /// <summary>
        /// Checks to see if the DvbTeletextPid property is set.
        /// </summary>
        internal bool IsSetDvbTeletextPid() => this.DvbTeletextPid != null;

        /// <summary>
        /// Gets and sets the property Ebif. If set to passthrough, passes any EBIF data from
        /// the input source to this output.
        /// </summary>
        public M2tsEbifControl Ebif { get; set; }

        /// <summary>
        /// Checks to see if the Ebif property is set.
        /// </summary>
        internal bool IsSetEbif() => this.Ebif != null;

        /// <summary>
        /// Gets and sets the property EbpAudioInterval. When videoAndFixedIntervals is selected,
        /// audio EBP markers will be added to partitions 3 and 4. The interval between these
        /// additional markers will be fixed, and will be slightly shorter than the video EBP
        /// marker interval. Only available when EBP Cablelabs segmentation markers are selected.
        /// Partitions 1 and 2 will always follow the video interval.
        /// </summary>
        public M2tsAudioInterval EbpAudioInterval { get; set; }

        /// <summary>
        /// Checks to see if the EbpAudioInterval property is set.
        /// </summary>
        internal bool IsSetEbpAudioInterval() => this.EbpAudioInterval != null;

        /// <summary>
        /// Gets and sets the property EbpLookaheadMs. When set, enforces that Encoder Boundary
        /// Points do not come within the specified time interval of each other by looking ahead
        /// at input video. If another EBP is going to come in within the specified time interval,
        /// the current EBP is not emitted, and the segment is "stretched" to the next marker.
        /// The lookahead value does not add latency to the system. The Live Event must be configured
        /// elsewhere to create sufficient latency to make the lookahead accurate.
        /// </summary>
        public int? EbpLookaheadMs { get; set; }

        /// <summary>
        /// Checks to see if the EbpLookaheadMs property is set.
        /// </summary>
        internal bool IsSetEbpLookaheadMs() => this.EbpLookaheadMs.HasValue;

        /// <summary>
        /// Gets and sets the property EbpPlacement. Controls placement of EBP on Audio PIDs.
        /// If set to videoAndAudioPids, EBP markers will be placed on the video PID and all audio
        /// PIDs. If set to videoPid, EBP markers will be placed on only the video PID.
        /// </summary>
        public M2tsEbpPlacement EbpPlacement { get; set; }

        /// <summary>
        /// Checks to see if the EbpPlacement property is set.
        /// </summary>
        internal bool IsSetEbpPlacement() => this.EbpPlacement != null;

        /// <summary>
        /// Gets and sets the property EcmPid. This field is unused and deprecated.
        /// </summary>
        public string EcmPid { get; set; }

        /// <summary>
        /// Checks to see if the EcmPid property is set.
        /// </summary>
        internal bool IsSetEcmPid() => this.EcmPid != null;

        /// <summary>
        /// Gets and sets the property EsRateInPes. Include or exclude the ES Rate field in the
        /// PES header.
        /// </summary>
        public M2tsEsRateInPes EsRateInPes { get; set; }

        /// <summary>
        /// Checks to see if the EsRateInPes property is set.
        /// </summary>
        internal bool IsSetEsRateInPes() => this.EsRateInPes != null;

        /// <summary>
        /// Gets and sets the property EtvPlatformPid. Packet Identifier (PID) for input source
        /// ETV Platform data to this output. Can be entered as a decimal or hexadecimal value.
        /// Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string EtvPlatformPid { get; set; }

        /// <summary>
        /// Checks to see if the EtvPlatformPid property is set.
        /// </summary>
        internal bool IsSetEtvPlatformPid() => this.EtvPlatformPid != null;

        /// <summary>
        /// Gets and sets the property EtvSignalPid. Packet Identifier (PID) for input source
        /// ETV Signal data to this output. Can be entered as a decimal or hexadecimal value.
        /// Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string EtvSignalPid { get; set; }

        /// <summary>
        /// Checks to see if the EtvSignalPid property is set.
        /// </summary>
        internal bool IsSetEtvSignalPid() => this.EtvSignalPid != null;

        /// <summary>
        /// Gets and sets the property FragmentTime. The length in seconds of each fragment. Only
        /// used with EBP markers.
        /// </summary>
        public double? FragmentTime { get; set; }

        /// <summary>
        /// Checks to see if the FragmentTime property is set.
        /// </summary>
        internal bool IsSetFragmentTime() => this.FragmentTime.HasValue;

        /// <summary>
        /// Gets and sets the property Klv. If set to passthrough, passes any KLV data from the
        /// input source to this output.
        /// </summary>
        public M2tsKlv Klv { get; set; }

        /// <summary>
        /// Checks to see if the Klv property is set.
        /// </summary>
        internal bool IsSetKlv() => this.Klv != null;

        /// <summary>
        /// Gets and sets the property KlvDataPids. Packet Identifier (PID) for input source KLV
        /// data to this output. Multiple values are accepted, and can be entered in ranges and/or
        /// by comma separation. Can be entered as decimal or hexadecimal values. Each PID specified
        /// must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string KlvDataPids { get; set; }

        /// <summary>
        /// Checks to see if the KlvDataPids property is set.
        /// </summary>
        internal bool IsSetKlvDataPids() => this.KlvDataPids != null;

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public M2tsNielsenId3Behavior NielsenId3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3Behavior property is set.
        /// </summary>
        internal bool IsSetNielsenId3Behavior() => this.NielsenId3Behavior != null;

        /// <summary>
        /// Gets and sets the property NullPacketBitrate. Value in bits per second of extra null
        /// packets to insert into the transport stream. This can be used if a downstream encryption
        /// system requires periodic null packets.
        /// </summary>
        public double? NullPacketBitrate { get; set; }

        /// <summary>
        /// Checks to see if the NullPacketBitrate property is set.
        /// </summary>
        internal bool IsSetNullPacketBitrate() => this.NullPacketBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property PatInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. Valid values are 0, 10..1000.
        /// </summary>
        public int? PatInterval { get; set; }

        /// <summary>
        /// Checks to see if the PatInterval property is set.
        /// </summary>
        internal bool IsSetPatInterval() => this.PatInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PcrControl. When set to pcrEveryPesPacket, a Program Clock
        /// Reference value is inserted for every Packetized Elementary Stream (PES) header. This
        /// parameter is effective only when the PCR PID is the same as the video or audio elementary
        /// stream.
        /// </summary>
        public M2tsPcrControl PcrControl { get; set; }

        /// <summary>
        /// Checks to see if the PcrControl property is set.
        /// </summary>
        internal bool IsSetPcrControl() => this.PcrControl != null;

        /// <summary>
        /// Gets and sets the property PcrPeriod. Maximum time in milliseconds between Program
        /// Clock Reference (PCRs) inserted into the transport stream.
        /// </summary>
        public int? PcrPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PcrPeriod property is set.
        /// </summary>
        internal bool IsSetPcrPeriod() => this.PcrPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property PcrPid. Packet Identifier (PID) of the Program Clock Reference
        /// (PCR) in the transport stream. When no value is given, the encoder will assign the
        /// same value as the Video PID. Can be entered as a decimal or hexadecimal value. Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid != null;

        /// <summary>
        /// Gets and sets the property PmtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. Valid values are 0, 10..1000.
        /// </summary>
        public int? PmtInterval { get; set; }

        /// <summary>
        /// Checks to see if the PmtInterval property is set.
        /// </summary>
        internal bool IsSetPmtInterval() => this.PmtInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PmtPid. Packet Identifier (PID) for the Program Map Table
        /// (PMT) in the transport stream. Can be entered as a decimal or hexadecimal value. Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string PmtPid { get; set; }

        /// <summary>
        /// Checks to see if the PmtPid property is set.
        /// </summary>
        internal bool IsSetPmtPid() => this.PmtPid != null;

        /// <summary>
        /// Gets and sets the property ProgramNum. The value of the program number field in the
        /// Program Map Table.
        /// </summary>
        public int? ProgramNum { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNum property is set.
        /// </summary>
        internal bool IsSetProgramNum() => this.ProgramNum.HasValue;

        /// <summary>
        /// Gets and sets the property RateMode. When vbr, does not insert null packets into transport
        /// stream to fill specified bitrate. The bitrate setting acts as the maximum bitrate
        /// when vbr is set.
        /// </summary>
        public M2tsRateMode RateMode { get; set; }

        /// <summary>
        /// Checks to see if the RateMode property is set.
        /// </summary>
        internal bool IsSetRateMode() => this.RateMode != null;

        /// <summary>
        /// Gets and sets the property Scte27Pids. Packet Identifier (PID) for input source SCTE-27
        /// data to this output. Multiple values are accepted, and can be entered in ranges and/or
        /// by comma separation. Can be entered as decimal or hexadecimal values. Each PID specified
        /// must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string Scte27Pids { get; set; }

        /// <summary>
        /// Checks to see if the Scte27Pids property is set.
        /// </summary>
        internal bool IsSetScte27Pids() => this.Scte27Pids != null;

        /// <summary>
        /// Gets and sets the property Scte35Control. SCTE-35 control. Option "none" indicates
        /// that a SCTE-35 marker will not be inserted, nor will an IDR be inserted at the SCTE-35
        /// cue point, nor will the segment be segmented. Option "scte35WithoutIdr" indicates
        /// that a SCTE-35 marker will be inserted to indicate the cue point, but MediaLive will
        /// not insert an IDR on that frame nor will it introduce a new segment boundary there
        /// if it wasn't already going to be one (this option is required for use with downstream
        /// multiview bitstream stitching workflows). Option "passthrough" indicates that a SCTE-35
        /// marker will be inserted to indicate the cue point, and an IDR will be inserted on
        /// that frame, and MediaLive itself will introduce a new segment boundary there.
        /// </summary>
        public M2tsScte35Control Scte35Control { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Control property is set.
        /// </summary>
        internal bool IsSetScte35Control() => this.Scte35Control != null;

        /// <summary>
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream. Can be entered as a decimal or hexadecimal value. Valid values
        /// are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid != null;

        /// <summary>
        /// Gets and sets the property Scte35PrerollPullupMilliseconds. Defines the amount SCTE-35
        /// preroll will be increased (in milliseconds) on the output. Preroll is the amount of
        /// time between the presence of a SCTE-35 indication in a transport stream and the PTS
        /// of the video frame it references. Zero means don't add pullup (it doesn't mean set
        /// the preroll to zero). Negative pullup is not supported, which means that you can't
        /// make the preroll shorter. Be aware that latency in the output will increase by the
        /// pullup amount.
        /// </summary>
        public double? Scte35PrerollPullupMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the Scte35PrerollPullupMilliseconds property is set.
        /// </summary>
        internal bool IsSetScte35PrerollPullupMilliseconds() => this.Scte35PrerollPullupMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationMarkers. Inserts segmentation markers at each
        /// segmentationTime period. raiSegstart sets the Random Access Indicator bit in the adaptation
        /// field. raiAdapt sets the RAI bit and adds the current timecode in the private data
        /// bytes. psiSegstart inserts PAT and PMT tables at the start of segments. ebp adds Encoder
        /// Boundary Point information to the adaptation field as per OpenCable specification
        /// OC-SP-EBP-I01-130118. ebpLegacy adds Encoder Boundary Point information to the adaptation
        /// field using a legacy proprietary format.
        /// </summary>
        public M2tsSegmentationMarkers SegmentationMarkers { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationMarkers property is set.
        /// </summary>
        internal bool IsSetSegmentationMarkers() => this.SegmentationMarkers != null;

        /// <summary>
        /// Gets and sets the property SegmentationStyle. The segmentation style parameter controls
        /// how segmentation markers are inserted into the transport stream. With avails, it is
        /// possible that segments may be truncated, which can influence where future segmentation
        /// markers are inserted. When a segmentation style of "resetCadence" is selected and
        /// a segment is truncated due to an avail, we will reset the segmentation cadence. This
        /// means the subsequent segment will have a duration of $segmentationTime seconds. When
        /// a segmentation style of "maintainCadence" is selected and a segment is truncated due
        /// to an avail, we will not reset the segmentation cadence. This means the subsequent
        /// segment will likely be truncated as well. However, all segments after that will have
        /// a duration of $segmentationTime seconds. Note that EBP lookahead is a slight exception
        /// to this rule.
        /// </summary>
        public M2tsSegmentationStyle SegmentationStyle { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationStyle property is set.
        /// </summary>
        internal bool IsSetSegmentationStyle() => this.SegmentationStyle != null;

        /// <summary>
        /// Gets and sets the property SegmentationTime. The length in seconds of each segment.
        /// Required unless markers is set to _none_.
        /// </summary>
        public double? SegmentationTime { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationTime property is set.
        /// </summary>
        internal bool IsSetSegmentationTime() => this.SegmentationTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimedMetadataBehavior. When set to passthrough, timed metadata
        /// will be passed through from input to output.
        /// </summary>
        public M2tsTimedMetadataBehavior TimedMetadataBehavior { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataBehavior property is set.
        /// </summary>
        internal bool IsSetTimedMetadataBehavior() => this.TimedMetadataBehavior != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the timed
        /// metadata stream in the transport stream. Can be entered as a decimal or hexadecimal
        /// value. Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string TimedMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataPid property is set.
        /// </summary>
        internal bool IsSetTimedMetadataPid() => this.TimedMetadataPid != null;

        /// <summary>
        /// Gets and sets the property TransportStreamId. The value of the transport stream ID
        /// field in the Program Map Table.
        /// </summary>
        public int? TransportStreamId { get; set; }

        /// <summary>
        /// Checks to see if the TransportStreamId property is set.
        /// </summary>
        internal bool IsSetTransportStreamId() => this.TransportStreamId.HasValue;

        /// <summary>
        /// Gets and sets the property VideoPid. Packet Identifier (PID) of the elementary video
        /// stream in the transport stream. Can be entered as a decimal or hexadecimal value.
        /// Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string VideoPid { get; set; }

        /// <summary>
        /// Checks to see if the VideoPid property is set.
        /// </summary>
        internal bool IsSetVideoPid() => this.VideoPid != null;
    }
}
