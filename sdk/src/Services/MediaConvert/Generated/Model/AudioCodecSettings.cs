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
    /// Settings related to audio encoding. The settings in this group vary depending on the
    /// value that you choose for your audio codec.
    /// </summary>
    public partial class AudioCodecSettings
    {
        private AacSettings _aacSettings;
        private Ac3Settings _ac3Settings;
        private AiffSettings _aiffSettings;
        private AudioCodec _codec;
        private Eac3AtmosSettings _eac3AtmosSettings;
        private Eac3Settings _eac3Settings;
        private Mp2Settings _mp2Settings;
        private Mp3Settings _mp3Settings;
        private OpusSettings _opusSettings;
        private VorbisSettings _vorbisSettings;
        private WavSettings _wavSettings;

        /// <summary>
        /// Gets and sets the property AacSettings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value AAC. The service accepts one of two mutually exclusive groups of AAC
        /// settings--VBR and CBR. To select one of these modes, set the value of Bitrate control
        /// mode (rateControlMode) to "VBR" or "CBR". In VBR mode, you control the audio quality
        /// with the setting VBR quality (vbrQuality). In CBR mode, you use the setting Bitrate
        /// (bitrate). Defaults and valid values depend on the rate control mode.
        /// </summary>
        public AacSettings AacSettings
        {
            get { return this._aacSettings; }
            set { this._aacSettings = value; }
        }

        // Check to see if AacSettings property is set
        internal bool IsSetAacSettings()
        {
            return this._aacSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Ac3Settings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value AC3.
        /// </summary>
        public Ac3Settings Ac3Settings
        {
            get { return this._ac3Settings; }
            set { this._ac3Settings = value; }
        }

        // Check to see if Ac3Settings property is set
        internal bool IsSetAc3Settings()
        {
            return this._ac3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property AiffSettings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value AIFF.
        /// </summary>
        public AiffSettings AiffSettings
        {
            get { return this._aiffSettings; }
            set { this._aiffSettings = value; }
        }

        // Check to see if AiffSettings property is set
        internal bool IsSetAiffSettings()
        {
            return this._aiffSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. Choose the audio codec for this output. Note that
        /// the option Dolby Digital passthrough (PASSTHROUGH) applies only to Dolby Digital and
        /// Dolby Digital Plus audio inputs. Make sure that you choose a codec that's supported
        /// with your output container: https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers.html#reference-codecs-containers-output-audio
        /// For audio-only outputs, make sure that both your input audio codec and your output
        /// audio codec are supported for audio-only workflows. For more information, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers-input.html#reference-codecs-containers-input-audio-only
        /// and https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers.html#audio-only-output
        /// </summary>
        public AudioCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property Eac3AtmosSettings. Required when you set (Codec) under
        /// (AudioDescriptions)>(CodecSettings) to the value EAC3_ATMOS.
        /// </summary>
        public Eac3AtmosSettings Eac3AtmosSettings
        {
            get { return this._eac3AtmosSettings; }
            set { this._eac3AtmosSettings = value; }
        }

        // Check to see if Eac3AtmosSettings property is set
        internal bool IsSetEac3AtmosSettings()
        {
            return this._eac3AtmosSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Eac3Settings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value EAC3.
        /// </summary>
        public Eac3Settings Eac3Settings
        {
            get { return this._eac3Settings; }
            set { this._eac3Settings = value; }
        }

        // Check to see if Eac3Settings property is set
        internal bool IsSetEac3Settings()
        {
            return this._eac3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mp2Settings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value MP2.
        /// </summary>
        public Mp2Settings Mp2Settings
        {
            get { return this._mp2Settings; }
            set { this._mp2Settings = value; }
        }

        // Check to see if Mp2Settings property is set
        internal bool IsSetMp2Settings()
        {
            return this._mp2Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mp3Settings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value MP3.
        /// </summary>
        public Mp3Settings Mp3Settings
        {
            get { return this._mp3Settings; }
            set { this._mp3Settings = value; }
        }

        // Check to see if Mp3Settings property is set
        internal bool IsSetMp3Settings()
        {
            return this._mp3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property OpusSettings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value OPUS.
        /// </summary>
        public OpusSettings OpusSettings
        {
            get { return this._opusSettings; }
            set { this._opusSettings = value; }
        }

        // Check to see if OpusSettings property is set
        internal bool IsSetOpusSettings()
        {
            return this._opusSettings != null;
        }

        /// <summary>
        /// Gets and sets the property VorbisSettings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value Vorbis.
        /// </summary>
        public VorbisSettings VorbisSettings
        {
            get { return this._vorbisSettings; }
            set { this._vorbisSettings = value; }
        }

        // Check to see if VorbisSettings property is set
        internal bool IsSetVorbisSettings()
        {
            return this._vorbisSettings != null;
        }

        /// <summary>
        /// Gets and sets the property WavSettings. Required when you set (Codec) under (AudioDescriptions)>(CodecSettings)
        /// to the value WAV.
        /// </summary>
        public WavSettings WavSettings
        {
            get { return this._wavSettings; }
            set { this._wavSettings = value; }
        }

        // Check to see if WavSettings property is set
        internal bool IsSetWavSettings()
        {
            return this._wavSettings != null;
        }

    }
}