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
    /// Container for the parameters to the GetTranscriptionJob operation.
    /// Provides information about the specified transcription job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified transcription job, check the <code>TranscriptionJobStatus</code>
    /// field. If the status is <code>COMPLETED</code>, the job is finished. You can find
    /// the results at the location specified in <code>TranscriptFileUri</code>. If the status
    /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
    /// job failed.
    /// </para>
    ///  
    /// <para>
    /// If you enabled content redaction, the redacted transcript can be found at the location
    /// specified in <code>RedactedTranscriptFileUri</code>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of your transcription jobs, use the operation.
    /// </para>
    /// </summary>
    public partial class GetTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private string _transcriptionJobName;

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// The name of the transcription job you want information about. Job names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

    }
}