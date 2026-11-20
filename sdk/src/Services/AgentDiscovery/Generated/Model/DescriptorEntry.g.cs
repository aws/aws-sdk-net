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

namespace Amazon.AgentDiscovery.Model
{
    /// <summary>
    /// A descriptor slot value (A2A card, MCP server card, skills definition, custom). Content
    /// is either inline (`data`) or a reference (`source`). `additionalData` carries nested
    /// sub-descriptors (e.g. mcpServer.tools, agentSkillsDefinition.skillMd).
    /// </summary>
    public partial class DescriptorEntry
    {
        /// <summary>
        /// Gets and sets the property AdditionalData. Nested sub-descriptors keyed by slot name
        /// (e.g. `tools`, `skillMd`).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 32)]
        public Dictionary<string, DescriptorEntry> AdditionalData { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DescriptorEntry>() : null;

        /// <summary>
        /// Checks to see if the AdditionalData property is set.
        /// </summary>
        internal bool IsSetAdditionalData() => this.AdditionalData != null && (this.AdditionalData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Data. Inline descriptor content (JSON string).
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Source. Reference to externally-hosted descriptor content.
        /// </summary>
        public DescriptorSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Version. Descriptor type version.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
