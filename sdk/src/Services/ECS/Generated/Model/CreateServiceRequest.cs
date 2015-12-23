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
    /// Container for the parameters to the CreateService operation.
    /// Runs and maintains a desired number of tasks from a specified task definition. If
    /// the number of tasks running in a service drops below <code>desiredCount</code>, Amazon
    /// ECS spawns another instantiation of the task in the specified cluster. To update an
    /// existing service, see <a>UpdateService</a>.
    /// 
    ///  
    /// <para>
    /// You can optionally specify a deployment configuration for your service. During a deployment
    /// (which is triggered by changing the task definition of a service with an <a>UpdateService</a>
    /// operation), the service scheduler uses the <code>minimumHealthyPercent</code> and
    /// <code>maximumPercent</code> parameters to determine the deployment strategy.
    /// </para>
    ///  
    /// <para>
    /// If the <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore
    /// the <code>desiredCount</code> temporarily during a deployment. For example, if your
    /// service has a <code>desiredCount</code> of four tasks, a <code>minimumHealthyPercent</code>
    /// of 50% allows the scheduler to stop two existing tasks before starting two new tasks.
    /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
    /// they are in the <code>RUNNING</code> state; tasks for services that <i>do</i> use
    /// a load balancer are considered healthy if they are in the <code>RUNNING</code> state
    /// and the container instance it is hosted on is reported as healthy by the load balancer.
    /// The default value for <code>minimumHealthyPercent</code> is 50% in the console and
    /// 100% for the AWS CLI, the AWS SDKs, and the APIs.
    /// </para>
    ///  
    /// <para>
    /// The <code>maximumPercent</code> parameter represents an upper limit on the number
    /// of running tasks during a deployment, which enables you to define the deployment batch
    /// size. For example, if your service has a <code>desiredCount</code> of four tasks,
    /// a <code>maximumPercent</code> value of 200% starts four new tasks before stopping
    /// the four older tasks (provided that the cluster resources required to do this are
    /// available). The default value for <code>maximumPercent</code> is 200%.
    /// </para>
    ///  
    /// <para>
    /// When the service scheduler launches new tasks, it attempts to balance them across
    /// the Availability Zones in your cluster with the following logic:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Determine which of the container instances in your cluster can support your service's
    /// task definition (for example, they have the required CPU, memory, ports, and container
    /// instance attributes).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sort the valid container instances by the fewest number of running tasks for this
    /// service in the same Availability Zone as the instance. For example, if zone A has
    /// one running service task and zones B and C each have zero, valid container instances
    /// in either zone B or C are considered optimal for placement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Place the new service task on a valid container instance in an optimal Availability
    /// Zone (based on the previous steps), favoring container instances with the fewest number
    /// of running tasks for this service.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateServiceRequest : AmazonECSRequest
    {
        private string _clientToken;
        private string _cluster;
        private DeploymentConfiguration _deploymentConfiguration;
        private int? _desiredCount;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private string _role;
        private string _serviceName;
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// Up to 32 ASCII characters are allowed.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster on which to run your
        /// service. If you do not specify a cluster, the default cluster is assumed.
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
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Optional deployment parameters that control how many tasks run during the deployment
        /// and the ordering of stopping and starting tasks. 
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The number of instantiations of the specified task definition to place and keep running
        /// on your cluster.
        /// </para>
        /// </summary>
        public int DesiredCount
        {
            get { return this._desiredCount.GetValueOrDefault(); }
            set { this._desiredCount = value; }
        }

        // Check to see if DesiredCount property is set
        internal bool IsSetDesiredCount()
        {
            return this._desiredCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// A list of load balancer objects, containing the load balancer name, the container
        /// name (as it appears in a container definition), and the container port to access from
        /// the load balancer.
        /// </para>
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the IAM role that allows your Amazon
        /// ECS container agent to make calls to your load balancer on your behalf. This parameter
        /// is only required if you are using a load balancer with your service.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, hyphens,
        /// and underscores are allowed. Service names must be unique within a cluster, but you
        /// can have similarly named services in multiple clusters within a region or across multiple
        /// regions.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full Amazon Resource Name (ARN) of the task definition to run in your service. If
        /// a <code>revision</code> is not specified, the latest <code>ACTIVE</code> revision
        /// is used.
        /// </para>
        /// </summary>
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}