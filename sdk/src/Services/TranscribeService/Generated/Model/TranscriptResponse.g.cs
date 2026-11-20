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
    /// Your transcript and information about your audio.
    /// </summary>
    public partial class TranscriptResponse
    {
        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Information about your audio, such as the detected language, format, and sample rate.
        /// </para>
        /// </summary>
        public TranscribeAudioMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property RedactedResults. 
        /// <para>
        /// Your transcript with personally identifiable information (PII) redacted. Present only
        /// if you included <c>ContentRedaction</c> in your request.
        /// </para>
        /// </summary>
        public TranscribeAudioResults RedactedResults { get; set; }

        /// <summary>
        /// Checks to see if the RedactedResults property is set.
        /// </summary>
        internal bool IsSetRedactedResults() => this.RedactedResults != null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Your unredacted transcript.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>RedactionOutput</c> to <c>redacted</c>, Amazon Transcribe doesn't return
        /// this field. Use <c>RedactedResults</c> instead.
        /// </para>
        /// </summary>
        public TranscribeAudioResults Results { get; set; }

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results != null;
    }
}
