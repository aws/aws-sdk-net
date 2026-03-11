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
    /// Contains patient-specific information used to customize the clinical note generation.
    /// </summary>
    public partial class MedicalScribePatientContext
    {
        private Pronouns _pronouns;

        /// <summary>
        /// Gets and sets the property Pronouns. 
        /// <para>
        /// The patient's preferred pronouns that the user wants to provide as a context for clinical
        /// note generation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Pronouns Pronouns
        {
            get { return this._pronouns; }
            set { this._pronouns = value; }
        }

        // Check to see if Pronouns property is set
        internal bool IsSetPronouns()
        {
            return this._pronouns != null;
        }

    }
}