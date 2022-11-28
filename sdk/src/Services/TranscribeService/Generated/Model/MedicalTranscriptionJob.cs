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
    /// Provides detailed information about a medical transcription job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified medical transcription job, check the <code>TranscriptionJobStatus</code>
    /// field. If the status is <code>COMPLETED</code>, the job is finished and you can find
    /// the results at the location specified in <code>TranscriptFileUri</code>. If the status
    /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
    /// job failed.
    /// </para>
    /// </summary>
    public partial class MedicalTranscriptionJob
    {
        private DateTime? _completionTime;
        private MedicalContentIdentificationType _contentIdentificationType;
        private DateTime? _creationTime;
        private string _failureReason;
        private LanguageCode _languageCode;
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private string _medicalTranscriptionJobName;
        private MedicalTranscriptionSetting _settings;
        private Specialty _specialty;
        private DateTime? _startTime;
        private List<Tag> _tags = new List<Tag>();
        private MedicalTranscript _transcript;
        private TranscriptionJobStatus _transcriptionJobStatus;
        private Type _type;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified medical transcription job finished processing.
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
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Indicates whether content identification was enabled for your transcription request.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified medical transcription job request was made.
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
        /// rate must be between 16,000 and 48,000 hertz.
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your medical transcription job. US English (<code>en-US</code>)
        /// is the only supported language for medical transcriptions.
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
        [AWSProperty(Min=16000, Max=48000)]
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
        /// Gets and sets the property MedicalTranscriptionJobName. 
        /// <para>
        /// The name of the medical transcription job. Job names are case sensitive and must be
        /// unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string MedicalTranscriptionJobName
        {
            get { return this._medicalTranscriptionJobName; }
            set { this._medicalTranscriptionJobName = value; }
        }

        // Check to see if MedicalTranscriptionJobName property is set
        internal bool IsSetMedicalTranscriptionJobName()
        {
            return this._medicalTranscriptionJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Provides information on any additional settings that were included in your request.
        /// Additional settings include channel identification, alternative transcriptions, speaker
        /// partitioning, custom vocabularies, and custom vocabulary filters.
        /// </para>
        /// </summary>
        public MedicalTranscriptionSetting Settings
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
        /// Gets and sets the property Specialty. 
        /// <para>
        /// Describes the medical specialty represented in your media.
        /// </para>
        /// </summary>
        public Specialty Specialty
        {
            get { return this._specialty; }
            set { this._specialty = value; }
        }

        // Check to see if Specialty property is set
        internal bool IsSetSpecialty()
        {
            return this._specialty != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the specified medical transcription job began processing.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags, each in the form of a key:value pair, assigned to the specified medical
        /// transcription job.
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
        public MedicalTranscript Transcript
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
        /// Gets and sets the property TranscriptionJobStatus. 
        /// <para>
        /// Provides the status of the specified medical transcription job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <code>COMPLETED</code>, the job is finished and you can find the
        /// results at the location specified in <code>TranscriptFileUri</code>. If the status
        /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
        /// job failed.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the input media is a dictation or a conversation, as specified in
        /// the <code>StartMedicalTranscriptionJob</code> request.
        /// </para>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}