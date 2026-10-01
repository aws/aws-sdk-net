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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains configuration details for retrieval of information and response generation.
    /// </summary>
    public partial class RAGConfig
    {
        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfig. 
        /// <para>
        /// Contains configuration details for knowledge base retrieval and response generation.
        /// </para>
        /// </summary>
        public KnowledgeBaseConfig KnowledgeBaseConfig { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseConfig property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseConfig() => this.KnowledgeBaseConfig != null;

        /// <summary>
        /// Gets and sets the property PrecomputedRagSourceConfig. 
        /// <para>
        /// Contains configuration details about the RAG source used to generate inference response
        /// data for a Knowledge Base evaluation job.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedRagSourceConfig PrecomputedRagSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the PrecomputedRagSourceConfig property is set.
        /// </summary>
        internal bool IsSetPrecomputedRagSourceConfig() => this.PrecomputedRagSourceConfig != null;
    }
}
