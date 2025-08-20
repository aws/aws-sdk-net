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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
        private GuardrailAutomatedReasoningImpossibleFinding _impossible;
        private GuardrailAutomatedReasoningInvalidFinding _invalid;
        private GuardrailAutomatedReasoningNoTranslationsFinding _noTranslations;
        private GuardrailAutomatedReasoningSatisfiableFinding _satisfiable;
        private GuardrailAutomatedReasoningTooComplexFinding _tooComplex;
        private GuardrailAutomatedReasoningTranslationAmbiguousFinding _translationAmbiguous;
        private GuardrailAutomatedReasoningValidFinding _valid;

        /// <summary>
        /// Gets and sets the property Impossible. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that no valid
        /// logical conclusions can be drawn due to contradictions in the premises or policy rules
        /// themselves.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningImpossibleFinding Impossible
        {
            get { return this._impossible; }
            set { this._impossible = value; }
        }

        // Check to see if Impossible property is set
        internal bool IsSetImpossible()
        {
            return this._impossible != null;
        }

        /// <summary>
        /// Gets and sets the property Invalid. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input are logically invalid and contradict the established premises or policy
        /// rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningInvalidFinding Invalid
        {
            get { return this._invalid; }
            set { this._invalid = value; }
        }

        // Check to see if Invalid property is set
        internal bool IsSetInvalid()
        {
            return this._invalid != null;
        }

        /// <summary>
        /// Gets and sets the property NoTranslations. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation cannot extract any relevant
        /// logical information from the input that can be validated against the policy rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningNoTranslationsFinding NoTranslations
        {
            get { return this._noTranslations; }
            set { this._noTranslations = value; }
        }

        // Check to see if NoTranslations property is set
        internal bool IsSetNoTranslations()
        {
            return this._noTranslations != null;
        }

        /// <summary>
        /// Gets and sets the property Satisfiable. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input could be either true or false depending on additional assumptions not
        /// provided in the input context.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningSatisfiableFinding Satisfiable
        {
            get { return this._satisfiable; }
            set { this._satisfiable = value; }
        }

        // Check to see if Satisfiable property is set
        internal bool IsSetSatisfiable()
        {
            return this._satisfiable != null;
        }

        /// <summary>
        /// Gets and sets the property TooComplex. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation cannot process the input
        /// due to its complexity or volume exceeding the system's processing capacity for logical
        /// analysis.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningTooComplexFinding TooComplex
        {
            get { return this._tooComplex; }
            set { this._tooComplex = value; }
        }

        // Check to see if TooComplex property is set
        internal bool IsSetTooComplex()
        {
            return this._tooComplex != null;
        }

        /// <summary>
        /// Gets and sets the property TranslationAmbiguous. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation detects that the input
        /// has multiple valid logical interpretations, requiring additional context or clarification
        /// to proceed with validation.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningTranslationAmbiguousFinding TranslationAmbiguous
        {
            get { return this._translationAmbiguous; }
            set { this._translationAmbiguous = value; }
        }

        // Check to see if TranslationAmbiguous property is set
        internal bool IsSetTranslationAmbiguous()
        {
            return this._translationAmbiguous != null;
        }

        /// <summary>
        /// Gets and sets the property Valid. 
        /// <para>
        /// Contains the result when the automated reasoning evaluation determines that the claims
        /// in the input are logically valid and definitively true based on the provided premises
        /// and policy rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningValidFinding Valid
        {
            get { return this._valid; }
            set { this._valid = value; }
        }

        // Check to see if Valid property is set
        internal bool IsSetValid()
        {
            return this._valid != null;
        }

    }
}