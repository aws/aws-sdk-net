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
    /// The memory configuration for a harness.
    /// </summary>
    public partial class HarnessMemoryConfiguration
    {
        private HarnessAgentCoreMemoryConfiguration _agentCoreMemoryConfiguration;
        private HarnessDisabledMemoryConfiguration _disabled;
        private HarnessManagedMemoryConfiguration _managedMemoryConfiguration;

        /// <summary>
        /// Gets and sets the property AgentCoreMemoryConfiguration. 
        /// <para>
        /// The AgentCore Memory configuration.
        /// </para>
        /// </summary>
        public HarnessAgentCoreMemoryConfiguration AgentCoreMemoryConfiguration
        {
            get { return this._agentCoreMemoryConfiguration; }
            set { this._agentCoreMemoryConfiguration = value; }
        }

        // Check to see if AgentCoreMemoryConfiguration property is set
        internal bool IsSetAgentCoreMemoryConfiguration()
        {
            return this._agentCoreMemoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Explicitly opt out of memory.
        /// </para>
        /// </summary>
        public HarnessDisabledMemoryConfiguration Disabled
        {
            get { return this._disabled; }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedMemoryConfiguration. 
        /// <para>
        /// Harness creates and manages a memory resource in the customer's account.
        /// </para>
        /// </summary>
        public HarnessManagedMemoryConfiguration ManagedMemoryConfiguration
        {
            get { return this._managedMemoryConfiguration; }
            set { this._managedMemoryConfiguration = value; }
        }

        // Check to see if ManagedMemoryConfiguration property is set
        internal bool IsSetManagedMemoryConfiguration()
        {
            return this._managedMemoryConfiguration != null;
        }

    }
}