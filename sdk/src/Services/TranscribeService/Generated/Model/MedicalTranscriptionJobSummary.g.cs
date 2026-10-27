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
    /// Provides detailed information about a specific medical transcription job.
    /// </summary>
    public partial class MedicalTranscriptionJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified medical transcription job finished processing.
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
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personal health information (PHI) identified in your transcript. For more
        /// information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/phi-id.html">Identifying
        /// personal health information (PHI) in a transcription</a>.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified medical transcription job request was made.
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your medical transcription. US English (<c>en-US</c>)
        /// is the only supported language for medical transcriptions.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MedicalTranscriptionJobName. 
        /// <para>
        /// The name of the medical transcription job. Job names are case sensitive and must be
        /// unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string MedicalTranscriptionJobName { get; set; }

        /// <summary>
        /// Checks to see if the MedicalTranscriptionJobName property is set.
        /// </summary>
        internal bool IsSetMedicalTranscriptionJobName() => this.MedicalTranscriptionJobName != null;

        /// <summary>
        /// Gets and sets the property OutputLocationType. 
        /// <para>
        /// Indicates where the specified medical transcription output is stored.
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
        /// in the <c>TranscriptFileUri</c> field.
        /// </para>
        /// </summary>
        public OutputLocationType OutputLocationType { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocationType property is set.
        /// </summary>
        internal bool IsSetOutputLocationType() => this.OutputLocationType != null;

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// Provides the medical specialty represented in your media.
        /// </para>
        /// </summary>
        public Specialty Specialty { get; set; }

        /// <summary>
        /// Checks to see if the Specialty property is set.
        /// </summary>
        internal bool IsSetSpecialty() => this.Specialty != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time your medical transcription job began processing.
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
        /// Gets and sets the property TranscriptionJobStatus. 
        /// <para>
        /// Provides the status of your medical transcription job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED</c>, the job is finished and you can find the results
        /// at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your transcription job failed.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus TranscriptionJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptionJobStatus property is set.
        /// </summary>
        internal bool IsSetTranscriptionJobStatus() => this.TranscriptionJobStatus != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the input media is a dictation or a conversation, as specified in
        /// the <c>StartMedicalTranscriptionJob</c> request.
        /// </para>
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
