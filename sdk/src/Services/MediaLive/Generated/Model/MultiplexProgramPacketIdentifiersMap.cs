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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Packet identifiers map for a given Multiplex program.
    /// </summary>
    public partial class MultiplexProgramPacketIdentifiersMap
    {
        private int? _aribCaptionsPid;
        private List<int> _audioPids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _dvbSubPids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _dvbTeletextPid;
        private List<int> _dvbTeletextPids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _ecmPid;
        private int? _etvPlatformPid;
        private int? _etvSignalPid;
        private List<int> _klvDataPids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _pcrPid;
        private int? _pmtPid;
        private int? _privateMetadataPid;
        private List<int> _scte27Pids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _scte35Pid;
        private int? _smpte2038Pid;
        private int? _timedMetadataPid;
        private int? _videoPid;

        /// <summary>
        /// Gets and sets the property AribCaptionsPid.
        /// </summary>
        public int? AribCaptionsPid
        {
            get { return this._aribCaptionsPid; }
            set { this._aribCaptionsPid = value; }
        }

        // Check to see if AribCaptionsPid property is set
        internal bool IsSetAribCaptionsPid()
        {
            return this._aribCaptionsPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> AudioPids
        {
            get { return this._audioPids; }
            set { this._audioPids = value; }
        }

        // Check to see if AudioPids property is set
        internal bool IsSetAudioPids()
        {
            return this._audioPids != null && (this._audioPids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DvbSubPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DvbSubPids
        {
            get { return this._dvbSubPids; }
            set { this._dvbSubPids = value; }
        }

        // Check to see if DvbSubPids property is set
        internal bool IsSetDvbSubPids()
        {
            return this._dvbSubPids != null && (this._dvbSubPids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DvbTeletextPid.
        /// </summary>
        public int? DvbTeletextPid
        {
            get { return this._dvbTeletextPid; }
            set { this._dvbTeletextPid = value; }
        }

        // Check to see if DvbTeletextPid property is set
        internal bool IsSetDvbTeletextPid()
        {
            return this._dvbTeletextPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DvbTeletextPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DvbTeletextPids
        {
            get { return this._dvbTeletextPids; }
            set { this._dvbTeletextPids = value; }
        }

        // Check to see if DvbTeletextPids property is set
        internal bool IsSetDvbTeletextPids()
        {
            return this._dvbTeletextPids != null && (this._dvbTeletextPids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EcmPid.
        /// </summary>
        public int? EcmPid
        {
            get { return this._ecmPid; }
            set { this._ecmPid = value; }
        }

        // Check to see if EcmPid property is set
        internal bool IsSetEcmPid()
        {
            return this._ecmPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EtvPlatformPid.
        /// </summary>
        public int? EtvPlatformPid
        {
            get { return this._etvPlatformPid; }
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
        public int? EtvSignalPid
        {
            get { return this._etvSignalPid; }
            set { this._etvSignalPid = value; }
        }

        // Check to see if EtvSignalPid property is set
        internal bool IsSetEtvSignalPid()
        {
            return this._etvSignalPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KlvDataPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> KlvDataPids
        {
            get { return this._klvDataPids; }
            set { this._klvDataPids = value; }
        }

        // Check to see if KlvDataPids property is set
        internal bool IsSetKlvDataPids()
        {
            return this._klvDataPids != null && (this._klvDataPids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PcrPid.
        /// </summary>
        public int? PcrPid
        {
            get { return this._pcrPid; }
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
        public int? PmtPid
        {
            get { return this._pmtPid; }
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
        public int? PrivateMetadataPid
        {
            get { return this._privateMetadataPid; }
            set { this._privateMetadataPid = value; }
        }

        // Check to see if PrivateMetadataPid property is set
        internal bool IsSetPrivateMetadataPid()
        {
            return this._privateMetadataPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scte27Pids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Scte27Pids
        {
            get { return this._scte27Pids; }
            set { this._scte27Pids = value; }
        }

        // Check to see if Scte27Pids property is set
        internal bool IsSetScte27Pids()
        {
            return this._scte27Pids != null && (this._scte27Pids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scte35Pid.
        /// </summary>
        public int? Scte35Pid
        {
            get { return this._scte35Pid; }
            set { this._scte35Pid = value; }
        }

        // Check to see if Scte35Pid property is set
        internal bool IsSetScte35Pid()
        {
            return this._scte35Pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Smpte2038Pid.
        /// </summary>
        public int? Smpte2038Pid
        {
            get { return this._smpte2038Pid; }
            set { this._smpte2038Pid = value; }
        }

        // Check to see if Smpte2038Pid property is set
        internal bool IsSetSmpte2038Pid()
        {
            return this._smpte2038Pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataPid.
        /// </summary>
        public int? TimedMetadataPid
        {
            get { return this._timedMetadataPid; }
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
        public int? VideoPid
        {
            get { return this._videoPid; }
            set { this._videoPid = value; }
        }

        // Check to see if VideoPid property is set
        internal bool IsSetVideoPid()
        {
            return this._videoPid.HasValue; 
        }

    }
}