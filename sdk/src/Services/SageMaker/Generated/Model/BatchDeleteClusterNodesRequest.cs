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
    /// Container for the parameters to the BatchDeleteClusterNodes operation.
    /// Deletes specific nodes within a SageMaker HyperPod cluster. <c>BatchDeleteClusterNodes</c>
    /// accepts a cluster name and a list of node IDs.
    /// 
    ///  <important> <ul> <li> 
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
    ///  </li> </ul> </important>
    /// </summary>
    public partial class BatchDeleteClusterNodesRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<string> _nodeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nodeLogicalIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the SageMaker HyperPod cluster from which to delete the specified nodes.
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
        /// A list of node IDs to be deleted from the specified cluster.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// For SageMaker HyperPod clusters using the Slurm workload manager, you cannot remove
        /// instances that are configured as Slurm controller nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need to delete more than 99 instances, contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for assistance.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// A list of <c>NodeLogicalIds</c> identifying the nodes to be deleted. You can specify
        /// up to 50 <c>NodeLogicalIds</c>. You must specify either <c>NodeLogicalIds</c>, <c>InstanceIds</c>,
        /// or both, with a combined maximum of 50 identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
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