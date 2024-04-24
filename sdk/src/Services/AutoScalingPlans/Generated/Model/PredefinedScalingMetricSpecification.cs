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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
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
namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents a predefined metric that can be used for dynamic scaling as part of a target
    /// tracking scaling policy.
    /// </summary>
    public partial class PredefinedScalingMetricSpecification
    {
        private ScalingMetricType _predefinedScalingMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricType. 
        /// <para>
        /// The metric type. The <c>ALBRequestCountPerTarget</c> metric type applies only to Auto
        /// Scaling groups, Spot Fleet requests, and ECS services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingMetricType PredefinedScalingMetricType
        {
            get { return this._predefinedScalingMetricType; }
            set { this._predefinedScalingMetricType = value; }
        }

        // Check to see if PredefinedScalingMetricType property is set
        internal bool IsSetPredefinedScalingMetricType()
        {
            return this._predefinedScalingMetricType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLabel. 
        /// <para>
        /// Identifies the resource associated with the metric type. You can't specify a resource
        /// label unless the metric type is <c>ALBRequestCountPerTarget</c> and there is a target
        /// group for an Application Load Balancer attached to the Auto Scaling group, Spot Fleet
        /// request, or ECS service.
        /// </para>
        ///  
        /// <para>
        /// You create the resource label by appending the final portion of the load balancer
        /// ARN and the final portion of the target group ARN into a single value, separated by
        /// a forward slash (/). The format is app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt;/targetgroup/&lt;target-group-name&gt;/&lt;target-group-id&gt;,
        /// where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt; is the final portion of the
        /// load balancer ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targetgroup/&lt;target-group-name&gt;/&lt;target-group-id&gt; is the final portion
        /// of the target group ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This is an example: app/EC2Co-EcsEl-1TKLTMITMM0EO/f37c06a68c1748aa/targetgroup/EC2Co-Defau-LDNM7Q3ZH1ZN/6d4ea56ca2d6a18d.
        /// </para>
        ///  
        /// <para>
        /// To find the ARN for an Application Load Balancer, use the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// API operation. To find the ARN for the target group, use the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeTargetGroups.html">DescribeTargetGroups</a>
        /// API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1023)]
        public string ResourceLabel
        {
            get { return this._resourceLabel; }
            set { this._resourceLabel = value; }
        }

        // Check to see if ResourceLabel property is set
        internal bool IsSetResourceLabel()
        {
            return this._resourceLabel != null;
        }

    }
}