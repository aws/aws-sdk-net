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
    /// Contains configuration information for a memory strategy.
    /// </summary>
    public partial class StrategyConfiguration
    {
        /// <summary>
        /// Gets and sets the property Consolidation. 
        /// <para>
        /// The consolidation configuration for the memory strategy.
        /// </para>
        /// </summary>
        public ConsolidationConfiguration Consolidation { get; set; }

        /// <summary>
        /// Checks to see if the Consolidation property is set.
        /// </summary>
        internal bool IsSetConsolidation() => this.Consolidation != null;

        /// <summary>
        /// Gets and sets the property Extraction. 
        /// <para>
        /// The extraction configuration for the memory strategy.
        /// </para>
        /// </summary>
        public ExtractionConfiguration Extraction { get; set; }

        /// <summary>
        /// Checks to see if the Extraction property is set.
        /// </summary>
        internal bool IsSetExtraction() => this.Extraction != null;

        /// <summary>
        /// Gets and sets the property Reflection. 
        /// <para>
        /// The reflection configuration for the memory strategy.
        /// </para>
        /// </summary>
        public ReflectionConfiguration Reflection { get; set; }

        /// <summary>
        /// Checks to see if the Reflection property is set.
        /// </summary>
        internal bool IsSetReflection() => this.Reflection != null;

        /// <summary>
        /// Gets and sets the property SelfManagedConfiguration. 
        /// <para>
        /// Self-managed configuration settings.
        /// </para>
        /// </summary>
        public SelfManagedConfiguration SelfManagedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedConfiguration() => this.SelfManagedConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of override for the strategy configuration.
        /// </para>
        /// </summary>
        public OverrideType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
