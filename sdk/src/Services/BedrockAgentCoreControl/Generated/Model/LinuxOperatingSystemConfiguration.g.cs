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
    /// Contains the operating system configuration of agents that run on Linux instances,
    /// such as the privilege mode.
    /// </summary>
    public partial class LinuxOperatingSystemConfiguration
    {
        /// <summary>
        /// Gets and sets the property PrivilegeMode. 
        /// <para>
        /// The privilege mode of the agents. If you omit this field, the agents run in <c>STANDARD</c>
        /// privilege mode. The following values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> – The agent runs without elevated privileges. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRIVILEGED</c> – The agent runs with elevated privileges on its instance. Use
        /// this mode for agents that build container images, run containers, or install system
        /// packages. A session that runs a <c>PRIVILEGED</c> agent runs only that agent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PrivilegeMode PrivilegeMode { get; set; }

        /// <summary>
        /// Checks to see if the PrivilegeMode property is set.
        /// </summary>
        internal bool IsSetPrivilegeMode() => this.PrivilegeMode != null;
    }
}
