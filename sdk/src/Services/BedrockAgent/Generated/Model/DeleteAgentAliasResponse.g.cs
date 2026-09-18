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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// This is the response object from the DeleteAgentAlias operation.
    /// </summary>
    public partial class DeleteAgentAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentAliasId. 
        /// <para>
        /// The unique identifier of the alias that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string AgentAliasId { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasId property is set.
        /// </summary>
        internal bool IsSetAgentAliasId() => this.AgentAliasId != null;

        /// <summary>
        /// Gets and sets the property AgentAliasStatus. 
        /// <para>
        /// The status of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentAliasStatus AgentAliasStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasStatus property is set.
        /// </summary>
        internal bool IsSetAgentAliasStatus() => this.AgentAliasStatus != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent that the alias belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;
    }
}
