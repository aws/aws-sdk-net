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
    /// Settings for generating clinical notes from the audio stream
    /// </summary>
    public partial class ClinicalNoteGenerationSettings
    {
        private NoteTemplateSettings _noteTemplateSettings;

        /// <summary>
        /// Gets and sets the property NoteTemplateSettings. 
        /// <para>
        /// Settings for the note template to use
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NoteTemplateSettings NoteTemplateSettings
        {
            get { return this._noteTemplateSettings; }
            set { this._noteTemplateSettings = value; }
        }

        // Check to see if NoteTemplateSettings property is set
        internal bool IsSetNoteTemplateSettings()
        {
            return this._noteTemplateSettings != null;
        }

    }
}