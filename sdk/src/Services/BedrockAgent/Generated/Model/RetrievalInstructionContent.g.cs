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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The instruction content, as a set of named fields. Every field is optional; at least
    /// one must be present. Service-side validation enforces per-field and aggregate size
    /// limits.
    /// </summary>
    public partial class RetrievalInstructionContent
    {
        /// <summary>
        /// Gets and sets the property AnswerFormat. 
        /// <para>
        /// How the answer is structured, including how sources are cited.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string AnswerFormat { get; set; }

        /// <summary>
        /// Checks to see if the AnswerFormat property is set.
        /// </summary>
        internal bool IsSetAnswerFormat() => this.AnswerFormat != null;

        /// <summary>
        /// Gets and sets the property AnswerPolicy. 
        /// <para>
        /// Whether and how to answer: how strongly an answer must be supported, and what to do
        /// with questions outside scope.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string AnswerPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AnswerPolicy property is set.
        /// </summary>
        internal bool IsSetAnswerPolicy() => this.AnswerPolicy != null;

        /// <summary>
        /// Gets and sets the property Persona. 
        /// <para>
        /// Who the assistant is: identity, tone and language.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string Persona { get; set; }

        /// <summary>
        /// Checks to see if the Persona property is set.
        /// </summary>
        internal bool IsSetPersona() => this.Persona != null;

        /// <summary>
        /// Gets and sets the property RetrievalGuidance. 
        /// <para>
        /// How to interpret and decompose the question, and what to prioritise when searching.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string RetrievalGuidance { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalGuidance property is set.
        /// </summary>
        internal bool IsSetRetrievalGuidance() => this.RetrievalGuidance != null;
    }
}
