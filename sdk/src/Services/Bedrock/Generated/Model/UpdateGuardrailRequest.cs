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
    /// Container for the parameters to the UpdateGuardrail operation.
    /// Updates a guardrail with the values you specify.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Specify a <c>name</c> and optional <c>description</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify messages for when the guardrail successfully blocks a prompt or a model response
    /// in the <c>blockedInputMessaging</c> and <c>blockedOutputsMessaging</c> fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify topics for the guardrail to deny in the <c>topicPolicyConfig</c> object. Each
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailTopicConfig.html">GuardrailTopicConfig</a>
    /// object in the <c>topicsConfig</c> list pertains to one topic.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Give a <c>name</c> and <c>description</c> so that the guardrail can properly identify
    /// the topic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify <c>DENY</c> in the <c>type</c> field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Provide up to five prompts that you would categorize as belonging to the
    /// topic in the <c>examples</c> list.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Specify filter strengths for the harmful categories defined in Amazon Bedrock in the
    /// <c>contentPolicyConfig</c> object. Each <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>
    /// object in the <c>filtersConfig</c> list pertains to a harmful category. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-content-filters">Content
    /// filters</a>. For more information about the fields in a content filter, see <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the category in the <c>type</c> field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify the strength of the filter for prompts in the <c>inputStrength</c> field and
    /// for model responses in the <c>strength</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// (Optional) For security, include the ARN of a KMS key in the <c>kmsKeyId</c> field.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateGuardrailRequest : AmazonBedrockRequest
    {
        private GuardrailAutomatedReasoningPolicyConfig _automatedReasoningPolicyConfig;
        private string _blockedInputMessaging;
        private string _blockedOutputsMessaging;
        private GuardrailContentPolicyConfig _contentPolicyConfig;
        private GuardrailContextualGroundingPolicyConfig _contextualGroundingPolicyConfig;
        private GuardrailCrossRegionConfig _crossRegionConfig;
        private string _description;
        private string _guardrailIdentifier;
        private string _kmsKeyId;
        private string _name;
        private GuardrailSensitiveInformationPolicyConfig _sensitiveInformationPolicyConfig;
        private GuardrailTopicPolicyConfig _topicPolicyConfig;
        private GuardrailWordPolicyConfig _wordPolicyConfig;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicyConfig. 
        /// <para>
        /// Updated configuration for Automated Reasoning policies associated with the guardrail.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicyConfig AutomatedReasoningPolicyConfig
        {
            get { return this._automatedReasoningPolicyConfig; }
            set { this._automatedReasoningPolicyConfig = value; }
        }

        // Check to see if AutomatedReasoningPolicyConfig property is set
        internal bool IsSetAutomatedReasoningPolicyConfig()
        {
            return this._automatedReasoningPolicyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message to return when the guardrail blocks a prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=500)]
        public string BlockedInputMessaging
        {
            get { return this._blockedInputMessaging; }
            set { this._blockedInputMessaging = value; }
        }

        // Check to see if BlockedInputMessaging property is set
        internal bool IsSetBlockedInputMessaging()
        {
            return this._blockedInputMessaging != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedOutputsMessaging. 
        /// <para>
        /// The message to return when the guardrail blocks a model response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=500)]
        public string BlockedOutputsMessaging
        {
            get { return this._blockedOutputsMessaging; }
            set { this._blockedOutputsMessaging = value; }
        }

        // Check to see if BlockedOutputsMessaging property is set
        internal bool IsSetBlockedOutputsMessaging()
        {
            return this._blockedOutputsMessaging != null;
        }

        /// <summary>
        /// Gets and sets the property ContentPolicyConfig. 
        /// <para>
        /// The content policy to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContentPolicyConfig ContentPolicyConfig
        {
            get { return this._contentPolicyConfig; }
            set { this._contentPolicyConfig = value; }
        }

        // Check to see if ContentPolicyConfig property is set
        internal bool IsSetContentPolicyConfig()
        {
            return this._contentPolicyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyConfig. 
        /// <para>
        /// The contextual grounding policy configuration used to update a guardrail.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicyConfig ContextualGroundingPolicyConfig
        {
            get { return this._contextualGroundingPolicyConfig; }
            set { this._contextualGroundingPolicyConfig = value; }
        }

        // Check to see if ContextualGroundingPolicyConfig property is set
        internal bool IsSetContextualGroundingPolicyConfig()
        {
            return this._contextualGroundingPolicyConfig != null;
        }

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
        public GuardrailCrossRegionConfig CrossRegionConfig
        {
            get { return this._crossRegionConfig; }
            set { this._crossRegionConfig = value; }
        }

        // Check to see if CrossRegionConfig property is set
        internal bool IsSetCrossRegionConfig()
        {
            return this._crossRegionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The unique identifier of the guardrail. This can be an ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string GuardrailIdentifier
        {
            get { return this._guardrailIdentifier; }
            set { this._guardrailIdentifier = value; }
        }

        // Check to see if GuardrailIdentifier property is set
        internal bool IsSetGuardrailIdentifier()
        {
            return this._guardrailIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key with which to encrypt the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyConfig. 
        /// <para>
        /// The sensitive information policy to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicyConfig SensitiveInformationPolicyConfig
        {
            get { return this._sensitiveInformationPolicyConfig; }
            set { this._sensitiveInformationPolicyConfig = value; }
        }

        // Check to see if SensitiveInformationPolicyConfig property is set
        internal bool IsSetSensitiveInformationPolicyConfig()
        {
            return this._sensitiveInformationPolicyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TopicPolicyConfig. 
        /// <para>
        /// The topic policy to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicyConfig TopicPolicyConfig
        {
            get { return this._topicPolicyConfig; }
            set { this._topicPolicyConfig = value; }
        }

        // Check to see if TopicPolicyConfig property is set
        internal bool IsSetTopicPolicyConfig()
        {
            return this._topicPolicyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WordPolicyConfig. 
        /// <para>
        /// The word policy to configure for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailWordPolicyConfig WordPolicyConfig
        {
            get { return this._wordPolicyConfig; }
            set { this._wordPolicyConfig = value; }
        }

        // Check to see if WordPolicyConfig property is set
        internal bool IsSetWordPolicyConfig()
        {
            return this._wordPolicyConfig != null;
        }

    }
}