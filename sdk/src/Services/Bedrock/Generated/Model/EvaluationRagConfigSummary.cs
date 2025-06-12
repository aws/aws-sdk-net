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
    /// A summary of the RAG resources used in an Amazon Bedrock Knowledge Base evaluation
    /// job. These resources can be Knowledge Bases in Amazon Bedrock or RAG sources outside
    /// of Amazon Bedrock that you use to generate your own inference response data.
    /// </summary>
    public partial class EvaluationRagConfigSummary
    {
        private List<string> _bedrockKnowledgeBaseIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _precomputedRagSourceIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BedrockKnowledgeBaseIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Knowledge Base resources used for a Knowledge
        /// Base evaluation job where Amazon Bedrock invokes the Knowledge Base for you.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> BedrockKnowledgeBaseIdentifiers
        {
            get { return this._bedrockKnowledgeBaseIdentifiers; }
            set { this._bedrockKnowledgeBaseIdentifiers = value; }
        }

        // Check to see if BedrockKnowledgeBaseIdentifiers property is set
        internal bool IsSetBedrockKnowledgeBaseIdentifiers()
        {
            return this._bedrockKnowledgeBaseIdentifiers != null && (this._bedrockKnowledgeBaseIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrecomputedRagSourceIdentifiers. 
        /// <para>
        /// A label that identifies the RAG sources used for a Knowledge Base evaluation job where
        /// you provide your own inference response data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> PrecomputedRagSourceIdentifiers
        {
            get { return this._precomputedRagSourceIdentifiers; }
            set { this._precomputedRagSourceIdentifiers = value; }
        }

        // Check to see if PrecomputedRagSourceIdentifiers property is set
        internal bool IsSetPrecomputedRagSourceIdentifiers()
        {
            return this._precomputedRagSourceIdentifiers != null && (this._precomputedRagSourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}