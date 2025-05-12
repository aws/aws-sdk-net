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
    /// Use Dynamic audio selectors when you do not know the track layout of your source when
    /// you submit your job, but want to select multiple audio tracks. When you include an
    /// audio track in your output and specify this Dynamic audio selector as the Audio source,
    /// MediaConvert creates an audio track within that output for each dynamically selected
    /// track. Note that when you include a Dynamic audio selector for two or more inputs,
    /// each input must have the same number of audio tracks and audio channels.
    /// </summary>
    public partial class DynamicAudioSelector
    {
        private AudioDurationCorrection _audioDurationCorrection;
        private string _externalAudioFileInput;
        private LanguageCode _languageCode;
        private int? _offset;
        private DynamicAudioSelectorType _selectorType;

        /// <summary>
        /// Gets and sets the property AudioDurationCorrection. Apply audio timing corrections
        /// to help synchronize audio and video in your output. To apply timing corrections, your
        /// input must meet the following requirements: * Container: MP4, or MOV, with an accurate
        /// time-to-sample (STTS) table. * Audio track: AAC. Choose from the following audio timing
        /// correction settings: * Disabled (Default): Apply no correction. * Auto: Recommended
        /// for most inputs. MediaConvert analyzes the audio timing in your input and determines
        /// which correction setting to use, if needed. * Track: Adjust the duration of each audio
        /// frame by a constant amount to align the audio track length with STTS duration. Track-level
        /// correction does not affect pitch, and is recommended for tonal audio content such
        /// as music. * Frame: Adjust the duration of each audio frame by a variable amount to
        /// align audio frames with STTS timestamps. No corrections are made to already-aligned
        /// frames. Frame-level correction may affect the pitch of corrected frames, and is recommended
        /// for atonal audio content such as speech or percussion. * Force: Apply audio duration
        /// correction, either Track or Frame depending on your input, regardless of the accuracy
        /// of your input's STTS table. Your output audio and video may not be aligned or it may
        /// contain audio artifacts.
        /// </summary>
        public AudioDurationCorrection AudioDurationCorrection
        {
            get { return this._audioDurationCorrection; }
            set { this._audioDurationCorrection = value; }
        }

        // Check to see if AudioDurationCorrection property is set
        internal bool IsSetAudioDurationCorrection()
        {
            return this._audioDurationCorrection != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalAudioFileInput. Specify the S3, HTTP, or HTTPS
        /// URL for your external audio file input.
        /// </summary>
        public string ExternalAudioFileInput
        {
            get { return this._externalAudioFileInput; }
            set { this._externalAudioFileInput = value; }
        }

        // Check to see if ExternalAudioFileInput property is set
        internal bool IsSetExternalAudioFileInput()
        {
            return this._externalAudioFileInput != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language to select from your
        /// audio input. In the MediaConvert console choose from a list of languages. In your
        /// JSON job settings choose from an ISO 639-2 three-letter code listed at https://www.loc.gov/standards/iso639-2/php/code_list.php
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
        /// Gets and sets the property Offset. Specify a time delta, in milliseconds, to offset
        /// the audio from the input video.To specify no offset: Keep the default value, 0.To
        /// specify an offset: Enter an integer from -2147483648 to 2147483647
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectorType. Specify which audio tracks to dynamically
        /// select from your source. To select all audio tracks: Keep the default value, All tracks.
        /// To select all audio tracks with a specific language code: Choose Language code. When
        /// you do, you must also specify a language code under the Language code setting. If
        /// there is no matching Language code in your source, then no track will be selected.
        /// </summary>
        public DynamicAudioSelectorType SelectorType
        {
            get { return this._selectorType; }
            set { this._selectorType = value; }
        }

        // Check to see if SelectorType property is set
        internal bool IsSetSelectorType()
        {
            return this._selectorType != null;
        }

    }
}