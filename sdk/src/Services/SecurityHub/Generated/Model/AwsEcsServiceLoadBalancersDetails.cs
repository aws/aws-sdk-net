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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _containerName;
        private int? _containerPort;
        private string _loadBalancerName;
        private string _targetGroupArn;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container to associate with the load balancer.
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
        /// For tasks that use the EC2 launch type, the container instance they are launched on
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
        /// Only specified when using a Classic Load Balancer. For an Application Load Balancer
        /// or a Network Load Balancer, the load balancer name is omitted.
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
        /// The ARN of the Elastic Load Balancing target group or groups associated with a service
        /// or task set.
        /// </para>
        ///  
        /// <para>
        /// Only specified when using an Application Load Balancer or a Network Load Balancer.
        /// For a Classic Load Balancer, the target group ARN is omitted.
        /// </para>
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