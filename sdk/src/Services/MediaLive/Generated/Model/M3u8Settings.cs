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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings information for the .m3u8 container
    /// </summary>
    public partial class M3u8Settings
    {
        private int? _audioFramesPerPes;
        private string _audioPids;
        private string _ecmPid;
        private int? _patInterval;
        private M3u8PcrControl _pcrControl;
        private int? _pcrPeriod;
        private string _pcrPid;
        private int? _pmtInterval;
        private string _pmtPid;
        private int? _programNum;
        private M3u8Scte35Behavior _scte35Behavior;
        private string _scte35Pid;
        private M3u8TimedMetadataBehavior _timedMetadataBehavior;
        private string _timedMetadataPid;
        private int? _transportStreamId;
        private string _videoPid;

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
        /// in ranges and/or by comma separation. Can be entered as decimal or hexadecimal values.
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
        /// Gets and sets the property EcmPid. This parameter is unused and deprecated.
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
        /// Gets and sets the property PatInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. A value of \"0\" writes out the PMT
        /// once per segment file.
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
        /// Gets and sets the property PcrControl. When set to pcrEveryPesPacket, a Program Clock
        /// Reference value is inserted for every Packetized Elementary Stream (PES) header. This
        /// parameter is effective only when the PCR PID is the same as the video or audio elementary
        /// stream.
        /// </summary>
        public M3u8PcrControl PcrControl
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
        /// Clock References (PCRs) inserted into the transport stream.
        /// </summary>
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
        /// same value as the Video PID. Can be entered as a decimal or hexadecimal value.
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
        /// of this table in the output transport stream. A value of \"0\" writes out the PMT
        /// once per segment file.
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
        /// (PMT) in the transport stream. Can be entered as a decimal or hexadecimal value.
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
        /// Gets and sets the property Scte35Behavior. If set to passthrough, passes any SCTE-35
        /// signals from the input source to this output.
        /// </summary>
        public M3u8Scte35Behavior Scte35Behavior
        {
            get { return this._scte35Behavior; }
            set { this._scte35Behavior = value; }
        }

        // Check to see if Scte35Behavior property is set
        internal bool IsSetScte35Behavior()
        {
            return this._scte35Behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream. Can be entered as a decimal or hexadecimal value.
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
        /// Gets and sets the property TimedMetadataBehavior. When set to passthrough, timed metadata
        /// is passed through from input to output.
        /// </summary>
        public M3u8TimedMetadataBehavior TimedMetadataBehavior
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