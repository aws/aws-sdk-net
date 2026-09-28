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
    /// The summary of the AI Prompt.
    /// </summary>
    public partial class AIPromptSummary
    {
        /// <summary>
        /// Gets and sets the property AiPromptArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiPromptArn { get; set; }

        /// <summary>
        /// Checks to see if the AiPromptArn property is set.
        /// </summary>
        internal bool IsSetAiPromptArn() => this.AiPromptArn != null;

        /// <summary>
        /// Gets and sets the property AiPromptId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiPromptId { get; set; }

        /// <summary>
        /// Checks to see if the AiPromptId property is set.
        /// </summary>
        internal bool IsSetAiPromptId() => this.AiPromptId != null;

        /// <summary>
        /// Gets and sets the property ApiFormat. 
        /// <para>
        /// The API format used for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIPromptAPIFormat ApiFormat { get; set; }

        /// <summary>
        /// Checks to see if the ApiFormat property is set.
        /// </summary>
        internal bool IsSetApiFormat() => this.ApiFormat != null;

        /// <summary>
        /// Gets and sets the property AssistantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q in Connect assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantArn { get; set; }

        /// <summary>
        /// Checks to see if the AssistantArn property is set.
        /// </summary>
        internal bool IsSetAssistantArn() => this.AssistantArn != null;

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
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the model used for this AI Prompt. Model Ids supported are: <c>anthropic.claude-3-haiku-20240307-v1:0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Prompt was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTime property is set.
        /// </summary>
        internal bool IsSetModifiedTime() => this.ModifiedTime.HasValue;

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
        /// Gets and sets the property Origin. 
        /// <para>
        /// The origin of the AI Prompt. <c>SYSTEM</c> for a default AI Prompt created by Q in
        /// Connect or <c>CUSTOMER</c> for an AI Prompt created by calling AI Prompt creation
        /// APIs. 
        /// </para>
        /// </summary>
        public Origin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the AI Prompt.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
