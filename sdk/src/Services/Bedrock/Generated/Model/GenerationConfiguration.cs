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
    /// The configuration details for response generation based on retrieved text chunks.
    /// </summary>
    public partial class GenerationConfiguration
    {
        private Dictionary<string, Amazon.Runtime.Documents.Document> _additionalModelRequestFields = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private GuardrailConfiguration _guardrailConfiguration;
        private KbInferenceConfig _kbInferenceConfig;
        private PromptTemplate _promptTemplate;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// Additional model parameters and corresponding values not included in the <c>textInferenceConfig</c>
        /// structure for a knowledge base. This allows you to provide custom model parameters
        /// specific to the language model being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> AdditionalModelRequestFields
        {
            get { return this._additionalModelRequestFields; }
            set { this._additionalModelRequestFields = value; }
        }

        // Check to see if AdditionalModelRequestFields property is set
        internal bool IsSetAdditionalModelRequestFields()
        {
            return this._additionalModelRequestFields != null && (this._additionalModelRequestFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Contains configuration details for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration
        {
            get { return this._guardrailConfiguration; }
            set { this._guardrailConfiguration = value; }
        }

        // Check to see if GuardrailConfiguration property is set
        internal bool IsSetGuardrailConfiguration()
        {
            return this._guardrailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KbInferenceConfig. 
        /// <para>
        /// Contains configuration details for inference for knowledge base retrieval and response
        /// generation.
        /// </para>
        /// </summary>
        public KbInferenceConfig KbInferenceConfig
        {
            get { return this._kbInferenceConfig; }
            set { this._kbInferenceConfig = value; }
        }

        // Check to see if KbInferenceConfig property is set
        internal bool IsSetKbInferenceConfig()
        {
            return this._kbInferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PromptTemplate. 
        /// <para>
        /// Contains the template for the prompt that's sent to the model for response generation.
        /// </para>
        /// </summary>
        public PromptTemplate PromptTemplate
        {
            get { return this._promptTemplate; }
            set { this._promptTemplate = value; }
        }

        // Check to see if PromptTemplate property is set
        internal bool IsSetPromptTemplate()
        {
            return this._promptTemplate != null;
        }

    }
}