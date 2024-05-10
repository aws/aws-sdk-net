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
    /// This is the response object from the GetTranscriptionJob operation.
    /// </summary>
    public partial class GetTranscriptionJobResponse : AmazonWebServiceResponse
    {
        private TranscriptionJob _transcriptionJob;

        /// <summary>
        /// Gets and sets the property TranscriptionJob. 
        /// <para>
        /// Provides detailed information about the specified transcription job, including job
        /// status and, if applicable, failure reason.
        /// </para>
        /// </summary>
        public TranscriptionJob TranscriptionJob
        {
            get { return this._transcriptionJob; }
            set { this._transcriptionJob = value; }
        }

        // Check to see if TranscriptionJob property is set
        internal bool IsSetTranscriptionJob()
        {
            return this._transcriptionJob != null;
        }

    }
}