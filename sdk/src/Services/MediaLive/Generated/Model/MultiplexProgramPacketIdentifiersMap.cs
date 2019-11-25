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
    /// Packet identifiers map for a given Multiplex program.
    /// </summary>
    public partial class MultiplexProgramPacketIdentifiersMap
    {
        private List<int> _audioPids = new List<int>();
        private List<int> _dvbSubPids = new List<int>();
        private int? _dvbTeletextPid;
        private int? _etvPlatformPid;
        private int? _etvSignalPid;
        private List<int> _klvDataPids = new List<int>();
        private int? _pcrPid;
        private int? _pmtPid;
        private int? _privateMetadataPid;
        private List<int> _scte27Pids = new List<int>();
        private int? _scte35Pid;
        private int? _timedMetadataPid;
        private int? _videoPid;

        /// <summary>
        /// Gets and sets the property AudioPids.
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
        /// Gets and sets the property DvbSubPids.
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
        /// Gets and sets the property DvbTeletextPid.
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
        /// Gets and sets the property EtvPlatformPid.
        /// </summary>
        public int EtvPlatformPid
        {
            get { return this._etvPlatformPid.GetValueOrDefault(); }
            set { this._etvPlatformPid = value; }
        }

        // Check to see if EtvPlatformPid property is set
        internal bool IsSetEtvPlatformPid()
        {
            return this._etvPlatformPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EtvSignalPid.
        /// </summary>
        public int EtvSignalPid
        {
            get { return this._etvSignalPid.GetValueOrDefault(); }
            set { this._etvSignalPid = value; }
        }

        // Check to see if EtvSignalPid property is set
        internal bool IsSetEtvSignalPid()
        {
            return this._etvSignalPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KlvDataPids.
        /// </summary>
        public List<int> KlvDataPids
        {
            get { return this._klvDataPids; }
            set { this._klvDataPids = value; }
        }

        // Check to see if KlvDataPids property is set
        internal bool IsSetKlvDataPids()
        {
            return this._klvDataPids != null && this._klvDataPids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PcrPid.
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
        /// Gets and sets the property PmtPid.
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
        /// Gets and sets the property PrivateMetadataPid.
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
        /// Gets and sets the property Scte27Pids.
        /// </summary>
        public List<int> Scte27Pids
        {
            get { return this._scte27Pids; }
            set { this._scte27Pids = value; }
        }

        // Check to see if Scte27Pids property is set
        internal bool IsSetScte27Pids()
        {
            return this._scte27Pids != null && this._scte27Pids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scte35Pid.
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
        /// Gets and sets the property TimedMetadataPid.
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
        /// Gets and sets the property VideoPid.
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