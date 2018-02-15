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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Description of audio output
    /// </summary>
    public partial class AudioDescription
    {
        private AudioNormalizationSettings _audioNormalizationSettings;
        private string _audioSourceName;
        private int? _audioType;
        private AudioTypeControl _audioTypeControl;
        private AudioCodecSettings _codecSettings;
        private LanguageCode _languageCode;
        private AudioLanguageCodeControl _languageCodeControl;
        private RemixSettings _remixSettings;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings.
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
        public int AudioType
        {
            get { return this._audioType.GetValueOrDefault(); }
            set { this._audioType = value; }
        }

        // Check to see if AudioType property is set
        internal bool IsSetAudioType()
        {
            return this._audioType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioTypeControl.
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
        /// Gets and sets the property CodecSettings.
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
        /// Gets and sets the property LanguageCodeControl.
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
        /// Gets and sets the property StreamName. Used for MS Smooth and Apple HLS outputs. Indicates
        /// the name displayed by the player (eg. English, or Director Commentary). Alphanumeric
        /// characters, spaces, and underscore are legal.
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