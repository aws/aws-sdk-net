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
    /// Configuration settings for the agentic retrieval operation.
    /// </summary>
    public partial class AgenticRetrieveConfiguration
    {
        private FoundationModelConfiguration _foundationModelConfiguration;
        private FoundationModelType _foundationModelType;
        private int? _maxAgentIteration;
        private AgenticRetrieveRerankingConfiguration _rerankingConfiguration;
        private AgenticRetrieveRerankingModelType _rerankingModelType;

        /// <summary>
        /// Gets and sets the property FoundationModelConfiguration. 
        /// <para>
        /// The foundation model configuration. Required when foundationModelType is CUSTOM.
        /// </para>
        /// </summary>
        public FoundationModelConfiguration FoundationModelConfiguration
        {
            get { return this._foundationModelConfiguration; }
            set { this._foundationModelConfiguration = value; }
        }

        // Check to see if FoundationModelConfiguration property is set
        internal bool IsSetFoundationModelConfiguration()
        {
            return this._foundationModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FoundationModelType. 
        /// <para>
        /// The type of foundation model to use. CUSTOM uses a specified model, MANAGED uses the
        /// service default.
        /// </para>
        /// </summary>
        public FoundationModelType FoundationModelType
        {
            get { return this._foundationModelType; }
            set { this._foundationModelType = value; }
        }

        // Check to see if FoundationModelType property is set
        internal bool IsSetFoundationModelType()
        {
            return this._foundationModelType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAgentIteration. 
        /// <para>
        /// The maximum number of agent iterations for retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? MaxAgentIteration
        {
            get { return this._maxAgentIteration; }
            set { this._maxAgentIteration = value; }
        }

        // Check to see if MaxAgentIteration property is set
        internal bool IsSetMaxAgentIteration()
        {
            return this._maxAgentIteration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RerankingConfiguration. 
        /// <para>
        /// The reranking model configuration. Required when rerankingModelType is CUSTOM.
        /// </para>
        /// </summary>
        public AgenticRetrieveRerankingConfiguration RerankingConfiguration
        {
            get { return this._rerankingConfiguration; }
            set { this._rerankingConfiguration = value; }
        }

        // Check to see if RerankingConfiguration property is set
        internal bool IsSetRerankingConfiguration()
        {
            return this._rerankingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RerankingModelType. 
        /// <para>
        /// The type of reranking model to use. CUSTOM uses a specified model, MANAGED uses the
        /// service default. If not specified, defaults to MANAGED for managed embedding knowledge
        /// bases and NONE for custom embedding knowledge bases.
        /// </para>
        /// </summary>
        public AgenticRetrieveRerankingModelType RerankingModelType
        {
            get { return this._rerankingModelType; }
            set { this._rerankingModelType = value; }
        }

        // Check to see if RerankingModelType property is set
        internal bool IsSetRerankingModelType()
        {
            return this._rerankingModelType != null;
        }

    }
}