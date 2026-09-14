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
    /// Settings related to one audio tab on the MediaConvert console. In your job JSON, an
    /// instance of AudioDescription is equivalent to one audio tab in the console. Usually,
    /// one audio tab corresponds to one output audio track. Depending on how you set up your
    /// input audio selectors and whether you use audio selector groups, one audio tab can
    /// correspond to a group of output audio tracks.
    /// </summary>
    public partial class AudioDescription
    {
        /// <summary>
        /// Gets and sets the property AudioChannelTaggingSettings. Specify the QuickTime audio
        /// channel layout tags for the audio channels in this audio track. When you don't specify
        /// a value, MediaConvert labels your track as Center (C) by default. To use Audio layout
        /// tagging, your output must be in a QuickTime (MOV) container and your audio codec must
        /// be AAC, WAV, or AIFF.
        /// </summary>
        public AudioChannelTaggingSettings AudioChannelTaggingSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioChannelTaggingSettings property is set.
        /// </summary>
        internal bool IsSetAudioChannelTaggingSettings() => this.AudioChannelTaggingSettings != null;

        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings. Advanced audio normalization
        /// settings. Ignore these settings unless you need to comply with a loudness standard.
        /// </summary>
        public AudioNormalizationSettings AudioNormalizationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioNormalizationSettings property is set.
        /// </summary>
        internal bool IsSetAudioNormalizationSettings() => this.AudioNormalizationSettings != null;

        /// <summary>
        /// Gets and sets the property AudioPitchCorrectionSettings. Settings for audio pitch
        /// correction during framerate conversion.
        /// </summary>
        public AudioPitchCorrectionSettings AudioPitchCorrectionSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioPitchCorrectionSettings property is set.
        /// </summary>
        internal bool IsSetAudioPitchCorrectionSettings() => this.AudioPitchCorrectionSettings != null;

        /// <summary>
        /// Gets and sets the property AudioSourceName. Specifies which audio data to use from
        /// each input. In the simplest case, specify an "Audio Selector":#inputs-audio_selector
        /// by name based on its order within each input. For example if you specify "Audio Selector
        /// 3", then the third audio selector will be used from each input. If an input does not
        /// have an "Audio Selector 3", then the audio selector marked as "default" in that input
        /// will be used. If there is no audio selector marked as "default", silence will be inserted
        /// for the duration of that input. Alternatively, an "Audio Selector Group":#inputs-audio_selector_group
        /// name may be specified, with similar default/silence behavior. If no audio_source_name
        /// is specified, then "Audio Selector 1" will be chosen automatically.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AudioSourceName { get; set; }

        /// <summary>
        /// Checks to see if the AudioSourceName property is set.
        /// </summary>
        internal bool IsSetAudioSourceName() => this.AudioSourceName != null;

        /// <summary>
        /// Gets and sets the property AudioType. Applies only if Follow Input Audio Type is unchecked
        /// (false). A number between 0 and 255. The following are defined in ISO-IEC 13818-1:
        /// 0 = Undefined, 1 = Clean Effects, 2 = Hearing Impaired, 3 = Visually Impaired Commentary,
        /// 4-255 = Reserved.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? AudioType { get; set; }

        /// <summary>
        /// Checks to see if the AudioType property is set.
        /// </summary>
        internal bool IsSetAudioType() => this.AudioType.HasValue;

        /// <summary>
        /// Gets and sets the property AudioTypeControl. When set to FOLLOW_INPUT, if the input
        /// contains an ISO 639 audio_type, then that value is passed through to the output. If
        /// the input contains no ISO 639 audio_type, the value in Audio Type is included in the
        /// output. Otherwise the value in Audio Type is included in the output. Note that this
        /// field and audioType are both ignored if audioDescriptionBroadcasterMix is set to BROADCASTER_MIXED_AD.
        /// </summary>
        public AudioTypeControl AudioTypeControl { get; set; }

        /// <summary>
        /// Checks to see if the AudioTypeControl property is set.
        /// </summary>
        internal bool IsSetAudioTypeControl() => this.AudioTypeControl != null;

        /// <summary>
        /// Gets and sets the property CodecSettings. Settings related to audio encoding. The
        /// settings in this group vary depending on the value that you choose for your audio
        /// codec.
        /// </summary>
        public AudioCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodecSettings property is set.
        /// </summary>
        internal bool IsSetCodecSettings() => this.CodecSettings != null;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Specify the language for this audio
        /// output track. The service puts this language code into your output audio track when
        /// you set Language code control to Use configured. The service also uses your specified
        /// custom language code when you set Language code control to Follow input, but your
        /// input file doesn't specify a language code. For all outputs, you can use an ISO 639-2
        /// or ISO 639-3 code. For streaming outputs, you can also use any other code in the full
        /// RFC-5646 specification. Streaming outputs are those that are in one of the following
        /// output groups: CMAF, DASH ISO, Apple HLS, or Microsoft Smooth Streaming.
        /// </summary>
        public string CustomLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the CustomLanguageCode property is set.
        /// </summary>
        internal bool IsSetCustomLanguageCode() => this.CustomLanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language for your output audio
        /// track. To follow the input language: Leave blank. When you do, also set Language code
        /// control to Follow input. If no input language is detected MediaConvert will not write
        /// an output language code. To follow the input langauge, but fall back to a specified
        /// language code if there is no input language to follow: Enter an ISO 639-2 three-letter
        /// language code in all capital letters. When you do, also set Language code control
        /// to Follow input. To specify the language code: Enter an ISO 639 three-letter language
        /// code in all capital letters. When you do, also set Language code control to Use configured.
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCodeControl. Specify which source for language
        /// code takes precedence for this audio track. When you choose Follow input, the service
        /// uses the language code from the input track if it's present. If there's no languge
        /// code on the input track, the service uses the code that you specify in the setting
        /// Language code. When you choose Use configured, the service uses the language code
        /// that you specify.
        /// </summary>
        public AudioLanguageCodeControl LanguageCodeControl { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCodeControl property is set.
        /// </summary>
        internal bool IsSetLanguageCodeControl() => this.LanguageCodeControl != null;

        /// <summary>
        /// Gets and sets the property RemixSettings. Advanced audio remixing settings.
        /// </summary>
        public RemixSettings RemixSettings { get; set; }

        /// <summary>
        /// Checks to see if the RemixSettings property is set.
        /// </summary>
        internal bool IsSetRemixSettings() => this.RemixSettings != null;

        /// <summary>
        /// Gets and sets the property StreamName. Specify a label for this output audio stream.
        /// For example, "English", "Director commentary", or "track_2". For streaming outputs,
        /// MediaConvert passes this information into destination manifests for display on the
        /// end-viewer's player device. For outputs in other output groups, the service ignores
        /// this setting.
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
