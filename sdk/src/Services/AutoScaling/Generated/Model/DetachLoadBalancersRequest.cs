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
    /// Container for the parameters to the DetachLoadBalancers operation.
    /// <note> 
    /// <para>
    /// This API operation is superseded by <a>DetachTrafficSources</a>, which can detach
    /// multiple traffic sources types. We recommend using <code>DetachTrafficSources</code>
    /// to simplify how you manage traffic sources. However, we continue to support <code>DetachLoadBalancers</code>.
    /// You can use both the original <code>DetachLoadBalancers</code> API operation and <code>DetachTrafficSources</code>
    /// on the same Auto Scaling group.
    /// </para>
    ///  </note> 
    /// <para>
    /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// This operation detaches only Classic Load Balancers. If you have Application Load
    /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DetachLoadBalancerTargetGroups</a>
    /// API instead.
    /// </para>
    ///  
    /// <para>
    /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
    /// the instances in the group. When all instances are deregistered, then you can no longer
    /// describe the load balancer using the <a>DescribeLoadBalancers</a> API call. The instances
    /// remain running.
    /// </para>
    /// </summary>
    public partial class DetachLoadBalancersRequest : AmazonAutoScalingRequest
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