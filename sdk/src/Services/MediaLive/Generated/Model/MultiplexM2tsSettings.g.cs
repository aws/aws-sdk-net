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
    /// Multiplex M2ts Settings
    /// </summary>
    public partial class MultiplexM2tsSettings
    {
        /// <summary>
        /// Gets and sets the property AbsentInputAudioBehavior. When set to drop, output audio
        /// streams will be removed from the program if the selected input audio stream is removed
        /// from the input. This allows the output audio configuration to dynamically change based
        /// on input configuration. If this is set to encodeSilence, all output audio streams
        /// will output encoded silence when not connected to an active input stream.
        /// </summary>
        public M2tsAbsentInputAudioBehavior AbsentInputAudioBehavior { get; set; }

        /// <summary>
        /// Checks to see if the AbsentInputAudioBehavior property is set.
        /// </summary>
        internal bool IsSetAbsentInputAudioBehavior() => this.AbsentInputAudioBehavior != null;

        /// <summary>
        /// Gets and sets the property Arib. When set to enabled, uses ARIB-compliant field muxing
        /// and removes video descriptor.
        /// </summary>
        public M2tsArib Arib { get; set; }

        /// <summary>
        /// Checks to see if the Arib property is set.
        /// </summary>
        internal bool IsSetArib() => this.Arib != null;

        /// <summary>
        /// Gets and sets the property AudioBufferModel. When set to dvb, uses DVB buffer model
        /// for Dolby Digital audio. When set to atsc, the ATSC model is used.
        /// </summary>
        public M2tsAudioBufferModel AudioBufferModel { get; set; }

        /// <summary>
        /// Checks to see if the AudioBufferModel property is set.
        /// </summary>
        internal bool IsSetAudioBufferModel() => this.AudioBufferModel != null;

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
        /// Gets and sets the property AudioStreamType. When set to atsc, uses stream type = 0x81
        /// for AC3 and stream type = 0x87 for EAC3. When set to dvb, uses stream type = 0x06.
        /// </summary>
        public M2tsAudioStreamType AudioStreamType { get; set; }

        /// <summary>
        /// Checks to see if the AudioStreamType property is set.
        /// </summary>
        internal bool IsSetAudioStreamType() => this.AudioStreamType != null;

        /// <summary>
        /// Gets and sets the property CcDescriptor. When set to enabled, generates captionServiceDescriptor
        /// in PMT.
        /// </summary>
        public M2tsCcDescriptor CcDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the CcDescriptor property is set.
        /// </summary>
        internal bool IsSetCcDescriptor() => this.CcDescriptor != null;

        /// <summary>
        /// Gets and sets the property Ebif. If set to passthrough, passes any EBIF data from
        /// the input source to this output.
        /// </summary>
        public M2tsEbifControl Ebif { get; set; }

        /// <summary>
        /// Checks to see if the Ebif property is set.
        /// </summary>
        internal bool IsSetEbif() => this.Ebif != null;

        /// <summary>
        /// Gets and sets the property EsRateInPes. Include or exclude the ES Rate field in the
        /// PES header.
        /// </summary>
        public M2tsEsRateInPes EsRateInPes { get; set; }

        /// <summary>
        /// Checks to see if the EsRateInPes property is set.
        /// </summary>
        internal bool IsSetEsRateInPes() => this.EsRateInPes != null;

        /// <summary>
        /// Gets and sets the property Klv. If set to passthrough, passes any KLV data from the
        /// input source to this output.
        /// </summary>
        public M2tsKlv Klv { get; set; }

        /// <summary>
        /// Checks to see if the Klv property is set.
        /// </summary>
        internal bool IsSetKlv() => this.Klv != null;

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public M2tsNielsenId3Behavior NielsenId3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3Behavior property is set.
        /// </summary>
        internal bool IsSetNielsenId3Behavior() => this.NielsenId3Behavior != null;

        /// <summary>
        /// Gets and sets the property PcrControl. When set to pcrEveryPesPacket, a Program Clock
        /// Reference value is inserted for every Packetized Elementary Stream (PES) header. This
        /// parameter is effective only when the PCR PID is the same as the video or audio elementary
        /// stream.
        /// </summary>
        public M2tsPcrControl PcrControl { get; set; }

        /// <summary>
        /// Checks to see if the PcrControl property is set.
        /// </summary>
        internal bool IsSetPcrControl() => this.PcrControl != null;

        /// <summary>
        /// Gets and sets the property PcrPeriod. Maximum time in milliseconds between Program
        /// Clock Reference (PCRs) inserted into the transport stream.
        /// </summary>
        public int? PcrPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PcrPeriod property is set.
        /// </summary>
        internal bool IsSetPcrPeriod() => this.PcrPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Scte35Control. SCTE-35 control. Option "none" indicates
        /// that a SCTE-35 marker will not be inserted, nor will an IDR be inserted at the SCTE-35
        /// cue point, nor will the segment be segmented. Option "scte35WithoutIdr" indicates
        /// that a SCTE-35 marker will be inserted to indicate the cue point, but MediaLive will
        /// not insert an IDR on that frame nor will it introduce a new segment boundary there
        /// if it wasn't already going to be one (this option is required for use with downstream
        /// multiview bitstream stitching workflows). Option "passthrough" indicates that a SCTE-35
        /// marker will be inserted to indicate the cue point, and an IDR will be inserted on
        /// that frame, and MediaLive itself will introduce a new segment boundary there.
        /// </summary>
        public M2tsScte35Control Scte35Control { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Control property is set.
        /// </summary>
        internal bool IsSetScte35Control() => this.Scte35Control != null;

        /// <summary>
        /// Gets and sets the property Scte35PrerollPullupMilliseconds. Defines the amount SCTE-35
        /// preroll will be increased (in milliseconds) on the output. Preroll is the amount of
        /// time between the presence of a SCTE-35 indication in a transport stream and the PTS
        /// of the video frame it references. Zero means don't add pullup (it doesn't mean set
        /// the preroll to zero). Negative pullup is not supported, which means that you can't
        /// make the preroll shorter. Be aware that latency in the output will increase by the
        /// pullup amount.
        /// </summary>
        public double? Scte35PrerollPullupMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the Scte35PrerollPullupMilliseconds property is set.
        /// </summary>
        internal bool IsSetScte35PrerollPullupMilliseconds() => this.Scte35PrerollPullupMilliseconds.HasValue;
    }
}
