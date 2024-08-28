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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteService operation.
    /// Deletes a specified service within a cluster. You can delete a service if you have
    /// no running tasks in it and the desired task count is zero. If the service is actively
    /// maintaining tasks, you can't delete it, and you must update the service to a desired
    /// task count of zero. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateService.html">UpdateService</a>.
    /// 
    ///  <note> 
    /// <para>
    /// When you delete a service, if there are still running tasks that require cleanup,
    /// the service status moves from <c>ACTIVE</c> to <c>DRAINING</c>, and the service is
    /// no longer visible in the console or in the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServices.html">ListServices</a>
    /// API operation. After all tasks have transitioned to either <c>STOPPING</c> or <c>STOPPED</c>
    /// status, the service status moves from <c>DRAINING</c> to <c>INACTIVE</c>. Services
    /// in the <c>DRAINING</c> or <c>INACTIVE</c> status can still be viewed with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServices.html">DescribeServices</a>
    /// API operation. However, in the future, <c>INACTIVE</c> services may be cleaned up
    /// and purged from Amazon ECS record keeping, and <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServices.html">DescribeServices</a>
    /// calls on those services return a <c>ServiceNotFoundException</c> error.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// If you attempt to create a new service with the same name as an existing service in
    /// either <c>ACTIVE</c> or <c>DRAINING</c> status, you receive an error.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteServiceRequest : AmazonECSRequest
    {
        private string _cluster;
        private bool? _force;
        private string _service;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// to delete. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// If <c>true</c>, allows you to delete a service even if it wasn't scaled down to zero
        /// tasks. It's only necessary to use this if the service uses the <c>REPLICA</c> scheduling
        /// strategy.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}