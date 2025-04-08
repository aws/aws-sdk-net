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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Context enrichment configuration is used to provide additional context to the RAG
    /// application using Amazon Bedrock foundation models.
    /// </summary>
    public partial class BedrockFoundationModelContextEnrichmentConfiguration
    {
        private EnrichmentStrategyConfiguration _enrichmentStrategyConfiguration;
        private string _modelArn;

        /// <summary>
        /// Gets and sets the property EnrichmentStrategyConfiguration. 
        /// <para>
        /// The enrichment stategy used to provide additional context. For example, Neptune GraphRAG
        /// uses Amazon Bedrock foundation models to perform chunk entity extraction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentStrategyConfiguration EnrichmentStrategyConfiguration
        {
            get { return this._enrichmentStrategyConfiguration; }
            set { this._enrichmentStrategyConfiguration = value; }
        }

        // Check to see if EnrichmentStrategyConfiguration property is set
        internal bool IsSetEnrichmentStrategyConfiguration()
        {
            return this._enrichmentStrategyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model used to create vector embeddings for the
        /// knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

    }
}