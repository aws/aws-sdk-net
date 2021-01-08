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
    /// Identifies the location of a transcription.
    /// </summary>
    public partial class Transcript
    {
        private string _redactedTranscriptFileUri;
        private string _transcriptFileUri;

        /// <summary>
        /// Gets and sets the property RedactedTranscriptFileUri. 
        /// <para>
        /// The S3 object location of the redacted transcript.
        /// </para>
        ///  
        /// <para>
        /// Use this URI to access the redacted transcript. If you specified an S3 bucket in the
        /// <code>OutputBucketName</code> field when you created the job, this is the URI of that
        /// bucket. If you chose to store the transcript in Amazon Transcribe, this is a shareable
        /// URL that provides secure access to that location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string RedactedTranscriptFileUri
        {
            get { return this._redactedTranscriptFileUri; }
            set { this._redactedTranscriptFileUri = value; }
        }

        // Check to see if RedactedTranscriptFileUri property is set
        internal bool IsSetRedactedTranscriptFileUri()
        {
            return this._redactedTranscriptFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptFileUri. 
        /// <para>
        /// The S3 object location of the transcript.
        /// </para>
        ///  
        /// <para>
        /// Use this URI to access the transcript. If you specified an S3 bucket in the <code>OutputBucketName</code>
        /// field when you created the job, this is the URI of that bucket. If you chose to store
        /// the transcript in Amazon Transcribe, this is a shareable URL that provides secure
        /// access to that location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TranscriptFileUri
        {
            get { return this._transcriptFileUri; }
            set { this._transcriptFileUri = value; }
        }

        // Check to see if TranscriptFileUri property is set
        internal bool IsSetTranscriptFileUri()
        {
            return this._transcriptFileUri != null;
        }

    }
}