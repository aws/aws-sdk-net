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
    /// Container for the parameters to the CreateGuardrail operation. Creates a guardrail
    /// to block topics and to implement safeguards for your generative AI applications. <para>
    /// You can configure the following policies in a guardrail to avoid undesirable and harmful
    /// content, filter out denied topics and words, and remove sensitive information for
    /// privacy protection. </para> <ul> <li> <para> <b>Content filters</b> - Adjust filter
    /// strengths to block input prompts or model responses containing harmful content. </para>
    /// </li> <li> <para> <b>Denied topics</b> - Define a set of topics that are undesirable
    /// in the context of your application. These topics will be blocked if detected in user
    /// queries or model responses. </para> </li> <li> <para> <b>Word filters</b> - Configure
    /// filters to block undesirable words, phrases, and profanity. Such words can include
    /// offensive terms, competitor names etc. </para> </li> <li> <para> <b>Sensitive information
    /// filters</b> - Block or mask sensitive information such as personally identifiable
    /// information (PII) or custom regex in user inputs and model responses. </para> </li>
    /// </ul> <para> In addition to the above policies, you can also configure the messages
    /// to be returned to the user if a user input or model response is in violation of the
    /// policies defined in the guardrail. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">Amazon
    /// Bedrock Guardrails</a> in the <i>Amazon Bedrock User Guide</i>. </para>
    /// </summary>
    public partial class CreateGuardrailRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicyConfig. 
        /// <para>
        /// Optional configuration for integrating Automated Reasoning policies with the new guardrail.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicyConfig AutomatedReasoningPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedReasoningPolicyConfig property is set.
        /// </summary>
        internal bool IsSetAutomatedReasoningPolicyConfig() => this.AutomatedReasoningPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message to return when the guardrail blocks a prompt.
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
        /// The message to return when the guardrail blocks a model response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public string BlockedOutputsMessaging { get; set; }

        /// <summary>
        /// Checks to see if the BlockedOutputsMessaging property is set.
        /// </summary>
        internal bool IsSetBlockedOutputsMessaging() => this.BlockedOutputsMessaging != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than once. If this token matches a previous request, Amazon Bedrock ignores the request,
        /// but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ContentPolicyConfig. 
        /// <para>
        /// The content filter policies to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContentPolicyConfig ContentPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicyConfig property is set.
        /// </summary>
        internal bool IsSetContentPolicyConfig() => this.ContentPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyConfig. 
        /// <para>
        /// The contextual grounding policy configuration used to create a guardrail.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicyConfig ContextualGroundingPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContextualGroundingPolicyConfig property is set.
        /// </summary>
        internal bool IsSetContextualGroundingPolicyConfig() => this.ContextualGroundingPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property CrossRegionConfig. 
        /// <para>
        /// The system-defined guardrail profile that you're using with your guardrail. Guardrail
        /// profiles define the destination Amazon Web Services Regions where guardrail inference
        /// requests can be automatically routed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        public GuardrailCrossRegionConfig CrossRegionConfig { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionConfig property is set.
        /// </summary>
        internal bool IsSetCrossRegionConfig() => this.CrossRegionConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that you use to encrypt the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to give the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyConfig. 
        /// <para>
        /// The sensitive information policy to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicyConfig SensitiveInformationPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicyConfig property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicyConfig() => this.SensitiveInformationPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to attach to the guardrail. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicPolicyConfig. 
        /// <para>
        /// The topic policies to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicyConfig TopicPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicyConfig property is set.
        /// </summary>
        internal bool IsSetTopicPolicyConfig() => this.TopicPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property WordPolicyConfig. 
        /// <para>
        /// The word policy you configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailWordPolicyConfig WordPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicyConfig property is set.
        /// </summary>
        internal bool IsSetWordPolicyConfig() => this.WordPolicyConfig != null;
    }
}
