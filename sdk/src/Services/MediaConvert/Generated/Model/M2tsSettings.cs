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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// MPEG-2 TS container settings. These apply to outputs in a File output group when the
    /// output's container (ContainerType) is MPEG-2 Transport Stream (M2TS). In these assets,
    /// data is organized by the program map table (PMT). Each transport stream program contains
    /// subsets of data, including audio, video, and metadata. Each of these subsets of data
    /// has a numerical label called a packet identifier (PID). Each transport stream program
    /// corresponds to one MediaConvert output. The PMT lists the types of data in a program
    /// along with their PID. Downstream systems and players use the program map table to
    /// look up the PID for each type of data it accesses and then uses the PIDs to locate
    /// specific data within the asset.
    /// </summary>
    public partial class M2tsSettings
    {
        private M2tsAudioBufferModel _audioBufferModel;
        private M2tsAudioDuration _audioDuration;
        private int? _audioFramesPerPes;
        private List<int> _audioPids = new List<int>();
        private int? _bitrate;
        private M2tsBufferModel _bufferModel;
        private M2tsDataPtsControl _dataPTSControl;
        private DvbNitSettings _dvbNitSettings;
        private DvbSdtSettings _dvbSdtSettings;
        private List<int> _dvbSubPids = new List<int>();
        private DvbTdtSettings _dvbTdtSettings;
        private int? _dvbTeletextPid;
        private M2tsEbpAudioInterval _ebpAudioInterval;
        private M2tsEbpPlacement _ebpPlacement;
        private M2tsEsRateInPes _esRateInPes;
        private M2tsForceTsVideoEbpOrder _forceTsVideoEbpOrder;
        private double? _fragmentTime;
        private M2tsKlvMetadata _klvMetadata;
        private int? _maxPcrInterval;
        private int? _minEbpInterval;
        private M2tsNielsenId3 _nielsenId3;
        private double? _nullPacketBitrate;
        private int? _patInterval;
        private M2tsPcrControl _pcrControl;
        private int? _pcrPid;
        private int? _pmtInterval;
        private int? _pmtPid;
        private int? _privateMetadataPid;
        private int? _programNumber;
        private M2tsRateMode _rateMode;
        private M2tsScte35Esam _scte35Esam;
        private int? _scte35Pid;
        private M2tsScte35Source _scte35Source;
        private M2tsSegmentationMarkers _segmentationMarkers;
        private M2tsSegmentationStyle _segmentationStyle;
        private double? _segmentationTime;
        private int? _timedMetadataPid;
        private int? _transportStreamId;
        private int? _videoPid;

        /// <summary>
        /// Gets and sets the property AudioBufferModel. Selects between the DVB and ATSC buffer
        /// models for Dolby Digital audio.
        /// </summary>
        public M2tsAudioBufferModel AudioBufferModel
        {
            get { return this._audioBufferModel; }
            set { this._audioBufferModel = value; }
        }

        // Check to see if AudioBufferModel property is set
        internal bool IsSetAudioBufferModel()
        {
            return this._audioBufferModel != null;
        }

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration (MATCH_VIDEO_DURATION). In all other cases, keep the default value, Default
        /// codec duration (DEFAULT_CODEC_DURATION). When you choose Match video duration, MediaConvert
        /// pads the output audio streams with silence or trims them to ensure that the total
        /// duration of each audio stream is at least as long as the total duration of the video
        /// stream. After padding or trimming, the audio stream duration is no more than one frame
        /// longer than the video stream. MediaConvert applies audio padding or trimming only
        /// to the end of the last segment of the output. For unsegmented outputs, MediaConvert
        /// adds padding only to the end of the file. When you keep the default value, any minor
        /// discrepancies between audio and video duration will depend on your output audio codec.
        /// </summary>
        public M2tsAudioDuration AudioDuration
        {
            get { return this._audioDuration; }
            set { this._audioDuration = value; }
        }

        // Check to see if AudioDuration property is set
        internal bool IsSetAudioDuration()
        {
            return this._audioDuration != null;
        }

        /// <summary>
        /// Gets and sets the property AudioFramesPerPes. The number of audio frames to insert
        /// for each PES packet.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int AudioFramesPerPes
        {
            get { return this._audioFramesPerPes.GetValueOrDefault(); }
            set { this._audioFramesPerPes = value; }
        }

        // Check to see if AudioFramesPerPes property is set
        internal bool IsSetAudioFramesPerPes()
        {
            return this._audioFramesPerPes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioPids. Specify the packet identifiers (PIDs) for any
        /// elementary audio streams you include in this output. Specify multiple PIDs as a JSON
        /// array. Default is the range 482-492.
        /// </summary>
        public List<int> AudioPids
        {
            get { return this._audioPids; }
            set { this._audioPids = value; }
        }

        // Check to see if AudioPids property is set
        internal bool IsSetAudioPids()
        {
            return this._audioPids != null && this._audioPids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the output bitrate of the transport stream
        /// in bits per second. Setting to 0 lets the muxer automatically determine the appropriate
        /// bitrate. Other common values are 3750000, 7500000, and 15000000.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int Bitrate
        {
            get { return this._bitrate.GetValueOrDefault(); }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BufferModel. Controls what buffer model to use for accurate
        /// interleaving. If set to MULTIPLEX, use multiplex buffer model. If set to NONE, this
        /// can lead to lower latency, but low-memory devices may not be able to play back the
        /// stream without interruptions.
        /// </summary>
        public M2tsBufferModel BufferModel
        {
            get { return this._bufferModel; }
            set { this._bufferModel = value; }
        }

        // Check to see if BufferModel property is set
        internal bool IsSetBufferModel()
        {
            return this._bufferModel != null;
        }

        /// <summary>
        /// Gets and sets the property DataPTSControl. If you select ALIGN_TO_VIDEO, MediaConvert
        /// writes captions and data packets with Presentation Timestamp (PTS) values greater
        /// than or equal to the first video packet PTS (MediaConvert drops captions and data
        /// packets with lesser PTS values). Keep the default value (AUTO) to allow all PTS values.
        /// </summary>
        public M2tsDataPtsControl DataPTSControl
        {
            get { return this._dataPTSControl; }
            set { this._dataPTSControl = value; }
        }

        // Check to see if DataPTSControl property is set
        internal bool IsSetDataPTSControl()
        {
            return this._dataPTSControl != null;
        }

        /// <summary>
        /// Gets and sets the property DvbNitSettings. Use these settings to insert a DVB Network
        /// Information Table (NIT) in the transport stream of this output. When you work directly
        /// in your JSON job specification, include this object only when your job has a transport
        /// stream output and the container settings contain the object M2tsSettings.
        /// </summary>
        public DvbNitSettings DvbNitSettings
        {
            get { return this._dvbNitSettings; }
            set { this._dvbNitSettings = value; }
        }

        // Check to see if DvbNitSettings property is set
        internal bool IsSetDvbNitSettings()
        {
            return this._dvbNitSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSdtSettings. Use these settings to insert a DVB Service
        /// Description Table (SDT) in the transport stream of this output. When you work directly
        /// in your JSON job specification, include this object only when your job has a transport
        /// stream output and the container settings contain the object M2tsSettings.
        /// </summary>
        public DvbSdtSettings DvbSdtSettings
        {
            get { return this._dvbSdtSettings; }
            set { this._dvbSdtSettings = value; }
        }

        // Check to see if DvbSdtSettings property is set
        internal bool IsSetDvbSdtSettings()
        {
            return this._dvbSdtSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSubPids. Specify the packet identifiers (PIDs) for DVB
        /// subtitle data included in this output. Specify multiple PIDs as a JSON array. Default
        /// is the range 460-479.
        /// </summary>
        public List<int> DvbSubPids
        {
            get { return this._dvbSubPids; }
            set { this._dvbSubPids = value; }
        }

        // Check to see if DvbSubPids property is set
        internal bool IsSetDvbSubPids()
        {
            return this._dvbSubPids != null && this._dvbSubPids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DvbTdtSettings. Use these settings to insert a DVB Time
        /// and Date Table (TDT) in the transport stream of this output. When you work directly
        /// in your JSON job specification, include this object only when your job has a transport
        /// stream output and the container settings contain the object M2tsSettings.
        /// </summary>
        public DvbTdtSettings DvbTdtSettings
        {
            get { return this._dvbTdtSettings; }
            set { this._dvbTdtSettings = value; }
        }

        // Check to see if DvbTdtSettings property is set
        internal bool IsSetDvbTdtSettings()
        {
            return this._dvbTdtSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbTeletextPid. Specify the packet identifier (PID) for
        /// DVB teletext data you include in this output. Default is 499.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int DvbTeletextPid
        {
            get { return this._dvbTeletextPid.GetValueOrDefault(); }
            set { this._dvbTeletextPid = value; }
        }

        // Check to see if DvbTeletextPid property is set
        internal bool IsSetDvbTeletextPid()
        {
            return this._dvbTeletextPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbpAudioInterval. When set to VIDEO_AND_FIXED_INTERVALS,
        /// audio EBP markers will be added to partitions 3 and 4. The interval between these
        /// additional markers will be fixed, and will be slightly shorter than the video EBP
        /// marker interval. When set to VIDEO_INTERVAL, these additional markers will not be
        /// inserted. Only applicable when EBP segmentation markers are is selected (segmentationMarkers
        /// is EBP or EBP_LEGACY).
        /// </summary>
        public M2tsEbpAudioInterval EbpAudioInterval
        {
            get { return this._ebpAudioInterval; }
            set { this._ebpAudioInterval = value; }
        }

        // Check to see if EbpAudioInterval property is set
        internal bool IsSetEbpAudioInterval()
        {
            return this._ebpAudioInterval != null;
        }

        /// <summary>
        /// Gets and sets the property EbpPlacement. Selects which PIDs to place EBP markers on.
        /// They can either be placed only on the video PID, or on both the video PID and all
        /// audio PIDs. Only applicable when EBP segmentation markers are is selected (segmentationMarkers
        /// is EBP or EBP_LEGACY).
        /// </summary>
        public M2tsEbpPlacement EbpPlacement
        {
            get { return this._ebpPlacement; }
            set { this._ebpPlacement = value; }
        }

        // Check to see if EbpPlacement property is set
        internal bool IsSetEbpPlacement()
        {
            return this._ebpPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property EsRateInPes. Controls whether to include the ES Rate field
        /// in the PES header.
        /// </summary>
        public M2tsEsRateInPes EsRateInPes
        {
            get { return this._esRateInPes; }
            set { this._esRateInPes = value; }
        }

        // Check to see if EsRateInPes property is set
        internal bool IsSetEsRateInPes()
        {
            return this._esRateInPes != null;
        }

        /// <summary>
        /// Gets and sets the property ForceTsVideoEbpOrder. Keep the default value (DEFAULT)
        /// unless you know that your audio EBP markers are incorrectly appearing before your
        /// video EBP markers. To correct this problem, set this value to Force (FORCE).
        /// </summary>
        public M2tsForceTsVideoEbpOrder ForceTsVideoEbpOrder
        {
            get { return this._forceTsVideoEbpOrder; }
            set { this._forceTsVideoEbpOrder = value; }
        }

        // Check to see if ForceTsVideoEbpOrder property is set
        internal bool IsSetForceTsVideoEbpOrder()
        {
            return this._forceTsVideoEbpOrder != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentTime. The length, in seconds, of each fragment.
        /// Only used with EBP markers.
        /// </summary>
        public double FragmentTime
        {
            get { return this._fragmentTime.GetValueOrDefault(); }
            set { this._fragmentTime = value; }
        }

        // Check to see if FragmentTime property is set
        internal bool IsSetFragmentTime()
        {
            return this._fragmentTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KlvMetadata. To include key-length-value metadata in this
        /// output: Set KLV metadata insertion to Passthrough. MediaConvert reads KLV metadata
        /// present in your input and passes it through to the output transport stream. To exclude
        /// this KLV metadata: Set KLV metadata insertion to None or leave blank.
        /// </summary>
        public M2tsKlvMetadata KlvMetadata
        {
            get { return this._klvMetadata; }
            set { this._klvMetadata = value; }
        }

        // Check to see if KlvMetadata property is set
        internal bool IsSetKlvMetadata()
        {
            return this._klvMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property MaxPcrInterval. Specify the maximum time, in milliseconds,
        /// between Program Clock References (PCRs) inserted into the transport stream.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int MaxPcrInterval
        {
            get { return this._maxPcrInterval.GetValueOrDefault(); }
            set { this._maxPcrInterval = value; }
        }

        // Check to see if MaxPcrInterval property is set
        internal bool IsSetMaxPcrInterval()
        {
            return this._maxPcrInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinEbpInterval. When set, enforces that Encoder Boundary
        /// Points do not come within the specified time interval of each other by looking ahead
        /// at input video. If another EBP is going to come in within the specified time interval,
        /// the current EBP is not emitted, and the segment is "stretched" to the next marker.
        /// The lookahead value does not add latency to the system. The Live Event must be configured
        /// elsewhere to create sufficient latency to make the lookahead accurate.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int MinEbpInterval
        {
            get { return this._minEbpInterval.GetValueOrDefault(); }
            set { this._minEbpInterval = value; }
        }

        // Check to see if MinEbpInterval property is set
        internal bool IsSetMinEbpInterval()
        {
            return this._minEbpInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NielsenId3. If INSERT, Nielsen inaudible tones for media
        /// tracking will be detected in the input audio and an equivalent ID3 tag will be inserted
        /// in the output.
        /// </summary>
        public M2tsNielsenId3 NielsenId3
        {
            get { return this._nielsenId3; }
            set { this._nielsenId3 = value; }
        }

        // Check to see if NielsenId3 property is set
        internal bool IsSetNielsenId3()
        {
            return this._nielsenId3 != null;
        }

        /// <summary>
        /// Gets and sets the property NullPacketBitrate. Value in bits per second of extra null
        /// packets to insert into the transport stream. This can be used if a downstream encryption
        /// system requires periodic null packets.
        /// </summary>
        public double NullPacketBitrate
        {
            get { return this._nullPacketBitrate.GetValueOrDefault(); }
            set { this._nullPacketBitrate = value; }
        }

        // Check to see if NullPacketBitrate property is set
        internal bool IsSetNullPacketBitrate()
        {
            return this._nullPacketBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PatInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int PatInterval
        {
            get { return this._patInterval.GetValueOrDefault(); }
            set { this._patInterval = value; }
        }

        // Check to see if PatInterval property is set
        internal bool IsSetPatInterval()
        {
            return this._patInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PcrControl. When set to PCR_EVERY_PES_PACKET, a Program
        /// Clock Reference value is inserted for every Packetized Elementary Stream (PES) header.
        /// This is effective only when the PCR PID is the same as the video or audio elementary
        /// stream.
        /// </summary>
        public M2tsPcrControl PcrControl
        {
            get { return this._pcrControl; }
            set { this._pcrControl = value; }
        }

        // Check to see if PcrControl property is set
        internal bool IsSetPcrControl()
        {
            return this._pcrControl != null;
        }

        /// <summary>
        /// Gets and sets the property PcrPid. Specify the packet identifier (PID) for the program
        /// clock reference (PCR) in this output. If you do not specify a value, the service will
        /// use the value for Video PID (VideoPid).
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int PcrPid
        {
            get { return this._pcrPid.GetValueOrDefault(); }
            set { this._pcrPid = value; }
        }

        // Check to see if PcrPid property is set
        internal bool IsSetPcrPid()
        {
            return this._pcrPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PmtInterval. Specify the number of milliseconds between
        /// instances of the program map table (PMT) in the output transport stream.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int PmtInterval
        {
            get { return this._pmtInterval.GetValueOrDefault(); }
            set { this._pmtInterval = value; }
        }

        // Check to see if PmtInterval property is set
        internal bool IsSetPmtInterval()
        {
            return this._pmtInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PmtPid. Specify the packet identifier (PID) for the program
        /// map table (PMT) itself. Default is 480.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int PmtPid
        {
            get { return this._pmtPid.GetValueOrDefault(); }
            set { this._pmtPid = value; }
        }

        // Check to see if PmtPid property is set
        internal bool IsSetPmtPid()
        {
            return this._pmtPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateMetadataPid. Specify the packet identifier (PID)
        /// of the private metadata stream. Default is 503.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int PrivateMetadataPid
        {
            get { return this._privateMetadataPid.GetValueOrDefault(); }
            set { this._privateMetadataPid = value; }
        }

        // Check to see if PrivateMetadataPid property is set
        internal bool IsSetPrivateMetadataPid()
        {
            return this._privateMetadataPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Use Program number (programNumber) to specify
        /// the program number used in the program map table (PMT) for this output. Default is
        /// 1. Program numbers and program map tables are parts of MPEG-2 transport stream containers,
        /// used for organizing data.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int ProgramNumber
        {
            get { return this._programNumber.GetValueOrDefault(); }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateMode. When set to CBR, inserts null packets into transport
        /// stream to fill specified bitrate. When set to VBR, the bitrate setting acts as the
        /// maximum bitrate, but the output will not be padded up to that bitrate.
        /// </summary>
        public M2tsRateMode RateMode
        {
            get { return this._rateMode; }
            set { this._rateMode = value; }
        }

        // Check to see if RateMode property is set
        internal bool IsSetRateMode()
        {
            return this._rateMode != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Esam. Include this in your job settings to put SCTE-35
        /// markers in your HLS and transport stream outputs at the insertion points that you
        /// specify in an ESAM XML document. Provide the document in the setting SCC XML (sccXml).
        /// </summary>
        public M2tsScte35Esam Scte35Esam
        {
            get { return this._scte35Esam; }
            set { this._scte35Esam = value; }
        }

        // Check to see if Scte35Esam property is set
        internal bool IsSetScte35Esam()
        {
            return this._scte35Esam != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Pid. Specify the packet identifier (PID) of the SCTE-35
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int Scte35Pid
        {
            get { return this._scte35Pid.GetValueOrDefault(); }
            set { this._scte35Pid = value; }
        }

        // Check to see if Scte35Pid property is set
        internal bool IsSetScte35Pid()
        {
            return this._scte35Pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scte35Source. For SCTE-35 markers from your input-- Choose
        /// Passthrough (PASSTHROUGH) if you want SCTE-35 markers that appear in your input to
        /// also appear in this output. Choose None (NONE) if you don't want SCTE-35 markers in
        /// this output. For SCTE-35 markers from an ESAM XML document-- Choose None (NONE). Also
        /// provide the ESAM XML as a string in the setting Signal processing notification XML
        /// (sccXml). Also enable ESAM SCTE-35 (include the property scte35Esam).
        /// </summary>
        public M2tsScte35Source Scte35Source
        {
            get { return this._scte35Source; }
            set { this._scte35Source = value; }
        }

        // Check to see if Scte35Source property is set
        internal bool IsSetScte35Source()
        {
            return this._scte35Source != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationMarkers. Inserts segmentation markers at each
        /// segmentation_time period. rai_segstart sets the Random Access Indicator bit in the
        /// adaptation field. rai_adapt sets the RAI bit and adds the current timecode in the
        /// private data bytes. psi_segstart inserts PAT and PMT tables at the start of segments.
        /// ebp adds Encoder Boundary Point information to the adaptation field as per OpenCable
        /// specification OC-SP-EBP-I01-130118. ebp_legacy adds Encoder Boundary Point information
        /// to the adaptation field using a legacy proprietary format.
        /// </summary>
        public M2tsSegmentationMarkers SegmentationMarkers
        {
            get { return this._segmentationMarkers; }
            set { this._segmentationMarkers = value; }
        }

        // Check to see if SegmentationMarkers property is set
        internal bool IsSetSegmentationMarkers()
        {
            return this._segmentationMarkers != null;
        }

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
        public M2tsSegmentationStyle SegmentationStyle
        {
            get { return this._segmentationStyle; }
            set { this._segmentationStyle = value; }
        }

        // Check to see if SegmentationStyle property is set
        internal bool IsSetSegmentationStyle()
        {
            return this._segmentationStyle != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationTime. Specify the length, in seconds, of each
        /// segment. Required unless markers is set to _none_.
        /// </summary>
        public double SegmentationTime
        {
            get { return this._segmentationTime.GetValueOrDefault(); }
            set { this._segmentationTime = value; }
        }

        // Check to see if SegmentationTime property is set
        internal bool IsSetSegmentationTime()
        {
            return this._segmentationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the ID3 metadata
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int TimedMetadataPid
        {
            get { return this._timedMetadataPid.GetValueOrDefault(); }
            set { this._timedMetadataPid = value; }
        }

        // Check to see if TimedMetadataPid property is set
        internal bool IsSetTimedMetadataPid()
        {
            return this._timedMetadataPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportStreamId. Specify the ID for the transport stream
        /// itself in the program map table for this output. Transport stream IDs and program
        /// map tables are parts of MPEG-2 transport stream containers, used for organizing data.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int TransportStreamId
        {
            get { return this._transportStreamId.GetValueOrDefault(); }
            set { this._transportStreamId = value; }
        }

        // Check to see if TransportStreamId property is set
        internal bool IsSetTransportStreamId()
        {
            return this._transportStreamId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoPid. Specify the packet identifier (PID) of the elementary
        /// video stream in the transport stream.
        /// </summary>
        [AWSProperty(Min=32, Max=8182)]
        public int VideoPid
        {
            get { return this._videoPid.GetValueOrDefault(); }
            set { this._videoPid = value; }
        }

        // Check to see if VideoPid property is set
        internal bool IsSetVideoPid()
        {
            return this._videoPid.HasValue; 
        }

    }
}