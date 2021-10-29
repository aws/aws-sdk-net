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
    /// Describes an asynchronous analytics job that was created with the <code>StartAnalyticsJob</code>
    /// operation.
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
        /// The name of the call analytics job.
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
        /// The status of the analytics job.
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
        /// Shows numeric values to indicate the channel assigned to the agent's audio and the
        /// channel assigned to the customer's audio. 
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
        /// A timestamp that shows when the analytics job was completed.
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
        /// A timestamp that shows when the analytics job was created.
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
        /// The Amazon Resource Number (ARN) that you use to access the analytics job. ARNs have
        /// the format <code>arn:partition:service:region:account-id:resource-type/resource-id</code>.
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
        /// If the <code>AnalyticsJobStatus</code> is <code>FAILED</code>, this field contains
        /// information about why the job failed.
        /// </para>
        ///  
        /// <para>
        /// The <code>FailureReason</code> field can contain one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Unsupported media format</code>: The media format specified in the <code>MediaFormat</code>
        /// field of the request isn't valid. See the description of the <code>MediaFormat</code>
        /// field for a list of valid values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The media format provided does not match the detected media format</code>:
        /// The media format of the audio file doesn't match the format specified in the <code>MediaFormat</code>
        /// field in the request. Check the media format of your media file and make sure the
        /// two values match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid sample rate for audio file</code>: The sample rate specified in the
        /// <code>MediaSampleRateHertz</code> of the request isn't valid. The sample rate must
        /// be between 8,000 and 48,000 Hertz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The sample rate provided does not match the detected sample rate</code>: The
        /// sample rate in the audio file doesn't match the sample rate specified in the <code>MediaSampleRateHertz</code>
        /// field in the request. Check the sample rate of your media file and make sure that
        /// the two values match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid file size: file size too large</code>: The size of your audio file
        /// is larger than what Amazon Transcribe Medical can process. For more information, see
        /// <i>Guidelines and Quotas</i> in the Amazon Transcribe Medical Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invalid number of channels: number of channels too large</code>: Your audio
        /// contains more channels than Amazon Transcribe Medical is configured to process. To
        /// request additional channels, see Amazon Transcribe Medical Endpoints and Quotas in
        /// the <a href="https://docs.aws.amazon.com/general/latest/gr/Welcome.html">Amazon Web
        /// Services General Reference</a>.
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
        /// A value between zero and one that Amazon Transcribe assigned to the language that
        /// it identified in the source audio. This value appears only when you don't provide
        /// a single language code. Larger values indicate that Amazon Transcribe has higher confidence
        /// in the language that it identified
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
        /// If you know the language spoken between the customer and the agent, specify a language
        /// code for this field.
        /// </para>
        ///  
        /// <para>
        /// If you don't know the language, you can leave this field blank, and Amazon Transcribe
        /// will use machine learning to automatically identify the language. To improve the accuracy
        /// of language identification, you can provide an array containing the possible language
        /// codes for the language spoken in your audio. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-it-works.html">Supported
        /// languages and language-specific features</a> for additional information.
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
        /// The format of the input audio file. Note: for call analytics jobs, only the following
        /// media formats are supported: MP3, MP4, WAV, FLAC, OGG, and WebM. 
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
        /// The sample rate, in Hertz, of the audio.
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
        /// Provides information about the settings used to run a transcription job.
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
        /// A timestamp that shows when the analytics job started processing.
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