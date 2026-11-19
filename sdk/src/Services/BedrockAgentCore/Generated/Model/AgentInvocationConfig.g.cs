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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The agent that the batch evaluation invokes with each scenario in the dataset.
    /// </summary>
    public partial class AgentInvocationConfig
    {
        /// <summary>
        /// Gets and sets the property AgentCoreRuntime. 
        /// <para>
        /// The configuration for invoking an agent hosted on AgentCore Runtime.
        /// </para>
        /// </summary>
        public AgentCoreRuntimeInvocation AgentCoreRuntime { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreRuntime property is set.
        /// </summary>
        internal bool IsSetAgentCoreRuntime() => this.AgentCoreRuntime != null;
    }
}
