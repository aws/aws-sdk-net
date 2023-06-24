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
    /// Container for the parameters to the DescribeLoadBalancers operation.
    /// <note> 
    /// <para>
    /// This API operation is superseded by <a>DescribeTrafficSources</a>, which can describe
    /// multiple traffic sources types. We recommend using <code>DescribeTrafficSources</code>
    /// to simplify how you manage traffic sources. However, we continue to support <code>DescribeLoadBalancers</code>.
    /// You can use both the original <code>DescribeLoadBalancers</code> API operation and
    /// <code>DescribeTrafficSources</code> on the same Auto Scaling group.
    /// </para>
    ///  </note> 
    /// <para>
    /// Gets information about the load balancers for the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// This operation describes only Classic Load Balancers. If you have Application Load
    /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DescribeLoadBalancerTargetGroups</a>
    /// API instead.
    /// </para>
    ///  
    /// <para>
    /// To determine the attachment status of the load balancer, use the <code>State</code>
    /// element in the response. When you attach a load balancer to an Auto Scaling group,
    /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
    /// to <code>Added</code> after all Auto Scaling instances are registered with the load
    /// balancer. If Elastic Load Balancing health checks are enabled for the Auto Scaling
    /// group, the state transitions to <code>InService</code> after at least one Auto Scaling
    /// instance passes the health check. When the load balancer is in the <code>InService</code>
    /// state, Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
    /// as unhealthy. If no registered instances pass the health checks, the load balancer
    /// doesn't enter the <code>InService</code> state. 
    /// </para>
    ///  
    /// <para>
    /// Load balancers also have an <code>InService</code> state if you attach them in the
    /// <a>CreateAutoScalingGroup</a> API call. If your load balancer state is <code>InService</code>,
    /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
    /// and take any corrective actions necessary.
    /// </para>
    ///  
    /// <para>
    /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
    /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
    /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
    /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
    /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DescribeLoadBalancersRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private int? _maxRecords;
        private string _nextToken;

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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <code>100</code>
        /// and the maximum value is <code>100</code>.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}