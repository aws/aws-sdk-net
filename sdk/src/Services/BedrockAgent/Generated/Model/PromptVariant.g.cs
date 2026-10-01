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
    /// Contains details about a variant of the prompt.
    /// </summary>
    public partial class PromptVariant
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// Contains model-specific inference configurations that aren't in the <c>inferenceConfiguration</c>
        /// field. To see model-specific inference parameters, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// request parameters and response fields for foundation models</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalModelRequestFields property is set.
        /// </summary>
        internal bool IsSetAdditionalModelRequestFields() => !this.AdditionalModelRequestFields.IsNull();

        /// <summary>
        /// Gets and sets the property GenAiResource. 
        /// <para>
        /// Specifies a generative AI resource with which to use the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PromptGenAiResource GenAiResource { get; set; }

        /// <summary>
        /// Checks to see if the GenAiResource property is set.
        /// </summary>
        internal bool IsSetGenAiResource() => this.GenAiResource != null;

        /// <summary>
        /// Gets and sets the property InferenceConfiguration. 
        /// <para>
        /// Contains inference configurations for the prompt variant.
        /// </para>
        /// </summary>
        public PromptInferenceConfiguration InferenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfiguration property is set.
        /// </summary>
        internal bool IsSetInferenceConfiguration() => this.InferenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// An array of objects, each containing a key-value pair that defines a metadata tag
        /// and value to attach to a prompt variant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public List<PromptMetadataEntry> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new List<PromptMetadataEntry>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a> with which to run inference on the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the prompt variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// Contains configurations for the prompt template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptTemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TemplateConfiguration property is set.
        /// </summary>
        internal bool IsSetTemplateConfiguration() => this.TemplateConfiguration != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of prompt template to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptTemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;
    }
}
