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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Indicates that no valid claims can be made due to logical contradictions in the premises
    /// or rules.
    /// </summary>
    public partial class AutomatedReasoningCheckImpossibleFinding
    {
        /// <summary>
        /// Gets and sets the property ContradictingRules. 
        /// <para>
        /// The automated reasoning policy rules that contradict the claims and/or premises in
        /// the input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckRule> ContradictingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckRule>() : null;

        /// <summary>
        /// Checks to see if the ContradictingRules property is set.
        /// </summary>
        internal bool IsSetContradictingRules() => this.ContradictingRules != null && (this.ContradictingRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogicWarning. 
        /// <para>
        /// Indication of a logic issue with the translation without needing to consider the automated
        /// reasoning policy rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckLogicWarning LogicWarning { get; set; }

        /// <summary>
        /// Checks to see if the LogicWarning property is set.
        /// </summary>
        internal bool IsSetLogicWarning() => this.LogicWarning != null;

        /// <summary>
        /// Gets and sets the property Translation. 
        /// <para>
        /// The logical translation of the input that this finding evaluates.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckTranslation Translation { get; set; }

        /// <summary>
        /// Checks to see if the Translation property is set.
        /// </summary>
        internal bool IsSetTranslation() => this.Translation != null;
    }
}
