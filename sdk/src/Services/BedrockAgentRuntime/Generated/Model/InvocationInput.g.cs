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
    /// Contains information pertaining to the action group or knowledge base that is being
    /// invoked.
    /// </summary>
    public partial class InvocationInput
    {
        /// <summary>
        /// Gets and sets the property ActionGroupInvocationInput. 
        /// <para>
        /// Contains information about the action group to be invoked.
        /// </para>
        /// </summary>
        public ActionGroupInvocationInput ActionGroupInvocationInput { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroupInvocationInput property is set.
        /// </summary>
        internal bool IsSetActionGroupInvocationInput() => this.ActionGroupInvocationInput != null;

        /// <summary>
        /// Gets and sets the property AgentCollaboratorInvocationInput. 
        /// <para>
        /// The collaborator's invocation input.
        /// </para>
        /// </summary>
        public AgentCollaboratorInvocationInput AgentCollaboratorInvocationInput { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboratorInvocationInput property is set.
        /// </summary>
        internal bool IsSetAgentCollaboratorInvocationInput() => this.AgentCollaboratorInvocationInput != null;

        /// <summary>
        /// Gets and sets the property CodeInterpreterInvocationInput. 
        /// <para>
        /// Contains information about the code interpreter to be invoked.
        /// </para>
        /// </summary>
        public CodeInterpreterInvocationInput CodeInterpreterInvocationInput { get; set; }

        /// <summary>
        /// Checks to see if the CodeInterpreterInvocationInput property is set.
        /// </summary>
        internal bool IsSetCodeInterpreterInvocationInput() => this.CodeInterpreterInvocationInput != null;

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Specifies whether the agent is invoking an action group or a knowledge base.
        /// </para>
        /// </summary>
        public InvocationType InvocationType { get; set; }

        /// <summary>
        /// Checks to see if the InvocationType property is set.
        /// </summary>
        internal bool IsSetInvocationType() => this.InvocationType != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseLookupInput. 
        /// <para>
        /// Contains details about the knowledge base to look up and the query to be made.
        /// </para>
        /// </summary>
        public KnowledgeBaseLookupInput KnowledgeBaseLookupInput { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseLookupInput property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseLookupInput() => this.KnowledgeBaseLookupInput != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The unique identifier of the trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 16)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;
    }
}
