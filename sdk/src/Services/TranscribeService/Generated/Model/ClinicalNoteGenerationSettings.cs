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
    /// The output configuration for clinical note generation.
    /// </summary>
    public partial class ClinicalNoteGenerationSettings
    {
        private MedicalScribeNoteTemplate _noteTemplate;

        /// <summary>
        /// Gets and sets the property NoteTemplate. 
        /// <para>
        /// Specify one of the following templates to use for the clinical note summary. The default
        /// is <c>HISTORY_AND_PHYSICAL</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HISTORY_AND_PHYSICAL: Provides summaries for key sections of the clinical documentation.
        /// Examples of sections include Chief Complaint, History of Present Illness, Review of
        /// Systems, Past Medical History, Assessment, and Plan. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GIRPP: Provides summaries based on the patients progress toward goals. Examples of
        /// sections include Goal, Intervention, Response, Progress, and Plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BIRP: Focuses on the patient's behavioral patterns and responses. Examples of sections
        /// include Behavior, Intervention, Response, and Plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SIRP: Emphasizes the situational context of therapy. Examples of sections include
        /// Situation, Intervention, Response, and Plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DAP: Provides a simplified format for clinical documentation. Examples of sections
        /// include Data, Assessment, and Plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BEHAVIORAL_SOAP: Behavioral health focused documentation format. Examples of sections
        /// include Subjective, Objective, Assessment, and Plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PHYSICAL_SOAP: Physical health focused documentation format. Examples of sections
        /// include Subjective, Objective, Assessment, and Plan.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MedicalScribeNoteTemplate NoteTemplate
        {
            get { return this._noteTemplate; }
            set { this._noteTemplate = value; }
        }

        // Check to see if NoteTemplate property is set
        internal bool IsSetNoteTemplate()
        {
            return this._noteTemplate != null;
        }

    }
}