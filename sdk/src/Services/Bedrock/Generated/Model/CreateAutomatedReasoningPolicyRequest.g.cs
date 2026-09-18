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
    /// Container for the parameters to the CreateAutomatedReasoningPolicy operation. Creates
    /// an Automated Reasoning policy for Amazon Bedrock Guardrails. Automated Reasoning policies
    /// use mathematical techniques to detect hallucinations, suggest corrections, and highlight
    /// unstated assumptions in the responses of your GenAI application. <para> To create
    /// a policy, you upload a source document that describes the rules that you're encoding.
    /// Automated Reasoning extracts important concepts from the source document that will
    /// become variables in the policy and infers policy rules. </para>
    /// </summary>
    public partial class CreateAutomatedReasoningPolicyRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than once. If this token matches a previous request, Amazon Bedrock ignores the request
        /// but doesn't return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Automated Reasoning policy. Use this to provide context about
        /// the policy's purpose and the types of validations it performs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key to use for encrypting the automated reasoning policy
        /// and its associated artifacts. If you don't specify a KMS key, Amazon Bedrock uses
        /// an KMS managed key for encryption. For enhanced security and control, you can specify
        /// a customer managed KMS key.
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
        /// A unique name for the Automated Reasoning policy. The name must be between 1 and 63
        /// characters and can contain letters, numbers, hyphens, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyDefinition. 
        /// <para>
        /// The policy definition that contains the formal logic rules, variables, and custom
        /// variable types used to validate foundation model responses in your application.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinition PolicyDefinition { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDefinition property is set.
        /// </summary>
        internal bool IsSetPolicyDefinition() => this.PolicyDefinition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the Automated Reasoning policy. Tags help you organize
        /// and manage your policies.
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
    }
}
