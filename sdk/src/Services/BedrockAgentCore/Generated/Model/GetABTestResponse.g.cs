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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the GetABTest operation.
    /// </summary>
    public partial class GetABTestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AbTestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AbTestArn { get; set; }

        /// <summary>
        /// Checks to see if the AbTestArn property is set.
        /// </summary>
        internal bool IsSetAbTestArn() => this.AbTestArn != null;

        /// <summary>
        /// Gets and sets the property AbTestId. 
        /// <para>
        /// The unique identifier of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AbTestId { get; set; }

        /// <summary>
        /// Checks to see if the AbTestId property is set.
        /// </summary>
        internal bool IsSetAbTestId() => this.AbTestId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the A/B test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentRunId. 
        /// <para>
        /// The identifier of the current run of the A/B test.
        /// </para>
        /// </summary>
        public string CurrentRunId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRunId property is set.
        /// </summary>
        internal bool IsSetCurrentRunId() => this.CurrentRunId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The error details if the A/B test encountered failures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> ErrorDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null && (this.ErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration for measuring variant performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestEvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationConfig property is set.
        /// </summary>
        internal bool IsSetEvaluationConfig() => this.EvaluationConfig != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The execution status indicating whether the A/B test is currently running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway used for traffic splitting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayFilter. 
        /// <para>
        /// The gateway filter restricting which target paths are included.
        /// </para>
        /// </summary>
        public GatewayFilter GatewayFilter { get; set; }

        /// <summary>
        /// Checks to see if the GatewayFilter property is set.
        /// </summary>
        internal bool IsSetGatewayFilter() => this.GatewayFilter != null;

        /// <summary>
        /// Gets and sets the property MaxDurationExpiresAt. 
        /// <para>
        /// The timestamp when the A/B test will automatically expire.
        /// </para>
        /// </summary>
        public DateTime? MaxDurationExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the MaxDurationExpiresAt property is set.
        /// </summary>
        internal bool IsSetMaxDurationExpiresAt() => this.MaxDurationExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The statistical results of the A/B test, including per-evaluator metrics and significance
        /// analysis.
        /// </para>
        /// </summary>
        public ABTestResults Results { get; set; }

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN used by the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the A/B test was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The timestamp when the A/B test was stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the A/B test was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// The list of variants in the A/B test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<Variant> Variants { get; set; } = AWSConfigs.InitializeCollections ? new List<Variant>() : null;

        /// <summary>
        /// Checks to see if the Variants property is set.
        /// </summary>
        internal bool IsSetVariants() => this.Variants != null && (this.Variants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
