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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// A collaborator agent configuration in which the Orchestration AI Agent transfers control
    /// of the conversation to the collaborator agent.
    /// </summary>
    public partial class HandoffAgentConfiguration
    {
        private AgentTarget _agentTarget;
        private bool? _audioStreamingEnabled;
        private bool? _immediateHandoff;
        private MultiAgentInstruction _instruction;

        /// <summary>
        /// Gets and sets the property AgentTarget. 
        /// <para>
        /// The collaborator agent to hand off to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentTarget AgentTarget
        {
            get { return this._agentTarget; }
            set { this._agentTarget = value; }
        }

        // Check to see if AgentTarget property is set
        internal bool IsSetAgentTarget()
        {
            return this._agentTarget != null;
        }

        /// <summary>
        /// Gets and sets the property AudioStreamingEnabled. 
        /// <para>
        /// Specifies whether the caller's audio is streamed directly to the collaborator agent
        /// and the collaborator's audio response is played back during the handoff. This applies
        /// only to voice handoffs.
        /// </para>
        /// </summary>
        public bool? AudioStreamingEnabled
        {
            get { return this._audioStreamingEnabled; }
            set { this._audioStreamingEnabled = value; }
        }

        // Check to see if AudioStreamingEnabled property is set
        internal bool IsSetAudioStreamingEnabled()
        {
            return this._audioStreamingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImmediateHandoff. 
        /// <para>
        /// Specifies whether the conversation is handed off to this collaborator agent immediately
        /// on the first turn, without any orchestration reasoning. At most one handoff in an
        /// AI Agent's configuration can set this to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ImmediateHandoff
        {
            get { return this._immediateHandoff; }
            set { this._immediateHandoff = value; }
        }

        // Check to see if ImmediateHandoff property is set
        internal bool IsSetImmediateHandoff()
        {
            return this._immediateHandoff.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// The instruction that tells the Orchestration AI Agent when and how to hand off to
        /// this collaborator agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MultiAgentInstruction Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

    }
}