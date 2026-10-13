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
    /// Container for the parameters to the AttachClusterNodeNetworkInterface operation. Attaches
    /// an elastic network interface (ENI) to a node in a HyperPod cluster. <para> To use
    /// this operation, you must have the <c>sagemaker:AttachClusterNodeNetworkInterface</c>
    /// permission. </para>
    /// </summary>
    public partial class AttachClusterNodeNetworkInterfaceRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        ///  The name or Amazon Resource Name (ARN) of the SageMaker HyperPod cluster that contains
        /// the target node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        ///  The unique identifier of the elastic network interface (ENI) to attach. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 21)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        ///  The unique identifier of the cluster node to which you want to attach the network
        /// interface. The node must belong to your specified HyperPod cluster and cannot be part
        /// of a Restricted Instance Group (RIG). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;
    }
}
