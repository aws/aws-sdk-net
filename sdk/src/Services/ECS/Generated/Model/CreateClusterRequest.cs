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
    /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
    /// cluster when you launch your first container instance. However, you can create your
    /// own cluster with a unique name with the <code>CreateCluster</code> action.
    /// 
    ///  <note> 
    /// <para>
    /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
    /// the service-linked role for your account so that required resources in other AWS services
    /// can be managed on your behalf. However, if the IAM user that makes the call does not
    /// have permissions to create the service-linked role, it is not created. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguideusing-service-linked-roles.html">Using
    /// Service-Linked Roles for Amazon ECS</a> in the <i>Amazon EC2 Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateClusterRequest : AmazonECSRequest
    {
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster. If you do not specify a name for your cluster, you create
        /// a cluster named <code>default</code>. Up to 255 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
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