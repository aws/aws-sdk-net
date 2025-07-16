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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Input for a custom consolidation configuration.
    /// </summary>
    public partial class CustomConsolidationConfigurationInput
    {
        private SemanticOverrideConsolidationConfigurationInput _semanticConsolidationOverride;
        private SummaryOverrideConsolidationConfigurationInput _summaryConsolidationOverride;
        private UserPreferenceOverrideConsolidationConfigurationInput _userPreferenceConsolidationOverride;

        /// <summary>
        /// Gets and sets the property SemanticConsolidationOverride. 
        /// <para>
        /// The semantic consolidation override configuration input.
        /// </para>
        /// </summary>
        public SemanticOverrideConsolidationConfigurationInput SemanticConsolidationOverride
        {
            get { return this._semanticConsolidationOverride; }
            set { this._semanticConsolidationOverride = value; }
        }

        // Check to see if SemanticConsolidationOverride property is set
        internal bool IsSetSemanticConsolidationOverride()
        {
            return this._semanticConsolidationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryConsolidationOverride. 
        /// <para>
        /// The summary consolidation override configuration input.
        /// </para>
        /// </summary>
        public SummaryOverrideConsolidationConfigurationInput SummaryConsolidationOverride
        {
            get { return this._summaryConsolidationOverride; }
            set { this._summaryConsolidationOverride = value; }
        }

        // Check to see if SummaryConsolidationOverride property is set
        internal bool IsSetSummaryConsolidationOverride()
        {
            return this._summaryConsolidationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property UserPreferenceConsolidationOverride. 
        /// <para>
        /// The user preference consolidation override configuration input.
        /// </para>
        /// </summary>
        public UserPreferenceOverrideConsolidationConfigurationInput UserPreferenceConsolidationOverride
        {
            get { return this._userPreferenceConsolidationOverride; }
            set { this._userPreferenceConsolidationOverride = value; }
        }

        // Check to see if UserPreferenceConsolidationOverride property is set
        internal bool IsSetUserPreferenceConsolidationOverride()
        {
            return this._userPreferenceConsolidationOverride != null;
        }

    }
}