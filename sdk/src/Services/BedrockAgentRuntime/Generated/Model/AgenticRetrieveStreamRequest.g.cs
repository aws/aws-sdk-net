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
    /// Container for the parameters to the AgenticRetrieveStream operation. Retrieves information
    /// from one or more knowledge bases using an agentic approach. Agentic retrieval uses
    /// a foundation model to intelligently decompose complex queries into sub-queries and
    /// iteratively retrieve relevant information from your knowledge bases. This approach
    /// improves retrieval accuracy for complex, multi-step questions that a single retrieval
    /// pass might not fully address. <para> The operation returns results through a stream
    /// that includes retrieval results, trace events for visibility into the process, and
    /// a generated response synthesized from the results by default, which can be turned
    /// off. </para>
    /// </summary>
    public partial class AgenticRetrieveStreamRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property AgenticRetrieveConfiguration. 
        /// <para>
        /// Configuration settings for the agentic retrieval operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgenticRetrieveConfiguration AgenticRetrieveConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AgenticRetrieveConfiguration property is set.
        /// </summary>
        internal bool IsSetAgenticRetrieveConfiguration() => this.AgenticRetrieveConfiguration != null;

        /// <summary>
        /// Gets and sets the property GenerateResponse. 
        /// <para>
        /// Whether to generate a response based on the retrieved results.
        /// </para>
        /// </summary>
        public bool? GenerateResponse { get; set; }

        /// <summary>
        /// Checks to see if the GenerateResponse property is set.
        /// </summary>
        internal bool IsSetGenerateResponse() => this.GenerateResponse.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryConfiguration. 
        /// <para>
        /// The configuration for using an Amazon Bedrock AgentCore Memory resource with this
        /// retrieval.
        /// </para>
        /// </summary>
        public AgenticRetrieveMemoryConfiguration MemoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MemoryConfiguration property is set.
        /// </summary>
        internal bool IsSetMemoryConfiguration() => this.MemoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The list of messages for the agentic retrieval conversation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<AgenticRetrieveMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Opaque continuation token for paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyConfiguration. 
        /// <para>
        /// Policy configuration for guardrails and content filtering.
        /// </para>
        /// </summary>
        public AgenticRetrievePolicyConfiguration PolicyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PolicyConfiguration property is set.
        /// </summary>
        internal bool IsSetPolicyConfiguration() => this.PolicyConfiguration != null;

        /// <summary>
        /// Gets and sets the property Retrievers. 
        /// <para>
        /// The list of retrievers to use for agentic retrieval.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<AgenticRetriever> Retrievers { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetriever>() : null;

        /// <summary>
        /// Checks to see if the Retrievers property is set.
        /// </summary>
        internal bool IsSetRetrievers() => this.Retrievers != null && (this.Retrievers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserContext. 
        /// <para>
        /// Contains information about the user making the request. This is used for access control
        /// filtering to ensure that retrieval results only include documents the user is authorized
        /// to access.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public UserContext UserContext { get; set; }

        /// <summary>
        /// Checks to see if the UserContext property is set.
        /// </summary>
        internal bool IsSetUserContext() => this.UserContext != null;
    }
}
