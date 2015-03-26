/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new Amazon ECS cluster. By default, your account will receive a <code>default</code>
    /// cluster when you launch your first container instance. However, you can create your
    /// own cluster with a unique name with the <code>CreateCluster</code> action.
    /// 
    ///  <important> 
    /// <para>
    /// During the preview, each account is limited to two clusters.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateClusterRequest : AmazonECSRequest
    {
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster. If you do not specify a name for your cluster, you will
        /// create a cluster named <code>default</code>.
        /// </para>
        /// </summary>
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