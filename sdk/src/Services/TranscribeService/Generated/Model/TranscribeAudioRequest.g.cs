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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the TranscribeAudio operation. Transcribes a media
    /// file and returns the transcript in the same response. There is no job to start and
    /// no status to poll. <para> Use <c>TranscribeAudio</c> when you already have a complete
    /// media file and want the transcript right away. For large files, long audio, or bulk
    /// processing, use . </para> <para> You must include the following parameters in your
    /// <c>TranscribeAudio</c> request: </para> <ul> <li> <para> <c>Media</c>: Your audio,
    /// either as inline bytes (<c>MediaBytes</c>) or as the Amazon S3 location of a media
    /// file (<c>MediaFileUri</c>). </para> </li> <li> <para> One of <c>Language</c> or <c>LanguageDetectionMode</c>:
    /// Specify the language of your audio, or have Amazon Transcribe identify it. </para>
    /// </li> </ul> <para> Your audio must be between 0.5 seconds and 1 hour long. Supported
    /// formats are WAV, MP3, FLAC, M4A, MP4, Ogg, WebM, and AMR. </para> <para> If you send
    /// your audio in the request (<c>MediaBytes</c>), the file can be up to 25 MB. If you
    /// provide an Amazon S3 location (<c>MediaFileUri</c>), the file can be up to 500 MB.
    /// </para> <para> Amazon Transcribe always turns on smart formatting, also known as inverse
    /// text normalization (ITN). It writes numbers, dates, currency, and similar items in
    /// their usual written form. For example, "one hundred" becomes "100". You can't turn
    /// smart formatting off. </para> <para> By default, Amazon Transcribe returns the transcript
    /// in <c>TranscriptResponse</c>. If you include <c>OutputConfiguration</c>, Amazon Transcribe
    /// writes the transcript to the Amazon S3 location you specify instead, and the response
    /// contains only that location. </para>
    /// </summary>
    public partial class TranscribeAudioRequest : AmazonTranscribeServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelIdentification. 
        /// <para>
        /// Enables channel identification in multi-channel audio. Each channel is transcribed
        /// independently, and each item in the transcript is labeled with its channel.
        /// </para>
        ///  
        /// <para>
        /// Channel identification supports up to two channels.
        /// </para>
        /// </summary>
        public bool? ChannelIdentification { get; set; }

        /// <summary>
        /// Checks to see if the ChannelIdentification property is set.
        /// </summary>
        internal bool IsSetChannelIdentification() => this.ChannelIdentification.HasValue;

        /// <summary>
        /// Gets and sets the property ContentRedaction. 
        /// <para>
        /// Redacts personally identifiable information (PII) from your transcript. Amazon Transcribe
        /// returns the redacted transcript in <c>RedactedResults</c>.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>RedactionOutput</c> to <c>redacted_and_unredacted</c>, Amazon Transcribe
        /// also returns the unredacted transcript in <c>Results</c>.
        /// </para>
        ///  
        /// <para>
        /// In Sync, content redaction has these limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Languages:</b> English (<c>en</c>), Spanish (<c>es</c>), French (<c>fr</c>), Italian
        /// (<c>it</c>), German (<c>de</c>), and Portuguese (<c>pt</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Language identification:</b> If you use <c>LanguageDetectionMode</c>, you must
        /// also include <c>LanguageOptions</c>, and every language in it must be one of the languages
        /// above. A request that has no <c>LanguageOptions</c>, or that lists a language that
        /// isn't supported, returns a <c>BadRequestException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Regions:</b> Content redaction isn't available in the South America (São Paulo)
        /// Region (<c>sa-east-1</c>). It's available in the other Amazon Web Services Regions
        /// where Sync is available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContentRedaction ContentRedaction { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedaction property is set.
        /// </summary>
        internal bool IsSetContentRedaction() => this.ContentRedaction != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language spoken in your audio, as a base language code (for example, <c>en</c>
        /// or <c>es</c>).
        /// </para>
        ///  
        /// <para>
        /// Include either <c>Language</c> or <c>LanguageDetectionMode</c> in your request, but
        /// not both.
        /// </para>
        /// </summary>
        public SyncLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property LanguageDetectionMode. 
        /// <para>
        /// Enables automatic language identification. Use <c>IDENTIFY_LANGUAGE</c> if your audio
        /// contains a single language that you don't know in advance.
        /// </para>
        ///  
        /// <para>
        /// You can optionally include <c>LanguageOptions</c> to limit identification to languages
        /// you think may be present, which can improve accuracy.
        /// </para>
        ///  
        /// <para>
        /// Amazon Transcribe returns the identified language, as a locale (for example, <c>en-US</c>),
        /// in the response metadata.
        /// </para>
        ///  
        /// <para>
        /// Include either <c>Language</c> or <c>LanguageDetectionMode</c> in your request, but
        /// not both.
        /// </para>
        /// </summary>
        public LanguageDetectionMode LanguageDetectionMode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageDetectionMode property is set.
        /// </summary>
        internal bool IsSetLanguageDetectionMode() => this.LanguageDetectionMode != null;

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// A list of two or more languages that you think may be present in your audio, as base
        /// language codes (for example, <c>en</c> and <c>es</c>). Each language can appear only
        /// once. A list with only one language returns a <c>BadRequestException</c>.
        /// </para>
        ///  
        /// <para>
        /// You can use <c>LanguageOptions</c> only with <c>LanguageDetectionMode</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> LanguageOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LanguageOptions property is set.
        /// </summary>
        internal bool IsSetLanguageOptions() => this.LanguageOptions != null && (this.LanguageOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxSpeakerLabels. 
        /// <para>
        /// Specify the maximum number of speakers you want to partition in your media.
        /// </para>
        ///  
        /// <para>
        /// Note that if your media contains more speakers than the specified number, Amazon Transcribe
        /// treats multiple speakers as a single speaker.
        /// </para>
        ///  
        /// <para>
        /// You can set <c>MaxSpeakerLabels</c> only if <c>ShowSpeakerLabels</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 30)]
        public int? MaxSpeakerLabels { get; set; }

        /// <summary>
        /// Checks to see if the MaxSpeakerLabels property is set.
        /// </summary>
        internal bool IsSetMaxSpeakerLabels() => this.MaxSpeakerLabels.HasValue;

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// The audio to transcribe. Specify exactly one of <c>MediaBytes</c> or <c>MediaFileUri</c>.
        /// </para>
        ///  
        /// <para>
        /// Audio sent in the request (<c>MediaBytes</c>) can be up to 25 MB. Audio in Amazon
        /// S3 (<c>MediaFileUri</c>) can be up to 500 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncMedia Media { get; set; }

        /// <summary>
        /// Checks to see if the Media property is set.
        /// </summary>
        internal bool IsSetMedia() => this.Media != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// Writes the transcript to an Amazon S3 location instead of returning it in the response.
        /// If you include <c>OutputConfiguration</c>, the response contains only the output location.
        /// </para>
        ///  
        /// <para>
        /// You must have write permission for the location you specify.
        /// </para>
        /// </summary>
        public SyncOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ShowSpeakerLabels. 
        /// <para>
        /// Enables speaker partitioning (diarization) in your transcript. Speaker partitioning
        /// labels the speech from individual speakers in your media file.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>ShowSpeakerLabels</c> to <c>true</c>, you must also include <c>MaxSpeakerLabels</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/diarization.html">Partitioning
        /// speakers (diarization)</a>.
        /// </para>
        /// </summary>
        public bool? ShowSpeakerLabels { get; set; }

        /// <summary>
        /// Checks to see if the ShowSpeakerLabels property is set.
        /// </summary>
        internal bool IsSetShowSpeakerLabels() => this.ShowSpeakerLabels.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyFilterSettings. 
        /// <para>
        /// Custom vocabulary filters to apply to your transcript, and how to apply them.
        /// </para>
        /// </summary>
        public VocabularyFilterSettings VocabularyFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterSettings property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterSettings() => this.VocabularyFilterSettings != null;

        /// <summary>
        /// Gets and sets the property VocabularySettings. 
        /// <para>
        /// Custom vocabularies to apply to your transcript, with one entry per language. In each
        /// entry, you can reference a custom vocabulary you created or provide phrases inline.
        /// All entries must use the same type, either all by name or all inline.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Language</c>, include exactly one entry, and its <c>Language</c>
        /// must match. If you use <c>LanguageDetectionMode</c>, you can include one entry for
        /// each language in <c>LanguageOptions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<VocabularySettingsEntry> VocabularySettings { get; set; } = AWSConfigs.InitializeCollections ? new List<VocabularySettingsEntry>() : null;

        /// <summary>
        /// Checks to see if the VocabularySettings property is set.
        /// </summary>
        internal bool IsSetVocabularySettings() => this.VocabularySettings != null && (this.VocabularySettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
