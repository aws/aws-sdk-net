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
    /// Input for semantic override configuration in a memory strategy.
    /// </summary>
    public partial class SemanticOverrideConfigurationInput
    {
        private SemanticOverrideConsolidationConfigurationInput _consolidation;
        private SemanticOverrideExtractionConfigurationInput _extraction;

        /// <summary>
        /// Gets and sets the property Consolidation. 
        /// <para>
        /// The consolidation configuration for a semantic override.
        /// </para>
        /// </summary>
        public SemanticOverrideConsolidationConfigurationInput Consolidation
        {
            get { return this._consolidation; }
            set { this._consolidation = value; }
        }

        // Check to see if Consolidation property is set
        internal bool IsSetConsolidation()
        {
            return this._consolidation != null;
        }

        /// <summary>
        /// Gets and sets the property Extraction. 
        /// <para>
        /// The extraction configuration for a semantic override.
        /// </para>
        /// </summary>
        public SemanticOverrideExtractionConfigurationInput Extraction
        {
            get { return this._extraction; }
            set { this._extraction = value; }
        }

        // Check to see if Extraction property is set
        internal bool IsSetExtraction()
        {
            return this._extraction != null;
        }

    }
}