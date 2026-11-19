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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration for invoking an agent hosted on AgentCore Runtime. Each scenario
    /// runs in its own runtime session, and the turns of a scenario are sent in order within
    /// that session. The batch evaluation uses your credentials to read the agent runtime
    /// endpoint and the dataset, invoke the agent runtime, and read the resulting traces.
    /// You must have permission for these actions.
    /// </summary>
    public partial class AgentCoreRuntimeInvocation
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent runtime endpoint to invoke. Specify an
        /// endpoint in the same account and Region as the batch evaluation. The service requires
        /// the endpoint and its agent runtime version to be ready. The agent runtime must use
        /// the HTTP protocol and IAM inbound authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeEndpointArn() => this.AgentRuntimeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property RequestTemplate. 
        /// <para>
        /// A JSON object template for the request payload sent to the agent for each turn. The
        /// template must contain the placeholder <c>{{turn.input}}</c> exactly once, as the complete
        /// value of a JSON string and not as a field name. The service replaces the placeholder
        /// with the input of the turn. If the input isn't a string, the service inserts it as
        /// a JSON value. If you don't specify a template, the service uses <c>{"prompt": "{{turn.input}}"}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10240)]
        public string RequestTemplate { get; set; }

        /// <summary>
        /// Checks to see if the RequestTemplate property is set.
        /// </summary>
        internal bool IsSetRequestTemplate() => this.RequestTemplate != null;
    }
}
