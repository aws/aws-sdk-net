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
    /// Multiplex M2ts Settings
    /// </summary>
    public partial class MultiplexM2tsSettings
    {
        private M2tsAbsentInputAudioBehavior _absentInputAudioBehavior;
        private M2tsArib _arib;
        private M2tsAudioBufferModel _audioBufferModel;
        private int? _audioFramesPerPes;
        private M2tsAudioStreamType _audioStreamType;
        private M2tsCcDescriptor _ccDescriptor;
        private M2tsEbifControl _ebif;
        private M2tsEsRateInPes _esRateInPes;
        private M2tsKlv _klv;
        private M2tsNielsenId3Behavior _nielsenId3Behavior;
        private M2tsPcrControl _pcrControl;
        private int? _pcrPeriod;
        private M2tsScte35Control _scte35Control;
        private double? _scte35PrerollPullupMilliseconds;

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
        public int? AudioFramesPerPes
        {
            get { return this._audioFramesPerPes; }
            set { this._audioFramesPerPes = value; }
        }

        // Check to see if AudioFramesPerPes property is set
        internal bool IsSetAudioFramesPerPes()
        {
            return this._audioFramesPerPes.HasValue; 
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
        public int? PcrPeriod
        {
            get { return this._pcrPeriod; }
            set { this._pcrPeriod = value; }
        }

        // Check to see if PcrPeriod property is set
        internal bool IsSetPcrPeriod()
        {
            return this._pcrPeriod.HasValue; 
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
        /// Gets and sets the property Scte35PrerollPullupMilliseconds. Defines the amount SCTE-35
        /// preroll will be increased (in milliseconds) on the output. Preroll is the amount of
        /// time between the presence of a SCTE-35 indication in a transport stream and the PTS
        /// of the video frame it references. Zero means don't add pullup (it doesn't mean set
        /// the preroll to zero). Negative pullup is not supported, which means that you can't
        /// make the preroll shorter. Be aware that latency in the output will increase by the
        /// pullup amount.
        /// </summary>
        public double? Scte35PrerollPullupMilliseconds
        {
            get { return this._scte35PrerollPullupMilliseconds; }
            set { this._scte35PrerollPullupMilliseconds = value; }
        }

        // Check to see if Scte35PrerollPullupMilliseconds property is set
        internal bool IsSetScte35PrerollPullupMilliseconds()
        {
            return this._scte35PrerollPullupMilliseconds.HasValue; 
        }

    }
}