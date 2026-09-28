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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A union that configures a single collaborator agent for an Orchestration AI Agent,
    /// as either a delegate or a handoff.
    /// </summary>
    public partial class MultiAgentConfiguration
    {
        /// <summary>
        /// Gets and sets the property DelegateAgentConfiguration. 
        /// <para>
        /// Configures the collaborator agent as a delegate that the Orchestration AI Agent invokes
        /// while retaining control of the conversation.
        /// </para>
        /// </summary>
        public DelegateAgentConfiguration DelegateAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DelegateAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetDelegateAgentConfiguration() => this.DelegateAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property HandoffAgentConfiguration. 
        /// <para>
        /// Configures the collaborator agent as a handoff target that the Orchestration AI Agent
        /// transfers control of the conversation to.
        /// </para>
        /// </summary>
        public HandoffAgentConfiguration HandoffAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HandoffAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetHandoffAgentConfiguration() => this.HandoffAgentConfiguration != null;
    }
}
