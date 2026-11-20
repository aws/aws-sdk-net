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
    /// This is the response object from the TranscribeAudio operation.
    /// </summary>
    public partial class TranscribeAudioResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The Amazon S3 location where your transcript was written. Present only if you included
        /// <c>OutputConfiguration</c> in your request. In that case, <c>TranscriptResponse</c>
        /// isn't returned.
        /// </para>
        /// </summary>
        public SyncOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property TranscriptResponse. 
        /// <para>
        /// Your transcript and information about your audio. Present only if you didn't include
        /// <c>OutputConfiguration</c> in your request.
        /// </para>
        /// </summary>
        public TranscriptResponse TranscriptResponse { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptResponse property is set.
        /// </summary>
        internal bool IsSetTranscriptResponse() => this.TranscriptResponse != null;
    }
}
