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
    /// This is the response object from the GetAgentCard operation.
    /// </summary>
    public partial class GetAgentCardResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentCard. 
        /// <para>
        /// An agent card document that contains metadata and capabilities for an AgentCore Runtime
        /// agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document AgentCard { get; set; }

        /// <summary>
        /// Checks to see if the AgentCard property is set.
        /// </summary>
        internal bool IsSetAgentCard() => !this.AgentCard.IsNull();

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The ID of the session associated with the AgentCore Runtime agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the request.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;
    }
}
