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
    /// This is the response object from the StartBatchEvaluation operation.
    /// </summary>
    public partial class StartBatchEvaluationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BatchEvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BatchEvaluationArn { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationArn property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationArn() => this.BatchEvaluationArn != null;

        /// <summary>
        /// Gets and sets the property BatchEvaluationId. 
        /// <para>
        /// The unique identifier of the created batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BatchEvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationId property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationId() => this.BatchEvaluationId != null;

        /// <summary>
        /// Gets and sets the property BatchEvaluationName. 
        /// <para>
        /// The name of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BatchEvaluationName { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationName property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationName() => this.BatchEvaluationName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the batch evaluation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        /// The list of evaluators applied during the batch evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Evaluator> Evaluators { get; set; } = AWSConfigs.InitializeCollections ? new List<Evaluator>() : null;

        /// <summary>
        /// Checks to see if the Evaluators property is set.
        /// </summary>
        internal bool IsSetEvaluators() => this.Evaluators != null && (this.Evaluators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight analyses applied during the batch evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Insight> Insights { get; set; } = AWSConfigs.InitializeCollections ? new List<Insight>() : null;

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null && (this.Insights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt evaluation data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration specifying where evaluation results are written.
        /// </para>
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchEvaluationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the batch evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
