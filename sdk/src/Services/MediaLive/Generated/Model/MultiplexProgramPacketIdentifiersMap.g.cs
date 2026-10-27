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
    /// Packet identifiers map for a given Multiplex program.
    /// </summary>
    public partial class MultiplexProgramPacketIdentifiersMap
    {
        /// <summary>
        /// Gets and sets the property AribCaptionsPid.
        /// </summary>
        public int? AribCaptionsPid { get; set; }

        /// <summary>
        /// Checks to see if the AribCaptionsPid property is set.
        /// </summary>
        internal bool IsSetAribCaptionsPid() => this.AribCaptionsPid.HasValue;

        /// <summary>
        /// Gets and sets the property AudioPids.
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
        /// Gets and sets the property DvbSubPids.
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
        /// Gets and sets the property DvbTeletextPid.
        /// </summary>
        public int? DvbTeletextPid { get; set; }

        /// <summary>
        /// Checks to see if the DvbTeletextPid property is set.
        /// </summary>
        internal bool IsSetDvbTeletextPid() => this.DvbTeletextPid.HasValue;

        /// <summary>
        /// Gets and sets the property DvbTeletextPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DvbTeletextPids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the DvbTeletextPids property is set.
        /// </summary>
        internal bool IsSetDvbTeletextPids() => this.DvbTeletextPids != null && (this.DvbTeletextPids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcmPid.
        /// </summary>
        public int? EcmPid { get; set; }

        /// <summary>
        /// Checks to see if the EcmPid property is set.
        /// </summary>
        internal bool IsSetEcmPid() => this.EcmPid.HasValue;

        /// <summary>
        /// Gets and sets the property EtvPlatformPid.
        /// </summary>
        public int? EtvPlatformPid { get; set; }

        /// <summary>
        /// Checks to see if the EtvPlatformPid property is set.
        /// </summary>
        internal bool IsSetEtvPlatformPid() => this.EtvPlatformPid.HasValue;

        /// <summary>
        /// Gets and sets the property EtvSignalPid.
        /// </summary>
        public int? EtvSignalPid { get; set; }

        /// <summary>
        /// Checks to see if the EtvSignalPid property is set.
        /// </summary>
        internal bool IsSetEtvSignalPid() => this.EtvSignalPid.HasValue;

        /// <summary>
        /// Gets and sets the property KlvDataPids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> KlvDataPids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the KlvDataPids property is set.
        /// </summary>
        internal bool IsSetKlvDataPids() => this.KlvDataPids != null && (this.KlvDataPids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PcrPid.
        /// </summary>
        public int? PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid.HasValue;

        /// <summary>
        /// Gets and sets the property PmtPid.
        /// </summary>
        public int? PmtPid { get; set; }

        /// <summary>
        /// Checks to see if the PmtPid property is set.
        /// </summary>
        internal bool IsSetPmtPid() => this.PmtPid.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateMetadataPid.
        /// </summary>
        public int? PrivateMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the PrivateMetadataPid property is set.
        /// </summary>
        internal bool IsSetPrivateMetadataPid() => this.PrivateMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property Scte27Pids.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Scte27Pids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Scte27Pids property is set.
        /// </summary>
        internal bool IsSetScte27Pids() => this.Scte27Pids != null && (this.Scte27Pids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scte35Pid.
        /// </summary>
        public int? Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid.HasValue;

        /// <summary>
        /// Gets and sets the property Smpte2038Pid.
        /// </summary>
        public int? Smpte2038Pid { get; set; }

        /// <summary>
        /// Checks to see if the Smpte2038Pid property is set.
        /// </summary>
        internal bool IsSetSmpte2038Pid() => this.Smpte2038Pid.HasValue;

        /// <summary>
        /// Gets and sets the property TimedMetadataPid.
        /// </summary>
        public int? TimedMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataPid property is set.
        /// </summary>
        internal bool IsSetTimedMetadataPid() => this.TimedMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property VideoPid.
        /// </summary>
        public int? VideoPid { get; set; }

        /// <summary>
        /// Checks to see if the VideoPid property is set.
        /// </summary>
        internal bool IsSetVideoPid() => this.VideoPid.HasValue;
    }
}
