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
    /// A regional grouping of one or more container instances on which you can run task requests.
    /// Each account receives a default cluster the first time you use the Amazon ECS service,
    /// but you may also create other clusters. Clusters may contain more than one instance
    /// type simultaneously.
    /// 
    ///  <important> 
    /// <para>
    /// During the preview, each account is limited to two clusters.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class Cluster
    {
        private string _clusterArn;
        private string _clusterName;
        private string _status;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. The ARN contains the <code>arn:aws:ecs</code>
        /// namespace, followed by the region of the cluster, the AWS account ID of the cluster
        /// owner, the <code>cluster</code> namespace, and then the cluster name. For example,
        /// arn:aws:ecs:<i>region</i>:<i>012345678910</i>:cluster/<i>test</i>.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A user-generated string that you can use to identify your cluster.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. The valid values are <code>ACTIVE</code> or <code>INACTIVE</code>.
        /// <code>ACTIVE</code> indicates that you can register container instances with the cluster
        /// and the associated instances can accept tasks.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}