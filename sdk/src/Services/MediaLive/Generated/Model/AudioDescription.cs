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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for AudioDescription
    /// </summary>
    public partial class AudioDescription
    {
        private AudioNormalizationSettings _audioNormalizationSettings;
        private string _audioSelectorName;
        private AudioType _audioType;
        private AudioDescriptionAudioTypeControl _audioTypeControl;
        private AudioCodecSettings _codecSettings;
        private string _languageCode;
        private AudioDescriptionLanguageCodeControl _languageCodeControl;
        private string _name;
        private RemixSettings _remixSettings;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings. Advanced audio normalization
        /// settings.
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
        /// Gets and sets the property AudioSelectorName. The name of the AudioSelector used as
        /// the source for this AudioDescription.
        /// </summary>
        public string AudioSelectorName
        {
            get { return this._audioSelectorName; }
            set { this._audioSelectorName = value; }
        }

        // Check to see if AudioSelectorName property is set
        internal bool IsSetAudioSelectorName()
        {
            return this._audioSelectorName != null;
        }

        /// <summary>
        /// Gets and sets the property AudioType. Applies only if audioTypeControl is useConfigured.
        /// The values for audioType are defined in ISO-IEC 13818-1.
        /// </summary>
        public AudioType AudioType
        {
            get { return this._audioType; }
            set { this._audioType = value; }
        }

        // Check to see if AudioType property is set
        internal bool IsSetAudioType()
        {
            return this._audioType != null;
        }

        /// <summary>
        /// Gets and sets the property AudioTypeControl. Determines how audio type is determined.
        ///  followInput: If the input contains an ISO 639 audioType, then that value is passed
        /// through to the output. If the input contains no ISO 639 audioType, the value in Audio
        /// Type is included in the output.  useConfigured: The value in Audio Type is included
        /// in the output.Note that this field and audioType are both ignored if inputType is
        /// broadcasterMixedAd.
        /// </summary>
        public AudioDescriptionAudioTypeControl AudioTypeControl
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
        /// Gets and sets the property CodecSettings. Audio codec settings.
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
        /// track. Only used if languageControlMode is useConfigured, or there is no ISO 639 language
        /// code specified in the input.
        /// </summary>
        public string LanguageCode
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
        /// Gets and sets the property LanguageCodeControl. Choosing followInput will cause the
        /// ISO 639 language code of the output to follow the ISO 639 language code of the input.
        /// The languageCode will be used when useConfigured is set, or when followInput is selected
        /// but there is no ISO 639 language code specified by the input.
        /// </summary>
        public AudioDescriptionLanguageCodeControl LanguageCodeControl
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
        /// Gets and sets the property Name. The name of this AudioDescription. Outputs will use
        /// this name to uniquely identify this AudioDescription.  Description names should be
        /// unique within this Live Event.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RemixSettings. Settings that control how input audio channels
        /// are remixed into the output audio channels.
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
        /// the name displayed by the player (eg. English, or Director Commentary).
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