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
    /// Defines the models used in the model evaluation job.
    /// </summary>
    public partial class EvaluationModelConfig
    {
        private EvaluationBedrockModel _bedrockModel;
        private EvaluationPrecomputedInferenceSource _precomputedInferenceSource;

        /// <summary>
        /// Gets and sets the property BedrockModel. 
        /// <para>
        /// Defines the Amazon Bedrock model or inference profile and inference parameters you
        /// want used.
        /// </para>
        /// </summary>
        public EvaluationBedrockModel BedrockModel
        {
            get { return this._bedrockModel; }
            set { this._bedrockModel = value; }
        }

        // Check to see if BedrockModel property is set
        internal bool IsSetBedrockModel()
        {
            return this._bedrockModel != null;
        }

        /// <summary>
        /// Gets and sets the property PrecomputedInferenceSource. 
        /// <para>
        /// Defines the model used to generate inference response data for a model evaluation
        /// job where you provide your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedInferenceSource PrecomputedInferenceSource
        {
            get { return this._precomputedInferenceSource; }
            set { this._precomputedInferenceSource = value; }
        }

        // Check to see if PrecomputedInferenceSource property is set
        internal bool IsSetPrecomputedInferenceSource()
        {
            return this._precomputedInferenceSource != null;
        }

    }
}