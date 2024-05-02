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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the ListAllowedNodeTypeUpdates operation.
    /// Lists all available node types that you can scale to from your cluster's current node
    /// type. When you use the UpdateCluster operation to scale your cluster, the value of
    /// the NodeType parameter must be one of the node types returned by this operation.
    /// </summary>
    public partial class ListAllowedNodeTypeUpdatesRequest : AmazonMemoryDBRequest
    {
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster you want to scale. MemoryDB uses the cluster name to identify
        /// the current node type being used by this cluster, and from that to create a list of
        /// node types you can scale up to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}