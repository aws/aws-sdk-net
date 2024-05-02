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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the GetCallAnalyticsJob operation.
    /// Provides information about the specified Call Analytics job.
    /// 
    ///  
    /// <para>
    /// To view the job's status, refer to <c>CallAnalyticsJobStatus</c>. If the status is
    /// <c>COMPLETED</c>, the job is finished. You can find your completed transcript at the
    /// URI specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>, <c>FailureReason</c>
    /// provides details on why your transcription job failed.
    /// </para>
    ///  
    /// <para>
    /// If you enabled personally identifiable information (PII) redaction, the redacted transcript
    /// appears at the location specified in <c>RedactedTranscriptFileUri</c>.
    /// </para>
    ///  
    /// <para>
    /// If you chose to redact the audio in your media file, you can find your redacted media
    /// file at the location specified in <c>RedactedMediaFileUri</c>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of your Call Analytics jobs, use the operation.
    /// </para>
    /// </summary>
    public partial class GetCallAnalyticsJobRequest : AmazonTranscribeServiceRequest
    {
        private string _callAnalyticsJobName;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobName. 
        /// <para>
        /// The name of the Call Analytics job you want information about. Job names are case
        /// sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

    }
}