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
    /// The details of the agent hosted on AgentCore Runtime that a batch evaluation invoked.
    /// </summary>
    public partial class AgentCoreRuntimeInvocationDetails
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent runtime endpoint that the batch evaluation
        /// invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeEndpointArn() => this.AgentRuntimeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the agent runtime that the endpoint pointed to when the batch evaluation
        /// started. If you update the endpoint after the batch evaluation starts, each later
        /// turn uses the version that the endpoint points to when the turn runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string AgentRuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeVersion property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeVersion() => this.AgentRuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property RequestTemplate. 
        /// <para>
        /// The request payload template that the batch evaluation used for each turn. If the
        /// request didn't specify a template, this is the default template.
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
