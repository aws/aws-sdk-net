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
        private Eac3AtmosDownmixControl _downmixControl;
        private Eac3AtmosDynamicRangeCompressionLine _dynamicRangeCompressionLine;
        private Eac3AtmosDynamicRangeCompressionRf _dynamicRangeCompressionRf;
        private Eac3AtmosDynamicRangeControl _dynamicRangeControl;
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
        /// Gets and sets the property Bitrate. Specify the average bitrate for this output in
        /// bits per second. Valid values: 384k, 448k, 576k, 640k, 768k, 1024k Default value:
        /// 448k Note that MediaConvert supports 384k only with channel-based immersive (CBI)
        /// 7.1.4 and 5.1.4 inputs. For CBI 9.1.6 and other input types, MediaConvert automatically
        /// increases your output bitrate to 448k.
        /// </summary>
        [AWSProperty(Min=384000, Max=1024000)]
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
        /// (Atmos).
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
        /// Gets and sets the property DownmixControl. Specify whether MediaConvert should use
        /// any downmix metadata from your input file. Keep the default value, Custom (SPECIFIED)
        /// to provide downmix values in your job settings. Choose Follow source (INITIALIZE_FROM_SOURCE)
        /// to use the metadata from your input. Related settings--Use these settings to specify
        /// your downmix values: Left only/Right only surround (LoRoSurroundMixLevel), Left total/Right
        /// total surround (LtRtSurroundMixLevel), Left total/Right total center (LtRtCenterMixLevel),
        /// Left only/Right only center (LoRoCenterMixLevel), and Stereo downmix (StereoDownmix).
        /// When you keep Custom (SPECIFIED) for Downmix control (DownmixControl) and you don't
        /// specify values for the related settings, MediaConvert uses default values for those
        /// settings.
        /// </summary>
        public Eac3AtmosDownmixControl DownmixControl
        {
            get { return this._downmixControl; }
            set { this._downmixControl = value; }
        }

        // Check to see if DownmixControl property is set
        internal bool IsSetDownmixControl()
        {
            return this._downmixControl != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine. Choose the Dolby dynamic range
        /// control (DRC) profile that MediaConvert uses when encoding the metadata in the Dolby
        /// stream for the line operating mode. Default value: Film light (ATMOS_STORAGE_DDP_COMPR_FILM_LIGHT)
        /// Related setting: To have MediaConvert use the value you specify here, keep the default
        /// value, Custom (SPECIFIED) for the setting Dynamic range control (DynamicRangeControl).
        /// Otherwise, MediaConvert ignores Dynamic range compression line (DynamicRangeCompressionLine).
        /// For information about the Dolby DRC operating modes and profiles, see the Dynamic
        /// Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
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
        /// Gets and sets the property DynamicRangeCompressionRf. Choose the Dolby dynamic range
        /// control (DRC) profile that MediaConvert uses when encoding the metadata in the Dolby
        /// stream for the RF operating mode. Default value: Film light (ATMOS_STORAGE_DDP_COMPR_FILM_LIGHT)
        /// Related setting: To have MediaConvert use the value you specify here, keep the default
        /// value, Custom (SPECIFIED) for the setting Dynamic range control (DynamicRangeControl).
        /// Otherwise, MediaConvert ignores Dynamic range compression RF (DynamicRangeCompressionRf).
        /// For information about the Dolby DRC operating modes and profiles, see the Dynamic
        /// Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
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
        /// Gets and sets the property DynamicRangeControl. Specify whether MediaConvert should
        /// use any dynamic range control metadata from your input file. Keep the default value,
        /// Custom (SPECIFIED), to provide dynamic range control values in your job settings.
        /// Choose Follow source (INITIALIZE_FROM_SOURCE) to use the metadata from your input.
        /// Related settings--Use these settings to specify your dynamic range control values:
        /// Dynamic range compression line (DynamicRangeCompressionLine) and Dynamic range compression
        /// RF (DynamicRangeCompressionRf). When you keep the value Custom (SPECIFIED) for Dynamic
        /// range control (DynamicRangeControl) and you don't specify values for the related settings,
        /// MediaConvert uses default values for those settings.
        /// </summary>
        public Eac3AtmosDynamicRangeControl DynamicRangeControl
        {
            get { return this._dynamicRangeControl; }
            set { this._dynamicRangeControl = value; }
        }

        // Check to see if DynamicRangeControl property is set
        internal bool IsSetDynamicRangeControl()
        {
            return this._dynamicRangeControl != null;
        }

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// Atmos setting: Left only/Right only center mix (Lo/Ro center). MediaConvert uses this
        /// value for downmixing. Default value: -3 dB (ATMOS_STORAGE_DDP_MIXLEV_MINUS_3_DB).
        /// Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, and -6.0. Related setting: How the
        /// service uses this value depends on the value that you choose for Stereo downmix (Eac3AtmosStereoDownmix).
        /// Related setting: To have MediaConvert use this value, keep the default value, Custom
        /// (SPECIFIED) for the setting Downmix control (DownmixControl). Otherwise, MediaConvert
        /// ignores Left only/Right only center (LoRoCenterMixLevel).
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
        /// value for downmixing. Default value: -3 dB (ATMOS_STORAGE_DDP_MIXLEV_MINUS_3_DB).
        /// Valid values: -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes the channel. Related
        /// setting: How the service uses this value depends on the value that you choose for
        /// Stereo downmix (Eac3AtmosStereoDownmix). Related setting: To have MediaConvert use
        /// this value, keep the default value, Custom (SPECIFIED) for the setting Downmix control
        /// (DownmixControl). Otherwise, MediaConvert ignores Left only/Right only surround (LoRoSurroundMixLevel).
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
        /// this value for downmixing. Default value: -3 dB (ATMOS_STORAGE_DDP_MIXLEV_MINUS_3_DB)
        /// Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, and -6.0. Related setting: How the
        /// service uses this value depends on the value that you choose for Stereo downmix (Eac3AtmosStereoDownmix).
        /// Related setting: To have MediaConvert use this value, keep the default value, Custom
        /// (SPECIFIED) for the setting Downmix control (DownmixControl). Otherwise, MediaConvert
        /// ignores Left total/Right total center (LtRtCenterMixLevel).
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
        /// uses this value for downmixing. Default value: -3 dB (ATMOS_STORAGE_DDP_MIXLEV_MINUS_3_DB)
        /// Valid values: -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes the channel. Related
        /// setting: How the service uses this value depends on the value that you choose for
        /// Stereo downmix (Eac3AtmosStereoDownmix). Related setting: To have MediaConvert use
        /// this value, keep the default value, Custom (SPECIFIED) for the setting Downmix control
        /// (DownmixControl). Otherwise, the service ignores Left total/Right total surround (LtRtSurroundMixLevel).
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
        /// Gets and sets the property SpeechThreshold. Specify the percentage of audio content,
        /// from 0% to 100%, that must be speech in order for the encoder to use the measured
        /// speech loudness as the overall program loudness. Default value: 15%
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Default value: Not indicated (ATMOS_STORAGE_DDP_DMIXMOD_NOT_INDICATED) Related setting:
        /// To have MediaConvert use this value, keep the default value, Custom (SPECIFIED) for
        /// the setting Downmix control (DownmixControl). Otherwise, MediaConvert ignores Stereo
        /// downmix (StereoDownmix).
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