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
    /// This is the response object from the DeleteAgentVersion operation.
    /// </summary>
    public partial class DeleteAgentVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentStatus AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;
    }
}
