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
    /// Use Audio selectors to specify a track or set of tracks from the input that you will
    /// use in your outputs. You can use multiple Audio selectors per input.
    /// </summary>
    public partial class AudioSelector
    {
        private AudioDurationCorrection _audioDurationCorrection;
        private string _customLanguageCode;
        private AudioDefaultSelection _defaultSelection;
        private string _externalAudioFileInput;
        private HlsRenditionGroupSettings _hlsRenditionGroupSettings;
        private LanguageCode _languageCode;
        private int? _offset;
        private List<int> _pids = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _programSelection;
        private RemixSettings _remixSettings;
        private AudioSelectorType _selectorType;
        private List<int> _tracks = AWSConfigs.InitializeCollections ? new List<int>() : null;

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
        /// Gets and sets the property CustomLanguageCode. Selects a specific language code from
        /// within an audio source, using the ISO 639-2 or ISO 639-3 three-letter language code
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
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
        /// Gets and sets the property DefaultSelection. Enable this setting on one audio selector
        /// to set it as the default for the job. The service uses this default for outputs where
        /// it can't find the specified input audio. If you don't set a default, those outputs
        /// have no audio.
        /// </summary>
        public AudioDefaultSelection DefaultSelection
        {
            get { return this._defaultSelection; }
            set { this._defaultSelection = value; }
        }

        // Check to see if DefaultSelection property is set
        internal bool IsSetDefaultSelection()
        {
            return this._defaultSelection != null;
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
        /// Gets and sets the property HlsRenditionGroupSettings. Settings specific to audio sources
        /// in an HLS alternate rendition group. Specify the properties (renditionGroupId, renditionName
        /// or renditionLanguageCode) to identify the unique audio track among the alternative
        /// rendition groups present in the HLS manifest. If no unique track is found, or multiple
        /// tracks match the properties provided, the job fails. If no properties in hlsRenditionGroupSettings
        /// are specified, the default audio track within the video segment is chosen. If there
        /// is no audio within video segment, the alternative audio with DEFAULT=YES is chosen
        /// instead.
        /// </summary>
        public HlsRenditionGroupSettings HlsRenditionGroupSettings
        {
            get { return this._hlsRenditionGroupSettings; }
            set { this._hlsRenditionGroupSettings = value; }
        }

        // Check to see if HlsRenditionGroupSettings property is set
        internal bool IsSetHlsRenditionGroupSettings()
        {
            return this._hlsRenditionGroupSettings != null;
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
        /// Gets and sets the property Pids. Selects a specific PID from within an audio source
        /// (e.g. 257 selects PID 0x101).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Pids
        {
            get { return this._pids; }
            set { this._pids = value; }
        }

        // Check to see if Pids property is set
        internal bool IsSetPids()
        {
            return this._pids != null && (this._pids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProgramSelection. Use this setting for input streams that
        /// contain Dolby E, to have the service extract specific program data from the track.
        /// To select multiple programs, create multiple selectors with the same Track and different
        /// Program numbers. In the console, this setting is visible when you set Selector type
        /// to Track. Choose the program number from the dropdown list. If your input file has
        /// incorrect metadata, you can choose All channels instead of a program number to have
        /// the service ignore the program IDs and include all the programs in the track.
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public int? ProgramSelection
        {
            get { return this._programSelection; }
            set { this._programSelection = value; }
        }

        // Check to see if ProgramSelection property is set
        internal bool IsSetProgramSelection()
        {
            return this._programSelection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemixSettings. Use these settings to reorder the audio
        /// channels of one input to match those of another input. This allows you to combine
        /// the two files into a single output, one after the other.
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
        /// Gets and sets the property SelectorType. Specify how MediaConvert selects audio content
        /// within your input. The default is Track. PID: Select audio by specifying the Packet
        /// Identifier (PID) values for MPEG Transport Stream inputs. Use this when you know the
        /// exact PID values of your audio streams. Track: Default. Select audio by track number.
        /// This is the most common option and works with most input container formats. Language
        /// code: Select audio by language using ISO 639-2 or ISO 639-3 three-letter language
        /// codes. Use this when your source has embedded language metadata and you want to select
        /// tracks based on their language. HLS rendition group: Select audio from an HLS rendition
        /// group. Use this when your input is an HLS package with multiple audio renditions and
        /// you want to select specific rendition groups. All PCM: Select all uncompressed PCM
        /// audio tracks from your input automatically. This is useful when you want to include
        /// all PCM audio tracks without specifying individual track numbers.
        /// </summary>
        public AudioSelectorType SelectorType
        {
            get { return this._selectorType; }
            set { this._selectorType = value; }
        }

        // Check to see if SelectorType property is set
        internal bool IsSetSelectorType()
        {
            return this._selectorType != null;
        }

        /// <summary>
        /// Gets and sets the property Tracks. Identify a track from the input audio to include
        /// in this selector by entering the track index number. To include several tracks in
        /// a single audio selector, specify multiple tracks as follows. Using the console, enter
        /// a comma-separated list. For example, type "1,2,3" to include tracks 1 through 3.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Tracks
        {
            get { return this._tracks; }
            set { this._tracks = value; }
        }

        // Check to see if Tracks property is set
        internal bool IsSetTracks()
        {
            return this._tracks != null && (this._tracks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}