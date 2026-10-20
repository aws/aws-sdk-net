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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Docker and Amazon ECS container agent version information about a container instance.
    /// </summary>
    public partial class VersionInfo
    {
        /// <summary>
        /// Gets and sets the property AgentHash. 
        /// <para>
        /// The Git commit hash for the Amazon ECS container agent build on the <a href="https://github.com/aws/amazon-ecs-agent">amazon-ecs-agent
        /// </a> GitHub repository.
        /// </para>
        /// </summary>
        public string AgentHash { get; set; }

        /// <summary>
        /// Checks to see if the AgentHash property is set.
        /// </summary>
        internal bool IsSetAgentHash() => this.AgentHash != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version number of the Amazon ECS container agent.
        /// </para>
        /// </summary>
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property DockerVersion. 
        /// <para>
        /// The Docker version that's running on the container instance.
        /// </para>
        /// </summary>
        public string DockerVersion { get; set; }

        /// <summary>
        /// Checks to see if the DockerVersion property is set.
        /// </summary>
        internal bool IsSetDockerVersion() => this.DockerVersion != null;
    }
}
