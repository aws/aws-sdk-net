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
    /// Container for the parameters to the BatchReplaceClusterNodes operation.
    /// Replaces specific nodes within a SageMaker HyperPod cluster with new hardware. <c>BatchReplaceClusterNodes</c>
    /// terminates the specified instances and provisions new replacement instances with the
    /// same configuration but fresh hardware. The Amazon Machine Image (AMI) and instance
    /// configuration remain the same.
    /// 
    ///  
    /// <para>
    /// This operation is useful for recovering from hardware failures or persistent issues
    /// that cannot be resolved through a reboot.
    /// </para>
    ///  <important> <ul> <li> 
    /// <para>
    ///  <b>Data Loss Warning:</b> Replacing nodes destroys all instance volumes, including
    /// both root and secondary volumes. All data stored on these volumes will be permanently
    /// lost and cannot be recovered.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To safeguard your work, back up your data to Amazon S3 or an FSx for Lustre file system
    /// before invoking the API on a worker node group. This will help prevent any potential
    /// data loss from the instance root volume. For more information about backup, see <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate-cli-command.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software-backup">Use
    /// the backup script provided by SageMaker HyperPod</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you want to invoke this API on an existing cluster, you'll first need to patch
    /// the cluster by running the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateClusterSoftware.html">UpdateClusterSoftware
    /// API</a>. For more information about patching a cluster, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate-cli-command.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software">Update
    /// the SageMaker HyperPod platform software of a cluster</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can replace up to 25 nodes in a single request.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class BatchReplaceClusterNodesRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<string> _nodeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nodeLogicalIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the SageMaker HyperPod cluster containing
        /// the nodes to replace.
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
        /// Gets and sets the property NodeIds. 
        /// <para>
        /// A list of EC2 instance IDs to replace with new hardware. You can specify between 1
        /// and 25 instance IDs.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replace operations destroy all instance volumes (root and secondary). Ensure you have
        /// backed up any important data before proceeding.
        /// </para>
        ///  </important> <note> <ul> <li> 
        /// <para>
        /// Either <c>NodeIds</c> or <c>NodeLogicalIds</c> must be provided (or both), but at
        /// least one is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each instance ID must follow the pattern <c>i-</c> followed by 17 hexadecimal characters
        /// (for example, <c>i-0123456789abcdef0</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For SageMaker HyperPod clusters using the Slurm workload manager, you cannot replace
        /// instances that are configured as Slurm controller nodes.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> NodeIds
        {
            get { return this._nodeIds; }
            set { this._nodeIds = value; }
        }

        // Check to see if NodeIds property is set
        internal bool IsSetNodeIds()
        {
            return this._nodeIds != null && (this._nodeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeLogicalIds. 
        /// <para>
        /// A list of logical node IDs to replace with new hardware. You can specify between 1
        /// and 25 logical node IDs.
        /// </para>
        ///  
        /// <para>
        /// The <c>NodeLogicalId</c> is a unique identifier that persists throughout the node's
        /// lifecycle and can be used to track nodes that are still being provisioned and don't
        /// yet have an EC2 instance ID assigned.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// Replace operations destroy all instance volumes (root and secondary). Ensure you have
        /// backed up any important data before proceeding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is only supported for clusters using <c>Continuous</c> as the <c>NodeProvisioningMode</c>.
        /// For clusters using the default provisioning mode, use <c>NodeIds</c> instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Either <c>NodeIds</c> or <c>NodeLogicalIds</c> must be provided (or both), but at
        /// least one is required.
        /// </para>
        ///  </li> </ul> </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> NodeLogicalIds
        {
            get { return this._nodeLogicalIds; }
            set { this._nodeLogicalIds = value; }
        }

        // Check to see if NodeLogicalIds property is set
        internal bool IsSetNodeLogicalIds()
        {
            return this._nodeLogicalIds != null && (this._nodeLogicalIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}