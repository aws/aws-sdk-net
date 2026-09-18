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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Defines the models used in the model evaluation job.
    /// </summary>
    public partial class EvaluationModelConfig
    {
        /// <summary>
        /// Gets and sets the property BedrockModel. 
        /// <para>
        /// Defines the Amazon Bedrock model or inference profile and inference parameters you
        /// want used.
        /// </para>
        /// </summary>
        public EvaluationBedrockModel BedrockModel { get; set; }

        /// <summary>
        /// Checks to see if the BedrockModel property is set.
        /// </summary>
        internal bool IsSetBedrockModel() => this.BedrockModel != null;

        /// <summary>
        /// Gets and sets the property PrecomputedInferenceSource. 
        /// <para>
        /// Defines the model used to generate inference response data for a model evaluation
        /// job where you provide your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedInferenceSource PrecomputedInferenceSource { get; set; }

        /// <summary>
        /// Checks to see if the PrecomputedInferenceSource property is set.
        /// </summary>
        internal bool IsSetPrecomputedInferenceSource() => this.PrecomputedInferenceSource != null;
    }
}
