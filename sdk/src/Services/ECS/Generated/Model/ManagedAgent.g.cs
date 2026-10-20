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
    /// Details about the managed agent status for the container.
    /// </summary>
    public partial class ManagedAgent
    {
        /// <summary>
        /// Gets and sets the property LastStartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the managed agent was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastStartedAt property is set.
        /// </summary>
        internal bool IsSetLastStartedAt() => this.LastStartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status of the managed agent.
        /// </para>
        /// </summary>
        public string LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed agent. When the execute command feature is turned on, the
        /// managed agent name is <c>ExecuteCommandAgent</c>.
        /// </para>
        /// </summary>
        public ManagedAgentName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for why the managed agent is in the state it is in.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
