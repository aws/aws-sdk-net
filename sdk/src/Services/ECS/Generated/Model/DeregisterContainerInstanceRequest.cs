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
    /// Container for the parameters to the DeregisterContainerInstance operation.
    /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
    /// is no longer available to run tasks.
    /// 
    ///  
    /// <para>
    /// If you intend to use the container instance for some other purpose after deregistration,
    /// you should stop all of the tasks running on the container instance before deregistration
    /// to avoid any orphaned tasks from consuming resources.
    /// </para>
    ///  
    /// <para>
    /// Deregistering a container instance removes the instance from a cluster, but it does
    /// not terminate the EC2 instance; if you are finished using the instance, be sure to
    /// terminate it in the Amazon EC2 console to stop billing.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you terminate a running container instance, Amazon ECS automatically deregisters
    /// the instance from your cluster (stopped container instances or instances with disconnected
    /// agents are not automatically deregistered when terminated).
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeregisterContainerInstanceRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _containerInstance;
        private bool? _force;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the container
        /// instance to deregister. If you do not specify a cluster, the default cluster is assumed.
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
        /// Gets and sets the property ContainerInstance. 
        /// <para>
        /// The container instance ID or full Amazon Resource Name (ARN) of the container instance
        /// to deregister. The ARN contains the <code>arn:aws:ecs</code> namespace, followed by
        /// the region of the container instance, the AWS account ID of the container instance
        /// owner, the <code>container-instance</code> namespace, and then the container instance
        /// ID. For example, <code>arn:aws:ecs:<i>region</i>:<i>aws_account_id</i>:container-instance/<i>container_instance_ID</i>
        /// </code>.
        /// </para>
        /// </summary>
        public string ContainerInstance
        {
            get { return this._containerInstance; }
            set { this._containerInstance = value; }
        }

        // Check to see if ContainerInstance property is set
        internal bool IsSetContainerInstance()
        {
            return this._containerInstance != null;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the deregistration of the container instance. If you have tasks running on
        /// the container instance when you deregister it with the <code>force</code> option,
        /// these tasks remain running until you terminate the instance or the tasks stop through
        /// some other means, but they are orphaned (no longer monitored or accounted for by Amazon
        /// ECS). If an orphaned task on your container instance is part of an Amazon ECS service,
        /// then the service scheduler starts another copy of that task, on a different container
        /// instance if possible. 
        /// </para>
        ///  
        /// <para>
        /// Any containers in orphaned service tasks that are registered with a Classic load balancer
        /// or an Application load balancer target group are deregistered, and they will begin
        /// connection draining according to the settings on the load balancer or target group.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

    }
}