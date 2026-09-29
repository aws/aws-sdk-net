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
    /// Configurations to apply to a knowledge base attached to the agent during query. For
    /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html#session-state-kb">Knowledge
    /// base retrieval configurations</a>.
    /// </summary>
    public partial class KnowledgeBaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for a knowledge base attached to the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// The configurations to apply to the knowledge base during query. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseRetrievalConfiguration RetrievalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalConfiguration property is set.
        /// </summary>
        internal bool IsSetRetrievalConfiguration() => this.RetrievalConfiguration != null;
    }
}
