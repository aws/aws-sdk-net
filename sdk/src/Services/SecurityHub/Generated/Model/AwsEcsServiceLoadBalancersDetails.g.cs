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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a load balancer that the service uses.
    /// </summary>
    public partial class AwsEcsServiceLoadBalancersDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container to associate with the load balancer.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port on the container to associate with the load balancer. This port must correspond
        /// to a <c>containerPort</c> in the task definition the tasks in the service are using.
        /// For tasks that use the EC2 launch type, the container instance they are launched on
        /// must allow ingress traffic on the <c>hostPort</c> of the port mapping.
        /// </para>
        /// </summary>
        public int? ContainerPort { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPort property is set.
        /// </summary>
        internal bool IsSetContainerPort() => this.ContainerPort.HasValue;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer to associate with the Amazon ECS service or task set.
        /// </para>
        ///  
        /// <para>
        /// Only specified when using a Classic Load Balancer. For an Application Load Balancer
        /// or a Network Load Balancer, the load balancer name is omitted.
        /// </para>
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The ARN of the Elastic Load Balancing target group or groups associated with a service
        /// or task set.
        /// </para>
        ///  
        /// <para>
        /// Only specified when using an Application Load Balancer or a Network Load Balancer.
        /// For a Classic Load Balancer, the target group ARN is omitted.
        /// </para>
        /// </summary>
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;
    }
}
