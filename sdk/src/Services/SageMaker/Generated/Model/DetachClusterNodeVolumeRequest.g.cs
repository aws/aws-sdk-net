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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DetachClusterNodeVolume operation. Detaches your
    /// Amazon Elastic Block Store (Amazon EBS) volume from a node in your EKS orchestrated
    /// SageMaker HyperPod cluster. <para> This API works with the Amazon Elastic Block Store
    /// (Amazon EBS) Container Storage Interface (CSI) driver to manage the lifecycle of persistent
    /// storage in your HyperPod EKS clusters. </para>
    /// </summary>
    public partial class DetachClusterNodeVolumeRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of your SageMaker HyperPod cluster containing the
        /// target node. Your cluster must use EKS as the orchestration and be in the <c>InService</c>
        /// state. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        ///  The unique identifier of the cluster node from which you want to detach the volume.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        ///  The unique identifier of your EBS volume that you want to detach. Your volume must
        /// be currently attached to the specified node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
