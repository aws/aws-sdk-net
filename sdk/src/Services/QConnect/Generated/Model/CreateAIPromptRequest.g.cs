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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAIPrompt operation. Creates an Amazon Q
    /// in Connect AI Prompt.
    /// </summary>
    public partial class CreateAIPromptRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ApiFormat. 
        /// <para>
        /// The API Format of the AI Prompt.
        /// </para>
        ///  
        /// <para>
        /// Recommended values: <c>MESSAGES | TEXT_COMPLETIONS</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The values <c>ANTHROPIC_CLAUDE_MESSAGES | ANTHROPIC_CLAUDE_TEXT_COMPLETIONS</c> will
        /// be deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIPromptAPIFormat ApiFormat { get; set; }

        /// <summary>
        /// Checks to see if the ApiFormat property is set.
        /// </summary>
        internal bool IsSetApiFormat() => this.ApiFormat != null;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>..
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InferenceConfiguration. 
        /// <para>
        /// The inference configuration for the AI Prompt being created.
        /// </para>
        /// </summary>
        public AIPromptInferenceConfiguration InferenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfiguration property is set.
        /// </summary>
        internal bool IsSetInferenceConfiguration() => this.InferenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the model used for this AI Prompt.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about which models are supported in each Amazon Web Services Region,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-ai-prompts.html#cli-create-aiprompt">Supported
        /// models for system/custom prompts</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The configuration of the prompt template for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIPromptTemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TemplateConfiguration property is set.
        /// </summary>
        internal bool IsSetTemplateConfiguration() => this.TemplateConfiguration != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of the prompt template for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIPromptTemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIPromptType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VisibilityStatus. 
        /// <para>
        /// The visibility status of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VisibilityStatus VisibilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityStatus property is set.
        /// </summary>
        internal bool IsSetVisibilityStatus() => this.VisibilityStatus != null;
    }
}
