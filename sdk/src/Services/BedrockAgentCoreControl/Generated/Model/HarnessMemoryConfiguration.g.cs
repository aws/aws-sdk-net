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
    /// The memory configuration for a harness.
    /// </summary>
    public partial class HarnessMemoryConfiguration
    {
        /// <summary>
        /// Gets and sets the property AgentCoreMemoryConfiguration. 
        /// <para>
        /// The AgentCore Memory configuration.
        /// </para>
        /// </summary>
        public HarnessAgentCoreMemoryConfiguration AgentCoreMemoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreMemoryConfiguration property is set.
        /// </summary>
        internal bool IsSetAgentCoreMemoryConfiguration() => this.AgentCoreMemoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Explicitly opt out of memory.
        /// </para>
        /// </summary>
        public HarnessDisabledMemoryConfiguration Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled != null;

        /// <summary>
        /// Gets and sets the property ManagedMemoryConfiguration. 
        /// <para>
        /// Harness creates and manages a memory resource in the customer's account.
        /// </para>
        /// </summary>
        public HarnessManagedMemoryConfiguration ManagedMemoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedMemoryConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedMemoryConfiguration() => this.ManagedMemoryConfiguration != null;
    }
}
