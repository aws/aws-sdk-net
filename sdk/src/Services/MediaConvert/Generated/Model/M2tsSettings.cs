/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for M2TS Container.
    /// </summary>
    public partial class M2tsSettings
    {
        private M2tsAudioBufferModel _audioBufferModel;
        private int? _audioFramesPerPes;
        private List<int> _audioPids = new List<int>();
        private int? _bitrate;
        private M2tsBufferModel _bufferModel;
        private DvbNitSettings _dvbNitSettings;
        private DvbSdtSettings _dvbSdtSettings;
        private List<int> _dvbSubPids = new List<int>();
        private DvbTdtSettings _dvbTdtSettings;
        private int? _dvbTeletextPid;
        private M2tsEbpAudioInterval _ebpAudioInterval;
        private M2tsEbpPlacement _ebpPlacement;
        private M2tsEsRateInPes _esRateInPes;
        private double? _fragmentTime;
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
        private int? _scte35Pid;
        private M2tsScte35Source _scte35Source;
        private M2tsSegmentationMarkers _segmentationMarkers;
        private M2tsSegmentationStyle _segmentationStyle;
        private double? _segmentationTime;
        private int? _timedMetadataPid;
        private int? _transportStreamId;
        private int? _videoPid;

        /// <summary>
        /// Gets and sets the property AudioBufferModel.
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
        /// in ranges and/or by comma separation.
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
        /// Gets and sets the property Bitrate. The output bitrate of the transport stream in
        /// bits per second. Setting to 0 lets the muxer automatically determine the appropriate
        /// bitrate. Other common values are 3750000, 7500000, and 15000000.
        /// </summary>
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
        /// Gets and sets the property BufferModel.
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
        /// Gets and sets the property DvbNitSettings.
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
        /// Gets and sets the property DvbSdtSettings.
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
        /// ranges and/or by comma separation.
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
        /// Gets and sets the property DvbTdtSettings.
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
        /// DVB Teletext data to this output.
        /// </summary>
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
        /// Gets and sets the property EbpAudioInterval.
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
        /// Gets and sets the property EbpPlacement.
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
        /// Gets and sets the property EsRateInPes.
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
        /// Gets and sets the property MaxPcrInterval. Maximum time in milliseconds between Program
        /// Clock References (PCRs) inserted into the transport stream.
        /// </summary>
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
        /// Gets and sets the property NielsenId3.
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
        /// Gets and sets the property PcrControl.
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
        /// Gets and sets the property PcrPid. Packet Identifier (PID) of the Program Clock Reference
        /// (PCR) in the transport stream. When no value is given, the encoder will assign the
        /// same value as the Video PID.
        /// </summary>
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
        /// Gets and sets the property PmtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
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
        /// (PMT) in the transport stream.
        /// </summary>
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
        /// Gets and sets the property PrivateMetadataPid. Packet Identifier (PID) of the private
        /// metadata stream in the transport stream.
        /// </summary>
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
        /// Gets and sets the property ProgramNumber. The value of the program number field in
        /// the Program Map Table.
        /// </summary>
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
        /// Gets and sets the property RateMode.
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
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream.
        /// </summary>
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
        /// Gets and sets the property Scte35Source.
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
        /// Gets and sets the property SegmentationMarkers.
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
        /// Gets and sets the property SegmentationStyle.
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
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the timed
        /// metadata stream in the transport stream.
        /// </summary>
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
        /// Gets and sets the property TransportStreamId. The value of the transport stream ID
        /// field in the Program Map Table.
        /// </summary>
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
        /// stream in the transport stream.
        /// </summary>
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