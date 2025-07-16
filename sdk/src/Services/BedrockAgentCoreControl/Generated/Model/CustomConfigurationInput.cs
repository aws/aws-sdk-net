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
    /// Input for custom configuration of a memory strategy.
    /// </summary>
    public partial class CustomConfigurationInput
    {
        private SemanticOverrideConfigurationInput _semanticOverride;
        private SummaryOverrideConfigurationInput _summaryOverride;
        private UserPreferenceOverrideConfigurationInput _userPreferenceOverride;

        /// <summary>
        /// Gets and sets the property SemanticOverride. 
        /// <para>
        /// The semantic override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public SemanticOverrideConfigurationInput SemanticOverride
        {
            get { return this._semanticOverride; }
            set { this._semanticOverride = value; }
        }

        // Check to see if SemanticOverride property is set
        internal bool IsSetSemanticOverride()
        {
            return this._semanticOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryOverride. 
        /// <para>
        /// The summary override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public SummaryOverrideConfigurationInput SummaryOverride
        {
            get { return this._summaryOverride; }
            set { this._summaryOverride = value; }
        }

        // Check to see if SummaryOverride property is set
        internal bool IsSetSummaryOverride()
        {
            return this._summaryOverride != null;
        }

        /// <summary>
        /// Gets and sets the property UserPreferenceOverride. 
        /// <para>
        /// The user preference override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public UserPreferenceOverrideConfigurationInput UserPreferenceOverride
        {
            get { return this._userPreferenceOverride; }
            set { this._userPreferenceOverride = value; }
        }

        // Check to see if UserPreferenceOverride property is set
        internal bool IsSetUserPreferenceOverride()
        {
            return this._userPreferenceOverride != null;
        }

    }
}