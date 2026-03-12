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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Results of clinical note generation including note, transcript, and summary
    /// </summary>
    public partial class ClinicalNoteGenerationResult
    {
        private ArtifactDetails _afterVisitSummaryResult;
        private ArtifactDetails _noteResult;
        private ArtifactDetails _transcriptResult;

        /// <summary>
        /// Gets and sets the property AfterVisitSummaryResult. 
        /// <para>
        /// Details about the generated after visit summary
        /// </para>
        /// </summary>
        public ArtifactDetails AfterVisitSummaryResult
        {
            get { return this._afterVisitSummaryResult; }
            set { this._afterVisitSummaryResult = value; }
        }

        // Check to see if AfterVisitSummaryResult property is set
        internal bool IsSetAfterVisitSummaryResult()
        {
            return this._afterVisitSummaryResult != null;
        }

        /// <summary>
        /// Gets and sets the property NoteResult. 
        /// <para>
        /// Details about the generated clinical note
        /// </para>
        /// </summary>
        public ArtifactDetails NoteResult
        {
            get { return this._noteResult; }
            set { this._noteResult = value; }
        }

        // Check to see if NoteResult property is set
        internal bool IsSetNoteResult()
        {
            return this._noteResult != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptResult. 
        /// <para>
        /// Details about the generated transcript
        /// </para>
        /// </summary>
        public ArtifactDetails TranscriptResult
        {
            get { return this._transcriptResult; }
            set { this._transcriptResult = value; }
        }

        // Check to see if TranscriptResult property is set
        internal bool IsSetTranscriptResult()
        {
            return this._transcriptResult != null;
        }

    }
}