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
    /// Container for the parameters to the AttachLoadBalancers operation.
    /// <note> 
    /// <para>
    /// This API operation is superseded by <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_AttachTrafficSources.html">https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_AttachTrafficSources.html</a>,
    /// which can attach multiple traffic sources types. We recommend using <c>AttachTrafficSources</c>
    /// to simplify how you manage traffic sources. However, we continue to support <c>AttachLoadBalancers</c>.
    /// You can use both the original <c>AttachLoadBalancers</c> API operation and <c>AttachTrafficSources</c>
    /// on the same Auto Scaling group.
    /// </para>
    ///  </note> 
    /// <para>
    /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
    /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// To describe the load balancers for an Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
    /// API. To detach a load balancer from the Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DetachLoadBalancers.html">DetachLoadBalancers</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// This operation is additive and does not detach existing Classic Load Balancers or
    /// target groups from the Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
    /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
    /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttachLoadBalancersRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _loadBalancerNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// The names of the load balancers. You can specify up to 10 load balancers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && (this._loadBalancerNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}