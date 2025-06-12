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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the AttachLoadBalancerTargetGroups operation.
    /// <note> 
    /// <para>
    /// This API operation is superseded by <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_AttachTrafficSources.html">AttachTrafficSources</a>,
    /// which can attach multiple traffic sources types. We recommend using <c>AttachTrafficSources</c>
    /// to simplify how you manage traffic sources. However, we continue to support <c>AttachLoadBalancerTargetGroups</c>.
    /// You can use both the original <c>AttachLoadBalancerTargetGroups</c> API operation
    /// and <c>AttachTrafficSources</c> on the same Auto Scaling group.
    /// </para>
    ///  </note> 
    /// <para>
    /// Attaches one or more target groups to the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// This operation is used with the following load balancer types: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Application Load Balancer - Operates at the application layer (layer 7) and supports
    /// HTTP and HTTPS. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
    /// TLS, and UDP. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gateway Load Balancer - Operates at the network layer (layer 3).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To describe the target groups for an Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeLoadBalancerTargetGroups.html">DescribeLoadBalancerTargetGroups</a>
    /// API. To detach the target group from the Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DetachLoadBalancerTargetGroups.html">DetachLoadBalancerTargetGroups</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// This operation is additive and does not detach existing target groups or Classic Load
    /// Balancers from the Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
    /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
    /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AttachLoadBalancerTargetGroupsRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _targetGroupARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupARNs. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the target groups. You can specify up to 10 target
        /// groups. To get the ARN of a target group, use the Elastic Load Balancing <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeTargetGroups.html">DescribeTargetGroups</a>
        /// API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetGroupARNs
        {
            get { return this._targetGroupARNs; }
            set { this._targetGroupARNs = value; }
        }

        // Check to see if TargetGroupARNs property is set
        internal bool IsSetTargetGroupARNs()
        {
            return this._targetGroupARNs != null && (this._targetGroupARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}