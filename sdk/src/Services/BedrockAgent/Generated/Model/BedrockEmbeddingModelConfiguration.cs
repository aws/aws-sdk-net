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
        private List<AudioConfiguration> _audio = AWSConfigs.InitializeCollections ? new List<AudioConfiguration>() : null;
        private int? _dimensions;
        private EmbeddingDataType _embeddingDataType;
        private List<VideoConfiguration> _video = AWSConfigs.InitializeCollections ? new List<VideoConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// Configuration settings for processing audio content in multimodal knowledge bases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AudioConfiguration> Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null && (this._audio.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// Configuration settings for processing video content in multimodal knowledge bases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<VideoConfiguration> Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null && (this._video.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}