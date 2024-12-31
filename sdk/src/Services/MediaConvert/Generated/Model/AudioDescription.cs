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
        private AudioChannelTaggingSettings _audioChannelTaggingSettings;
        private AudioNormalizationSettings _audioNormalizationSettings;
        private string _audioSourceName;
        private int? _audioType;
        private AudioTypeControl _audioTypeControl;
        private AudioCodecSettings _codecSettings;
        private string _customLanguageCode;
        private LanguageCode _languageCode;
        private AudioLanguageCodeControl _languageCodeControl;
        private RemixSettings _remixSettings;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property AudioChannelTaggingSettings. Specify the QuickTime audio
        /// channel layout tags for the audio channels in this audio track. When you don't specify
        /// a value, MediaConvert labels your track as Center (C) by default. To use Audio layout
        /// tagging, your output must be in a QuickTime (MOV) container and your audio codec must
        /// be AAC, WAV, or AIFF.
        /// </summary>
        public AudioChannelTaggingSettings AudioChannelTaggingSettings
        {
            get { return this._audioChannelTaggingSettings; }
            set { this._audioChannelTaggingSettings = value; }
        }

        // Check to see if AudioChannelTaggingSettings property is set
        internal bool IsSetAudioChannelTaggingSettings()
        {
            return this._audioChannelTaggingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings. Advanced audio normalization
        /// settings. Ignore these settings unless you need to comply with a loudness standard.
        /// </summary>
        public AudioNormalizationSettings AudioNormalizationSettings
        {
            get { return this._audioNormalizationSettings; }
            set { this._audioNormalizationSettings = value; }
        }

        // Check to see if AudioNormalizationSettings property is set
        internal bool IsSetAudioNormalizationSettings()
        {
            return this._audioNormalizationSettings != null;
        }

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
        [AWSProperty(Max=2048)]
        public string AudioSourceName
        {
            get { return this._audioSourceName; }
            set { this._audioSourceName = value; }
        }

        // Check to see if AudioSourceName property is set
        internal bool IsSetAudioSourceName()
        {
            return this._audioSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property AudioType. Applies only if Follow Input Audio Type is unchecked
        /// (false). A number between 0 and 255. The following are defined in ISO-IEC 13818-1:
        /// 0 = Undefined, 1 = Clean Effects, 2 = Hearing Impaired, 3 = Visually Impaired Commentary,
        /// 4-255 = Reserved.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? AudioType
        {
            get { return this._audioType; }
            set { this._audioType = value; }
        }

        // Check to see if AudioType property is set
        internal bool IsSetAudioType()
        {
            return this._audioType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioTypeControl. When set to FOLLOW_INPUT, if the input
        /// contains an ISO 639 audio_type, then that value is passed through to the output. If
        /// the input contains no ISO 639 audio_type, the value in Audio Type is included in the
        /// output. Otherwise the value in Audio Type is included in the output. Note that this
        /// field and audioType are both ignored if audioDescriptionBroadcasterMix is set to BROADCASTER_MIXED_AD.
        /// </summary>
        public AudioTypeControl AudioTypeControl
        {
            get { return this._audioTypeControl; }
            set { this._audioTypeControl = value; }
        }

        // Check to see if AudioTypeControl property is set
        internal bool IsSetAudioTypeControl()
        {
            return this._audioTypeControl != null;
        }

        /// <summary>
        /// Gets and sets the property CodecSettings. Settings related to audio encoding. The
        /// settings in this group vary depending on the value that you choose for your audio
        /// codec.
        /// </summary>
        public AudioCodecSettings CodecSettings
        {
            get { return this._codecSettings; }
            set { this._codecSettings = value; }
        }

        // Check to see if CodecSettings property is set
        internal bool IsSetCodecSettings()
        {
            return this._codecSettings != null;
        }

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
        public string CustomLanguageCode
        {
            get { return this._customLanguageCode; }
            set { this._customLanguageCode = value; }
        }

        // Check to see if CustomLanguageCode property is set
        internal bool IsSetCustomLanguageCode()
        {
            return this._customLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. Indicates the language of the audio output
        /// track. The ISO 639 language specified in the 'Language Code' drop down will be used
        /// when 'Follow Input Language Code' is not selected or when 'Follow Input Language Code'
        /// is selected but there is no ISO 639 language code specified by the input.
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCodeControl. Specify which source for language
        /// code takes precedence for this audio track. When you choose Follow input, the service
        /// uses the language code from the input track if it's present. If there's no languge
        /// code on the input track, the service uses the code that you specify in the setting
        /// Language code. When you choose Use configured, the service uses the language code
        /// that you specify.
        /// </summary>
        public AudioLanguageCodeControl LanguageCodeControl
        {
            get { return this._languageCodeControl; }
            set { this._languageCodeControl = value; }
        }

        // Check to see if LanguageCodeControl property is set
        internal bool IsSetLanguageCodeControl()
        {
            return this._languageCodeControl != null;
        }

        /// <summary>
        /// Gets and sets the property RemixSettings. Advanced audio remixing settings.
        /// </summary>
        public RemixSettings RemixSettings
        {
            get { return this._remixSettings; }
            set { this._remixSettings = value; }
        }

        // Check to see if RemixSettings property is set
        internal bool IsSetRemixSettings()
        {
            return this._remixSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. Specify a label for this output audio stream.
        /// For example, "English", "Director commentary", or "track_2". For streaming outputs,
        /// MediaConvert passes this information into destination manifests for display on the
        /// end-viewer's player device. For outputs in other output groups, the service ignores
        /// this setting.
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}