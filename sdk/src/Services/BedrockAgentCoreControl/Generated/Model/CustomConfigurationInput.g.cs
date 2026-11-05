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
    /// Input for custom configuration of a memory strategy.
    /// </summary>
    public partial class CustomConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property EpisodicOverride. 
        /// <para>
        /// The episodic memory strategy override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public EpisodicOverrideConfigurationInput EpisodicOverride { get; set; }

        /// <summary>
        /// Checks to see if the EpisodicOverride property is set.
        /// </summary>
        internal bool IsSetEpisodicOverride() => this.EpisodicOverride != null;

        /// <summary>
        /// Gets and sets the property SelfManagedConfiguration. 
        /// <para>
        /// The self managed configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public SelfManagedConfigurationInput SelfManagedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedConfiguration() => this.SelfManagedConfiguration != null;

        /// <summary>
        /// Gets and sets the property SemanticOverride. 
        /// <para>
        /// The semantic override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public SemanticOverrideConfigurationInput SemanticOverride { get; set; }

        /// <summary>
        /// Checks to see if the SemanticOverride property is set.
        /// </summary>
        internal bool IsSetSemanticOverride() => this.SemanticOverride != null;

        /// <summary>
        /// Gets and sets the property SummaryOverride. 
        /// <para>
        /// The summary override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public SummaryOverrideConfigurationInput SummaryOverride { get; set; }

        /// <summary>
        /// Checks to see if the SummaryOverride property is set.
        /// </summary>
        internal bool IsSetSummaryOverride() => this.SummaryOverride != null;

        /// <summary>
        /// Gets and sets the property UserPreferenceOverride. 
        /// <para>
        /// The user preference override configuration for a custom memory strategy.
        /// </para>
        /// </summary>
        public UserPreferenceOverrideConfigurationInput UserPreferenceOverride { get; set; }

        /// <summary>
        /// Checks to see if the UserPreferenceOverride property is set.
        /// </summary>
        internal bool IsSetUserPreferenceOverride() => this.UserPreferenceOverride != null;
    }
}
