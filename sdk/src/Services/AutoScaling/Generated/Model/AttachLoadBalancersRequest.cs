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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the AttachLoadBalancers operation.
    /// <note> 
    /// <para>
    /// To attach an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer,
    /// use the <a>AttachLoadBalancerTargetGroups</a> API operation instead.
    /// </para>
    ///  </note> 
    /// <para>
    /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
    /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// To describe the load balancers for an Auto Scaling group, call the <a>DescribeLoadBalancers</a>
    /// API. To detach the load balancer from the Auto Scaling group, call the <a>DetachLoadBalancers</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
    /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AttachLoadBalancersRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _loadBalancerNames = new List<string>();

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
            return this._loadBalancerNames != null && this._loadBalancerNames.Count > 0; 
        }

    }
}