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
    /// Use Audio selectors to specify a track or set of tracks from the input that you will
    /// use in your outputs. You can use multiple Audio selectors per input.
    /// </summary>
    public partial class AudioSelector
    {
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
        public AudioDurationCorrection AudioDurationCorrection { get; set; }

        /// <summary>
        /// Checks to see if the AudioDurationCorrection property is set.
        /// </summary>
        internal bool IsSetAudioDurationCorrection() => this.AudioDurationCorrection != null;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Selects a specific language code from
        /// within an audio source, using the ISO 639-2 or ISO 639-3 three-letter language code
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CustomLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the CustomLanguageCode property is set.
        /// </summary>
        internal bool IsSetCustomLanguageCode() => this.CustomLanguageCode != null;

        /// <summary>
        /// Gets and sets the property DefaultSelection. Specify a fallback audio selector for
        /// this input. Use to ensure outputs have audio even when the audio selector you specify
        /// in your output is missing from the source. DEFAULT (Checked in the MediaConvert console):
        /// If your output settings specify an audio selector that does not exist in this input,
        /// MediaConvert uses this audio selector instead. This is useful when you have multiple
        /// inputs with a different number of audio tracks. NOT_DEFAULT (Unchecked in the MediaConvert
        /// console): MediaConvert will not fallback from any missing audio selector. Any output
        /// specifying a missing audio selector will be silent.
        /// </summary>
        public AudioDefaultSelection DefaultSelection { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSelection property is set.
        /// </summary>
        internal bool IsSetDefaultSelection() => this.DefaultSelection != null;

        /// <summary>
        /// Gets and sets the property ExternalAudioFileInput. Specify the S3, HTTP, or HTTPS
        /// URL for your external audio file input.
        /// </summary>
        public string ExternalAudioFileInput { get; set; }

        /// <summary>
        /// Checks to see if the ExternalAudioFileInput property is set.
        /// </summary>
        internal bool IsSetExternalAudioFileInput() => this.ExternalAudioFileInput != null;

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
        public HlsRenditionGroupSettings HlsRenditionGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsRenditionGroupSettings property is set.
        /// </summary>
        internal bool IsSetHlsRenditionGroupSettings() => this.HlsRenditionGroupSettings != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language, using an ISO 639-2
        /// three-letter code in all capital letters. You can find a list of codes at: https://www.loc.gov/standards/iso639-2/php/code_list.php
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Offset. Specify a time delta, in milliseconds, to offset
        /// the audio from the input video. To specify no offset: Keep the default value, 0. To
        /// specify an offset: Enter an integer from -2147483648 to 2147483647
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? Offset { get; set; }

        /// <summary>
        /// Checks to see if the Offset property is set.
        /// </summary>
        internal bool IsSetOffset() => this.Offset.HasValue;

        /// <summary>
        /// Gets and sets the property Pids. Selects a specific PID from within an audio source
        /// (e.g. 257 selects PID 0x101).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Pids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Pids property is set.
        /// </summary>
        internal bool IsSetPids() => this.Pids != null && (this.Pids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProgramSelection. Use this setting for input streams that
        /// contain Dolby E, to have the service extract specific program data from the track.
        /// To select multiple programs, create multiple selectors with the same Track and different
        /// Program numbers. In the console, this setting is visible when you set Selector type
        /// to Track. Choose the program number from the dropdown list. If your input file has
        /// incorrect metadata, you can choose All channels instead of a program number to have
        /// the service ignore the program IDs and include all the programs in the track.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public int? ProgramSelection { get; set; }

        /// <summary>
        /// Checks to see if the ProgramSelection property is set.
        /// </summary>
        internal bool IsSetProgramSelection() => this.ProgramSelection.HasValue;

        /// <summary>
        /// Gets and sets the property RemixSettings. Use these settings to reorder the audio
        /// channels of one input to match those of another input. This allows you to combine
        /// the two files into a single output, one after the other.
        /// </summary>
        public RemixSettings RemixSettings { get; set; }

        /// <summary>
        /// Checks to see if the RemixSettings property is set.
        /// </summary>
        internal bool IsSetRemixSettings() => this.RemixSettings != null;

        /// <summary>
        /// Gets and sets the property SelectorType. Specify how MediaConvert selects audio content
        /// within your input. The default is Track. PID: Select audio by specifying the Packet
        /// Identifier (PID) values for MPEG Transport Stream inputs. Use this when you know the
        /// exact PID values of your audio streams. Track: Default. Select audio by track number.
        /// This is the most common option and works with most input container formats. If more
        /// types of audio data get recognized in the future, these numberings may shift, but
        /// the numberings used for Stream mode will not. Language code: Select audio by language
        /// using an ISO 639-2 or ISO 639-3 three-letter code in all capital letters. Use this
        /// when your source has embedded language metadata and you want to select tracks based
        /// on their language. HLS rendition group: Select audio from an HLS rendition group.
        /// Use this when your input is an HLS package with multiple audio renditions and you
        /// want to select specific rendition groups. All PCM: Select all uncompressed PCM audio
        /// tracks from your input automatically. This is useful when you want to include all
        /// PCM audio tracks without specifying individual track numbers. Stream: Select audio
        /// by stream number. Stream numbers include all tracks in the source file, regardless
        /// of type, and correspond to either the order of tracks in the file, or if applicable,
        /// the stream number metadata of the track. Although all tracks count toward these stream
        /// numbers, in this audio selector context, only the stream number of a track containing
        /// audio data may be used. If your source file contains a track which is not recognized
        /// by the service, then the corresponding stream number will still be reserved for future
        /// use. If more types of audio data get recognized in the future, these numberings will
        /// not shift.
        /// </summary>
        public AudioSelectorType SelectorType { get; set; }

        /// <summary>
        /// Checks to see if the SelectorType property is set.
        /// </summary>
        internal bool IsSetSelectorType() => this.SelectorType != null;

        /// <summary>
        /// Gets and sets the property Streams. Identify a track from the input audio to include
        /// in this selector by entering the stream index number. These numberings count all tracks
        /// in the input file, but only a track containing audio data may be used here. To include
        /// several tracks in a single audio selector, specify multiple tracks as follows. Using
        /// the console, enter a comma-separated list. For example, type "1,2,3" to include tracks
        /// 1 through 3.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Streams { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null && (this.Streams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tracks. Identify a track from the input audio to include
        /// in this selector by entering the track index number. These numberings include only
        /// tracks recognized as audio. If the service recognizes more types of audio tracks in
        /// the future, these numberings may shift. To include several tracks in a single audio
        /// selector, specify multiple tracks as follows. Using the console, enter a comma-separated
        /// list. For example, type "1,2,3" to include tracks 1 through 3.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Tracks { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Tracks property is set.
        /// </summary>
        internal bool IsSetTracks() => this.Tracks != null && (this.Tracks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
