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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeCluster operation.
    /// </summary>
    public partial class DescribeClusterResponse : AmazonWebServiceResponse
    {
        private string _clusterArn;
        private string _clusterName;
        private ClusterStatus _clusterStatus;
        private DateTime? _creationTime;
        private string _failureMessage;
        private List<ClusterInstanceGroupDetails> _instanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupDetails>() : null;
        private ClusterNodeRecovery _nodeRecovery;
        private ClusterOrchestrator _orchestrator;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterStatus ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the SageMaker Cluster is created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// The failure message of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The instance groups of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ClusterInstanceGroupDetails> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeRecovery. 
        /// <para>
        /// The node recovery mode configured for the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterNodeRecovery NodeRecovery
        {
            get { return this._nodeRecovery; }
            set { this._nodeRecovery = value; }
        }

        // Check to see if NodeRecovery property is set
        internal bool IsSetNodeRecovery()
        {
            return this._nodeRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property Orchestrator. 
        /// <para>
        /// The type of orchestrator used for the SageMaker HyperPod cluster. 
        /// </para>
        /// </summary>
        public ClusterOrchestrator Orchestrator
        {
            get { return this._orchestrator; }
            set { this._orchestrator = value; }
        }

        // Check to see if Orchestrator property is set
        internal bool IsSetOrchestrator()
        {
            return this._orchestrator != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}