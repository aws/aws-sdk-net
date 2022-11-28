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
    /// Provides detailed information about a Call Analytics job.
    /// 
    ///  
    /// <para>
    /// To view the job's status, refer to <code>CallAnalyticsJobStatus</code>. If the status
    /// is <code>COMPLETED</code>, the job is finished. You can find your completed transcript
    /// at the URI specified in <code>TranscriptFileUri</code>. If the status is <code>FAILED</code>,
    /// <code>FailureReason</code> provides details on why your transcription job failed.
    /// </para>
    ///  
    /// <para>
    /// If you enabled personally identifiable information (PII) redaction, the redacted transcript
    /// appears at the location specified in <code>RedactedTranscriptFileUri</code>.
    /// </para>
    ///  
    /// <para>
    /// If you chose to redact the audio in your media file, you can find your redacted media
    /// file at the location specified in the <code>RedactedMediaFileUri</code> field of your
    /// response.
    /// </para>
    /// </summary>
    public partial class CallAnalyticsJob
    {
        private string _callAnalyticsJobName;
        private CallAnalyticsJobStatus _callAnalyticsJobStatus;
        private List<ChannelDefinition> _channelDefinitions = new List<ChannelDefinition>();
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private string _dataAccessRoleArn;
        private string _failureReason;
        private float? _identifiedLanguageScore;
        private LanguageCode _languageCode;
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private CallAnalyticsJobSettings _settings;
        private DateTime? _startTime;
        private Transcript _transcript;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobName. 
        /// <para>
        /// The name of the Call Analytics job. Job names are case sensitive and must be unique
        /// within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string CallAnalyticsJobName
        {
            get { return this._callAnalyticsJobName; }
            set { this._callAnalyticsJobName = value; }
        }

        // Check to see if CallAnalyticsJobName property is set
        internal bool IsSetCallAnalyticsJobName()
        {
            return this._callAnalyticsJobName != null;
        }

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobStatus. 
        /// <para>
        /// Provides the status of the specified Call Analytics job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <code>COMPLETED</code>, the job is finished and you can find the
        /// results at the location specified in <code>TranscriptFileUri</code> (or <code>RedactedTranscriptFileUri</code>,
        /// if you requested transcript redaction). If the status is <code>FAILED</code>, <code>FailureReason</code>
        /// provides details on why your transcription job failed.
        /// </para>
        /// </summary>
        public CallAnalyticsJobStatus CallAnalyticsJobStatus
        {
            get { return this._callAnalyticsJobStatus; }
            set { this._callAnalyticsJobStatus = value; }
        }

        // Check to see if CallAnalyticsJobStatus property is set
        internal bool IsSetCallAnalyticsJobStatus()
        {
            return this._callAnalyticsJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Indicates which speaker is on which channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<ChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && this._channelDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified Call Analytics job finished processing.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified Call Analytics job request was made.
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
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) you included in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <code>CallAnalyticsJobStatus</code> is <code>FAILED</code>, <code>FailureReason</code>
        /// contains information about why the Call Analytics job request failed.
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
        /// rate must be between 8,000 and 48,000 hertz.
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your Call Analytics job. For a list of supported
        /// languages and their associated language codes, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  
        /// <para>
        /// If you don't know the language spoken in your media file, you can omit this field
        /// and let Amazon Transcribe automatically identify the language of your media. To improve
        /// the accuracy of language identification, you can include several language codes and
        /// Amazon Transcribe chooses the closest match for your transcription.
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
        /// Gets and sets the property Media. 
        /// <para>
        /// Provides the Amazon S3 location of the media file you used in your Call Analytics
        /// request.
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
        /// The sample rate, in hertz, of the audio track in your input media file.
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// Provides information on any additional settings that were included in your request.
        /// Additional settings include content redaction and language identification settings.
        /// </para>
        /// </summary>
        public CallAnalyticsJobSettings Settings
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
        /// The date and time the specified Call Analytics job began processing.
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
        /// Gets and sets the property Transcript.
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

    }
}