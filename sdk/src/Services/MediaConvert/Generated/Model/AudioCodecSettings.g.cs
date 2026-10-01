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
    /// Settings related to audio encoding. The settings in this group vary depending on the
    /// value that you choose for your audio codec.
    /// </summary>
    public partial class AudioCodecSettings
    {
        /// <summary>
        /// Gets and sets the property AacSettings. Required when you set Codec to the value AAC.
        /// The service accepts one of two mutually exclusive groups of AAC settings--VBR and
        /// CBR. To select one of these modes, set the value of Bitrate control mode to "VBR"
        /// or "CBR". In VBR mode, you control the audio quality with the setting VBR quality.
        /// In CBR mode, you use the setting Bitrate. Defaults and valid values depend on the
        /// rate control mode.
        /// </summary>
        public AacSettings AacSettings { get; set; }

        /// <summary>
        /// Checks to see if the AacSettings property is set.
        /// </summary>
        internal bool IsSetAacSettings() => this.AacSettings != null;

        /// <summary>
        /// Gets and sets the property Ac3Settings. Required when you set Codec to the value AC3.
        /// </summary>
        public Ac3Settings Ac3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Ac3Settings property is set.
        /// </summary>
        internal bool IsSetAc3Settings() => this.Ac3Settings != null;

        /// <summary>
        /// Gets and sets the property Ac4Settings. Required when you set Codec to the value AC4.
        /// </summary>
        public Ac4Settings Ac4Settings { get; set; }

        /// <summary>
        /// Checks to see if the Ac4Settings property is set.
        /// </summary>
        internal bool IsSetAc4Settings() => this.Ac4Settings != null;

        /// <summary>
        /// Gets and sets the property AiffSettings. Required when you set Codec to the value
        /// AIFF.
        /// </summary>
        public AiffSettings AiffSettings { get; set; }

        /// <summary>
        /// Checks to see if the AiffSettings property is set.
        /// </summary>
        internal bool IsSetAiffSettings() => this.AiffSettings != null;

        /// <summary>
        /// Gets and sets the property Codec. Choose the audio codec for this output. Note that
        /// the option passthrough applies only to Dolby Digital, Dolby Digital Plus, AAC LC,
        /// AAC HEV1, and AAC HEV2 audio inputs. Make sure that you choose a codec that's supported
        /// with your output container: https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers.html#reference-codecs-containers-output-audio
        /// For audio-only outputs, make sure that both your input audio codec and your output
        /// audio codec are supported for audio-only workflows. For more information, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers-input.html#reference-codecs-containers-input-audio-only
        /// and https://docs.aws.amazon.com/mediaconvert/latest/ug/reference-codecs-containers.html#audio-only-output
        /// </summary>
        public AudioCodec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property Eac3AtmosSettings. Required when you set Codec to the value
        /// EAC3_ATMOS.
        /// </summary>
        public Eac3AtmosSettings Eac3AtmosSettings { get; set; }

        /// <summary>
        /// Checks to see if the Eac3AtmosSettings property is set.
        /// </summary>
        internal bool IsSetEac3AtmosSettings() => this.Eac3AtmosSettings != null;

        /// <summary>
        /// Gets and sets the property Eac3Settings. Required when you set Codec to the value
        /// EAC3.
        /// </summary>
        public Eac3Settings Eac3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Eac3Settings property is set.
        /// </summary>
        internal bool IsSetEac3Settings() => this.Eac3Settings != null;

        /// <summary>
        /// Gets and sets the property FlacSettings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value FLAC.
        /// </summary>
        public FlacSettings FlacSettings { get; set; }

        /// <summary>
        /// Checks to see if the FlacSettings property is set.
        /// </summary>
        internal bool IsSetFlacSettings() => this.FlacSettings != null;

        /// <summary>
        /// Gets and sets the property Mp2Settings. Required when you set Codec to the value MP2.
        /// </summary>
        public Mp2Settings Mp2Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mp2Settings property is set.
        /// </summary>
        internal bool IsSetMp2Settings() => this.Mp2Settings != null;

        /// <summary>
        /// Gets and sets the property Mp3Settings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value MP3.
        /// </summary>
        public Mp3Settings Mp3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mp3Settings property is set.
        /// </summary>
        internal bool IsSetMp3Settings() => this.Mp3Settings != null;

        /// <summary>
        /// Gets and sets the property OpusSettings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value OPUS.
        /// </summary>
        public OpusSettings OpusSettings { get; set; }

        /// <summary>
        /// Checks to see if the OpusSettings property is set.
        /// </summary>
        internal bool IsSetOpusSettings() => this.OpusSettings != null;

        /// <summary>
        /// Gets and sets the property VorbisSettings. Required when you set Codec, under AudioDescriptions>CodecSettings,
        /// to the value Vorbis.
        /// </summary>
        public VorbisSettings VorbisSettings { get; set; }

        /// <summary>
        /// Checks to see if the VorbisSettings property is set.
        /// </summary>
        internal bool IsSetVorbisSettings() => this.VorbisSettings != null;

        /// <summary>
        /// Gets and sets the property WavSettings. Required when you set Codec to the value WAV.
        /// </summary>
        public WavSettings WavSettings { get; set; }

        /// <summary>
        /// Checks to see if the WavSettings property is set.
        /// </summary>
        internal bool IsSetWavSettings() => this.WavSettings != null;
    }
}
