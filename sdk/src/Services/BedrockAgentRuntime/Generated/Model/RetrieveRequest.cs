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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Container for the parameters to the Retrieve operation.
    /// Queries a knowledge base and retrieves information from it.
    /// </summary>
    public partial class RetrieveRequest : AmazonBedrockAgentRuntimeRequest
    {
        private GuardrailConfiguration _guardrailConfiguration;
        private string _knowledgeBaseId;
        private string _nextToken;
        private KnowledgeBaseRetrievalConfiguration _retrievalConfiguration;
        private KnowledgeBaseQuery _retrievalQuery;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Guardrail settings.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration
        {
            get { return this._guardrailConfiguration; }
            set { this._guardrailConfiguration = value; }
        }

        // Check to see if GuardrailConfiguration property is set
        internal bool IsSetGuardrailConfiguration()
        {
            return this._guardrailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more results than can fit in the response, the response returns a <c>nextToken</c>.
        /// Use this token in the <c>nextToken</c> field of another request to retrieve the next
        /// batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// Contains configurations for the knowledge base query and retrieval process. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        public KnowledgeBaseRetrievalConfiguration RetrievalConfiguration
        {
            get { return this._retrievalConfiguration; }
            set { this._retrievalConfiguration = value; }
        }

        // Check to see if RetrievalConfiguration property is set
        internal bool IsSetRetrievalConfiguration()
        {
            return this._retrievalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalQuery. 
        /// <para>
        /// Contains the query to send the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public KnowledgeBaseQuery RetrievalQuery
        {
            get { return this._retrievalQuery; }
            set { this._retrievalQuery = value; }
        }

        // Check to see if RetrievalQuery property is set
        internal bool IsSetRetrievalQuery()
        {
            return this._retrievalQuery != null;
        }

    }
}