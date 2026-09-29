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
    /// An agent collaborator invocation input.
    /// </summary>
    public partial class AgentCollaboratorInvocationInput
    {
        /// <summary>
        /// Gets and sets the property AgentCollaboratorAliasArn. 
        /// <para>
        /// The collaborator's alias ARN.
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
        /// The collaborator's name.
        /// </para>
        /// </summary>
        public string AgentCollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboratorName property is set.
        /// </summary>
        internal bool IsSetAgentCollaboratorName() => this.AgentCollaboratorName != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Text or action invocation result input for the collaborator.
        /// </para>
        /// </summary>
        public AgentCollaboratorInputPayload Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;
    }
}
