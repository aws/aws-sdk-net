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
    /// Output from an agent collaborator.
    /// </summary>
    public partial class AgentCollaboratorInvocationOutput
    {
        /// <summary>
        /// Gets and sets the property AgentCollaboratorAliasArn. 
        /// <para>
        /// The output's agent collaborator alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string AgentCollaboratorAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboratorAliasArn property is set.
        /// </summary>
        internal bool IsSetAgentCollaboratorAliasArn() => this.AgentCollaboratorAliasArn != null;

        /// <summary>
        /// Gets and sets the property AgentCollaboratorName. 
        /// <para>
        /// The output's agent collaborator name.
        /// </para>
        /// </summary>
        public string AgentCollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboratorName property is set.
        /// </summary>
        internal bool IsSetAgentCollaboratorName() => this.AgentCollaboratorName != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains information about the output from the agent collaborator.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The output's output.
        /// </para>
        /// </summary>
        public AgentCollaboratorOutputPayload Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;
    }
}
