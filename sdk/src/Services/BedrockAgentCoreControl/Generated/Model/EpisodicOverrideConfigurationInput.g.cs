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
    /// Input for the configuration to override the episodic memory strategy.
    /// </summary>
    public partial class EpisodicOverrideConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property Consolidation. 
        /// <para>
        /// Contains configurations for overriding the consolidation step of the episodic memory
        /// strategy.
        /// </para>
        /// </summary>
        public EpisodicOverrideConsolidationConfigurationInput Consolidation { get; set; }

        /// <summary>
        /// Checks to see if the Consolidation property is set.
        /// </summary>
        internal bool IsSetConsolidation() => this.Consolidation != null;

        /// <summary>
        /// Gets and sets the property Extraction. 
        /// <para>
        /// Contains configurations for overriding the extraction step of the episodic memory
        /// strategy.
        /// </para>
        /// </summary>
        public EpisodicOverrideExtractionConfigurationInput Extraction { get; set; }

        /// <summary>
        /// Checks to see if the Extraction property is set.
        /// </summary>
        internal bool IsSetExtraction() => this.Extraction != null;

        /// <summary>
        /// Gets and sets the property Reflection. 
        /// <para>
        /// Contains configurations for overriding the reflection step of the episodic memory
        /// strategy.
        /// </para>
        /// </summary>
        public EpisodicOverrideReflectionConfigurationInput Reflection { get; set; }

        /// <summary>
        /// Checks to see if the Reflection property is set.
        /// </summary>
        internal bool IsSetReflection() => this.Reflection != null;
    }
}
