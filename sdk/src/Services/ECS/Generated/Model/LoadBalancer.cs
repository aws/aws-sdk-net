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
    /// The load balancer configuration to use with a service or task set.
    /// 
    ///  
    /// <para>
    /// When you add, update, or remove a load balancer configuration, Amazon ECS starts a
    /// new deployment with the updated Elastic Load Balancing configuration. This causes
    /// tasks to register to and deregister from load balancers.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you verify this on a test environment before you update the Elastic
    /// Load Balancing configuration. 
    /// </para>
    ///  
    /// <para>
    /// A service-linked role is required for services that use multiple target groups. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
    /// service-linked roles</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class LoadBalancer
    {
        private AdvancedConfiguration _advancedConfiguration;
        private string _containerName;
        private int? _containerPort;
        private string _loadBalancerName;
        private string _targetGroupArn;

        /// <summary>
        /// Gets and sets the property AdvancedConfiguration. 
        /// <para>
        /// The advanced settings for the load balancer used in blue/green deployments. Specify
        /// the alternate target group, listener rules, and IAM role required for traffic shifting
        /// during blue/green deployments.
        /// </para>
        /// </summary>
        public AdvancedConfiguration AdvancedConfiguration
        {
            get { return this._advancedConfiguration; }
            set { this._advancedConfiguration = value; }
        }

        // Check to see if AdvancedConfiguration property is set
        internal bool IsSetAdvancedConfiguration()
        {
            return this._advancedConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container (as it appears in a container definition) to associate with
        /// the load balancer.
        /// </para>
        ///  
        /// <para>
        /// You need to specify the container name when configuring the target group for an Amazon
        /// ECS load balancer.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port on the container to associate with the load balancer. This port must correspond
        /// to a <c>containerPort</c> in the task definition the tasks in the service are using.
        /// For tasks that use the EC2 launch type, the container instance they're launched on
        /// must allow ingress traffic on the <c>hostPort</c> of the port mapping.
        /// </para>
        /// </summary>
        public int? ContainerPort
        {
            get { return this._containerPort; }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer to associate with the Amazon ECS service or task set.
        /// </para>
        ///  
        /// <para>
        /// If you are using an Application Load Balancer or a Network Load Balancer the load
        /// balancer name parameter should be omitted.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the Elastic Load Balancing target group or
        /// groups associated with a service or task set.
        /// </para>
        ///  
        /// <para>
        /// A target group ARN is only specified when using an Application Load Balancer or Network
        /// Load Balancer. 
        /// </para>
        ///  
        /// <para>
        /// For services using the <c>ECS</c> deployment controller, you can specify one or multiple
        /// target groups. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/register-multiple-targetgroups.html">Registering
        /// multiple target groups with a service</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For services using the <c>CODE_DEPLOY</c> deployment controller, you're required to
        /// define two target groups for the load balancer. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-bluegreen.html">Blue/green
        /// deployment with CodeDeploy</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your service's task definition uses the <c>awsvpc</c> network mode, you must choose
        /// <c>ip</c> as the target type, not <c>instance</c>. Do this when creating your target
        /// groups because tasks that use the <c>awsvpc</c> network mode are associated with an
        /// elastic network interface, not an Amazon EC2 instance. This network mode is required
        /// for the Fargate launch type.
        /// </para>
        ///  </important>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

    }
}