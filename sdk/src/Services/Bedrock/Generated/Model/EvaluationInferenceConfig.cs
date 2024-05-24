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
    /// Used to define the models you want used in your model evaluation job. Automated model
    /// evaluation jobs support only a single model. In a human-based model evaluation job,
    /// your annotator can compare the responses for up to two different models.
    /// </summary>
    public partial class EvaluationInferenceConfig
    {
        private List<EvaluationModelConfig> _models = AWSConfigs.InitializeCollections ? new List<EvaluationModelConfig>() : null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Used to specify the models.
        /// </para>
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

    }
}