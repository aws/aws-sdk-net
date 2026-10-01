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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// The node information object.
    /// </summary>
    public partial class NodeInfo
    {
        /// <summary>
        /// Gets and sets the property AddedToClusterTime. 
        /// <para>
        /// The start time.
        /// </para>
        /// </summary>
        public string AddedToClusterTime { get; set; }

        /// <summary>
        /// Checks to see if the AddedToClusterTime property is set.
        /// </summary>
        internal bool IsSetAddedToClusterTime() => this.AddedToClusterTime != null;

        /// <summary>
        /// Gets and sets the property BrokerNodeInfo. 
        /// <para>
        /// The broker node info.
        /// </para>
        /// </summary>
        public BrokerNodeInfo BrokerNodeInfo { get; set; }

        /// <summary>
        /// Checks to see if the BrokerNodeInfo property is set.
        /// </summary>
        internal bool IsSetBrokerNodeInfo() => this.BrokerNodeInfo != null;

        /// <summary>
        /// Gets and sets the property ControllerNodeInfo. 
        /// <para>
        /// The ControllerNodeInfo.
        /// </para>
        /// </summary>
        public ControllerNodeInfo ControllerNodeInfo { get; set; }

        /// <summary>
        /// Checks to see if the ControllerNodeInfo property is set.
        /// </summary>
        internal bool IsSetControllerNodeInfo() => this.ControllerNodeInfo != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property NodeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the node.
        /// </para>
        /// </summary>
        public string NodeARN { get; set; }

        /// <summary>
        /// Checks to see if the NodeARN property is set.
        /// </summary>
        internal bool IsSetNodeARN() => this.NodeARN != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type.
        /// </para>
        /// </summary>
        public NodeType NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property ZookeeperNodeInfo. 
        /// <para>
        /// The ZookeeperNodeInfo.
        /// </para>
        /// </summary>
        public ZookeeperNodeInfo ZookeeperNodeInfo { get; set; }

        /// <summary>
        /// Checks to see if the ZookeeperNodeInfo property is set.
        /// </summary>
        internal bool IsSetZookeeperNodeInfo() => this.ZookeeperNodeInfo != null;
    }
}
