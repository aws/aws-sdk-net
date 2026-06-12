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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private ClusteringConfig _clusteringConfig;
        private DateTime? _createdAt;
        private string _description;
        private OnlineEvaluationExecutionStatus _executionStatus;
        private string _failureReason;
        private List<Insight> _insights = AWSConfigs.InitializeCollections ? new List<Insight>() : null;
        private string _onlineEvaluationConfigArn;
        private string _onlineEvaluationConfigId;
        private string _onlineEvaluationConfigName;
        private OnlineEvaluationConfigStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ClusteringConfig. 
        /// <para>
        /// The clustering configuration for periodic batch evaluation.
        /// </para>
        /// </summary>
        public ClusteringConfig ClusteringConfig
        {
            get { return this._clusteringConfig; }
            set { this._clusteringConfig = value; }
        }

        // Check to see if ClusteringConfig property is set
        internal bool IsSetClusteringConfig()
        {
            return this._clusteringConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the online evaluation configuration was created. 
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the online evaluation configuration. 
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  The execution status indicating whether the online evaluation is currently running.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnlineEvaluationExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason for failure if the online evaluation configuration execution failed. 
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight types configured for this evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<Insight> Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null && (this._insights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigArn
        {
            get { return this._onlineEvaluationConfigArn; }
            set { this._onlineEvaluationConfigArn = value; }
        }

        // Check to see if OnlineEvaluationConfigArn property is set
        internal bool IsSetOnlineEvaluationConfigArn()
        {
            return this._onlineEvaluationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigId. 
        /// <para>
        ///  The unique identifier of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigId
        {
            get { return this._onlineEvaluationConfigId; }
            set { this._onlineEvaluationConfigId = value; }
        }

        // Check to see if OnlineEvaluationConfigId property is set
        internal bool IsSetOnlineEvaluationConfigId()
        {
            return this._onlineEvaluationConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigName. 
        /// <para>
        ///  The name of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigName
        {
            get { return this._onlineEvaluationConfigName; }
            set { this._onlineEvaluationConfigName = value; }
        }

        // Check to see if OnlineEvaluationConfigName property is set
        internal bool IsSetOnlineEvaluationConfigName()
        {
            return this._onlineEvaluationConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnlineEvaluationConfigStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the online evaluation configuration was last updated. 
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

    }
}