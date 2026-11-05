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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Description
    /// </summary>
    public partial class AudioDescription
    {
        /// <summary>
        /// Gets and sets the property AudioDashRoles. Identifies the DASH roles to assign to
        /// this audio output. Applies only when the audio output is configured for DVB DASH accessibility
        /// signaling.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AudioDashRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AudioDashRoles property is set.
        /// </summary>
        internal bool IsSetAudioDashRoles() => this.AudioDashRoles != null && (this.AudioDashRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings. Advanced audio normalization
        /// settings.
        /// </summary>
        public AudioNormalizationSettings AudioNormalizationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioNormalizationSettings property is set.
        /// </summary>
        internal bool IsSetAudioNormalizationSettings() => this.AudioNormalizationSettings != null;

        /// <summary>
        /// Gets and sets the property AudioSelectorName. The name of the AudioSelector used as
        /// the source for this AudioDescription.
        /// </summary>
        [AWSProperty(Required = true)]
        public string AudioSelectorName { get; set; }

        /// <summary>
        /// Checks to see if the AudioSelectorName property is set.
        /// </summary>
        internal bool IsSetAudioSelectorName() => this.AudioSelectorName != null;

        /// <summary>
        /// Gets and sets the property AudioType. Applies only if audioTypeControl is useConfigured.
        /// The values for audioType are defined in ISO-IEC 13818-1.
        /// </summary>
        public AudioType AudioType { get; set; }

        /// <summary>
        /// Checks to see if the AudioType property is set.
        /// </summary>
        internal bool IsSetAudioType() => this.AudioType != null;

        /// <summary>
        /// Gets and sets the property AudioTypeControl. Determines how audio type is determined.
        /// followInput: If the input contains an ISO 639 audioType, then that value is passed
        /// through to the output. If the input contains no ISO 639 audioType, the value in Audio
        /// Type is included in the output. useConfigured: The value in Audio Type is included
        /// in the output. Note that this field and audioType are both ignored if inputType is
        /// broadcasterMixedAd.
        /// </summary>
        public AudioDescriptionAudioTypeControl AudioTypeControl { get; set; }

        /// <summary>
        /// Checks to see if the AudioTypeControl property is set.
        /// </summary>
        internal bool IsSetAudioTypeControl() => this.AudioTypeControl != null;

        /// <summary>
        /// Gets and sets the property AudioWatermarkingSettings. Settings to configure one or
        /// more solutions that insert audio watermarks in the audio encode
        /// </summary>
        public AudioWatermarkSettings AudioWatermarkingSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioWatermarkingSettings property is set.
        /// </summary>
        internal bool IsSetAudioWatermarkingSettings() => this.AudioWatermarkingSettings != null;

        /// <summary>
        /// Gets and sets the property CodecSettings. Audio codec settings.
        /// </summary>
        public AudioCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodecSettings property is set.
        /// </summary>
        internal bool IsSetCodecSettings() => this.CodecSettings != null;

        /// <summary>
        /// Gets and sets the property DvbDashAccessibility. Identifies DVB DASH accessibility
        /// signaling in this audio output. Used in Microsoft Smooth Streaming outputs to signal
        /// accessibility information to packagers.
        /// </summary>
        public DvbDashAccessibility DvbDashAccessibility { get; set; }

        /// <summary>
        /// Checks to see if the DvbDashAccessibility property is set.
        /// </summary>
        internal bool IsSetDvbDashAccessibility() => this.DvbDashAccessibility != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. RFC 5646 language code representing the language
        /// of the audio output track. Only used if languageControlMode is useConfigured, or there
        /// is no ISO 639 language code specified in the input.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCodeControl. Choosing followInput will cause the
        /// ISO 639 language code of the output to follow the ISO 639 language code of the input.
        /// The languageCode will be used when useConfigured is set, or when followInput is selected
        /// but there is no ISO 639 language code specified by the input.
        /// </summary>
        public AudioDescriptionLanguageCodeControl LanguageCodeControl { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCodeControl property is set.
        /// </summary>
        internal bool IsSetLanguageCodeControl() => this.LanguageCodeControl != null;

        /// <summary>
        /// Gets and sets the property Name. The name of this AudioDescription. Outputs will use
        /// this name to uniquely identify this AudioDescription. Description names should be
        /// unique within this Live Event.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RemixSettings. Settings that control how input audio channels
        /// are remixed into the output audio channels.
        /// </summary>
        public RemixSettings RemixSettings { get; set; }

        /// <summary>
        /// Checks to see if the RemixSettings property is set.
        /// </summary>
        internal bool IsSetRemixSettings() => this.RemixSettings != null;

        /// <summary>
        /// Gets and sets the property StreamName. Used for MS Smooth and Apple HLS outputs. Indicates
        /// the name displayed by the player (eg. English, or Director Commentary).
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
