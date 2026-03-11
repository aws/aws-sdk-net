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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents the result of an Automated Reasoning validation check, indicating whether
    /// the content is logically valid, invalid, or falls into other categories based on the
    /// policy rules.
    /// </summary>
    public partial class AutomatedReasoningCheckFinding
    {
        private AutomatedReasoningCheckImpossibleFinding _impossible;
        private AutomatedReasoningCheckInvalidFinding _invalid;
        private AutomatedReasoningCheckNoTranslationsFinding _noTranslations;
        private AutomatedReasoningCheckSatisfiableFinding _satisfiable;
        private AutomatedReasoningCheckTooComplexFinding _tooComplex;
        private AutomatedReasoningCheckTranslationAmbiguousFinding _translationAmbiguous;
        private AutomatedReasoningCheckValidFinding _valid;

        /// <summary>
        /// Gets and sets the property Impossible. 
        /// <para>
        /// Indicates that Automated Reasoning cannot make a statement about the claims. This
        /// can happen if the premises are logically incorrect, or if there is a conflict within
        /// the Automated Reasoning policy itself.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckImpossibleFinding Impossible
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
        /// Indicates that the claims are false. The claims are not implied by the premises and
        /// Automated Reasoning policy. Furthermore, there exist different claims that are consistent
        /// with the premises and Automated Reasoning policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckInvalidFinding Invalid
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
        /// Identifies that some or all of the input prompt wasn't translated into logic. This
        /// can happen if the input isn't relevant to the Automated Reasoning policy, or if the
        /// policy doesn't have variables to model relevant input.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckNoTranslationsFinding NoTranslations
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
        /// Indicates that the claims can be true or false. It depends on what assumptions are
        /// made for the claim to be implied from the premises and Automated Reasoning policy
        /// rules. In this situation, different assumptions can make input claims false and alternative
        /// claims true.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckSatisfiableFinding Satisfiable
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
        /// Indicates that the input contains too much information for Automated Reasoning to
        /// process within its latency limits.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckTooComplexFinding TooComplex
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
        /// Indicates that an ambiguity was detected in the translation, making it unsound to
        /// continue with validity checking. Additional context or follow-up questions might be
        /// needed to get translation to succeed.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckTranslationAmbiguousFinding TranslationAmbiguous
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
        /// Indicates that the claims are true. The claims are implied by the premises and the
        /// Automated Reasoning policy. Given the Automated Reasoning policy and premises, it
        /// is not possible for these claims to be false.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckValidFinding Valid
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