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
    /// The Amazon S3 location where your transcript is written.
    /// </summary>
    public partial class SyncOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property OutputMediaFileUri. 
        /// <para>
        /// The Amazon S3 location where you want your transcript written. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/my-transcript.json</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/transcripts/</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the location ends with an object key, Amazon Transcribe writes the transcript to
        /// that key. If it is a bucket or ends with a forward slash (<c>/</c>), it's treated
        /// as a prefix, and Amazon Transcribe writes the transcript under it to a file named
        /// with the request ID of your call and a <c>.json</c> extension.
        /// </para>
        ///  
        /// <para>
        /// If you use <c>ContentRedaction</c>, Amazon Transcribe writes the redacted transcript
        /// to the same location and adds <c>redacted-</c> before the file name (for example,
        /// <c>redacted-my-transcript.json</c>). With <c>redacted_and_unredacted</c>, Amazon Transcribe
        /// writes both files.
        /// </para>
        ///  
        /// <para>
        /// If an object already exists at that key, Amazon Transcribe overwrites it.
        /// </para>
        ///  
        /// <para>
        /// In a response, this is the location where Amazon Transcribe wrote your transcript.
        /// If you requested <c>redacted_and_unredacted</c> output, this is the location of the
        /// unredacted transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string OutputMediaFileUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputMediaFileUri property is set.
        /// </summary>
        internal bool IsSetOutputMediaFileUri() => this.OutputMediaFileUri != null;
    }
}
