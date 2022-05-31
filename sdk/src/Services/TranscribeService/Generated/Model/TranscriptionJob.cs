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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides detailed information about a transcription job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified transcription job, check the <code>TranscriptionJobStatus</code>
    /// field. If the status is <code>COMPLETED</code>, the job is finished and you can find
    /// the results at the location specified in <code>TranscriptFileUri</code>. If the status
    /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
    /// job failed.
    /// </para>
    ///  
    /// <para>
    /// If you enabled content redaction, the redacted transcript can be found at the location
    /// specified in <code>RedactedTranscriptFileUri</code>.
    /// </para>
    /// </summary>
    public partial class TranscriptionJob
    {
        private DateTime? _completionTime;
        private ContentRedaction _contentRedaction;
        private DateTime? _creationTime;
        private string _failureReason;
        private float? _identifiedLanguageScore;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private JobExecutionSettings _jobExecutionSettings;
        private LanguageCode _languageCode;
        private List<LanguageCodeItem> _languageCodes = new List<LanguageCodeItem>();
        private Dictionary<string, LanguageIdSettings> _languageIdSettings = new Dictionary<string, LanguageIdSettings>();
        private List<string> _languageOptions = new List<string>();
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private ModelSettings _modelSettings;
        private Settings _settings;
        private DateTime? _startTime;
        private SubtitlesOutput _subtitles;
        private List<Tag> _tags = new List<Tag>();
        private Transcript _transcript;
        private string _transcriptionJobName;
        private TranscriptionJobStatus _transcriptionJobStatus;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified transcription job finished processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <code>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</code>. For example,
        /// <code>2022-05-04T12:33:13.922000-07:00</code> represents a transcription job that
        /// started processing at 12:33 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentRedaction. 
        /// <para>
        /// Redacts or flags specified personally identifiable information (PII) in your transcript.
        /// </para>
        /// </summary>
        public ContentRedaction ContentRedaction
        {
            get { return this._contentRedaction; }
            set { this._contentRedaction = value; }
        }

        // Check to see if ContentRedaction property is set
        internal bool IsSetContentRedaction()
        {
            return this._contentRedaction != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified transcription job request was made.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <code>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</code>. For example,
        /// <code>2022-05-04T12:32:58.761000-07:00</code> represents a transcription job that
        /// started processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <code>TranscriptionJobStatus</code> is <code>FAILED</code>, <code>FailureReason</code>
        /// contains information about why the transcription job request failed.
        /// </para>
        ///  
        /// <para>
        /// The <code>FailureReason</code> field contains one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Unsupported media format</code>.
        /// </para>
        ///  
        /// <para>
        /// The media format specified in <code>MediaFormat</code> isn't valid. Refer to <b>MediaFormat</b>
        /// for a list of supported formats.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The media format provided does not match the detected media format</code>.
        /// </para>
        ///  
        /// <para>
        /// The media format specified in <code>MediaFormat</code> doesn't match the format of
        /// the input file. Check the media format of your media file and correct the specified
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid sample rate for audio file</code>.
        /// </para>
        ///  
        /// <para>
        /// The sample rate specified in <code>MediaSampleRateHertz</code> isn't valid. The sample
        /// rate must be between 8,000 and 48,000 Hertz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The sample rate provided does not match the detected sample rate</code>.
        /// </para>
        ///  
        /// <para>
        /// The sample rate specified in <code>MediaSampleRateHertz</code> doesn't match the sample
        /// rate detected in your input media file. Check the sample rate of your media file and
        /// correct the specified value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid file size: file size too large</code>.
        /// </para>
        ///  
        /// <para>
        /// The size of your media file is larger than what Amazon Transcribe can process. For
        /// more information, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/limits-guidelines.html#limits">Guidelines
        /// and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid number of channels: number of channels too large</code>.
        /// </para>
        ///  
        /// <para>
        /// Your audio contains more channels than Amazon Transcribe is able to process. For more
        /// information, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/limits-guidelines.html#limits">Guidelines
        /// and quotas</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

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
        public float IdentifiedLanguageScore
        {
            get { return this._identifiedLanguageScore.GetValueOrDefault(); }
            set { this._identifiedLanguageScore = value; }
        }

        // Check to see if IdentifiedLanguageScore property is set
        internal bool IsSetIdentifiedLanguageScore()
        {
            return this._identifiedLanguageScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Indicates whether automatic language identification was enabled (<code>TRUE</code>)
        /// for the specified transcription job.
        /// </para>
        /// </summary>
        public bool IdentifyLanguage
        {
            get { return this._identifyLanguage.GetValueOrDefault(); }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Indicates whether automatic multi-language identification was enabled (<code>TRUE</code>)
        /// for the specified transcription job.
        /// </para>
        /// </summary>
        public bool IdentifyMultipleLanguages
        {
            get { return this._identifyMultipleLanguages.GetValueOrDefault(); }
            set { this._identifyMultipleLanguages = value; }
        }

        // Check to see if IdentifyMultipleLanguages property is set
        internal bool IsSetIdentifyMultipleLanguages()
        {
            return this._identifyMultipleLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobExecutionSettings. 
        /// <para>
        /// Provides information about how your transcription job is being processed. This parameter
        /// shows if your request is queued and what data access role is being used.
        /// </para>
        /// </summary>
        public JobExecutionSettings JobExecutionSettings
        {
            get { return this._jobExecutionSettings; }
            set { this._jobExecutionSettings = value; }
        }

        // Check to see if JobExecutionSettings property is set
        internal bool IsSetJobExecutionSettings()
        {
            return this._jobExecutionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your transcription job. For a list of supported languages
        /// and their associated language codes, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include one of <code>LanguageCode</code>, <code>IdentifyLanguage</code>,
        /// or <code>IdentifyMultipleLanguages</code> in your request. If you include more than
        /// one of these parameters, your transcription job fails.
        /// </para>
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
        /// Gets and sets the property LanguageCodes. 
        /// <para>
        /// The language codes used to create your transcription job. This parameter is used with
        /// multi-language identification. For single-language identification requests, refer
        /// to the singular version of this parameter, <code>LanguageCode</code>.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        /// </summary>
        public List<LanguageCodeItem> LanguageCodes
        {
            get { return this._languageCodes; }
            set { this._languageCodes = value; }
        }

        // Check to see if LanguageCodes property is set
        internal bool IsSetLanguageCodes()
        {
            return this._languageCodes != null && this._languageCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LanguageIdSettings. 
        /// <para>
        /// If using automatic language identification (<code>IdentifyLanguage</code>) in your
        /// request and you want to apply a custom language model, a custom vocabulary, or a custom
        /// vocabulary filter, include <code>LanguageIdSettings</code> with the relevant sub-parameters
        /// (<code>VocabularyName</code>, <code>LanguageModelName</code>, and <code>VocabularyFilterName</code>).
        /// </para>
        ///  
        /// <para>
        /// You can specify two or more language codes that represent the languages you think
        /// may be present in your media; including more than five is not recommended. Each language
        /// code you include can have an associated custom language model, custom vocabulary,
        /// and custom vocabulary filter. The languages you specify must match the languages of
        /// the specified custom language models, custom vocabularies, and custom vocabulary filters.
        /// </para>
        ///  
        /// <para>
        /// To include language options using <code>IdentifyLanguage</code> <b>without</b> including
        /// a custom language model, a custom vocabulary, or a custom vocabulary filter, use <code>LanguageOptions</code>
        /// instead of <code>LanguageIdSettings</code>. Including language options can improve
        /// the accuracy of automatic language identification.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom language model with your request but <b>do not</b>
        /// want to use automatic language identification, use instead the <code/> parameter with
        /// the <code>LanguageModelName</code> sub-parameter.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom vocabulary or a custom vocabulary filter (or both)
        /// with your request but <b>do not</b> want to use automatic language identification,
        /// use instead the <code/> parameter with the <code>VocabularyName</code> or <code>VocabularyFilterName</code>
        /// (or both) sub-parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, LanguageIdSettings> LanguageIdSettings
        {
            get { return this._languageIdSettings; }
            set { this._languageIdSettings = value; }
        }

        // Check to see if LanguageIdSettings property is set
        internal bool IsSetLanguageIdSettings()
        {
            return this._languageIdSettings != null && this._languageIdSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// You can specify two or more language codes that represent the languages you think
        /// may be present in your media; including more than five is not recommended. If you're
        /// unsure what languages are present, do not include this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>LanguageOptions</code> in your request, you must also include
        /// <code>IdentifyLanguage</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  
        /// <para>
        /// To transcribe speech in Modern Standard Arabic (<code>ar-SA</code>), your media file
        /// must be encoded at a sample rate of 16,000 Hz or higher.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null && this._languageOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// Describes the Amazon S3 location of the media file you want to use in your request.
        /// </para>
        /// </summary>
        public Media Media
        {
            get { return this._media; }
            set { this._media = value; }
        }

        // Check to see if Media property is set
        internal bool IsSetMedia()
        {
            return this._media != null;
        }

        /// <summary>
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The format of the input media file.
        /// </para>
        /// </summary>
        public MediaFormat MediaFormat
        {
            get { return this._mediaFormat; }
            set { this._mediaFormat = value; }
        }

        // Check to see if MediaFormat property is set
        internal bool IsSetMediaFormat()
        {
            return this._mediaFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate, in Hertz, of the audio track in your input media file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8000, Max=48000)]
        public int MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz.GetValueOrDefault(); }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelSettings. 
        /// <para>
        /// The custom language model you want to include with your transcription job. If you
        /// include <code>ModelSettings</code> in your request, you must include the <code>LanguageModelName</code>
        /// sub-parameter.
        /// </para>
        /// </summary>
        public ModelSettings ModelSettings
        {
            get { return this._modelSettings; }
            set { this._modelSettings = value; }
        }

        // Check to see if ModelSettings property is set
        internal bool IsSetModelSettings()
        {
            return this._modelSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Specify additional optional settings in your request, including channel identification,
        /// alternative transcriptions, speaker labeling; allows you to apply custom vocabularies
        /// and vocabulary filters.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom vocabulary or a custom vocabulary filter (or both)
        /// with your request but <b>do not</b> want to use automatic language identification,
        /// use <code>Settings</code> with the <code>VocabularyName</code> or <code>VocabularyFilterName</code>
        /// (or both) sub-parameter.
        /// </para>
        ///  
        /// <para>
        /// If you're using automatic language identification with your request and want to include
        /// a custom language model, a custom vocabulary, or a custom vocabulary filter, do not
        /// use the <code>Settings</code> parameter; use instead the <code/> parameter with the
        /// <code>LanguageModelName</code>, <code>VocabularyName</code> or <code>VocabularyFilterName</code>
        /// sub-parameters.
        /// </para>
        /// </summary>
        public Settings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the specified transcription job began processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <code>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</code>. For example,
        /// <code>2022-05-04T12:32:58.789000-07:00</code> represents a transcription job that
        /// started processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Subtitles. 
        /// <para>
        /// Generate subtitles for your media file with your transcription request.
        /// </para>
        /// </summary>
        public SubtitlesOutput Subtitles
        {
            get { return this._subtitles; }
            set { this._subtitles = value; }
        }

        // Check to see if Subtitles property is set
        internal bool IsSetSubtitles()
        {
            return this._subtitles != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more custom tags, each in the form of a key:value pair, to a new transcription
        /// job at the time you start this new job.
        /// </para>
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// Provides you with the Amazon S3 URI you can use to access your transcript.
        /// </para>
        /// </summary>
        public Transcript Transcript
        {
            get { return this._transcript; }
            set { this._transcript = value; }
        }

        // Check to see if Transcript property is set
        internal bool IsSetTranscript()
        {
            return this._transcript != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// The name of the transcription job. Job names are case sensitive and must be unique
        /// within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string TranscriptionJobName
        {
            get { return this._transcriptionJobName; }
            set { this._transcriptionJobName = value; }
        }

        // Check to see if TranscriptionJobName property is set
        internal bool IsSetTranscriptionJobName()
        {
            return this._transcriptionJobName != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobStatus. 
        /// <para>
        /// Provides the status of the specified transcription job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <code>COMPLETED</code>, the job is finished and you can find the
        /// results at the location specified in <code>TranscriptFileUri</code> (or <code>RedactedTranscriptFileUri</code>,
        /// if you requested transcript redaction). If the status is <code>FAILED</code>, <code>FailureReason</code>
        /// provides details on why your transcription job failed.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus TranscriptionJobStatus
        {
            get { return this._transcriptionJobStatus; }
            set { this._transcriptionJobStatus = value; }
        }

        // Check to see if TranscriptionJobStatus property is set
        internal bool IsSetTranscriptionJobStatus()
        {
            return this._transcriptionJobStatus != null;
        }

    }
}