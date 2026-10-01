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
    /// This is the response object from the GetGuardrail operation.
    /// </summary>
    public partial class GetGuardrailResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicy. 
        /// <para>
        /// The current Automated Reasoning policy configuration for the guardrail, if any is
        /// configured.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicy AutomatedReasoningPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedReasoningPolicy property is set.
        /// </summary>
        internal bool IsSetAutomatedReasoningPolicy() => this.AutomatedReasoningPolicy != null;

        /// <summary>
        /// Gets and sets the property BlockedInputMessaging. 
        /// <para>
        /// The message that the guardrail returns when it blocks a prompt.
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
        /// The message that the guardrail returns when it blocks a model response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public string BlockedOutputsMessaging { get; set; }

        /// <summary>
        /// Checks to see if the BlockedOutputsMessaging property is set.
        /// </summary>
        internal bool IsSetBlockedOutputsMessaging() => this.BlockedOutputsMessaging != null;

        /// <summary>
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// The content policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContentPolicy ContentPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicy property is set.
        /// </summary>
        internal bool IsSetContentPolicy() => this.ContentPolicy != null;

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicy. 
        /// <para>
        /// The contextual grounding policy used in the guardrail.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicy ContextualGroundingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContextualGroundingPolicy property is set.
        /// </summary>
        internal bool IsSetContextualGroundingPolicy() => this.ContextualGroundingPolicy != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time at which the guardrail was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CrossRegionDetails. 
        /// <para>
        /// Details about the system-defined guardrail profile that you're using with your guardrail,
        /// including the guardrail profile ID and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public GuardrailCrossRegionDetails CrossRegionDetails { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionDetails property is set.
        /// </summary>
        internal bool IsSetCrossRegionDetails() => this.CrossRegionDetails != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureRecommendations. 
        /// <para>
        /// Appears if the <c>status</c> of the guardrail is <c>FAILED</c>. A list of recommendations
        /// to carry out before retrying the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> FailureRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureRecommendations property is set.
        /// </summary>
        internal bool IsSetFailureRecommendations() => this.FailureRecommendations != null && (this.FailureRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string GuardrailArn { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailArn property is set.
        /// </summary>
        internal bool IsSetGuardrailArn() => this.GuardrailArn != null;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique identifier of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string GuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailId property is set.
        /// </summary>
        internal bool IsSetGuardrailId() => this.GuardrailId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key that encrypts the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// The sensitive information policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicy SensitiveInformationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicy property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicy() => this.SensitiveInformationPolicy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Appears if the <c>status</c> is <c>FAILED</c>. A list of reasons for why the guardrail
        /// failed to be created, updated, versioned, or deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// The topic policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicy TopicPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicy property is set.
        /// </summary>
        internal bool IsSetTopicPolicy() => this.TopicPolicy != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the guardrail was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property WordPolicy. 
        /// <para>
        /// The word policy that was configured for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailWordPolicy WordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicy property is set.
        /// </summary>
        internal bool IsSetWordPolicy() => this.WordPolicy != null;
    }
}
