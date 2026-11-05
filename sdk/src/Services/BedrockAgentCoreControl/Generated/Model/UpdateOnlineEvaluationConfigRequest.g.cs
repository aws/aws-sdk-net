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
    /// Container for the parameters to the UpdateOnlineEvaluationConfig operation. Updates
    /// an online evaluation configuration's settings, including rules, data sources, evaluators,
    /// and execution status. Changes take effect immediately for ongoing evaluations.
    /// </summary>
    public partial class UpdateOnlineEvaluationConfigRequest : AmazonBedrockAgentCoreControlRequest
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
        /// The updated clustering configuration for periodic batch evaluation.
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
        ///  The updated data source configuration specifying CloudWatch log groups and service
        /// names to monitor. 
        /// </para>
        /// </summary>
        public DataSourceConfig DataSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfig property is set.
        /// </summary>
        internal bool IsSetDataSourceConfig() => this.DataSourceConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The updated description of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluationExecutionRoleArn. 
        /// <para>
        ///  The updated Amazon Resource Name (ARN) of the IAM role used for evaluation execution.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EvaluationExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetEvaluationExecutionRoleArn() => this.EvaluationExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        ///  The updated list of evaluators to apply during online evaluation. 
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  The updated execution status to enable or disable the online evaluation. 
        /// </para>
        /// </summary>
        public OnlineEvaluationExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The updated list of insight types to run against agent sessions.
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
        /// Gets and sets the property OnlineEvaluationConfigId. 
        /// <para>
        ///  The unique identifier of the online evaluation configuration to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigId { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigId property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigId() => this.OnlineEvaluationConfigId != null;

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
        ///  The updated evaluation rule containing sampling configuration, filters, and session
        /// settings. 
        /// </para>
        /// </summary>
        public Rule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;
    }
}
