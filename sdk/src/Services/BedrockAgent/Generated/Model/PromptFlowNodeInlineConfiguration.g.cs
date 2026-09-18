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
    /// Contains configurations for a prompt defined inline in the node.
    /// </summary>
    public partial class PromptFlowNodeInlineConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// Additional fields to be included in the model request for the Prompt node.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalModelRequestFields property is set.
        /// </summary>
        internal bool IsSetAdditionalModelRequestFields() => !this.AdditionalModelRequestFields.IsNull();

        /// <summary>
        /// Gets and sets the property InferenceConfiguration. 
        /// <para>
        /// Contains inference configurations for the prompt.
        /// </para>
        /// </summary>
        public PromptInferenceConfiguration InferenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfiguration property is set.
        /// </summary>
        internal bool IsSetInferenceConfiguration() => this.InferenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a> to run inference with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// Contains a prompt and variables in the prompt that can be replaced with values at
        /// runtime.
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
        /// The type of prompt template.
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
