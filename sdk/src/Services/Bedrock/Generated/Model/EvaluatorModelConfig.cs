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
    /// Specifies the model configuration for the evaluator model. <c>EvaluatorModelConfig</c>
    /// is required for evaluation jobs that use a knowledge base or in model evaluation job
    /// that use a model as judge. This model computes all evaluation related metrics.
    /// </summary>
    public partial class EvaluatorModelConfig
    {
        private List<BedrockEvaluatorModel> _bedrockEvaluatorModels = AWSConfigs.InitializeCollections ? new List<BedrockEvaluatorModel>() : null;

        /// <summary>
        /// Gets and sets the property BedrockEvaluatorModels. 
        /// <para>
        /// The evaluator model used in knowledge base evaluation job or in model evaluation job
        /// that use a model as judge. This model computes all evaluation related metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<BedrockEvaluatorModel> BedrockEvaluatorModels
        {
            get { return this._bedrockEvaluatorModels; }
            set { this._bedrockEvaluatorModels = value; }
        }

        // Check to see if BedrockEvaluatorModels property is set
        internal bool IsSetBedrockEvaluatorModels()
        {
            return this._bedrockEvaluatorModels != null && (this._bedrockEvaluatorModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}