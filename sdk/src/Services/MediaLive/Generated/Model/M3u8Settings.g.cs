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
    /// Settings information for the .m3u8 container
    /// </summary>
    public partial class M3u8Settings
    {
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
        /// </summary>
        public string AudioPids { get; set; }

        /// <summary>
        /// Checks to see if the AudioPids property is set.
        /// </summary>
        internal bool IsSetAudioPids() => this.AudioPids != null;

        /// <summary>
        /// Gets and sets the property EcmPid. This parameter is unused and deprecated.
        /// </summary>
        public string EcmPid { get; set; }

        /// <summary>
        /// Checks to see if the EcmPid property is set.
        /// </summary>
        internal bool IsSetEcmPid() => this.EcmPid != null;

        /// <summary>
        /// Gets and sets the property KlvBehavior. If set to passthrough, passes any KLV data
        /// from the input source to this output.
        /// </summary>
        public M3u8KlvBehavior KlvBehavior { get; set; }

        /// <summary>
        /// Checks to see if the KlvBehavior property is set.
        /// </summary>
        internal bool IsSetKlvBehavior() => this.KlvBehavior != null;

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
        public M3u8NielsenId3Behavior NielsenId3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3Behavior property is set.
        /// </summary>
        internal bool IsSetNielsenId3Behavior() => this.NielsenId3Behavior != null;

        /// <summary>
        /// Gets and sets the property PatInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. A value of \"0\" writes out the PMT
        /// once per segment file.
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
        public M3u8PcrControl PcrControl { get; set; }

        /// <summary>
        /// Checks to see if the PcrControl property is set.
        /// </summary>
        internal bool IsSetPcrControl() => this.PcrControl != null;

        /// <summary>
        /// Gets and sets the property PcrPeriod. Maximum time in milliseconds between Program
        /// Clock References (PCRs) inserted into the transport stream.
        /// </summary>
        public int? PcrPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PcrPeriod property is set.
        /// </summary>
        internal bool IsSetPcrPeriod() => this.PcrPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property PcrPid. Packet Identifier (PID) of the Program Clock Reference
        /// (PCR) in the transport stream. When no value is given, the encoder will assign the
        /// same value as the Video PID. Can be entered as a decimal or hexadecimal value.
        /// </summary>
        public string PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid != null;

        /// <summary>
        /// Gets and sets the property PmtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream. A value of \"0\" writes out the PMT
        /// once per segment file.
        /// </summary>
        public int? PmtInterval { get; set; }

        /// <summary>
        /// Checks to see if the PmtInterval property is set.
        /// </summary>
        internal bool IsSetPmtInterval() => this.PmtInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PmtPid. Packet Identifier (PID) for the Program Map Table
        /// (PMT) in the transport stream. Can be entered as a decimal or hexadecimal value.
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
        /// Gets and sets the property Scte35Behavior. If set to passthrough, passes any SCTE-35
        /// signals from the input source to this output.
        /// </summary>
        public M3u8Scte35Behavior Scte35Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Behavior property is set.
        /// </summary>
        internal bool IsSetScte35Behavior() => this.Scte35Behavior != null;

        /// <summary>
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream. Can be entered as a decimal or hexadecimal value.
        /// </summary>
        public string Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataBehavior. Set to PASSTHROUGH to enable ID3
        /// metadata insertion. To include metadata, you configure other parameters in the output
        /// group or individual outputs, or you add an ID3 action to the channel schedule.
        /// </summary>
        public M3u8TimedMetadataBehavior TimedMetadataBehavior { get; set; }

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
        /// </summary>
        public string VideoPid { get; set; }

        /// <summary>
        /// Checks to see if the VideoPid property is set.
        /// </summary>
        internal bool IsSetVideoPid() => this.VideoPid != null;
    }
}
