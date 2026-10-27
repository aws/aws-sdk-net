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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOnlineEvaluationConfig operation. Creates
    /// an online evaluation configuration for continuous monitoring of agent performance.
    /// Online evaluation automatically samples live traffic from CloudWatch logs at specified
    /// rates and applies evaluators to assess agent quality in production.
    /// </summary>
    public partial class CreateOnlineEvaluationConfigRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusteringConfig. 
        /// <para>
        /// Configuration for periodic batch evaluation clustering of insight results.
        /// </para>
        /// </summary>
        public ClusteringConfig ClusteringConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClusteringConfig property is set.
        /// </summary>
        internal bool IsSetClusteringConfig() => this.ClusteringConfig != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        ///  The data source configuration that specifies CloudWatch log groups and service names
        /// to monitor for agent traces. 
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
        ///  The description of the online evaluation configuration that explains its monitoring
        /// purpose and scope. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableOnCreate. 
        /// <para>
        ///  Whether to enable the online evaluation configuration immediately upon creation.
        /// If true, evaluation begins automatically. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the EnableOnCreate property is set.
        /// </summary>
        internal bool IsSetEnableOnCreate() => this.EnableOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationExecutionRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role that grants permissions to read from
        /// CloudWatch logs, write evaluation results, and invoke Amazon Bedrock models for evaluation.
        /// If the configuration references evaluators encrypted with a customer managed KMS key,
        /// this role must also have <c>kms:Decrypt</c> permission on the KMS key. The service
        /// validates this permission at configuration creation time. For more information, see
        /// <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/evaluations-encryption.html">Encryption
        /// at rest for AgentCore Evaluations</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EvaluationExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetEvaluationExecutionRoleArn() => this.EvaluationExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        ///  The list of evaluators to apply during online evaluation. Can include both built-in
        /// evaluators and custom evaluators created with <c>CreateEvaluator</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<EvaluatorReference> Evaluators { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatorReference>() : null;

        /// <summary>
        /// Checks to see if the Evaluators property is set.
        /// </summary>
        internal bool IsSetEvaluators() => this.Evaluators != null && (this.Evaluators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight types to run against agent sessions.
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
        /// Gets and sets the property OnlineEvaluationConfigName. 
        /// <para>
        ///  The name of the online evaluation configuration. Must be unique within your account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigName { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigName property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigName() => this.OnlineEvaluationConfigName != null;

        /// <summary>
        /// Gets and sets the property OutputConfig.
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        ///  The evaluation rule that defines sampling configuration, filters, and session detection
        /// settings for the online evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Rule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to an AgentCore Online Evaluation Config. Tags
        /// enable you to categorize your resources in different ways, for example, by purpose,
        /// owner, or environment.
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
