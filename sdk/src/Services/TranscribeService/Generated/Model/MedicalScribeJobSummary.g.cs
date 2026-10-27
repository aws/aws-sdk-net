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
    /// Provides detailed information about a specific Medical Scribe job.
    /// </summary>
    public partial class MedicalScribeJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified Medical Scribe job finished processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents a Medical Scribe job that finished
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified Medical Scribe job request was made.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents a Medical Scribe job that started
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
        /// If <c>MedicalScribeJobStatus</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
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
        /// The language code used to create your Medical Scribe job. US English (<c>en-US</c>)
        /// is the only supported language for Medical Scribe jobs. 
        /// </para>
        /// </summary>
        public MedicalScribeLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MedicalScribeJobName. 
        /// <para>
        /// The name of the Medical Scribe job. Job names are case sensitive and must be unique
        /// within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string MedicalScribeJobName { get; set; }

        /// <summary>
        /// Checks to see if the MedicalScribeJobName property is set.
        /// </summary>
        internal bool IsSetMedicalScribeJobName() => this.MedicalScribeJobName != null;

        /// <summary>
        /// Gets and sets the property MedicalScribeJobStatus. 
        /// <para>
        /// Provides the status of the specified Medical Scribe job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED</c>, the job is finished and you can find the results
        /// at the location specified in <c>MedicalScribeOutput</c> If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your Medical Scribe job failed.
        /// </para>
        /// </summary>
        public MedicalScribeJobStatus MedicalScribeJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the MedicalScribeJobStatus property is set.
        /// </summary>
        internal bool IsSetMedicalScribeJobStatus() => this.MedicalScribeJobStatus != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time your Medical Scribe job began processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.789000-07:00</c> represents a Medical Scribe job that started
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
