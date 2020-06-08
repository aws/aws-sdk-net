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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Codec) under (AudioDescriptions)>(CodecSettings) to the value
    /// EAC3_ATMOS.
    /// </summary>
    public partial class Eac3AtmosSettings
    {
        private int? _bitrate;
        private Eac3AtmosBitstreamMode _bitstreamMode;
        private Eac3AtmosCodingMode _codingMode;
        private Eac3AtmosDialogueIntelligence _dialogueIntelligence;
        private Eac3AtmosDynamicRangeCompressionLine _dynamicRangeCompressionLine;
        private Eac3AtmosDynamicRangeCompressionRf _dynamicRangeCompressionRf;
        private double? _loRoCenterMixLevel;
        private double? _loRoSurroundMixLevel;
        private double? _ltRtCenterMixLevel;
        private double? _ltRtSurroundMixLevel;
        private Eac3AtmosMeteringMode _meteringMode;
        private int? _sampleRate;
        private int? _speechThreshold;
        private Eac3AtmosStereoDownmix _stereoDownmix;
        private Eac3AtmosSurroundExMode _surroundExMode;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.Valid
        /// values: 384k, 448k, 640k, 768k
        /// </summary>
        [AWSProperty(Min=384000, Max=768000)]
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
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the E-AC-3
        /// stream that the encoder emits. For more information about the EAC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
        /// </summary>
        public Eac3AtmosBitstreamMode BitstreamMode
        {
            get { return this._bitstreamMode; }
            set { this._bitstreamMode = value; }
        }

        // Check to see if BitstreamMode property is set
        internal bool IsSetBitstreamMode()
        {
            return this._bitstreamMode != null;
        }

        /// <summary>
        /// Gets and sets the property CodingMode. The coding mode for Dolby Digital Plus JOC
        /// (Atmos) is always 9.1.6 (CODING_MODE_9_1_6).
        /// </summary>
        public Eac3AtmosCodingMode CodingMode
        {
            get { return this._codingMode; }
            set { this._codingMode = value; }
        }

        // Check to see if CodingMode property is set
        internal bool IsSetCodingMode()
        {
            return this._codingMode != null;
        }

        /// <summary>
        /// Gets and sets the property DialogueIntelligence. Enable Dolby Dialogue Intelligence
        /// to adjust loudness based on dialogue analysis.
        /// </summary>
        public Eac3AtmosDialogueIntelligence DialogueIntelligence
        {
            get { return this._dialogueIntelligence; }
            set { this._dialogueIntelligence = value; }
        }

        // Check to see if DialogueIntelligence property is set
        internal bool IsSetDialogueIntelligence()
        {
            return this._dialogueIntelligence != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine. Specify the absolute peak
        /// level for a signal with dynamic range compression.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionLine DynamicRangeCompressionLine
        {
            get { return this._dynamicRangeCompressionLine; }
            set { this._dynamicRangeCompressionLine = value; }
        }

        // Check to see if DynamicRangeCompressionLine property is set
        internal bool IsSetDynamicRangeCompressionLine()
        {
            return this._dynamicRangeCompressionLine != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf. Specify how the service limits
        /// the audio dynamic range when compressing the audio.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionRf DynamicRangeCompressionRf
        {
            get { return this._dynamicRangeCompressionRf; }
            set { this._dynamicRangeCompressionRf = value; }
        }

        // Check to see if DynamicRangeCompressionRf property is set
        internal bool IsSetDynamicRangeCompressionRf()
        {
            return this._dynamicRangeCompressionRf != null;
        }

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// Atmos setting: Left only/Right only center mix(Lo/Ro center). MediaConvert uses this
        /// value for downmixing. How the service uses thisvalue depends on the value that you
        /// choose for Stereo downmix (Eac3AtmosStereoDownmix).Valid values: 3.0, 1.5, 0.0, -1.5,
        /// -3.0, -4.5, and -6.0.
        /// </summary>
        public double LoRoCenterMixLevel
        {
            get { return this._loRoCenterMixLevel.GetValueOrDefault(); }
            set { this._loRoCenterMixLevel = value; }
        }

        // Check to see if LoRoCenterMixLevel property is set
        internal bool IsSetLoRoCenterMixLevel()
        {
            return this._loRoCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby Atmos setting: Left only/Right only (Lo/Ro surround). MediaConvert uses this
        /// value for downmixing. How the service uses this value depends on the value that you
        /// choose for Stereo downmix (Eac3AtmosStereoDownmix). Valid values: -1.5, -3.0, -4.5,
        /// -6.0, and -60. The value -60 mutes the channel.
        /// </summary>
        public double LoRoSurroundMixLevel
        {
            get { return this._loRoSurroundMixLevel.GetValueOrDefault(); }
            set { this._loRoSurroundMixLevel = value; }
        }

        // Check to see if LoRoSurroundMixLevel property is set
        internal bool IsSetLoRoSurroundMixLevel()
        {
            return this._loRoSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// Atmos setting: Left total/Right total center mix (Lt/Rt center). MediaConvert uses
        /// this value for downmixing. How the service uses this value depends on the value that
        /// you choose for Stereo downmix (Eac3AtmosStereoDownmix). Valid values: 3.0, 1.5, 0.0,
        /// -1.5, -3.0, -4.5, and -6.0.
        /// </summary>
        public double LtRtCenterMixLevel
        {
            get { return this._ltRtCenterMixLevel.GetValueOrDefault(); }
            set { this._ltRtCenterMixLevel = value; }
        }

        // Check to see if LtRtCenterMixLevel property is set
        internal bool IsSetLtRtCenterMixLevel()
        {
            return this._ltRtCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Specify a value for the following
        /// Dolby Atmos setting: Left total/Right total surround mix (Lt/Rt surround). MediaConvert
        /// uses this value for downmixing. How the service uses this value depends on the value
        /// that you choose for Stereo downmix (Eac3AtmosStereoDownmix). Valid values: -1.5, -3.0,
        /// -4.5, -6.0, and -60. The value -60 mutes the channel.
        /// </summary>
        public double LtRtSurroundMixLevel
        {
            get { return this._ltRtSurroundMixLevel.GetValueOrDefault(); }
            set { this._ltRtSurroundMixLevel = value; }
        }

        // Check to see if LtRtSurroundMixLevel property is set
        internal bool IsSetLtRtSurroundMixLevel()
        {
            return this._ltRtSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MeteringMode. Choose how the service meters the loudness
        /// of your audio.
        /// </summary>
        public Eac3AtmosMeteringMode MeteringMode
        {
            get { return this._meteringMode; }
            set { this._meteringMode = value; }
        }

        // Check to see if MeteringMode property is set
        internal bool IsSetMeteringMode()
        {
            return this._meteringMode != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. This value is always 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min=48000, Max=48000)]
        public int SampleRate
        {
            get { return this._sampleRate.GetValueOrDefault(); }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpeechThreshold. Specify the percentage of audio content
        /// that must be speech before the encoder uses the measured speech loudness as the overall
        /// program loudness.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int SpeechThreshold
        {
            get { return this._speechThreshold.GetValueOrDefault(); }
            set { this._speechThreshold = value; }
        }

        // Check to see if SpeechThreshold property is set
        internal bool IsSetSpeechThreshold()
        {
            return this._speechThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StereoDownmix. Choose how the service does stereo downmixing.
        /// </summary>
        public Eac3AtmosStereoDownmix StereoDownmix
        {
            get { return this._stereoDownmix; }
            set { this._stereoDownmix = value; }
        }

        // Check to see if StereoDownmix property is set
        internal bool IsSetStereoDownmix()
        {
            return this._stereoDownmix != null;
        }

        /// <summary>
        /// Gets and sets the property SurroundExMode. Specify whether your input audio has an
        /// additional center rear surround channel matrix encoded into your left and right surround
        /// channels.
        /// </summary>
        public Eac3AtmosSurroundExMode SurroundExMode
        {
            get { return this._surroundExMode; }
            set { this._surroundExMode = value; }
        }

        // Check to see if SurroundExMode property is set
        internal bool IsSetSurroundExMode()
        {
            return this._surroundExMode != null;
        }

    }
}