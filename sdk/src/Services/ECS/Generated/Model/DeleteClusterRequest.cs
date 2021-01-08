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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCluster operation.
    /// Deletes the specified cluster. The cluster will transition to the <code>INACTIVE</code>
    /// state. Clusters with an <code>INACTIVE</code> status may remain discoverable in your
    /// account for a period of time. However, this behavior is subject to change in the future,
    /// so you should not rely on <code>INACTIVE</code> clusters persisting.
    /// 
    ///  
    /// <para>
    /// You must deregister all container instances from this cluster before you may delete
    /// it. You can list the container instances in a cluster with <a>ListContainerInstances</a>
    /// and deregister them with <a>DeregisterContainerInstance</a>.
    /// </para>
    /// </summary>
    public partial class DeleteClusterRequest : AmazonECSRequest
    {
        private string _cluster;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

    }
}