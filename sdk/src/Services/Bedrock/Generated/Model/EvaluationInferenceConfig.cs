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
    /// The configuration details of the inference model for an evaluation job.
    /// 
    ///  
    /// <para>
    /// For automated model evaluation jobs, only a single model is supported.
    /// </para>
    ///  
    /// <para>
    /// For human-based model evaluation jobs, your annotator can compare the responses for
    /// up to two different models.
    /// </para>
    /// </summary>
    public partial class EvaluationInferenceConfig
    {
        private List<EvaluationModelConfig> _models = AWSConfigs.InitializeCollections ? new List<EvaluationModelConfig>() : null;
        private List<RAGConfig> _ragConfigs = AWSConfigs.InitializeCollections ? new List<RAGConfig>() : null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Specifies the inference models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<EvaluationModelConfig> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RagConfigs. 
        /// <para>
        /// Contains the configuration details of the inference for a knowledge base evaluation
        /// job, including either the retrieval only configuration or the retrieval with response
        /// generation configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<RAGConfig> RagConfigs
        {
            get { return this._ragConfigs; }
            set { this._ragConfigs = value; }
        }

        // Check to see if RagConfigs property is set
        internal bool IsSetRagConfigs()
        {
            return this._ragConfigs != null && (this._ragConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}