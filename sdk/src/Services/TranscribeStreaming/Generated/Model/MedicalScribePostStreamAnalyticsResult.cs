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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains details for the result of post-stream analytics.
    /// </summary>
    public partial class MedicalScribePostStreamAnalyticsResult
    {
        private ClinicalNoteGenerationResult _clinicalNoteGenerationResult;

        /// <summary>
        /// Gets and sets the property ClinicalNoteGenerationResult. 
        /// <para>
        /// Provides the Clinical Note Generation result for post-stream analytics.
        /// </para>
        /// </summary>
        public ClinicalNoteGenerationResult ClinicalNoteGenerationResult
        {
            get { return this._clinicalNoteGenerationResult; }
            set { this._clinicalNoteGenerationResult = value; }
        }

        // Check to see if ClinicalNoteGenerationResult property is set
        internal bool IsSetClinicalNoteGenerationResult()
        {
            return this._clinicalNoteGenerationResult != null;
        }

    }
}