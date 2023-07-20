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
    /// Provides detailed information about a specific transcription job.
    /// </summary>
    public partial class TranscriptionJobSummary
    {
        private DateTime? _completionTime;
        private ContentRedaction _contentRedaction;
        private DateTime? _creationTime;
        private string _failureReason;
        private float? _identifiedLanguageScore;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private LanguageCode _languageCode;
        private List<LanguageCodeItem> _languageCodes = new List<LanguageCodeItem>();
        private ModelSettings _modelSettings;
        private OutputLocationType _outputLocationType;
        private DateTime? _startTime;
        private List<ToxicityDetectionSettings> _toxicityDetection = new List<ToxicityDetectionSettings>();
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
        /// The content redaction settings of the transcription job.
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
        /// contains information about why the transcription job failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your transcription.
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
        /// multi-language identification. For single-language identification, the singular version
        /// of this parameter, <code>LanguageCode</code>, is present.
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
        /// Gets and sets the property ModelSettings.
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
        /// Gets and sets the property OutputLocationType. 
        /// <para>
        /// Indicates where the specified transcription output is stored.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>CUSTOMER_BUCKET</code>, the location is the Amazon S3 bucket
        /// you specified using the <code>OutputBucketName</code> parameter in your request. If
        /// you also included <code>OutputKey</code> in your request, your output is located in
        /// the path you specified in your request.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>SERVICE_BUCKET</code>, the location is a service-managed Amazon
        /// S3 bucket. To access a transcript stored in a service-managed bucket, use the URI
        /// shown in the <code>TranscriptFileUri</code> or <code>RedactedTranscriptFileUri</code>
        /// field.
        /// </para>
        /// </summary>
        public OutputLocationType OutputLocationType
        {
            get { return this._outputLocationType; }
            set { this._outputLocationType = value; }
        }

        // Check to see if OutputLocationType property is set
        internal bool IsSetOutputLocationType()
        {
            return this._outputLocationType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time your transcription job began processing.
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
        /// Gets and sets the property ToxicityDetection. 
        /// <para>
        /// Indicates whether toxicity detection was enabled for the specified transcription job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ToxicityDetectionSettings> ToxicityDetection
        {
            get { return this._toxicityDetection; }
            set { this._toxicityDetection = value; }
        }

        // Check to see if ToxicityDetection property is set
        internal bool IsSetToxicityDetection()
        {
            return this._toxicityDetection != null && this._toxicityDetection.Count > 0; 
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
        /// Provides the status of your transcription job.
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