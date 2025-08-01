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
    /// The deployment controller to use for the service.
    /// </summary>
    public partial class DeploymentController
    {
        private DeploymentControllerType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The deployment controller type to use.
        /// </para>
        ///  
        /// <para>
        /// The deployment controller is the mechanism that determines how tasks are deployed
        /// for your service. The valid options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ECS
        /// </para>
        ///  
        /// <para>
        /// When you create a service which uses the <c>ECS</c> deployment controller, you can
        /// choose between the following deployment strategies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ROLLING</c>: When you create a service which uses the <i>rolling update</i> (<c>ROLLING</c>)
        /// deployment strategy, the Amazon ECS service scheduler replaces the currently running
        /// tasks with new tasks. The number of tasks that Amazon ECS adds or removes from the
        /// service during a rolling update is controlled by the service deployment configuration.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Rolling update deployments are best suited for the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Gradual service updates: You need to update your service incrementally without taking
        /// the entire service offline at once.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Limited resource requirements: You want to avoid the additional resource costs of
        /// running two complete environments simultaneously (as required by blue/green deployments).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Acceptable deployment time: Your application can tolerate a longer deployment process,
        /// as rolling updates replace tasks one by one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No need for instant roll back: Your service can tolerate a rollback process that takes
        /// minutes rather than seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Simple deployment process: You prefer a straightforward deployment approach without
        /// the complexity of managing multiple environments, target groups, and listeners.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No load balancer requirement: Your service doesn't use or require a load balancer,
        /// Application Load Balancer, Network Load Balancer, or Service Connect (which are required
        /// for blue/green deployments).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stateful applications: Your application maintains state that makes it difficult to
        /// run two parallel environments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cost sensitivity: You want to minimize deployment costs by not running duplicate environments
        /// during deployment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Rolling updates are the default deployment strategy for services and provide a balance
        /// between deployment safety and resource efficiency for many common application scenarios.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLUE_GREEN</c>: A <i>blue/green</i> deployment strategy (<c>BLUE_GREEN</c>) is
        /// a release methodology that reduces downtime and risk by running two identical production
        /// environments called blue and green. With Amazon ECS blue/green deployments, you can
        /// validate new service revisions before directing production traffic to them. This approach
        /// provides a safer way to deploy changes with the ability to quickly roll back if needed.
        /// </para>
        ///  
        /// <para>
        /// Amazon ECS blue/green deployments are best suited for the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service validation: When you need to validate new service revisions before directing
        /// production traffic to them
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Zero downtime: When your service requires zero-downtime deployments
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instant roll back: When you need the ability to quickly roll back if issues are detected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Load balancer requirement: When your service uses Application Load Balancer, Network
        /// Load Balancer, or Service Connect
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// External
        /// </para>
        ///  
        /// <para>
        /// Use a third-party deployment controller.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Blue/green deployment (powered by CodeDeploy)
        /// </para>
        ///  
        /// <para>
        /// CodeDeploy installs an updated version of the application as a new replacement task
        /// set and reroutes production traffic from the original application task set to the
        /// replacement task set. The original task set is terminated after a successful deployment.
        /// Use this deployment controller to verify a new deployment of a service before sending
        /// production traffic to it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentControllerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}