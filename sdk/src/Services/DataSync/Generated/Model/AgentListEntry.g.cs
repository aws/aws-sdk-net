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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents a single entry in a list (or array) of DataSync agents when you call the
    /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_ListAgents.html">ListAgents</a>
    /// operation.
    /// </summary>
    public partial class AgentListEntry
    {
        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a DataSync agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AgentArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentArn property is set.
        /// </summary>
        internal bool IsSetAgentArn() => this.AgentArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform-related details about the agent, such as the version number.
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an agent.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the status is <c>ONLINE</c>, the agent is configured properly and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the status is <c>OFFLINE</c>, the agent has been out of contact with DataSync for
        /// five minutes or longer. This can happen for a few reasons. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-agents.html#troubleshoot-agent-offline">What
        /// do I do if my agent is offline?</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AgentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
