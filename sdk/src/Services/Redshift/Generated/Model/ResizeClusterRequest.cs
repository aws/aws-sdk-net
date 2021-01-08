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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ResizeCluster operation.
    /// Changes the size of the cluster. You can change the cluster's type, or change the
    /// number or type of nodes. The default behavior is to use the elastic resize method.
    /// With an elastic resize, your cluster is available for read and write operations more
    /// quickly than with the classic resize method. 
    /// 
    ///  
    /// <para>
    /// Elastic resize operations have the following restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can only resize clusters of the following types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// dc1.large (if your cluster is in a VPC)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// dc1.8xlarge (if your cluster is in a VPC)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// dc2.large
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// dc2.8xlarge
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ds2.xlarge
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ds2.8xlarge
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ra3.xlplus
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ra3.4xlarge
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ra3.16xlarge
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// The type of nodes that you add must match the node type for the cluster.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ResizeClusterRequest : AmazonRedshiftRequest
    {
        private bool? _classic;
        private string _clusterIdentifier;
        private string _clusterType;
        private string _nodeType;
        private int? _numberOfNodes;

        /// <summary>
        /// Gets and sets the property Classic. 
        /// <para>
        /// A boolean value indicating whether the resize operation is using the classic resize
        /// process. If you don't provide this parameter or set the value to <code>false</code>,
        /// the resize type is elastic. 
        /// </para>
        /// </summary>
        public bool Classic
        {
            get { return this._classic.GetValueOrDefault(); }
            set { this._classic = value; }
        }

        // Check to see if Classic property is set
        internal bool IsSetClassic()
        {
            return this._classic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier for the cluster to resize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The new cluster type for the specified cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type for the nodes you are adding. If not specified, the cluster's current
        /// node type is used.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NodeType
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
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The new number of nodes for the cluster. If not specified, the cluster's current number
        /// of nodes is used.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

    }
}