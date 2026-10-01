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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about the agent and session, alongside the agent's reasoning
    /// process and results from calling API actions and querying knowledge bases and metadata
    /// about the trace. You can use the trace to understand how the agent arrived at the
    /// response it provided the customer. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-enablement">Trace
    /// enablement</a>.
    /// </summary>
    public partial class TracePart : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property AgentAliasId. 
        /// <para>
        /// The unique identifier of the alias of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public string AgentAliasId { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasId property is set.
        /// </summary>
        internal bool IsSetAgentAliasId() => this.AgentAliasId != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property CallerChain. 
        /// <para>
        /// The part's caller chain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Caller> CallerChain { get; set; } = AWSConfigs.InitializeCollections ? new List<Caller>() : null;

        /// <summary>
        /// Checks to see if the CallerChain property is set.
        /// </summary>
        internal bool IsSetCallerChain() => this.CallerChain != null && (this.CallerChain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The part's collaborator name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorName property is set.
        /// </summary>
        internal bool IsSetCollaboratorName() => this.CollaboratorName != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        ///  The time of the trace. 
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session with the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// Contains one part of the agent's reasoning process and results from calling API actions
        /// and querying knowledge bases. You can use the trace to understand how the agent arrived
        /// at the response it provided the customer. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-enablement">Trace
        /// enablement</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Trace Trace { get; set; }

        /// <summary>
        /// Checks to see if the Trace property is set.
        /// </summary>
        internal bool IsSetTrace() => this.Trace != null;
    }
}
