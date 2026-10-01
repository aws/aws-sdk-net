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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// MPEG-2 TS container settings. These apply to outputs in a File output group when the
    /// output's container is MPEG-2 Transport Stream (M2TS). In these assets, data is organized
    /// by the program map table (PMT). Each transport stream program contains subsets of
    /// data, including audio, video, and metadata. Each of these subsets of data has a numerical
    /// label called a packet identifier (PID). Each transport stream program corresponds
    /// to one MediaConvert output. The PMT lists the types of data in a program along with
    /// their PID. Downstream systems and players use the program map table to look up the
    /// PID for each type of data it accesses and then uses the PIDs to locate specific data
    /// within the asset.
    /// </summary>
    public partial class M2tsSettings
    {
        /// <summary>
        /// Gets and sets the property AudioBufferModel. Selects between the DVB and ATSC buffer
        /// models for Dolby Digital audio.
        /// </summary>
        public M2tsAudioBufferModel AudioBufferModel { get; set; }

        /// <summary>
        /// Checks to see if the AudioBufferModel property is set.
        /// </summary>
        internal bool IsSetAudioBufferModel() => this.AudioBufferModel != null;

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration. In all other cases, keep the default value, Default codec duration. When
        /// you choose Match video duration, MediaConvert pads the output audio streams with silence
        /// or trims them to ensure that the total duration of each audio stream is at least as
        /// long as the total duration of the video stream. After padding or trimming, the audio
        /// stream duration is no more than one frame longer than the video stream. MediaConvert
        /// applies audio padding or trimming only to the end of the last segment of the output.
        /// For unsegmented outputs, MediaConvert adds padding only to the end of the file. When
        /// you keep the default value, any minor discrepancies between audio and video duration
        /// will depend on your output audio codec.
        /// </summary>
        public M2tsAudioDuration AudioDuration { get; set; }

        /// <summary>
        /// Checks to see if the AudioDuration property is set.
        /// </summary>
        internal bool IsSetAudioDuration() => this.AudioDuration != null;

        /// <summary>
        /// Gets and sets the property AudioFramesPerPes. The number of audio frames to insert
        /// for each PES packet.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? AudioFramesPerPes { get; set; }

        /// <summary>
        /// Checks to see if the AudioFramesPerPes property is set.
        /// </summary>
        internal bool IsSetAudioFramesPerPes() => this.AudioFramesPerPes.HasValue;

        /// <summary>
        /// Gets and sets the property AudioPids. Specify the packet identifiers (PIDs) for any
        /// elementary audio streams you include in this output. Specify multiple PIDs as a JSON
        /// array. Default is the range 482-492.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> AudioPids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the AudioPids property is set.
        /// </summary>
        internal bool IsSetAudioPids() => this.AudioPids != null && (this.AudioPids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AudioPtsOffsetDelta. Manually specify the difference in
        /// PTS offset that will be applied to the audio track, in seconds or milliseconds, when
        /// you set PTS offset to Seconds or Milliseconds. Enter an integer from -10000 to 10000.
        /// Leave blank to keep the default value 0.
        /// </summary>
        [AWSProperty(Min = -10000, Max = 10000)]
        public int? AudioPtsOffsetDelta { get; set; }

        /// <summary>
        /// Checks to see if the AudioPtsOffsetDelta property is set.
        /// </summary>
        internal bool IsSetAudioPtsOffsetDelta() => this.AudioPtsOffsetDelta.HasValue;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the output bitrate of the transport stream
        /// in bits per second. Setting to 0 lets the muxer automatically determine the appropriate
        /// bitrate. Other common values are 3750000, 7500000, and 15000000.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BufferModel. Controls what buffer model to use for accurate
        /// interleaving. If set to MULTIPLEX, use multiplex buffer model. If set to NONE, this
        /// can lead to lower latency, but low-memory devices may not be able to play back the
        /// stream without interruptions.
        /// </summary>
        public M2tsBufferModel BufferModel { get; set; }

        /// <summary>
        /// Checks to see if the BufferModel property is set.
        /// </summary>
        internal bool IsSetBufferModel() => this.BufferModel != null;

        /// <summary>
        /// Gets and sets the property DataPTSControl. If you select ALIGN_TO_VIDEO, MediaConvert
        /// writes captions and data packets with Presentation Timestamp (PTS) values greater
        /// than or equal to the first video packet PTS (MediaConvert drops captions and data
        /// packets with lesser PTS values). Keep the default value to allow all PTS values.
        /// </summary>
        public M2tsDataPtsControl DataPTSControl { get; set; }

        /// <summary>
        /// Checks to see if the DataPTSControl property is set.
        /// </summary>
        internal bool IsSetDataPTSControl() => this.DataPTSControl != null;

        /// <summary>
        /// Gets and sets the property DvbNitSettings. Use these settings to insert a DVB Network
        /// Information Table (NIT) in the transport stream of this output.
        /// </summary>
        public DvbNitSettings DvbNitSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbNitSettings property is set.
        /// </summary>
        internal bool IsSetDvbNitSettings() => this.DvbNitSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSdtSettings. Use these settings to insert a DVB Service
        /// Description Table (SDT) in the transport stream of this output.
        /// </summary>
        public DvbSdtSettings DvbSdtSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSdtSettings property is set.
        /// </summary>
        internal bool IsSetDvbSdtSettings() => this.DvbSdtSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSubPids. Specify the packet identifiers (PIDs) for DVB
        /// subtitle data included in this output. Specify multiple PIDs as a JSON array. Default
        /// is the range 460-479.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DvbSubPids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the DvbSubPids property is set.
        /// </summary>
        internal bool IsSetDvbSubPids() => this.DvbSubPids != null && (this.DvbSubPids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DvbTdtSettings. Use these settings to insert a DVB Time
        /// and Date Table (TDT) in the transport stream of this output.
        /// </summary>
        public DvbTdtSettings DvbTdtSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbTdtSettings property is set.
        /// </summary>
        internal bool IsSetDvbTdtSettings() => this.DvbTdtSettings != null;

        /// <summary>
        /// Gets and sets the property DvbTeletextPid. Specify the packet identifier (PID) for
        /// DVB teletext data you include in this output. Default is 499.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? DvbTeletextPid { get; set; }

        /// <summary>
        /// Checks to see if the DvbTeletextPid property is set.
        /// </summary>
        internal bool IsSetDvbTeletextPid() => this.DvbTeletextPid.HasValue;

        /// <summary>
        /// Gets and sets the property EbpAudioInterval. When set to VIDEO_AND_FIXED_INTERVALS,
        /// audio EBP markers will be added to partitions 3 and 4. The interval between these
        /// additional markers will be fixed, and will be slightly shorter than the video EBP
        /// marker interval. When set to VIDEO_INTERVAL, these additional markers will not be
        /// inserted. Only applicable when EBP segmentation markers are is selected (segmentationMarkers
        /// is EBP or EBP_LEGACY).
        /// </summary>
        public M2tsEbpAudioInterval EbpAudioInterval { get; set; }

        /// <summary>
        /// Checks to see if the EbpAudioInterval property is set.
        /// </summary>
        internal bool IsSetEbpAudioInterval() => this.EbpAudioInterval != null;

        /// <summary>
        /// Gets and sets the property EbpPlacement. Selects which PIDs to place EBP markers on.
        /// They can either be placed only on the video PID, or on both the video PID and all
        /// audio PIDs. Only applicable when EBP segmentation markers are is selected (segmentationMarkers
        /// is EBP or EBP_LEGACY).
        /// </summary>
        public M2tsEbpPlacement EbpPlacement { get; set; }

        /// <summary>
        /// Checks to see if the EbpPlacement property is set.
        /// </summary>
        internal bool IsSetEbpPlacement() => this.EbpPlacement != null;

        /// <summary>
        /// Gets and sets the property EsRateInPes. Controls whether to include the ES Rate field
        /// in the PES header.
        /// </summary>
        public M2tsEsRateInPes EsRateInPes { get; set; }

        /// <summary>
        /// Checks to see if the EsRateInPes property is set.
        /// </summary>
        internal bool IsSetEsRateInPes() => this.EsRateInPes != null;

        /// <summary>
        /// Gets and sets the property ForceTsVideoEbpOrder. Keep the default value unless you
        /// know that your audio EBP markers are incorrectly appearing before your video EBP markers.
        /// To correct this problem, set this value to Force.
        /// </summary>
        public M2tsForceTsVideoEbpOrder ForceTsVideoEbpOrder { get; set; }

        /// <summary>
        /// Checks to see if the ForceTsVideoEbpOrder property is set.
        /// </summary>
        internal bool IsSetForceTsVideoEbpOrder() => this.ForceTsVideoEbpOrder != null;

        /// <summary>
        /// Gets and sets the property FragmentTime. The length, in seconds, of each fragment.
        /// Only used with EBP markers.
        /// </summary>
        public double? FragmentTime { get; set; }

        /// <summary>
        /// Checks to see if the FragmentTime property is set.
        /// </summary>
        internal bool IsSetFragmentTime() => this.FragmentTime.HasValue;

        /// <summary>
        /// Gets and sets the property KlvMetadata. To include key-length-value metadata in this
        /// output: Set KLV metadata insertion to Passthrough. MediaConvert reads KLV metadata
        /// present in your input and passes it through to the output transport stream. To exclude
        /// this KLV metadata: Set KLV metadata insertion to None or leave blank.
        /// </summary>
        public M2tsKlvMetadata KlvMetadata { get; set; }

        /// <summary>
        /// Checks to see if the KlvMetadata property is set.
        /// </summary>
        internal bool IsSetKlvMetadata() => this.KlvMetadata != null;

        /// <summary>
        /// Gets and sets the property MaxPcrInterval. Specify the maximum time, in milliseconds,
        /// between Program Clock References (PCRs) inserted into the transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public int? MaxPcrInterval { get; set; }

        /// <summary>
        /// Checks to see if the MaxPcrInterval property is set.
        /// </summary>
        internal bool IsSetMaxPcrInterval() => this.MaxPcrInterval.HasValue;

        /// <summary>
        /// Gets and sets the property MinEbpInterval. When set, enforces that Encoder Boundary
        /// Points do not come within the specified time interval of each other by looking ahead
        /// at input video. If another EBP is going to come in within the specified time interval,
        /// the current EBP is not emitted, and the segment is "stretched" to the next marker.
        /// The lookahead value does not add latency to the system. The Live Event must be configured
        /// elsewhere to create sufficient latency to make the lookahead accurate.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? MinEbpInterval { get; set; }

        /// <summary>
        /// Checks to see if the MinEbpInterval property is set.
        /// </summary>
        internal bool IsSetMinEbpInterval() => this.MinEbpInterval.HasValue;

        /// <summary>
        /// Gets and sets the property NielsenId3. If INSERT, Nielsen inaudible tones for media
        /// tracking will be detected in the input audio and an equivalent ID3 tag will be inserted
        /// in the output.
        /// </summary>
        public M2tsNielsenId3 NielsenId3 { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3 property is set.
        /// </summary>
        internal bool IsSetNielsenId3() => this.NielsenId3 != null;

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
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? PatInterval { get; set; }

        /// <summary>
        /// Checks to see if the PatInterval property is set.
        /// </summary>
        internal bool IsSetPatInterval() => this.PatInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PcrControl. When set to PCR_EVERY_PES_PACKET, a Program
        /// Clock Reference value is inserted for every Packetized Elementary Stream (PES) header.
        /// This is effective only when the PCR PID is the same as the video or audio elementary
        /// stream.
        /// </summary>
        public M2tsPcrControl PcrControl { get; set; }

        /// <summary>
        /// Checks to see if the PcrControl property is set.
        /// </summary>
        internal bool IsSetPcrControl() => this.PcrControl != null;

        /// <summary>
        /// Gets and sets the property PcrPid. Specify the packet identifier (PID) for the program
        /// clock reference (PCR) in this output. If you do not specify a value, the service will
        /// use the value for Video PID.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid.HasValue;

        /// <summary>
        /// Gets and sets the property PmtInterval. Specify the number of milliseconds between
        /// instances of the program map table (PMT) in the output transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? PmtInterval { get; set; }

        /// <summary>
        /// Checks to see if the PmtInterval property is set.
        /// </summary>
        internal bool IsSetPmtInterval() => this.PmtInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PmtPid. Specify the packet identifier (PID) for the program
        /// map table (PMT) itself. Default is 480.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PmtPid { get; set; }

        /// <summary>
        /// Checks to see if the PmtPid property is set.
        /// </summary>
        internal bool IsSetPmtPid() => this.PmtPid.HasValue;

        /// <summary>
        /// Gets and sets the property PreventBufferUnderflow. Specify whether MediaConvert automatically
        /// attempts to prevent decoder buffer underflows in your transport stream output. Use
        /// if you are seeing decoder buffer underflows in your output and are unable to increase
        /// your transport stream's bitrate. For most workflows: We recommend that you keep the
        /// default value, Disabled. To prevent decoder buffer underflows in your output, when
        /// possible: Choose Enabled. Note that if MediaConvert prevents a decoder buffer underflow
        /// in your output, output video quality is reduced and your job will take longer to complete.
        /// </summary>
        public M2tsPreventBufferUnderflow PreventBufferUnderflow { get; set; }

        /// <summary>
        /// Checks to see if the PreventBufferUnderflow property is set.
        /// </summary>
        internal bool IsSetPreventBufferUnderflow() => this.PreventBufferUnderflow != null;

        /// <summary>
        /// Gets and sets the property PrivateMetadataPid. Specify the packet identifier (PID)
        /// of the private metadata stream. Default is 503.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PrivateMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the PrivateMetadataPid property is set.
        /// </summary>
        internal bool IsSetPrivateMetadataPid() => this.PrivateMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property ProgramNumber. Use Program number to specify the program
        /// number used in the program map table (PMT) for this output. Default is 1. Program
        /// numbers and program map tables are parts of MPEG-2 transport stream containers, used
        /// for organizing data.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PtsOffset. Manually specify the initial PTS offset, in
        /// seconds, when you set PTS offset to Seconds. Enter an integer from 0 to 3600. Leave
        /// blank to keep the default value 2.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? PtsOffset { get; set; }

        /// <summary>
        /// Checks to see if the PtsOffset property is set.
        /// </summary>
        internal bool IsSetPtsOffset() => this.PtsOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PtsOffsetMode. Specify the initial presentation timestamp
        /// (PTS) offset for your transport stream output. To let MediaConvert automatically determine
        /// the initial PTS offset: Keep the default value, Auto. We recommend that you choose
        /// Auto for the widest player compatibility. The initial PTS will be at least two seconds
        /// and vary depending on your output's bitrate, HRD buffer size and HRD buffer initial
        /// fill percentage. To manually specify an initial PTS offset: Choose Seconds or Milliseconds.
        /// Then specify the number of seconds or milliseconds with PTS offset.
        /// </summary>
        public TsPtsOffset PtsOffsetMode { get; set; }

        /// <summary>
        /// Checks to see if the PtsOffsetMode property is set.
        /// </summary>
        internal bool IsSetPtsOffsetMode() => this.PtsOffsetMode != null;

        /// <summary>
        /// Gets and sets the property RateMode. When set to CBR, inserts null packets into transport
        /// stream to fill specified bitrate. When set to VBR, the bitrate setting acts as the
        /// maximum bitrate, but the output will not be padded up to that bitrate.
        /// </summary>
        public M2tsRateMode RateMode { get; set; }

        /// <summary>
        /// Checks to see if the RateMode property is set.
        /// </summary>
        internal bool IsSetRateMode() => this.RateMode != null;

        /// <summary>
        /// Gets and sets the property Scte35Esam. Include this in your job settings to put SCTE-35
        /// markers in your HLS and transport stream outputs at the insertion points that you
        /// specify in an ESAM XML document. Provide the document in the setting SCC XML.
        /// </summary>
        public M2tsScte35Esam Scte35Esam { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Esam property is set.
        /// </summary>
        internal bool IsSetScte35Esam() => this.Scte35Esam != null;

        /// <summary>
        /// Gets and sets the property Scte35Pid. Specify the packet identifier (PID) of the SCTE-35
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid.HasValue;

        /// <summary>
        /// Gets and sets the property Scte35Source. For SCTE-35 markers from your input-- Choose
        /// Passthrough if you want SCTE-35 markers that appear in your input to also appear in
        /// this output. Choose None if you don't want SCTE-35 markers in this output. When your
        /// input is an HLS manifest, choose Manifest cues to pass through CUE markers in your
        /// HLS manifest as segment boundaries and SCTE-35 markers in this output at each EXT-X-CUE-OUT
        /// splice point in the input manifest. For SCTE-35 markers from an ESAM XML document--
        /// Choose None. Also provide the ESAM XML as a string in the setting Signal processing
        /// notification XML. Also enable ESAM SCTE-35 (include the property scte35Esam).
        /// </summary>
        public M2tsScte35Source Scte35Source { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Source property is set.
        /// </summary>
        internal bool IsSetScte35Source() => this.Scte35Source != null;

        /// <summary>
        /// Gets and sets the property SegmentationMarkers. Inserts segmentation markers at each
        /// segmentation_time period. rai_segstart sets the Random Access Indicator bit in the
        /// adaptation field. rai_adapt sets the RAI bit and adds the current timecode in the
        /// private data bytes. psi_segstart inserts PAT and PMT tables at the start of segments.
        /// ebp adds Encoder Boundary Point information to the adaptation field as per OpenCable
        /// specification OC-SP-EBP-I01-130118. ebp_legacy adds Encoder Boundary Point information
        /// to the adaptation field using a legacy proprietary format.
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
        /// markers are inserted. When a segmentation style of "reset_cadence" is selected and
        /// a segment is truncated due to an avail, we will reset the segmentation cadence. This
        /// means the subsequent segment will have a duration of of $segmentation_time seconds.
        /// When a segmentation style of "maintain_cadence" is selected and a segment is truncated
        /// due to an avail, we will not reset the segmentation cadence. This means the subsequent
        /// segment will likely be truncated as well. However, all segments after that will have
        /// a duration of $segmentation_time seconds. Note that EBP lookahead is a slight exception
        /// to this rule.
        /// </summary>
        public M2tsSegmentationStyle SegmentationStyle { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationStyle property is set.
        /// </summary>
        internal bool IsSetSegmentationStyle() => this.SegmentationStyle != null;

        /// <summary>
        /// Gets and sets the property SegmentationTime. Specify the length, in seconds, of each
        /// segment. Required unless markers is set to _none_.
        /// </summary>
        public double? SegmentationTime { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationTime property is set.
        /// </summary>
        internal bool IsSetSegmentationTime() => this.SegmentationTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the ID3 metadata
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? TimedMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataPid property is set.
        /// </summary>
        internal bool IsSetTimedMetadataPid() => this.TimedMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property TransportStreamId. Specify the ID for the transport stream
        /// itself in the program map table for this output. Transport stream IDs and program
        /// map tables are parts of MPEG-2 transport stream containers, used for organizing data.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? TransportStreamId { get; set; }

        /// <summary>
        /// Checks to see if the TransportStreamId property is set.
        /// </summary>
        internal bool IsSetTransportStreamId() => this.TransportStreamId.HasValue;

        /// <summary>
        /// Gets and sets the property VideoPid. Specify the packet identifier (PID) of the elementary
        /// video stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? VideoPid { get; set; }

        /// <summary>
        /// Checks to see if the VideoPid property is set.
        /// </summary>
        internal bool IsSetVideoPid() => this.VideoPid.HasValue;
    }
}
