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
    /// Container for the parameters to the StopRuntimeSession operation. Stops a session
    /// that is running in an running AgentCore Runtime agent.
    /// </summary>
    public partial class StopRuntimeSessionRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The ARN of the agent that contains the session that you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArn() => this.AgentRuntimeArn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotent token used to identify the request. If you use the same token with multiple
        /// requests, the same response is returned. Use ClientToken to prevent the same request
        /// from being processed more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Optional qualifier to specify an agent alias, such as <c>prod</c>code&gt; or <c>dev</c>.
        /// If you don't provide a value, the DEFAULT alias is used. 
        /// </para>
        /// </summary>
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The ID of the session that you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 33, Max = 256)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;
    }
}
