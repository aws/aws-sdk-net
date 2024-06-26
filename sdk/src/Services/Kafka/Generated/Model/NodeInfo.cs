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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private string _addedToClusterTime;
        private BrokerNodeInfo _brokerNodeInfo;
        private ControllerNodeInfo _controllerNodeInfo;
        private string _instanceType;
        private string _nodeARN;
        private NodeType _nodeType;
        private ZookeeperNodeInfo _zookeeperNodeInfo;

        /// <summary>
        /// Gets and sets the property AddedToClusterTime.             
        /// <para>
        /// The start time.
        /// </para>
        /// </summary>
        public string AddedToClusterTime
        {
            get { return this._addedToClusterTime; }
            set { this._addedToClusterTime = value; }
        }

        // Check to see if AddedToClusterTime property is set
        internal bool IsSetAddedToClusterTime()
        {
            return this._addedToClusterTime != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerNodeInfo.             
        /// <para>
        /// The broker node info.
        /// </para>
        /// </summary>
        public BrokerNodeInfo BrokerNodeInfo
        {
            get { return this._brokerNodeInfo; }
            set { this._brokerNodeInfo = value; }
        }

        // Check to see if BrokerNodeInfo property is set
        internal bool IsSetBrokerNodeInfo()
        {
            return this._brokerNodeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ControllerNodeInfo.             
        /// <para>
        /// The ControllerNodeInfo.
        /// </para>
        /// </summary>
        public ControllerNodeInfo ControllerNodeInfo
        {
            get { return this._controllerNodeInfo; }
            set { this._controllerNodeInfo = value; }
        }

        // Check to see if ControllerNodeInfo property is set
        internal bool IsSetControllerNodeInfo()
        {
            return this._controllerNodeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType.             
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeARN.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the node.
        /// </para>
        /// </summary>
        public string NodeARN
        {
            get { return this._nodeARN; }
            set { this._nodeARN = value; }
        }

        // Check to see if NodeARN property is set
        internal bool IsSetNodeARN()
        {
            return this._nodeARN != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType.             
        /// <para>
        /// The node type.
        /// </para>
        /// </summary>
        public NodeType NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property ZookeeperNodeInfo.             
        /// <para>
        /// The ZookeeperNodeInfo.
        /// </para>
        /// </summary>
        public ZookeeperNodeInfo ZookeeperNodeInfo
        {
            get { return this._zookeeperNodeInfo; }
            set { this._zookeeperNodeInfo = value; }
        }

        // Check to see if ZookeeperNodeInfo property is set
        internal bool IsSetZookeeperNodeInfo()
        {
            return this._zookeeperNodeInfo != null;
        }

    }
}