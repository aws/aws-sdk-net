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
    /// Container for the parameters to the UpdateContainerInstancesState operation.
    /// Modifies the status of an Amazon ECS container instance.
    /// 
    ///  
    /// <para>
    /// Once a container instance has reached an <code>ACTIVE</code> state, you can change
    /// the status of a container instance to <code>DRAINING</code> to manually remove an
    /// instance from a cluster, for example to perform system updates, update the Docker
    /// daemon, or scale down the cluster size.
    /// </para>
    ///  <important> 
    /// <para>
    /// A container instance cannot be changed to <code>DRAINING</code> until it has reached
    /// an <code>ACTIVE</code> status. If the instance is in any other status, an error will
    /// be received.
    /// </para>
    ///  </important> 
    /// <para>
    /// When you set a container instance to <code>DRAINING</code>, Amazon ECS prevents new
    /// tasks from being scheduled for placement on the container instance and replacement
    /// service tasks are started on other container instances in the cluster if the resources
    /// are available. Service tasks on the container instance that are in the <code>PENDING</code>
    /// state are stopped immediately.
    /// </para>
    ///  
    /// <para>
    /// Service tasks on the container instance that are in the <code>RUNNING</code> state
    /// are stopped and replaced according to the service's deployment configuration parameters,
    /// <code>minimumHealthyPercent</code> and <code>maximumPercent</code>. You can change
    /// the deployment configuration of your service using <a>UpdateService</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
    /// temporarily during task replacement. For example, <code>desiredCount</code> is four
    /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
    /// two new tasks. If the minimum is 100%, the service scheduler can't remove existing
    /// tasks until the replacement tasks are considered healthy. Tasks for services that
    /// do not use a load balancer are considered healthy if they are in the <code>RUNNING</code>
    /// state. Tasks for services that use a load balancer are considered healthy if they
    /// are in the <code>RUNNING</code> state and the container instance they are hosted on
    /// is reported as healthy by the load balancer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>maximumPercent</code> parameter represents an upper limit on the number
    /// of running tasks during task replacement, which enables you to define the replacement
    /// batch size. For example, if <code>desiredCount</code> is four tasks, a maximum of
    /// 200% starts four new tasks before stopping the four tasks to be drained, provided
    /// that the cluster resources required to do this are available. If the maximum is 100%,
    /// then replacement tasks can't start until the draining tasks have stopped.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
    /// are not affected. You must wait for them to finish or stop them manually.
    /// </para>
    ///  
    /// <para>
    /// A container instance has completed draining when it has no more <code>RUNNING</code>
    /// tasks. You can verify this using <a>ListTasks</a>.
    /// </para>
    ///  
    /// <para>
    /// When a container instance has been drained, you can set a container instance to <code>ACTIVE</code>
    /// status and once it has reached that status the Amazon ECS scheduler can begin scheduling
    /// tasks on the instance again.
    /// </para>
    /// </summary>
    public partial class UpdateContainerInstancesStateRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _containerInstances = new List<string>();
        private ContainerInstanceStatus _status;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the container
        /// instance to update. If you do not specify a cluster, the default cluster is assumed.
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
        /// Gets and sets the property ContainerInstances. 
        /// <para>
        /// A list of container instance IDs or full ARN entries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ContainerInstances
        {
            get { return this._containerInstances; }
            set { this._containerInstances = value; }
        }

        // Check to see if ContainerInstances property is set
        internal bool IsSetContainerInstances()
        {
            return this._containerInstances != null && this._containerInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The container instance state with which to update the container instance. The only
        /// valid values for this action are <code>ACTIVE</code> and <code>DRAINING</code>. A
        /// container instance can only be updated to <code>DRAINING</code> status once it has
        /// reached an <code>ACTIVE</code> state. If a container instance is in <code>REGISTERING</code>,
        /// <code>DEREGISTERING</code>, or <code>REGISTRATION_FAILED</code> state you can describe
        /// the container instance but will be unable to update the container instance state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerInstanceStatus Status
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