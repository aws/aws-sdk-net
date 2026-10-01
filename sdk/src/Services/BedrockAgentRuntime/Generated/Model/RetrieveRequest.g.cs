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
    /// Container for the parameters to the Retrieve operation. Queries a knowledge base and
    /// retrieves information from it.
    /// </summary>
    public partial class RetrieveRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Guardrail settings.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 2048)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more results than can fit in the response, the response returns a <c>nextToken</c>.
        /// Use this token in the <c>nextToken</c> field of another request to retrieve the next
        /// batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// Contains configurations for the knowledge base query and retrieval process. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        public KnowledgeBaseRetrievalConfiguration RetrievalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalConfiguration property is set.
        /// </summary>
        internal bool IsSetRetrievalConfiguration() => this.RetrievalConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetrievalQuery. 
        /// <para>
        /// Contains the query to send the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public KnowledgeBaseQuery RetrievalQuery { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalQuery property is set.
        /// </summary>
        internal bool IsSetRetrievalQuery() => this.RetrievalQuery != null;

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
