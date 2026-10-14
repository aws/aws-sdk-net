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
    /// The location of the output of your Medical Scribe job. <c>ClinicalDocumentUri</c>
    /// holds the Amazon S3 URI for the Clinical Document and <c>TranscriptFileUri</c> holds
    /// the Amazon S3 URI for the Transcript.
    /// </summary>
    public partial class MedicalScribeOutput
    {
        /// <summary>
        /// Gets and sets the property ClinicalDocumentUri. 
        /// <para>
        /// Holds the Amazon S3 URI for the Clinical Document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string ClinicalDocumentUri { get; set; }

        /// <summary>
        /// Checks to see if the ClinicalDocumentUri property is set.
        /// </summary>
        internal bool IsSetClinicalDocumentUri() => this.ClinicalDocumentUri != null;

        /// <summary>
        /// Gets and sets the property TranscriptFileUri. 
        /// <para>
        /// Holds the Amazon S3 URI for the Transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string TranscriptFileUri { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFileUri property is set.
        /// </summary>
        internal bool IsSetTranscriptFileUri() => this.TranscriptFileUri != null;
    }
}
