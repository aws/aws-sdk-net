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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// An agent collaborator invocation input.
    /// </summary>
    public partial class AgentCollaboratorInvocationInput
    {
        private string _agentCollaboratorAliasArn;
        private string _agentCollaboratorName;
        private AgentCollaboratorInputPayload _input;

        /// <summary>
        /// Gets and sets the property AgentCollaboratorAliasArn. 
        /// <para>
        /// The collaborator's alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AgentCollaboratorAliasArn
        {
            get { return this._agentCollaboratorAliasArn; }
            set { this._agentCollaboratorAliasArn = value; }
        }

        // Check to see if AgentCollaboratorAliasArn property is set
        internal bool IsSetAgentCollaboratorAliasArn()
        {
            return this._agentCollaboratorAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCollaboratorName. 
        /// <para>
        /// The collaborator's name.
        /// </para>
        /// </summary>
        public string AgentCollaboratorName
        {
            get { return this._agentCollaboratorName; }
            set { this._agentCollaboratorName = value; }
        }

        // Check to see if AgentCollaboratorName property is set
        internal bool IsSetAgentCollaboratorName()
        {
            return this._agentCollaboratorName != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Text or action invocation result input for the collaborator.
        /// </para>
        /// </summary>
        public AgentCollaboratorInputPayload Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}