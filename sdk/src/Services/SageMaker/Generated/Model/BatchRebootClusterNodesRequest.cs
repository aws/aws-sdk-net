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
    /// Container for the parameters to the BatchRebootClusterNodes operation.
    /// Reboots specific nodes within a SageMaker HyperPod cluster using a soft recovery mechanism.
    /// <c>BatchRebootClusterNodes</c> performs a graceful reboot of the specified nodes by
    /// calling the Amazon Elastic Compute Cloud <c>RebootInstances</c> API, which attempts
    /// to cleanly shut down the operating system before restarting the instance.
    /// 
    ///  
    /// <para>
    /// This operation is useful for recovering from transient issues or applying certain
    /// configuration changes that require a restart.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Rebooting a node may cause temporary service interruption for workloads running on
    /// that node. Ensure your workloads can handle node restarts or use appropriate scheduling
    /// to minimize impact.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can reboot up to 25 nodes in a single request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For SageMaker HyperPod clusters using the Slurm workload manager, ensure rebooting
    /// nodes will not disrupt critical cluster operations.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class BatchRebootClusterNodesRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<string> _nodeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nodeLogicalIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the SageMaker HyperPod cluster containing
        /// the nodes to reboot.
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
        /// A list of EC2 instance IDs to reboot using soft recovery. You can specify between
        /// 1 and 25 instance IDs.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Either <c>NodeIds</c> or <c>NodeLogicalIds</c> must be provided (or both), but at
        /// least one is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each instance ID must follow the pattern <c>i-</c> followed by 17 hexadecimal characters
        /// (for example, <c>i-0123456789abcdef0</c>).
        /// </para>
        ///  </li> </ul> </note>
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
        /// A list of logical node IDs to reboot using soft recovery. You can specify between
        /// 1 and 25 logical node IDs.
        /// </para>
        ///  
        /// <para>
        /// The <c>NodeLogicalId</c> is a unique identifier that persists throughout the node's
        /// lifecycle and can be used to track nodes that are still being provisioned and don't
        /// yet have an EC2 instance ID assigned.
        /// </para>
        ///  <important> <ul> <li> 
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