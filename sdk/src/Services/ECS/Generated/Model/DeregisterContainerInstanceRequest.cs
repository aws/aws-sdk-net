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
    /// Container for the parameters to the DeregisterContainerInstance operation.
    /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
    /// is no longer available to run tasks.
    /// 
    ///  
    /// <para>
    /// If you intend to use the container instance for some other purpose after deregistration,
    /// we recommend that you stop all of the tasks running on the container instance before
    /// deregistration. That prevents any orphaned tasks from consuming resources.
    /// </para>
    ///  
    /// <para>
    /// Deregistering a container instance removes the instance from a cluster, but it doesn't
    /// terminate the EC2 instance. If you are finished using the instance, be sure to terminate
    /// it in the Amazon EC2 console to stop billing.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you terminate a running container instance, Amazon ECS automatically deregisters
    /// the instance from your cluster (stopped container instances or instances with disconnected
    /// agents aren't automatically deregistered when terminated).
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
        /// The container instance ID or full ARN of the container instance to deregister. For
        /// more information about the ARN format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Forces the container instance to be deregistered. If you have tasks running on the
        /// container instance when you deregister it with the <c>force</c> option, these tasks
        /// remain running until you terminate the instance or the tasks stop through some other
        /// means, but they're orphaned (no longer monitored or accounted for by Amazon ECS).
        /// If an orphaned task on your container instance is part of an Amazon ECS service, then
        /// the service scheduler starts another copy of that task, on a different container instance
        /// if possible. 
        /// </para>
        ///  
        /// <para>
        /// Any containers in orphaned service tasks that are registered with a Classic Load Balancer
        /// or an Application Load Balancer target group are deregistered. They begin connection
        /// draining according to the settings on the load balancer or target group.
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

    }
}