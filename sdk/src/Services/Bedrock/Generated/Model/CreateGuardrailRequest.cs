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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGuardrail operation.
    /// Creates a guardrail to block topics and to filter out harmful content.
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
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-filters">Content
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
    ///  </li> <li> 
    /// <para>
    /// (Optional) Attach any tags to the guardrail in the <c>tags</c> object. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tagging">Tag resources</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateGuardrailRequest : AmazonBedrockRequest
    {
        private string _blockedInputMessaging;
        private string _blockedOutputsMessaging;
        private string _clientRequestToken;
        private GuardrailContentPolicyConfig _contentPolicyConfig;
        private string _description;
        private string _kmsKeyId;
        private string _name;
        private GuardrailSensitiveInformationPolicyConfig _sensitiveInformationPolicyConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private GuardrailTopicPolicyConfig _topicPolicyConfig;
        private GuardrailWordPolicyConfig _wordPolicyConfig;

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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than once. If this token matches a previous request, Amazon Bedrock ignores the request,
        /// but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentPolicyConfig. 
        /// <para>
        /// The content filter policies to configure for the guardrail.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that you use to encrypt the guardrail.
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
        /// The name to give the guardrail.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to attach to the guardrail. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicPolicyConfig. 
        /// <para>
        /// The topic policies to configure for the guardrail.
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
        /// The word policy you configure for the guardrail.
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