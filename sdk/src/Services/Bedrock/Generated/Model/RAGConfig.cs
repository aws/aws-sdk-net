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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains configuration details for retrieval of information and response generation.
    /// </summary>
    public partial class RAGConfig
    {
        private KnowledgeBaseConfig _knowledgeBaseConfig;
        private EvaluationPrecomputedRagSourceConfig _precomputedRagSourceConfig;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfig. 
        /// <para>
        /// Contains configuration details for knowledge base retrieval and response generation.
        /// </para>
        /// </summary>
        public KnowledgeBaseConfig KnowledgeBaseConfig
        {
            get { return this._knowledgeBaseConfig; }
            set { this._knowledgeBaseConfig = value; }
        }

        // Check to see if KnowledgeBaseConfig property is set
        internal bool IsSetKnowledgeBaseConfig()
        {
            return this._knowledgeBaseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PrecomputedRagSourceConfig. 
        /// <para>
        /// Contains configuration details about the RAG source used to generate inference response
        /// data for a Knowledge Base evaluation job.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedRagSourceConfig PrecomputedRagSourceConfig
        {
            get { return this._precomputedRagSourceConfig; }
            set { this._precomputedRagSourceConfig = value; }
        }

        // Check to see if PrecomputedRagSourceConfig property is set
        internal bool IsSetPrecomputedRagSourceConfig()
        {
            return this._precomputedRagSourceConfig != null;
        }

    }
}