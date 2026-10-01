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
    /// Container for the parameters to the UpdateAgent operation. Updates the configuration
    /// of an agent.
    /// </summary>
    public partial class UpdateAgentRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentCollaboration. 
        /// <para>
        /// The agent's collaboration role.
        /// </para>
        /// </summary>
        public AgentCollaboration AgentCollaboration { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboration property is set.
        /// </summary>
        internal bool IsSetAgentCollaboration() => this.AgentCollaboration != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// Specifies a new name for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property AgentResourceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role with permissions to invoke API operations
        /// on the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string AgentResourceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentResourceRoleArn property is set.
        /// </summary>
        internal bool IsSetAgentResourceRoleArn() => this.AgentResourceRoleArn != null;

        /// <summary>
        /// Gets and sets the property CustomOrchestration. 
        /// <para>
        ///  Contains details of the custom orchestration configured for the agent. 
        /// </para>
        /// </summary>
        public CustomOrchestration CustomOrchestration { get; set; }

        /// <summary>
        /// Checks to see if the CustomOrchestration property is set.
        /// </summary>
        internal bool IsSetCustomOrchestration() => this.CustomOrchestration != null;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key with which to encrypt the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new description of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        /// The identifier for the model that you want to be used for orchestration by the agent
        /// you create.
        /// </para>
        ///  
        /// <para>
        /// The <c>modelId</c> to provide depends on the type of model or throughput that you
        /// use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you use a base model, specify the model ID or its ARN. For a list of model IDs
        /// for base models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#model-ids-arns">Amazon
        /// Bedrock base model IDs (on-demand throughput)</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use an inference profile, specify the inference profile ID or its ARN. For
        /// a list of inference profile IDs, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference-support.html">Supported
        /// Regions and models for cross-region inference</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use a provisioned model, specify the ARN of the Provisioned Throughput. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-thru-use.html">Run
        /// inference using a Provisioned Throughput</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use a custom model, first purchase Provisioned Throughput for it. Then specify
        /// the ARN of the resulting provisioned model. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Use
        /// a custom model in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use an <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">imported
        /// model</a>, specify the ARN of the imported model. You can get the model ARN from a
        /// successful call to <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateModelImportJob.html">CreateModelImportJob</a>
        /// or from the Imported models page in the Amazon Bedrock console.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string FoundationModel { get; set; }

        /// <summary>
        /// Checks to see if the FoundationModel property is set.
        /// </summary>
        internal bool IsSetFoundationModel() => this.FoundationModel != null;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// The unique Guardrail configuration assigned to the agent when it is updated.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The number of seconds for which Amazon Bedrock keeps information about a user's conversation
        /// with the agent.
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Bedrock deletes any data provided
        /// before the timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 5400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// Specifies new instructions that tell the agent what it should do and how it should
        /// interact with users.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 40, Max = 4000)]
        public string Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property MemoryConfiguration. 
        /// <para>
        /// Specifies the new memory configuration for the agent. 
        /// </para>
        /// </summary>
        public MemoryConfiguration MemoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MemoryConfiguration property is set.
        /// </summary>
        internal bool IsSetMemoryConfiguration() => this.MemoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property OrchestrationType. 
        /// <para>
        ///  Specifies the type of orchestration strategy for the agent. This is set to <c>DEFAULT</c>
        /// orchestration type, by default. 
        /// </para>
        /// </summary>
        public OrchestrationType OrchestrationType { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationType property is set.
        /// </summary>
        internal bool IsSetOrchestrationType() => this.OrchestrationType != null;

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        /// Contains configurations to override prompts in different parts of an agent sequence.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PromptOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetPromptOverrideConfiguration() => this.PromptOverrideConfiguration != null;
    }
}
