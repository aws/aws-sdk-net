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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The vector configuration details for the Bedrock embeddings model.
    /// </summary>
    public partial class BedrockEmbeddingModelConfiguration
    {
        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// Configuration settings for processing audio content in multimodal knowledge bases.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field is deprecated. Use <c>modelConfiguration</c> instead.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use Managed Knowledge Base's modelConfiguration field. https://docs.aws.amazon.com/bedrock/latest/userguide/kb-build-managed.html")]
        [AWSProperty(Min = 1, Max = 1)]
        public List<AudioConfiguration> Audio { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Audio property is set.
        /// </summary>
        internal bool IsSetAudio() => this.Audio != null && (this.Audio.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions details for the vector configuration used on the Bedrock embeddings
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions.HasValue;

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
        public EmbeddingDataType EmbeddingDataType { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingDataType property is set.
        /// </summary>
        internal bool IsSetEmbeddingDataType() => this.EmbeddingDataType != null;

        /// <summary>
        /// Gets and sets the property ModelConfiguration. 
        /// <para>
        /// Model-specific configuration for the embedding model, provided as a JSON object. Use
        /// this field to specify settings that apply to the embedding model that you selected,
        /// such as how audio and video files are divided into segments.
        /// </para>
        ///  
        /// <para>
        /// The fields that this object accepts depend on the embedding model. For the settings
        /// that each model accepts, see the documentation for that model.
        /// </para>
        ///  
        /// <para>
        /// For an example of a <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_CreateKnowledgeBase.html">CreateKnowledgeBase</a>
        /// request that uses this field to configure a multimodal embedding model, see the <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_CreateKnowledgeBase.html#API_agent_CreateKnowledgeBase_Examples">Examples</a>
        /// section of <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_CreateKnowledgeBase.html">CreateKnowledgeBase</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfiguration property is set.
        /// </summary>
        internal bool IsSetModelConfiguration() => !this.ModelConfiguration.IsNull();

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// Configuration settings for processing video content in multimodal knowledge bases.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field is deprecated. Use <c>modelConfiguration</c> instead.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use Managed Knowledge Base's modelConfiguration field. https://docs.aws.amazon.com/bedrock/latest/userguide/kb-build-managed.html")]
        [AWSProperty(Min = 1, Max = 1)]
        public List<VideoConfiguration> Video { get; set; } = AWSConfigs.InitializeCollections ? new List<VideoConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null && (this.Video.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
