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
    /// Provides detailed information about a transcription job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified transcription job, check the <c>TranscriptionJobStatus</c>
    /// field. If the status is <c>COMPLETED</c>, the job is finished and you can find the
    /// results at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
    /// <c>FailureReason</c> provides details on why your transcription job failed.
    /// </para>
    ///  
    /// <para>
    /// If you enabled content redaction, the redacted transcript can be found at the location
    /// specified in <c>RedactedTranscriptFileUri</c>.
    /// </para>
    /// </summary>
    public partial class TranscriptionJob
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified transcription job finished processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:33:13.922000-07:00</c> represents a transcription job that started
        /// processing at 12:33 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ContentRedaction. 
        /// <para>
        /// Indicates whether redaction was enabled in your transcript.
        /// </para>
        /// </summary>
        public ContentRedaction ContentRedaction { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedaction property is set.
        /// </summary>
        internal bool IsSetContentRedaction() => this.ContentRedaction != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified transcription job request was made.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents a transcription job that started
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>TranscriptionJobStatus</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
        /// about why the transcription job request failed.
        /// </para>
        ///  
        /// <para>
        /// The <c>FailureReason</c> field contains one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Unsupported media format</c>.
        /// </para>
        ///  
        /// <para>
        /// The media format specified in <c>MediaFormat</c> isn't valid. Refer to refer to the
        /// <c>MediaFormat</c> parameter for a list of supported formats.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>The media format provided does not match the detected media format</c>.
        /// </para>
        ///  
        /// <para>
        /// The media format specified in <c>MediaFormat</c> doesn't match the format of the input
        /// file. Check the media format of your media file and correct the specified value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invalid sample rate for audio file</c>.
        /// </para>
        ///  
        /// <para>
        /// The sample rate specified in <c>MediaSampleRateHertz</c> isn't valid. The sample rate
        /// must be between 8,000 and 48,000 hertz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>The sample rate provided does not match the detected sample rate</c>.
        /// </para>
        ///  
        /// <para>
        /// The sample rate specified in <c>MediaSampleRateHertz</c> doesn't match the sample
        /// rate detected in your input media file. Check the sample rate of your media file and
        /// correct the specified value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invalid file size: file size too large</c>.
        /// </para>
        ///  
        /// <para>
        /// The size of your media file is larger than what Amazon Transcribe can process. For
        /// more information, refer to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html#limits-amazon-transcribe">Service
        /// quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invalid number of channels: number of channels too large</c>.
        /// </para>
        ///  
        /// <para>
        /// Your audio contains more channels than Amazon Transcribe is able to process. For more
        /// information, refer to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html#limits-amazon-transcribe">Service
        /// quotas</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IdentifiedLanguageScore. 
        /// <para>
        /// The confidence score associated with the language identified in your media file.
        /// </para>
        ///  
        /// <para>
        /// Confidence scores are values between 0 and 1; a larger value indicates a higher probability
        /// that the identified language correctly matches the language spoken in your media.
        /// </para>
        /// </summary>
        public float? IdentifiedLanguageScore { get; set; }

        /// <summary>
        /// Checks to see if the IdentifiedLanguageScore property is set.
        /// </summary>
        internal bool IsSetIdentifiedLanguageScore() => this.IdentifiedLanguageScore.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Indicates whether automatic language identification was enabled (<c>TRUE</c>) for
        /// the specified transcription job.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyLanguage property is set.
        /// </summary>
        internal bool IsSetIdentifyLanguage() => this.IdentifyLanguage.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Indicates whether automatic multi-language identification was enabled (<c>TRUE</c>)
        /// for the specified transcription job.
        /// </para>
        /// </summary>
        public bool? IdentifyMultipleLanguages { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyMultipleLanguages property is set.
        /// </summary>
        internal bool IsSetIdentifyMultipleLanguages() => this.IdentifyMultipleLanguages.HasValue;

        /// <summary>
        /// Gets and sets the property JobExecutionSettings. 
        /// <para>
        /// Provides information about how your transcription job was processed. This parameter
        /// shows if your request was queued and what data access role was used.
        /// </para>
        /// </summary>
        public JobExecutionSettings JobExecutionSettings { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionSettings property is set.
        /// </summary>
        internal bool IsSetJobExecutionSettings() => this.JobExecutionSettings != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your transcription job. This parameter is used with
        /// single-language identification. For multi-language identification requests, refer
        /// to the plural version of this parameter, <c>LanguageCodes</c>.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCodes. 
        /// <para>
        /// The language codes used to create your transcription job. This parameter is used with
        /// multi-language identification. For single-language identification requests, refer
        /// to the singular version of this parameter, <c>LanguageCode</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LanguageCodeItem> LanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<LanguageCodeItem>() : null;

        /// <summary>
        /// Checks to see if the LanguageCodes property is set.
        /// </summary>
        internal bool IsSetLanguageCodes() => this.LanguageCodes != null && (this.LanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageIdSettings. 
        /// <para>
        /// Provides the name and language of all custom language models, custom vocabularies,
        /// and custom vocabulary filters that you included in your request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public Dictionary<string, LanguageIdSettings> LanguageIdSettings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LanguageIdSettings>() : null;

        /// <summary>
        /// Checks to see if the LanguageIdSettings property is set.
        /// </summary>
        internal bool IsSetLanguageIdSettings() => this.LanguageIdSettings != null && (this.LanguageIdSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// Provides the language codes you specified in your request.
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
        /// Gets and sets the property Media. 
        /// <para>
        /// Provides the Amazon S3 location of the media file you used in your request.
        /// </para>
        /// </summary>
        public Media Media { get; set; }

        /// <summary>
        /// Checks to see if the Media property is set.
        /// </summary>
        internal bool IsSetMedia() => this.Media != null;

        /// <summary>
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The format of the input media file.
        /// </para>
        /// </summary>
        public MediaFormat MediaFormat { get; set; }

        /// <summary>
        /// Checks to see if the MediaFormat property is set.
        /// </summary>
        internal bool IsSetMediaFormat() => this.MediaFormat != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate, in hertz, of the audio track in your input media file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property ModelSettings. 
        /// <para>
        /// Provides information on the custom language model you included in your request.
        /// </para>
        /// </summary>
        public ModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Checks to see if the ModelSettings property is set.
        /// </summary>
        internal bool IsSetModelSettings() => this.ModelSettings != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Provides information on any additional settings that were included in your request.
        /// Additional settings include channel identification, alternative transcriptions, speaker
        /// partitioning, custom vocabularies, and custom vocabulary filters.
        /// </para>
        /// </summary>
        public Settings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the specified transcription job began processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.789000-07:00</c> represents a transcription job that started
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Subtitles. 
        /// <para>
        /// Indicates whether subtitles were generated with your transcription.
        /// </para>
        /// </summary>
        public SubtitlesOutput Subtitles { get; set; }

        /// <summary>
        /// Checks to see if the Subtitles property is set.
        /// </summary>
        internal bool IsSetSubtitles() => this.Subtitles != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags, each in the form of a key:value pair, assigned to the specified transcription
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToxicityDetection. 
        /// <para>
        /// Provides information about the toxicity detection settings applied to your transcription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<ToxicityDetectionSettings> ToxicityDetection { get; set; } = AWSConfigs.InitializeCollections ? new List<ToxicityDetectionSettings>() : null;

        /// <summary>
        /// Checks to see if the ToxicityDetection property is set.
        /// </summary>
        internal bool IsSetToxicityDetection() => this.ToxicityDetection != null && (this.ToxicityDetection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// Provides you with the Amazon S3 URI you can use to access your transcript.
        /// </para>
        /// </summary>
        public Transcript Transcript { get; set; }

        /// <summary>
        /// Checks to see if the Transcript property is set.
        /// </summary>
        internal bool IsSetTranscript() => this.Transcript != null;

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// The name of the transcription job. Job names are case sensitive and must be unique
        /// within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string TranscriptionJobName { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptionJobName property is set.
        /// </summary>
        internal bool IsSetTranscriptionJobName() => this.TranscriptionJobName != null;

        /// <summary>
        /// Gets and sets the property TranscriptionJobStatus. 
        /// <para>
        /// Provides the status of the specified transcription job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED</c>, the job is finished and you can find the results
        /// at the location specified in <c>TranscriptFileUri</c> (or <c>RedactedTranscriptFileUri</c>,
        /// if you requested transcript redaction). If the status is <c>FAILED</c>, <c>FailureReason</c>
        /// provides details on why your transcription job failed.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus TranscriptionJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptionJobStatus property is set.
        /// </summary>
        internal bool IsSetTranscriptionJobStatus() => this.TranscriptionJobStatus != null;
    }
}
