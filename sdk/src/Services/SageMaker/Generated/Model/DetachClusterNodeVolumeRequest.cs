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
    /// Container for the parameters to the DetachClusterNodeVolume operation.
    /// Detaches your Amazon Elastic Block Store (Amazon EBS) volume from a node in your
    /// EKS orchestrated SageMaker HyperPod cluster.
    /// 
    ///  
    /// <para>
    ///  This API works with the Amazon Elastic Block Store (Amazon EBS) Container Storage
    /// Interface (CSI) driver to manage the lifecycle of persistent storage in your HyperPod
    /// EKS clusters. 
    /// </para>
    /// </summary>
    public partial class DetachClusterNodeVolumeRequest : AmazonSageMakerRequest
    {
        private string _clusterArn;
        private string _nodeId;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of your SageMaker HyperPod cluster containing the
        /// target node. Your cluster must use EKS as the orchestration and be in the <c>InService</c>
        /// state. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property NodeId. 
        /// <para>
        ///  The unique identifier of the cluster node from which you want to detach the volume.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        ///  The unique identifier of your EBS volume that you want to detach. Your volume must
        /// be currently attached to the specified node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}