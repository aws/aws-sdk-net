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
    /// Indicates that the claims are logically false and contradictory to the established
    /// rules or premises.
    /// </summary>
    public partial class AutomatedReasoningCheckInvalidFinding
    {
        private List<AutomatedReasoningCheckRule> _contradictingRules = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckRule>() : null;
        private AutomatedReasoningCheckLogicWarning _logicWarning;
        private AutomatedReasoningCheckTranslation _translation;

        /// <summary>
        /// Gets and sets the property ContradictingRules. 
        /// <para>
        /// The automated reasoning policy rules that contradict the claims in the input.
        /// </para>
        /// </summary>
        public List<AutomatedReasoningCheckRule> ContradictingRules
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
        public AutomatedReasoningCheckLogicWarning LogicWarning
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
        /// The logical translation of the input that this finding invalidates.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckTranslation Translation
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