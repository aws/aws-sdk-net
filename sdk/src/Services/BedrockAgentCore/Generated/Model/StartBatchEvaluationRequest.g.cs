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
    /// Container for the parameters to the StartBatchEvaluation operation. Starts a batch
    /// evaluation job that evaluates agent performance across multiple sessions. Batch evaluations
    /// pull agent traces from CloudWatch Logs or an existing online evaluation configuration
    /// and run specified evaluators and insights against them.
    /// </summary>
    public partial class StartBatchEvaluationRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property BatchEvaluationName. 
        /// <para>
        /// The name of the batch evaluation. Must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BatchEvaluationName { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationName property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationName() => this.BatchEvaluationName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        /// The data source configuration that specifies where to pull agent session traces from
        /// for evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceConfig DataSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfig property is set.
        /// </summary>
        internal bool IsSetDataSourceConfig() => this.DataSourceConfig != null;

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
        /// Gets and sets the property EvaluationMetadata. 
        /// <para>
        /// Optional metadata for the evaluation, including session-specific ground truth data
        /// and test scenario identifiers.
        /// </para>
        /// </summary>
        public EvaluationMetadata EvaluationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMetadata property is set.
        /// </summary>
        internal bool IsSetEvaluationMetadata() => this.EvaluationMetadata != null;

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        /// The list of evaluators to apply during the batch evaluation. Can include both built-in
        /// evaluators and custom evaluators. Maximum of 10 evaluators.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<Evaluator> Evaluators { get; set; } = AWSConfigs.InitializeCollections ? new List<Evaluator>() : null;

        /// <summary>
        /// Checks to see if the Evaluators property is set.
        /// </summary>
        internal bool IsSetEvaluators() => this.Evaluators != null && (this.Evaluators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight analyses to run against sessions during the batch evaluation.
        /// Maximum of 10 insights.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<Insight> Insights { get; set; } = AWSConfigs.InitializeCollections ? new List<Insight>() : null;

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null && (this.Insights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt evaluation data. If provided, customer data
        /// is encrypted at rest with the specified key.
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
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to associate with the batch evaluation.
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
