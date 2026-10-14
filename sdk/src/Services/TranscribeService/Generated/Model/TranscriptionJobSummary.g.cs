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
    /// Provides detailed information about a specific transcription job.
    /// </summary>
    public partial class TranscriptionJobSummary
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
        /// The content redaction settings of the transcription job.
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
        /// about why the transcription job failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your transcription.
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
        /// multi-language identification. For single-language identification, the singular version
        /// of this parameter, <c>LanguageCode</c>, is present.
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
        /// Gets and sets the property ModelSettings.
        /// </summary>
        public ModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Checks to see if the ModelSettings property is set.
        /// </summary>
        internal bool IsSetModelSettings() => this.ModelSettings != null;

        /// <summary>
        /// Gets and sets the property OutputLocationType. 
        /// <para>
        /// Indicates where the specified transcription output is stored.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>CUSTOMER_BUCKET</c>, the location is the Amazon S3 bucket you specified
        /// using the <c>OutputBucketName</c> parameter in your request. If you also included
        /// <c>OutputKey</c> in your request, your output is located in the path you specified
        /// in your request.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>SERVICE_BUCKET</c>, the location is a service-managed Amazon S3
        /// bucket. To access a transcript stored in a service-managed bucket, use the URI shown
        /// in the <c>TranscriptFileUri</c> or <c>RedactedTranscriptFileUri</c> field.
        /// </para>
        /// </summary>
        public OutputLocationType OutputLocationType { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocationType property is set.
        /// </summary>
        internal bool IsSetOutputLocationType() => this.OutputLocationType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time your transcription job began processing.
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
        /// Gets and sets the property ToxicityDetection. 
        /// <para>
        /// Indicates whether toxicity detection was enabled for the specified transcription job.
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
        /// Provides the status of your transcription job.
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
