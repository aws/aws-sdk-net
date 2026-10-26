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
    /// The artifact of the agent.
    /// </summary>
    public partial class AgentRuntimeArtifact
    {
        /// <summary>
        /// Gets and sets the property CodeConfiguration. 
        /// <para>
        /// The code configuration for the agent runtime artifact, including the source code location
        /// and execution settings.
        /// </para>
        /// </summary>
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CodeConfiguration property is set.
        /// </summary>
        internal bool IsSetCodeConfiguration() => this.CodeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContainerConfiguration. 
        /// <para>
        /// The container configuration for the agent artifact.
        /// </para>
        /// </summary>
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ContainerConfiguration property is set.
        /// </summary>
        internal bool IsSetContainerConfiguration() => this.ContainerConfiguration != null;
    }
}
