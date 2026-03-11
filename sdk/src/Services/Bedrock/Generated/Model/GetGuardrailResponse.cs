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
    /// This is the response object from the GetGuardrail operation.
    /// </summary>
    public partial class GetGuardrailResponse : AmazonWebServiceResponse
    {
        private GuardrailAutomatedReasoningPolicy _automatedReasoningPolicy;
        private string _blockedInputMessaging;
        private string _blockedOutputsMessaging;
        private GuardrailContentPolicy _contentPolicy;
        private GuardrailContextualGroundingPolicy _contextualGroundingPolicy;
        private DateTime? _createdAt;
        private GuardrailCrossRegionDetails _crossRegionDetails;
        private string _description;
        private List<string> _failureRecommendations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _guardrailArn;
        private string _guardrailId;
        private string _kmsKeyArn;
        private string _name;
        private GuardrailSensitiveInformationPolicy _sensitiveInformationPolicy;
        private GuardrailStatus _status;
        private List<string> _statusReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GuardrailTopicPolicy _topicPolicy;
        private DateTime? _updatedAt;
        private string _version;
        private GuardrailWordPolicy _wordPolicy;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicy. 
        /// <para>
        /// The current Automated Reasoning policy configuration for the guardrail, if any is
        /// configured.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicy AutomatedReasoningPolicy
        {
            get { return this._automatedReasoningPolicy; }
            set { this._automatedReasoningPolicy = value; }
        }

        // Check to see if AutomatedReasoningPolicy property is set
        internal bool IsSetAutomatedReasoningPolicy()
        {
            return this._automatedReasoningPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message that the guardrail returns when it blocks a prompt.
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
        /// The message that the guardrail returns when it blocks a model response.
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
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// The content policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContentPolicy ContentPolicy
        {
            get { return this._contentPolicy; }
            set { this._contentPolicy = value; }
        }

        // Check to see if ContentPolicy property is set
        internal bool IsSetContentPolicy()
        {
            return this._contentPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicy. 
        /// <para>
        /// The contextual grounding policy used in the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicy ContextualGroundingPolicy
        {
            get { return this._contextualGroundingPolicy; }
            set { this._contextualGroundingPolicy = value; }
        }

        // Check to see if ContextualGroundingPolicy property is set
        internal bool IsSetContextualGroundingPolicy()
        {
            return this._contextualGroundingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time at which the guardrail was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossRegionDetails. 
        /// <para>
        /// Details about the system-defined guardrail profile that you're using with your guardrail,
        /// including the guardrail profile ID and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public GuardrailCrossRegionDetails CrossRegionDetails
        {
            get { return this._crossRegionDetails; }
            set { this._crossRegionDetails = value; }
        }

        // Check to see if CrossRegionDetails property is set
        internal bool IsSetCrossRegionDetails()
        {
            return this._crossRegionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the guardrail.
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
        /// Gets and sets the property FailureRecommendations. 
        /// <para>
        /// Appears if the <c>status</c> of the guardrail is <c>FAILED</c>. A list of recommendations
        /// to carry out before retrying the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> FailureRecommendations
        {
            get { return this._failureRecommendations; }
            set { this._failureRecommendations = value; }
        }

        // Check to see if FailureRecommendations property is set
        internal bool IsSetFailureRecommendations()
        {
            return this._failureRecommendations != null && (this._failureRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string GuardrailArn
        {
            get { return this._guardrailArn; }
            set { this._guardrailArn = value; }
        }

        // Check to see if GuardrailArn property is set
        internal bool IsSetGuardrailArn()
        {
            return this._guardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique identifier of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string GuardrailId
        {
            get { return this._guardrailId; }
            set { this._guardrailId = value; }
        }

        // Check to see if GuardrailId property is set
        internal bool IsSetGuardrailId()
        {
            return this._guardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key that encrypts the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the guardrail.
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
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// The sensitive information policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicy SensitiveInformationPolicy
        {
            get { return this._sensitiveInformationPolicy; }
            set { this._sensitiveInformationPolicy = value; }
        }

        // Check to see if SensitiveInformationPolicy property is set
        internal bool IsSetSensitiveInformationPolicy()
        {
            return this._sensitiveInformationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Appears if the <c>status</c> is <c>FAILED</c>. A list of reasons for why the guardrail
        /// failed to be created, updated, versioned, or deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> StatusReasons
        {
            get { return this._statusReasons; }
            set { this._statusReasons = value; }
        }

        // Check to see if StatusReasons property is set
        internal bool IsSetStatusReasons()
        {
            return this._statusReasons != null && (this._statusReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// The topic policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicy TopicPolicy
        {
            get { return this._topicPolicy; }
            set { this._topicPolicy = value; }
        }

        // Check to see if TopicPolicy property is set
        internal bool IsSetTopicPolicy()
        {
            return this._topicPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the guardrail was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property WordPolicy. 
        /// <para>
        /// The word policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailWordPolicy WordPolicy
        {
            get { return this._wordPolicy; }
            set { this._wordPolicy = value; }
        }

        // Check to see if WordPolicy property is set
        internal bool IsSetWordPolicy()
        {
            return this._wordPolicy != null;
        }

    }
}