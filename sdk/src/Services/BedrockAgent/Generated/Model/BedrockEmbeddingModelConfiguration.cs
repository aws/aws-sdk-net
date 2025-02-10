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
    /// The vector configuration details for the Bedrock embeddings model.
    /// </summary>
    public partial class BedrockEmbeddingModelConfiguration
    {
        private int? _dimensions;
        private EmbeddingDataType _embeddingDataType;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions details for the vector configuration used on the Bedrock embeddings
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public int? Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmbeddingDataType. 
        /// <para>
        /// The data type for the vectors when using a model to convert text into vector embeddings.
        /// The model must support the specified data type for vector embeddings. Floating-point
        /// (float32) is the default data type, and is supported by most models for vector embeddings.
        /// See <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-supported.html">Supported
        /// embeddings models</a> for information on the available models and their vector data
        /// types.
        /// </para>
        /// </summary>
        public EmbeddingDataType EmbeddingDataType
        {
            get { return this._embeddingDataType; }
            set { this._embeddingDataType = value; }
        }

        // Check to see if EmbeddingDataType property is set
        internal bool IsSetEmbeddingDataType()
        {
            return this._embeddingDataType != null;
        }

    }
}