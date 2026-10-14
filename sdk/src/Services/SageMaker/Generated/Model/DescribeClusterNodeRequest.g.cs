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
    /// Container for the parameters to the DescribeClusterNode operation. Retrieves information
    /// of a node (also called a <i>instance</i> interchangeably) of a SageMaker HyperPod
    /// cluster.
    /// </summary>
    public partial class DescribeClusterNodeRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The string name or the Amazon Resource Name (ARN) of the SageMaker HyperPod cluster
        /// in which the node is.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The ID of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// The logical identifier of the node to describe. You can specify either <c>NodeLogicalId</c>
        /// or <c>InstanceId</c>, but not both. <c>NodeLogicalId</c> can be used to describe nodes
        /// that are still being provisioned and don't yet have an <c>InstanceId</c> assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NodeLogicalId { get; set; }

        /// <summary>
        /// Checks to see if the NodeLogicalId property is set.
        /// </summary>
        internal bool IsSetNodeLogicalId() => this.NodeLogicalId != null;
    }
}
