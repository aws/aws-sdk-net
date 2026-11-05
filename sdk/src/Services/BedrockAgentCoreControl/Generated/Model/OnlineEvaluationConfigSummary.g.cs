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
    /// The summary information about an online evaluation configuration, including basic
    /// metadata and execution status.
    /// </summary>
    public partial class OnlineEvaluationConfigSummary
    {
        /// <summary>
        /// Gets and sets the property ClusteringConfig. 
        /// <para>
        /// The clustering configuration for periodic batch evaluation.
        /// </para>
        /// </summary>
        public ClusteringConfig ClusteringConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClusteringConfig property is set.
        /// </summary>
        internal bool IsSetClusteringConfig() => this.ClusteringConfig != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the online evaluation configuration was created. 
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
        ///  The description of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  The execution status indicating whether the online evaluation is currently running.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnlineEvaluationExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason for failure if the online evaluation configuration execution failed. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight types configured for this evaluation.
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
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigArn property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigArn() => this.OnlineEvaluationConfigArn != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigId. 
        /// <para>
        ///  The unique identifier of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigId { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigId property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigId() => this.OnlineEvaluationConfigId != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigName. 
        /// <para>
        ///  The name of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigName { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigName property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigName() => this.OnlineEvaluationConfigName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnlineEvaluationConfigStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the online evaluation configuration was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
