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
    /// Indicates that no valid claims can be made due to logical contradictions in the premises
    /// or rules.
    /// </summary>
    public partial class GuardrailAutomatedReasoningImpossibleFinding
    {
        private List<GuardrailAutomatedReasoningRule> _contradictingRules = AWSConfigs.InitializeCollections ? new List<GuardrailAutomatedReasoningRule>() : null;
        private GuardrailAutomatedReasoningLogicWarning _logicWarning;
        private GuardrailAutomatedReasoningTranslation _translation;

        /// <summary>
        /// Gets and sets the property ContradictingRules. 
        /// <para>
        /// The automated reasoning policy rules that contradict the claims and/or premises in
        /// the input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailAutomatedReasoningRule> ContradictingRules
        {
            get { return this._contradictingRules; }
            set { this._contradictingRules = value; }
        }

        // Check to see if ContradictingRules property is set
        internal bool IsSetContradictingRules()
        {
            return this._contradictingRules != null && (this._contradictingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogicWarning. 
        /// <para>
        /// Indication of a logic issue with the translation without needing to consider the automated
        /// reasoning policy rules.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningLogicWarning LogicWarning
        {
            get { return this._logicWarning; }
            set { this._logicWarning = value; }
        }

        // Check to see if LogicWarning property is set
        internal bool IsSetLogicWarning()
        {
            return this._logicWarning != null;
        }

        /// <summary>
        /// Gets and sets the property Translation. 
        /// <para>
        /// The logical translation of the input that this finding evaluates.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningTranslation Translation
        {
            get { return this._translation; }
            set { this._translation = value; }
        }

        // Check to see if Translation property is set
        internal bool IsSetTranslation()
        {
            return this._translation != null;
        }

    }
}