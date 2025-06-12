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
    /// A summary of the models used in an Amazon Bedrock model evaluation job. These resources
    /// can be models in Amazon Bedrock or models outside of Amazon Bedrock that you use to
    /// generate your own inference response data.
    /// </summary>
    public partial class EvaluationModelConfigSummary
    {
        private List<string> _bedrockModelIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _precomputedInferenceSourceIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BedrockModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the models used for the evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> BedrockModelIdentifiers
        {
            get { return this._bedrockModelIdentifiers; }
            set { this._bedrockModelIdentifiers = value; }
        }

        // Check to see if BedrockModelIdentifiers property is set
        internal bool IsSetBedrockModelIdentifiers()
        {
            return this._bedrockModelIdentifiers != null && (this._bedrockModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrecomputedInferenceSourceIdentifiers. 
        /// <para>
        /// A label that identifies the models used for a model evaluation job where you provide
        /// your own inference response data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> PrecomputedInferenceSourceIdentifiers
        {
            get { return this._precomputedInferenceSourceIdentifiers; }
            set { this._precomputedInferenceSourceIdentifiers = value; }
        }

        // Check to see if PrecomputedInferenceSourceIdentifiers property is set
        internal bool IsSetPrecomputedInferenceSourceIdentifiers()
        {
            return this._precomputedInferenceSourceIdentifiers != null && (this._precomputedInferenceSourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}