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
    /// Container for the parameters to the GetAgentInsight operation. Amazon Bedrock AgentCore
    /// Agent Insights identifies patterns detected across your agent sessions. Use Agent
    /// Insights to identify recurring issues and prioritize fixes. <para> Retrieves detailed
    /// information about an Amazon Bedrock AgentCore Agent Insight, including its archive
    /// status, affected sessions, and, when applicable, the batch evaluation that produced
    /// it. </para>
    /// </summary>
    public partial class GetAgentInsightRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property AgentInsightId. 
        /// <para>
        /// The unique identifier of the Agent Insight to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentInsightId { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightId property is set.
        /// </summary>
        internal bool IsSetAgentInsightId() => this.AgentInsightId != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application that the Agent Insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;
    }
}
