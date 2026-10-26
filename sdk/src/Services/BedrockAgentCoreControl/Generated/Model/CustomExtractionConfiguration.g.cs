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
    /// Contains custom extraction configuration information.
    /// </summary>
    public partial class CustomExtractionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EpisodicExtractionOverride. 
        /// <para>
        /// The configurations to override the default extraction step for the episodic memory
        /// strategy.
        /// </para>
        /// </summary>
        public EpisodicExtractionOverride EpisodicExtractionOverride { get; set; }

        /// <summary>
        /// Checks to see if the EpisodicExtractionOverride property is set.
        /// </summary>
        internal bool IsSetEpisodicExtractionOverride() => this.EpisodicExtractionOverride != null;

        /// <summary>
        /// Gets and sets the property SemanticExtractionOverride. 
        /// <para>
        /// The semantic extraction override configuration.
        /// </para>
        /// </summary>
        public SemanticExtractionOverride SemanticExtractionOverride { get; set; }

        /// <summary>
        /// Checks to see if the SemanticExtractionOverride property is set.
        /// </summary>
        internal bool IsSetSemanticExtractionOverride() => this.SemanticExtractionOverride != null;

        /// <summary>
        /// Gets and sets the property UserPreferenceExtractionOverride. 
        /// <para>
        /// The user preference extraction override configuration.
        /// </para>
        /// </summary>
        public UserPreferenceExtractionOverride UserPreferenceExtractionOverride { get; set; }

        /// <summary>
        /// Checks to see if the UserPreferenceExtractionOverride property is set.
        /// </summary>
        internal bool IsSetUserPreferenceExtractionOverride() => this.UserPreferenceExtractionOverride != null;
    }
}
