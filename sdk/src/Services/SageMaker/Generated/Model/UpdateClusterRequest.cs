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
    /// Container for the parameters to the UpdateCluster operation.
    /// Updates a SageMaker HyperPod cluster.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonSageMakerRequest
    {
        private ClusterAutoScalingConfig _autoScaling;
        private string _clusterName;
        private string _clusterRole;
        private List<ClusterInstanceGroupSpecification> _instanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;
        private List<string> _instanceGroupsToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ClusterNodeRecovery _nodeRecovery;
        private List<ClusterRestrictedInstanceGroupSpecification> _restrictedInstanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterRestrictedInstanceGroupSpecification>() : null;
        private ClusterTieredStorageConfig _tieredStorageConfig;

        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// Updates the autoscaling configuration for the cluster. Use to enable or disable automatic
        /// node scaling.
        /// </para>
        /// </summary>
        public ClusterAutoScalingConfig AutoScaling
        {
            get { return this._autoScaling; }
            set { this._autoScaling = value; }
        }

        // Check to see if AutoScaling property is set
        internal bool IsSetAutoScaling()
        {
            return this._autoScaling != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Specify the name of the SageMaker HyperPod cluster you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property ClusterRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that HyperPod assumes for cluster autoscaling
        /// operations. Cannot be updated while autoscaling is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ClusterRole
        {
            get { return this._clusterRole; }
            set { this._clusterRole = value; }
        }

        // Check to see if ClusterRole property is set
        internal bool IsSetClusterRole()
        {
            return this._clusterRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Specify the instance groups to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ClusterInstanceGroupSpecification> InstanceGroups
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
        /// Gets and sets the property InstanceGroupsToDelete. 
        /// <para>
        /// Specify the names of the instance groups to delete. Use a single <c>,</c> as the separator
        /// between multiple names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InstanceGroupsToDelete
        {
            get { return this._instanceGroupsToDelete; }
            set { this._instanceGroupsToDelete = value; }
        }

        // Check to see if InstanceGroupsToDelete property is set
        internal bool IsSetInstanceGroupsToDelete()
        {
            return this._instanceGroupsToDelete != null && (this._instanceGroupsToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeRecovery. 
        /// <para>
        /// The node recovery mode to be applied to the SageMaker HyperPod cluster.
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
        /// Gets and sets the property RestrictedInstanceGroups. 
        /// <para>
        /// The specialized instance groups for training models like Amazon Nova to be created
        /// in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ClusterRestrictedInstanceGroupSpecification> RestrictedInstanceGroups
        {
            get { return this._restrictedInstanceGroups; }
            set { this._restrictedInstanceGroups = value; }
        }

        // Check to see if RestrictedInstanceGroups property is set
        internal bool IsSetRestrictedInstanceGroups()
        {
            return this._restrictedInstanceGroups != null && (this._restrictedInstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TieredStorageConfig. 
        /// <para>
        /// Updates the configuration for managed tier checkpointing on the HyperPod cluster.
        /// For example, you can enable or disable the feature and modify the percentage of cluster
        /// memory allocated for checkpoint storage.
        /// </para>
        /// </summary>
        public ClusterTieredStorageConfig TieredStorageConfig
        {
            get { return this._tieredStorageConfig; }
            set { this._tieredStorageConfig = value; }
        }

        // Check to see if TieredStorageConfig property is set
        internal bool IsSetTieredStorageConfig()
        {
            return this._tieredStorageConfig != null;
        }

    }
}