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
    /// Settings for TS segments in HLS
    /// </summary>
    public partial class M3u8Settings
    {
        private int? _audioFramesPerPes;
        private List<int> _audioPids = new List<int>();
        private M3u8NielsenId3 _nielsenId3;
        private int? _patInterval;
        private M3u8PcrControl _pcrControl;
        private int? _pcrPid;
        private int? _pmtInterval;
        private int? _pmtPid;
        private int? _privateMetadataPid;
        private int? _programNumber;
        private int? _scte35Pid;
        private M3u8Scte35Source _scte35Source;
        private TimedMetadata _timedMetadata;
        private int? _timedMetadataPid;
        private int? _transportStreamId;
        private int? _videoPid;

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
        /// Gets and sets the property NielsenId3.
        /// </summary>
        public M3u8NielsenId3 NielsenId3
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
        public M3u8Scte35Source Scte35Source
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
        /// Gets and sets the property TimedMetadata.
        /// </summary>
        public TimedMetadata TimedMetadata
        {
            get { return this._timedMetadata; }
            set { this._timedMetadata = value; }
        }

        // Check to see if TimedMetadata property is set
        internal bool IsSetTimedMetadata()
        {
            return this._timedMetadata != null;
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