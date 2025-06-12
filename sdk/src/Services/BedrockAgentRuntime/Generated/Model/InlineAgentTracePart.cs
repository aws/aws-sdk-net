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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

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
    public partial class InlineAgentTracePart
        : IEventStreamEvent
    {
        private List<Caller> _callerChain = AWSConfigs.InitializeCollections ? new List<Caller>() : null;
        private string _collaboratorName;
        private DateTime? _eventTime;
        private string _sessionId;
        private Trace _trace;

        /// <summary>
        /// Gets and sets the property CallerChain. 
        /// <para>
        /// The caller chain for the trace part.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Caller> CallerChain
        {
            get { return this._callerChain; }
            set { this._callerChain = value; }
        }

        // Check to see if CallerChain property is set
        internal bool IsSetCallerChain()
        {
            return this._callerChain != null && (this._callerChain.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The collaborator name for the trace part.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CollaboratorName
        {
            get { return this._collaboratorName; }
            set { this._collaboratorName = value; }
        }

        // Check to see if CollaboratorName property is set
        internal bool IsSetCollaboratorName()
        {
            return this._collaboratorName != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time that trace occurred. 
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session with the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// Contains one part of the agent's reasoning process and results from calling API actions
        /// and querying knowledge bases. You can use the trace to understand how the agent arrived
        /// at the response it provided the customer. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-enablement">Trace
        /// enablement</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Trace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return this._trace != null;
        }

    }
}