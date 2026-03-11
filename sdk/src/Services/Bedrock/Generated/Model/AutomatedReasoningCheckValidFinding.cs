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
    /// Indicates that the claims are definitively true and logically implied by the premises,
    /// with no possible alternative interpretations.
    /// </summary>
    public partial class AutomatedReasoningCheckValidFinding
    {
        private AutomatedReasoningCheckScenario _claimsTrueScenario;
        private AutomatedReasoningCheckLogicWarning _logicWarning;
        private List<AutomatedReasoningCheckRule> _supportingRules = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckRule>() : null;
        private AutomatedReasoningCheckTranslation _translation;

        /// <summary>
        /// Gets and sets the property ClaimsTrueScenario. 
        /// <para>
        /// An example scenario demonstrating how the claims are logically true.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckScenario ClaimsTrueScenario
        {
            get { return this._claimsTrueScenario; }
            set { this._claimsTrueScenario = value; }
        }

        // Check to see if ClaimsTrueScenario property is set
        internal bool IsSetClaimsTrueScenario()
        {
            return this._claimsTrueScenario != null;
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
        /// Gets and sets the property SupportingRules. 
        /// <para>
        /// The automated reasoning policy rules that support why this result is considered valid.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckRule> SupportingRules
        {
            get { return this._supportingRules; }
            set { this._supportingRules = value; }
        }

        // Check to see if SupportingRules property is set
        internal bool IsSetSupportingRules()
        {
            return this._supportingRules != null && (this._supportingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Translation. 
        /// <para>
        /// The logical translation of the input that this finding validates.
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