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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Input for a custom consolidation configuration.
    /// </summary>
    public partial class CustomConsolidationConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property EpisodicConsolidationOverride. 
        /// <para>
        /// Configurations to override the consolidation step of the episodic strategy.
        /// </para>
        /// </summary>
        public EpisodicOverrideConsolidationConfigurationInput EpisodicConsolidationOverride { get; set; }

        /// <summary>
        /// Checks to see if the EpisodicConsolidationOverride property is set.
        /// </summary>
        internal bool IsSetEpisodicConsolidationOverride() => this.EpisodicConsolidationOverride != null;

        /// <summary>
        /// Gets and sets the property SemanticConsolidationOverride. 
        /// <para>
        /// The semantic consolidation override configuration input.
        /// </para>
        /// </summary>
        public SemanticOverrideConsolidationConfigurationInput SemanticConsolidationOverride { get; set; }

        /// <summary>
        /// Checks to see if the SemanticConsolidationOverride property is set.
        /// </summary>
        internal bool IsSetSemanticConsolidationOverride() => this.SemanticConsolidationOverride != null;

        /// <summary>
        /// Gets and sets the property SummaryConsolidationOverride. 
        /// <para>
        /// The summary consolidation override configuration input.
        /// </para>
        /// </summary>
        public SummaryOverrideConsolidationConfigurationInput SummaryConsolidationOverride { get; set; }

        /// <summary>
        /// Checks to see if the SummaryConsolidationOverride property is set.
        /// </summary>
        internal bool IsSetSummaryConsolidationOverride() => this.SummaryConsolidationOverride != null;

        /// <summary>
        /// Gets and sets the property UserPreferenceConsolidationOverride. 
        /// <para>
        /// The user preference consolidation override configuration input.
        /// </para>
        /// </summary>
        public UserPreferenceOverrideConsolidationConfigurationInput UserPreferenceConsolidationOverride { get; set; }

        /// <summary>
        /// Checks to see if the UserPreferenceConsolidationOverride property is set.
        /// </summary>
        internal bool IsSetUserPreferenceConsolidationOverride() => this.UserPreferenceConsolidationOverride != null;
    }
}
