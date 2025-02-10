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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// Container for the parameters to the CreateAIGuardrail operation.
    /// Creates an Amazon Q in Connect AI Guardrail.
    /// </summary>
    public partial class CreateAIGuardrailRequest : AmazonQConnectRequest
    {
        private string _assistantId;
        private string _blockedInputMessaging;
        private string _blockedOutputsMessaging;
        private string _clientToken;
        private AIGuardrailContentPolicyConfig _contentPolicyConfig;
        private AIGuardrailContextualGroundingPolicyConfig _contextualGroundingPolicyConfig;
        private string _description;
        private string _name;
        private AIGuardrailSensitiveInformationPolicyConfig _sensitiveInformationPolicyConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AIGuardrailTopicPolicyConfig _topicPolicyConfig;
        private VisibilityStatus _visibilityStatus;
        private AIGuardrailWordPolicyConfig _wordPolicyConfig;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message to return when the AI Guardrail blocks a prompt.
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
        /// The message to return when the AI Guardrail blocks a model response.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>..
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentPolicyConfig. 
        /// <para>
        /// The content filter policies to configure for the AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailContentPolicyConfig ContentPolicyConfig
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
        /// The contextual grounding policy configuration used to create an AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailContextualGroundingPolicyConfig ContextualGroundingPolicyConfig
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the AI Guardrail.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The sensitive information policy to configure for the AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailSensitiveInformationPolicyConfig SensitiveInformationPolicyConfig
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
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
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
        /// The topic policies to configure for the AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailTopicPolicyConfig TopicPolicyConfig
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
        /// Gets and sets the property VisibilityStatus. 
        /// <para>
        /// The visibility status of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisibilityStatus VisibilityStatus
        {
            get { return this._visibilityStatus; }
            set { this._visibilityStatus = value; }
        }

        // Check to see if VisibilityStatus property is set
        internal bool IsSetVisibilityStatus()
        {
            return this._visibilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property WordPolicyConfig. 
        /// <para>
        /// The word policy you configure for the AI Guardrail.
        /// </para>
        /// </summary>
        public AIGuardrailWordPolicyConfig WordPolicyConfig
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