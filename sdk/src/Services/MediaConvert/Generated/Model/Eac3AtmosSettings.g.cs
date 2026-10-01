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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec to the value EAC3_ATMOS.
    /// </summary>
    public partial class Eac3AtmosSettings
    {
        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate for this output in
        /// bits per second. Valid values: 384k, 448k, 576k, 640k, 768k, 1024k Default value:
        /// 448k Note that MediaConvert supports 384k only with channel-based immersive (CBI)
        /// 7.1.4 and 5.1.4 inputs. For CBI 9.1.6 and other input types, MediaConvert automatically
        /// increases your output bitrate to 448k.
        /// </summary>
        [AWSProperty(Min = 384000, Max = 1024000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the E-AC-3
        /// stream that the encoder emits. For more information about the EAC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
        /// </summary>
        public Eac3AtmosBitstreamMode BitstreamMode { get; set; }

        /// <summary>
        /// Checks to see if the BitstreamMode property is set.
        /// </summary>
        internal bool IsSetBitstreamMode() => this.BitstreamMode != null;

        /// <summary>
        /// Gets and sets the property CodingMode. The coding mode for Dolby Digital Plus JOC
        /// (Atmos).
        /// </summary>
        public Eac3AtmosCodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property DialogueIntelligence. Enable Dolby Dialogue Intelligence
        /// to adjust loudness based on dialogue analysis.
        /// </summary>
        public Eac3AtmosDialogueIntelligence DialogueIntelligence { get; set; }

        /// <summary>
        /// Checks to see if the DialogueIntelligence property is set.
        /// </summary>
        internal bool IsSetDialogueIntelligence() => this.DialogueIntelligence != null;

        /// <summary>
        /// Gets and sets the property DownmixControl. Specify whether MediaConvert should use
        /// any downmix metadata from your input file. Keep the default value, Custom to provide
        /// downmix values in your job settings. Choose Follow source to use the metadata from
        /// your input. Related settings--Use these settings to specify your downmix values: Left
        /// only/Right only surround, Left total/Right total surround, Left total/Right total
        /// center, Left only/Right only center, and Stereo downmix. When you keep Custom for
        /// Downmix control and you don't specify values for the related settings, MediaConvert
        /// uses default values for those settings.
        /// </summary>
        public Eac3AtmosDownmixControl DownmixControl { get; set; }

        /// <summary>
        /// Checks to see if the DownmixControl property is set.
        /// </summary>
        internal bool IsSetDownmixControl() => this.DownmixControl != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine. Choose the Dolby dynamic range
        /// control (DRC) profile that MediaConvert uses when encoding the metadata in the Dolby
        /// stream for the line operating mode. Default value: Film light Related setting: To
        /// have MediaConvert use the value you specify here, keep the default value, Custom for
        /// the setting Dynamic range control. Otherwise, MediaConvert ignores Dynamic range compression
        /// line. For information about the Dolby DRC operating modes and profiles, see the Dynamic
        /// Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionLine DynamicRangeCompressionLine { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionLine property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionLine() => this.DynamicRangeCompressionLine != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf. Choose the Dolby dynamic range
        /// control (DRC) profile that MediaConvert uses when encoding the metadata in the Dolby
        /// stream for the RF operating mode. Default value: Film light Related setting: To have
        /// MediaConvert use the value you specify here, keep the default value, Custom for the
        /// setting Dynamic range control. Otherwise, MediaConvert ignores Dynamic range compression
        /// RF. For information about the Dolby DRC operating modes and profiles, see the Dynamic
        /// Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionRf DynamicRangeCompressionRf { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionRf property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionRf() => this.DynamicRangeCompressionRf != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeControl. Specify whether MediaConvert should
        /// use any dynamic range control metadata from your input file. Keep the default value,
        /// Custom, to provide dynamic range control values in your job settings. Choose Follow
        /// source to use the metadata from your input. Related settings--Use these settings to
        /// specify your dynamic range control values: Dynamic range compression line and Dynamic
        /// range compression RF. When you keep the value Custom for Dynamic range control and
        /// you don't specify values for the related settings, MediaConvert uses default values
        /// for those settings.
        /// </summary>
        public Eac3AtmosDynamicRangeControl DynamicRangeControl { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeControl property is set.
        /// </summary>
        internal bool IsSetDynamicRangeControl() => this.DynamicRangeControl != null;

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// Atmos setting: Left only/Right only center mix (Lo/Ro center). MediaConvert uses this
        /// value for downmixing. Default value: -3 dB. Valid values: 3.0, 1.5, 0.0, -1.5, -3.0,
        /// -4.5, and -6.0. Related setting: How the service uses this value depends on the value
        /// that you choose for Stereo downmix. Related setting: To have MediaConvert use this
        /// value, keep the default value, Custom for the setting Downmix control. Otherwise,
        /// MediaConvert ignores Left only/Right only center.
        /// </summary>
        public double? LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoCenterMixLevel() => this.LoRoCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby Atmos setting: Left only/Right only. MediaConvert uses this value for downmixing.
        /// Default value: -3 dB. Valid values: -1.5, -3.0, -4.5, -6.0, and -60. The value -60
        /// mutes the channel. Related setting: How the service uses this value depends on the
        /// value that you choose for Stereo downmix. Related setting: To have MediaConvert use
        /// this value, keep the default value, Custom for the setting Downmix control. Otherwise,
        /// MediaConvert ignores Left only/Right only surround.
        /// </summary>
        public double? LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoSurroundMixLevel() => this.LoRoSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// Atmos setting: Left total/Right total center mix (Lt/Rt center). MediaConvert uses
        /// this value for downmixing. Default value: -3 dB Valid values: 3.0, 1.5, 0.0, -1.5,
        /// -3.0, -4.5, and -6.0. Related setting: How the service uses this value depends on
        /// the value that you choose for Stereo downmix. Related setting: To have MediaConvert
        /// use this value, keep the default value, Custom for the setting Downmix control. Otherwise,
        /// MediaConvert ignores Left total/Right total center.
        /// </summary>
        public double? LtRtCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtCenterMixLevel() => this.LtRtCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Specify a value for the following
        /// Dolby Atmos setting: Left total/Right total surround mix (Lt/Rt surround). MediaConvert
        /// uses this value for downmixing. Default value: -3 dB Valid values: -1.5, -3.0, -4.5,
        /// -6.0, and -60. The value -60 mutes the channel. Related setting: How the service uses
        /// this value depends on the value that you choose for Stereo downmix. Related setting:
        /// To have MediaConvert use this value, keep the default value, Custom for the setting
        /// Downmix control. Otherwise, the service ignores Left total/Right total surround.
        /// </summary>
        public double? LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtSurroundMixLevel() => this.LtRtSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property MeteringMode. Choose how the service meters the loudness
        /// of your audio.
        /// </summary>
        public Eac3AtmosMeteringMode MeteringMode { get; set; }

        /// <summary>
        /// Checks to see if the MeteringMode property is set.
        /// </summary>
        internal bool IsSetMeteringMode() => this.MeteringMode != null;

        /// <summary>
        /// Gets and sets the property SampleRate. This value is always 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min = 48000, Max = 48000)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

        /// <summary>
        /// Gets and sets the property SpeechThreshold. Specify the percentage of audio content,
        /// from 0% to 100%, that must be speech in order for the encoder to use the measured
        /// speech loudness as the overall program loudness. Default value: 15%
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? SpeechThreshold { get; set; }

        /// <summary>
        /// Checks to see if the SpeechThreshold property is set.
        /// </summary>
        internal bool IsSetSpeechThreshold() => this.SpeechThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property StereoDownmix. Choose how the service does stereo downmixing.
        /// Default value: Not indicated Related setting: To have MediaConvert use this value,
        /// keep the default value, Custom for the setting Downmix control. Otherwise, MediaConvert
        /// ignores Stereo downmix.
        /// </summary>
        public Eac3AtmosStereoDownmix StereoDownmix { get; set; }

        /// <summary>
        /// Checks to see if the StereoDownmix property is set.
        /// </summary>
        internal bool IsSetStereoDownmix() => this.StereoDownmix != null;

        /// <summary>
        /// Gets and sets the property SurroundExMode. Specify whether your input audio has an
        /// additional center rear surround channel matrix encoded into your left and right surround
        /// channels.
        /// </summary>
        public Eac3AtmosSurroundExMode SurroundExMode { get; set; }

        /// <summary>
        /// Checks to see if the SurroundExMode property is set.
        /// </summary>
        internal bool IsSetSurroundExMode() => this.SurroundExMode != null;
    }
}
