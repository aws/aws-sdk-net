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
    /// The data for the AI Guardrail
    /// </summary>
    public partial class AIGuardrailData
    {
        /// <summary>
        /// Gets and sets the property AiGuardrailArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiGuardrailArn { get; set; }

        /// <summary>
        /// Checks to see if the AiGuardrailArn property is set.
        /// </summary>
        internal bool IsSetAiGuardrailArn() => this.AiGuardrailArn != null;

        /// <summary>
        /// Gets and sets the property AiGuardrailId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiGuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the AiGuardrailId property is set.
        /// </summary>
        internal bool IsSetAiGuardrailId() => this.AiGuardrailId != null;

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
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message to return when the AI Guardrail blocks a prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public string BlockedInputMessaging { get; set; }

        /// <summary>
        /// Checks to see if the BlockedInputMessaging property is set.
        /// </summary>
        internal bool IsSetBlockedInputMessaging() => this.BlockedInputMessaging != null;

        /// <summary>
        /// Gets and sets the property BlockedOutputsMessaging. 
        /// <para>
        /// The message to return when the AI Guardrail blocks a model response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public string BlockedOutputsMessaging { get; set; }

        /// <summary>
        /// Checks to see if the BlockedOutputsMessaging property is set.
        /// </summary>
        internal bool IsSetBlockedOutputsMessaging() => this.BlockedOutputsMessaging != null;

        /// <summary>
        /// Gets and sets the property ContentPolicyConfig. 
        /// <para>
        /// Contains details about how to handle harmful content.
        /// </para>
        /// </summary>
        public AIGuardrailContentPolicyConfig ContentPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicyConfig property is set.
        /// </summary>
        internal bool IsSetContentPolicyConfig() => this.ContentPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyConfig. 
        /// <para>
        /// The policy configuration details for the AI Guardrail's contextual grounding policy.
        /// </para>
        /// </summary>
        public AIGuardrailContextualGroundingPolicyConfig ContextualGroundingPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContextualGroundingPolicyConfig property is set.
        /// </summary>
        internal bool IsSetContextualGroundingPolicyConfig() => this.ContextualGroundingPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Guardrail was last modified.
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
        /// The name of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyConfig. 
        /// <para>
        /// Contains details about PII entities and regular expressions to configure for the AI
        /// Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailSensitiveInformationPolicyConfig SensitiveInformationPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicyConfig property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicyConfig() => this.SensitiveInformationPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the AI Guardrail.
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
        /// Gets and sets the property TopicPolicyConfig. 
        /// <para>
        /// Contains details about topics that the AI Guardrail should identify and deny.
        /// </para>
        /// </summary>
        public AIGuardrailTopicPolicyConfig TopicPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicyConfig property is set.
        /// </summary>
        internal bool IsSetTopicPolicyConfig() => this.TopicPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property VisibilityStatus. 
        /// <para>
        /// The visibility status of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VisibilityStatus VisibilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityStatus property is set.
        /// </summary>
        internal bool IsSetVisibilityStatus() => this.VisibilityStatus != null;

        /// <summary>
        /// Gets and sets the property WordPolicyConfig. 
        /// <para>
        /// Contains details about the word policy to configured for the AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailWordPolicyConfig WordPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicyConfig property is set.
        /// </summary>
        internal bool IsSetWordPolicyConfig() => this.WordPolicyConfig != null;
    }
}
