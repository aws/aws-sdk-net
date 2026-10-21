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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Represents a logical validation result from automated reasoning policy evaluation.
    /// The finding indicates whether claims in the input are logically valid, invalid, satisfiable,
    /// impossible, or have other logical issues.
    /// </summary>
    public partial class GuardrailAutomatedReasoningFinding
    {
        /// <summary>
        /// Gets and sets the property Impossible. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that no valid
        /// logical conclusions can be drawn due to contradictions in the premises or policy rules
        /// themselves.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningImpossibleFinding Impossible { get; set; }

        /// <summary>
        /// Checks to see if the Impossible property is set.
        /// </summary>
        internal bool IsSetImpossible() => this.Impossible != null;

        /// <summary>
        /// Gets and sets the property Invalid. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input are logically invalid and contradict the established premises or policy
        /// rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningInvalidFinding Invalid { get; set; }

        /// <summary>
        /// Checks to see if the Invalid property is set.
        /// </summary>
        internal bool IsSetInvalid() => this.Invalid != null;

        /// <summary>
        /// Gets and sets the property NoTranslations. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation cannot extract any relevant
        /// logical information from the input that can be validated against the policy rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningNoTranslationsFinding NoTranslations { get; set; }

        /// <summary>
        /// Checks to see if the NoTranslations property is set.
        /// </summary>
        internal bool IsSetNoTranslations() => this.NoTranslations != null;

        /// <summary>
        /// Gets and sets the property Satisfiable. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input could be either true or false depending on additional assumptions not
        /// provided in the input context.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningSatisfiableFinding Satisfiable { get; set; }

        /// <summary>
        /// Checks to see if the Satisfiable property is set.
        /// </summary>
        internal bool IsSetSatisfiable() => this.Satisfiable != null;

        /// <summary>
        /// Gets and sets the property TooComplex. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation cannot process the input
        /// due to its complexity or volume exceeding the system's processing capacity for logical
        /// analysis.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningTooComplexFinding TooComplex { get; set; }

        /// <summary>
        /// Checks to see if the TooComplex property is set.
        /// </summary>
        internal bool IsSetTooComplex() => this.TooComplex != null;

        /// <summary>
        /// Gets and sets the property TranslationAmbiguous. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation detects that the input
        /// has multiple valid logical interpretations, requiring additional context or clarification
        /// to proceed with validation.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningTranslationAmbiguousFinding TranslationAmbiguous { get; set; }

        /// <summary>
        /// Checks to see if the TranslationAmbiguous property is set.
        /// </summary>
        internal bool IsSetTranslationAmbiguous() => this.TranslationAmbiguous != null;

        /// <summary>
        /// Gets and sets the property Valid. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input are logically valid and definitively true based on the provided premises
        /// and policy rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningValidFinding Valid { get; set; }

        /// <summary>
        /// Checks to see if the Valid property is set.
        /// </summary>
        internal bool IsSetValid() => this.Valid != null;
    }
}
