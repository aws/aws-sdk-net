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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// M2ts Settings
    /// </summary>
    public partial class M2tsSettings
    {
        private M2tsAbsentInputAudioBehavior _absentInputAudioBehavior;
        private M2tsArib _arib;
        private string _aribCaptionsPid;
        private M2tsAribCaptionsPidControl _aribCaptionsPidControl;
        private M2tsAudioBufferModel _audioBufferModel;
        private int? _audioFramesPerPes;
        private string _audioPids;
        private M2tsAudioStreamType _audioStreamType;
        private int? _bitrate;
        private M2tsBufferModel _bufferModel;
        private M2tsCcDescriptor _ccDescriptor;
        private DvbNitSettings _dvbNitSettings;
        private DvbSdtSettings _dvbSdtSettings;
        private string _dvbSubPids;
        private DvbTdtSettings _dvbTdtSettings;
        private string _dvbTeletextPid;
        private M2tsEbifControl _ebif;
        private M2tsAudioInterval _ebpAudioInterval;
        private int? _ebpLookaheadMs;
        private M2tsEbpPlacement _ebpPlacement;
        private string _ecmPid;
        private M2tsEsRateInPes _esRateInPes;
        private string _etvPlatformPid;
        private string _etvSignalPid;
        private double? _fragmentTime;
        private M2tsKlv _klv;
        private string _klvDataPids;
        private M2tsNielsenId3Behavior _nielsenId3Behavior;
        private double? _nullPacketBitrate;
        private int? _patInterval;
        private M2tsPcrControl _pcrControl;
        private int? _pcrPeriod;
        private string _pcrPid;
        private int? _pmtInterval;
        private string _pmtPid;
        private int? _programNum;
        private M2tsRateMode _rateMode;
        private string _scte27Pids;
        private M2tsScte35Control _scte35Control;
        private string _scte35Pid;
        private double? _scte35PrerollPullupMilliseconds;
        private M2tsSegmentationMarkers _segmentationMarkers;
        private M2tsSegmentationStyle _segmentationStyle;
        private double? _segmentationTime;
        private M2tsTimedMetadataBehavior _timedMetadataBehavior;
        private string _timedMetadataPid;
        private int? _transportStreamId;
        private string _videoPid;

        /// <summary>
        /// Gets and sets the property AbsentInputAudioBehavior. When set to drop, output audio
        /// streams will be removed from the program if the selected input audio stream is removed
        /// from the input. This allows the output audio configuration to dynamically change based
        /// on input configuration. If this is set to encodeSilence, all output audio streams
        /// will output encoded silence when not connected to an active input stream.
        /// </summary>
        public M2tsAbsentInputAudioBehavior AbsentInputAudioBehavior
        {
            get { return this._absentInputAudioBehavior; }
            set { this._absentInputAudioBehavior = value; }
        }

        // Check to see if AbsentInputAudioBehavior property is set
        internal bool IsSetAbsentInputAudioBehavior()
        {
            return this._absentInputAudioBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Arib. When set to enabled, uses ARIB-compliant field muxing
        /// and removes video descriptor.
        /// </summary>
        public M2tsArib Arib
        {
            get { return this._arib; }
            set { this._arib = value; }
        }

        // Check to see if Arib property is set
        internal bool IsSetArib()
        {
            return this._arib != null;
        }

        /// <summary>
        /// Gets and sets the property AribCaptionsPid. Packet Identifier (PID) for ARIB Captions
        /// in the transport stream. Can be entered as a decimal or hexadecimal value.  Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string AribCaptionsPid
        {
            get { return this._aribCaptionsPid; }
            set { this._aribCaptionsPid = value; }
        }

        // Check to see if AribCaptionsPid property is set
        internal bool IsSetAribCaptionsPid()
        {
            return this._aribCaptionsPid != null;
        }

        /// <summary>
        /// Gets and sets the property AribCaptionsPidControl. If set to auto, pid number used
        /// for ARIB Captions will be auto-selected from unused pids.  If set to useConfigured,
        /// ARIB Captions will be on the configured pid number.
        /// </summary>
        public M2tsAribCaptionsPidControl AribCaptionsPidControl
        {
            get { return this._aribCaptionsPidControl; }
            set { this._aribCaptionsPidControl = value; }
        }

        // Check to see if AribCaptionsPidControl property is set
        internal bool IsSetAribCaptionsPidControl()
        {
            return this._aribCaptionsPidControl != null;
        }

        /// <summary>
        /// Gets and sets the property AudioBufferModel. When set to dvb, uses DVB buffer model
        /// for Dolby Digital audio.  When set to atsc, the ATSC model is used.
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
        /// Gets and sets the property AudioFramesPerPes. The number of audio frames to insert
        /// for each PES packet.
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property AudioPids. Packet Identifier (PID) of the elementary audio
        /// stream(s) in the transport stream. Multiple values are accepted, and can be entered
        /// in ranges and/or by comma separation. Can be entered as decimal or hexadecimal values.
        /// Each PID specified must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string AudioPids
        {
            get { return this._audioPids; }
            set { this._audioPids = value; }
        }

        // Check to see if AudioPids property is set
        internal bool IsSetAudioPids()
        {
            return this._audioPids != null;
        }

        /// <summary>
        /// Gets and sets the property AudioStreamType. When set to atsc, uses stream type = 0x81
        /// for AC3 and stream type = 0x87 for EAC3. When set to dvb, uses stream type = 0x06.
        /// </summary>
        public M2tsAudioStreamType AudioStreamType
        {
            get { return this._audioStreamType; }
            set { this._audioStreamType = value; }
        }

        // Check to see if AudioStreamType property is set
        internal bool IsSetAudioStreamType()
        {
            return this._audioStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. The output bitrate of the transport stream in
        /// bits per second. Setting to 0 lets the muxer automatically determine the appropriate
        /// bitrate.
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property BufferModel. Controls the timing accuracy for output network
        /// traffic. Leave as MULTIPLEX to ensure accurate network packet timing. Or set to NONE,
        /// which might result in lower latency but will result in more variability in output
        /// network packet timing. This variability might cause interruptions, jitter, or bursty
        /// behavior in your playback or receiving devices.
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
        /// Gets and sets the property CcDescriptor. When set to enabled, generates captionServiceDescriptor
        /// in PMT.
        /// </summary>
        public M2tsCcDescriptor CcDescriptor
        {
            get { return this._ccDescriptor; }
            set { this._ccDescriptor = value; }
        }

        // Check to see if CcDescriptor property is set
        internal bool IsSetCcDescriptor()
        {
            return this._ccDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property DvbNitSettings. Inserts DVB Network Information Table (NIT)
        /// at the specified table repetition interval.
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
        /// Gets and sets the property DvbSdtSettings. Inserts DVB Service Description Table (SDT)
        /// at the specified table repetition interval.
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
        /// Gets and sets the property DvbSubPids. Packet Identifier (PID) for input source DVB
        /// Subtitle data to this output. Multiple values are accepted, and can be entered in
        /// ranges and/or by comma separation. Can be entered as decimal or hexadecimal values.
        ///  Each PID specified must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string DvbSubPids
        {
            get { return this._dvbSubPids; }
            set { this._dvbSubPids = value; }
        }

        // Check to see if DvbSubPids property is set
        internal bool IsSetDvbSubPids()
        {
            return this._dvbSubPids != null;
        }

        /// <summary>
        /// Gets and sets the property DvbTdtSettings. Inserts DVB Time and Date Table (TDT) at
        /// the specified table repetition interval.
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
        /// Gets and sets the property DvbTeletextPid. Packet Identifier (PID) for input source
        /// DVB Teletext data to this output. Can be entered as a decimal or hexadecimal value.
        ///  Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string DvbTeletextPid
        {
            get { return this._dvbTeletextPid; }
            set { this._dvbTeletextPid = value; }
        }

        // Check to see if DvbTeletextPid property is set
        internal bool IsSetDvbTeletextPid()
        {
            return this._dvbTeletextPid != null;
        }

        /// <summary>
        /// Gets and sets the property Ebif. If set to passthrough, passes any EBIF data from
        /// the input source to this output.
        /// </summary>
        public M2tsEbifControl Ebif
        {
            get { return this._ebif; }
            set { this._ebif = value; }
        }

        // Check to see if Ebif property is set
        internal bool IsSetEbif()
        {
            return this._ebif != null;
        }

        /// <summary>
        /// Gets and sets the property EbpAudioInterval. When videoAndFixedIntervals is selected,
        /// audio EBP markers will be added to partitions 3 and 4. The interval between these
        /// additional markers will be fixed, and will be slightly shorter than the video EBP
        /// marker interval. Only available when EBP Cablelabs segmentation markers are selected.
        ///  Partitions 1 and 2 will always follow the video interval.
        /// </summary>
        public M2tsAudioInterval EbpAudioInterval
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
        /// Gets and sets the property EbpLookaheadMs. When set, enforces that Encoder Boundary
        /// Points do not come within the specified time interval of each other by looking ahead
        /// at input video. If another EBP is going to come in within the specified time interval,
        /// the current EBP is not emitted, and the segment is "stretched" to the next marker.
        ///  The lookahead value does not add latency to the system. The Live Event must be configured
        /// elsewhere to create sufficient latency to make the lookahead accurate.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int EbpLookaheadMs
        {
            get { return this._ebpLookaheadMs.GetValueOrDefault(); }
            set { this._ebpLookaheadMs = value; }
        }

        // Check to see if EbpLookaheadMs property is set
        internal bool IsSetEbpLookaheadMs()
        {
            return this._ebpLookaheadMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbpPlacement. Controls placement of EBP on Audio PIDs.
        /// If set to videoAndAudioPids, EBP markers will be placed on the video PID and all audio
        /// PIDs.  If set to videoPid, EBP markers will be placed on only the video PID.
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
        /// Gets and sets the property EcmPid. This field is unused and deprecated.
        /// </summary>
        public string EcmPid
        {
            get { return this._ecmPid; }
            set { this._ecmPid = value; }
        }

        // Check to see if EcmPid property is set
        internal bool IsSetEcmPid()
        {
            return this._ecmPid != null;
        }

        /// <summary>
        /// Gets and sets the property EsRateInPes. Include or exclude the ES Rate field in the
        /// PES header.
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
        /// Gets and sets the property EtvPlatformPid. Packet Identifier (PID) for input source
        /// ETV Platform data to this output. Can be entered as a decimal or hexadecimal value.
        ///  Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string EtvPlatformPid
        {
            get { return this._etvPlatformPid; }
            set { this._etvPlatformPid = value; }
        }

        // Check to see if EtvPlatformPid property is set
        internal bool IsSetEtvPlatformPid()
        {
            return this._etvPlatformPid != null;
        }

        /// <summary>
        /// Gets and sets the property EtvSignalPid. Packet Identifier (PID) for input source
        /// ETV Signal data to this output. Can be entered as a decimal or hexadecimal value.
        ///  Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string EtvSignalPid
        {
            get { return this._etvSignalPid; }
            set { this._etvSignalPid = value; }
        }

        // Check to see if EtvSignalPid property is set
        internal bool IsSetEtvSignalPid()
        {
            return this._etvSignalPid != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentTime. The length in seconds of each fragment. Only
        /// used with EBP markers.
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
        /// Gets and sets the property Klv. If set to passthrough, passes any KLV data from the
        /// input source to this output.
        /// </summary>
        public M2tsKlv Klv
        {
            get { return this._klv; }
            set { this._klv = value; }
        }

        // Check to see if Klv property is set
        internal bool IsSetKlv()
        {
            return this._klv != null;
        }

        /// <summary>
        /// Gets and sets the property KlvDataPids. Packet Identifier (PID) for input source KLV
        /// data to this output. Multiple values are accepted, and can be entered in ranges and/or
        /// by comma separation. Can be entered as decimal or hexadecimal values.  Each PID specified
        /// must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string KlvDataPids
        {
            get { return this._klvDataPids; }
            set { this._klvDataPids = value; }
        }

        // Check to see if KlvDataPids property is set
        internal bool IsSetKlvDataPids()
        {
            return this._klvDataPids != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public M2tsNielsenId3Behavior NielsenId3Behavior
        {
            get { return this._nielsenId3Behavior; }
            set { this._nielsenId3Behavior = value; }
        }

        // Check to see if NielsenId3Behavior property is set
        internal bool IsSetNielsenId3Behavior()
        {
            return this._nielsenId3Behavior != null;
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
        /// of this table in the output transport stream.  Valid values are 0, 10..1000.
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
        /// Gets and sets the property PcrControl. When set to pcrEveryPesPacket, a Program Clock
        /// Reference value is inserted for every Packetized Elementary Stream (PES) header. This
        /// parameter is effective only when the PCR PID is the same as the video or audio elementary
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
        /// Gets and sets the property PcrPeriod. Maximum time in milliseconds between Program
        /// Clock Reference (PCRs) inserted into the transport stream.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int PcrPeriod
        {
            get { return this._pcrPeriod.GetValueOrDefault(); }
            set { this._pcrPeriod = value; }
        }

        // Check to see if PcrPeriod property is set
        internal bool IsSetPcrPeriod()
        {
            return this._pcrPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PcrPid. Packet Identifier (PID) of the Program Clock Reference
        /// (PCR) in the transport stream. When no value is given, the encoder will assign the
        /// same value as the Video PID. Can be entered as a decimal or hexadecimal value.  Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string PcrPid
        {
            get { return this._pcrPid; }
            set { this._pcrPid = value; }
        }

        // Check to see if PcrPid property is set
        internal bool IsSetPcrPid()
        {
            return this._pcrPid != null;
        }

        /// <summary>
        /// Gets and sets the property PmtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. Valid values are 0, 10..1000.
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
        /// Gets and sets the property PmtPid. Packet Identifier (PID) for the Program Map Table
        /// (PMT) in the transport stream. Can be entered as a decimal or hexadecimal value. Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string PmtPid
        {
            get { return this._pmtPid; }
            set { this._pmtPid = value; }
        }

        // Check to see if PmtPid property is set
        internal bool IsSetPmtPid()
        {
            return this._pmtPid != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramNum. The value of the program number field in the
        /// Program Map Table.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int ProgramNum
        {
            get { return this._programNum.GetValueOrDefault(); }
            set { this._programNum = value; }
        }

        // Check to see if ProgramNum property is set
        internal bool IsSetProgramNum()
        {
            return this._programNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateMode. When vbr, does not insert null packets into transport
        /// stream to fill specified bitrate. The bitrate setting acts as the maximum bitrate
        /// when vbr is set.
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
        /// Gets and sets the property Scte27Pids. Packet Identifier (PID) for input source SCTE-27
        /// data to this output. Multiple values are accepted, and can be entered in ranges and/or
        /// by comma separation. Can be entered as decimal or hexadecimal values.  Each PID specified
        /// must be in the range of 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string Scte27Pids
        {
            get { return this._scte27Pids; }
            set { this._scte27Pids = value; }
        }

        // Check to see if Scte27Pids property is set
        internal bool IsSetScte27Pids()
        {
            return this._scte27Pids != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Control. Optionally pass SCTE-35 signals from the
        /// input source to this output.
        /// </summary>
        public M2tsScte35Control Scte35Control
        {
            get { return this._scte35Control; }
            set { this._scte35Control = value; }
        }

        // Check to see if Scte35Control property is set
        internal bool IsSetScte35Control()
        {
            return this._scte35Control != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream. Can be entered as a decimal or hexadecimal value.  Valid
        /// values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string Scte35Pid
        {
            get { return this._scte35Pid; }
            set { this._scte35Pid = value; }
        }

        // Check to see if Scte35Pid property is set
        internal bool IsSetScte35Pid()
        {
            return this._scte35Pid != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35PrerollPullupMilliseconds. Defines the amount SCTE-35
        /// preroll will be increased (in milliseconds) on the output. Preroll is the amount of
        /// time between the presence of a SCTE-35 indication in a transport stream and the PTS
        /// of the video frame it references. Zero means don't add pullup (it doesn't mean set
        /// the preroll to zero). Negative pullup is not supported, which means that you can't
        /// make the preroll shorter. Be aware that latency in the output will increase by the
        /// pullup amount.
        /// </summary>
        public double Scte35PrerollPullupMilliseconds
        {
            get { return this._scte35PrerollPullupMilliseconds.GetValueOrDefault(); }
            set { this._scte35PrerollPullupMilliseconds = value; }
        }

        // Check to see if Scte35PrerollPullupMilliseconds property is set
        internal bool IsSetScte35PrerollPullupMilliseconds()
        {
            return this._scte35PrerollPullupMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationMarkers. Inserts segmentation markers at each
        /// segmentationTime period. raiSegstart sets the Random Access Indicator bit in the adaptation
        /// field. raiAdapt sets the RAI bit and adds the current timecode in the private data
        /// bytes. psiSegstart inserts PAT and PMT tables at the start of segments. ebp adds Encoder
        /// Boundary Point information to the adaptation field as per OpenCable specification
        /// OC-SP-EBP-I01-130118. ebpLegacy adds Encoder Boundary Point information to the adaptation
        /// field using a legacy proprietary format.
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
        /// markers are inserted.When a segmentation style of "resetCadence" is selected and a
        /// segment is truncated due to an avail, we will reset the segmentation cadence. This
        /// means the subsequent segment will have a duration of $segmentationTime seconds.When
        /// a segmentation style of "maintainCadence" is selected and a segment is truncated due
        /// to an avail, we will not reset the segmentation cadence. This means the subsequent
        /// segment will likely be truncated as well. However, all segments after that will have
        /// a duration of $segmentationTime seconds. Note that EBP lookahead is a slight exception
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
        /// Gets and sets the property SegmentationTime. The length in seconds of each segment.
        /// Required unless markers is set to _none_.
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
        /// Gets and sets the property TimedMetadataBehavior. When set to passthrough, timed metadata
        /// will be passed through from input to output.
        /// </summary>
        public M2tsTimedMetadataBehavior TimedMetadataBehavior
        {
            get { return this._timedMetadataBehavior; }
            set { this._timedMetadataBehavior = value; }
        }

        // Check to see if TimedMetadataBehavior property is set
        internal bool IsSetTimedMetadataBehavior()
        {
            return this._timedMetadataBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the timed
        /// metadata stream in the transport stream. Can be entered as a decimal or hexadecimal
        /// value.  Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string TimedMetadataPid
        {
            get { return this._timedMetadataPid; }
            set { this._timedMetadataPid = value; }
        }

        // Check to see if TimedMetadataPid property is set
        internal bool IsSetTimedMetadataPid()
        {
            return this._timedMetadataPid != null;
        }

        /// <summary>
        /// Gets and sets the property TransportStreamId. The value of the transport stream ID
        /// field in the Program Map Table.
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
        /// Gets and sets the property VideoPid. Packet Identifier (PID) of the elementary video
        /// stream in the transport stream. Can be entered as a decimal or hexadecimal value.
        ///  Valid values are 32 (or 0x20)..8182 (or 0x1ff6).
        /// </summary>
        public string VideoPid
        {
            get { return this._videoPid; }
            set { this._videoPid = value; }
        }

        // Check to see if VideoPid property is set
        internal bool IsSetVideoPid()
        {
            return this._videoPid != null;
        }

    }
}