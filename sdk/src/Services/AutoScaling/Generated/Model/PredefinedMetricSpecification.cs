/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Represents a predefined metric for a target tracking scaling policy to use with Amazon
    /// EC2 Auto Scaling.
    /// </summary>
    public partial class PredefinedMetricSpecification
    {
        private MetricType _predefinedMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedMetricType. 
        /// <para>
        /// The metric type. The following predefined metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASGAverageCPUUtilization</code> - Average CPU utilization of the Auto Scaling
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ASGAverageNetworkIn</code> - Average number of bytes received on all network
        /// interfaces by the Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ASGAverageNetworkOut</code> - Average number of bytes sent out on all network
        /// interfaces by the Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALBRequestCountPerTarget</code> - Number of requests completed per target in
        /// an Application Load Balancer target group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricType PredefinedMetricType
        {
            get { return this._predefinedMetricType; }
            set { this._predefinedMetricType = value; }
        }

        // Check to see if PredefinedMetricType property is set
        internal bool IsSetPredefinedMetricType()
        {
            return this._predefinedMetricType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLabel. 
        /// <para>
        /// Identifies the resource associated with the metric type. You can't specify a resource
        /// label unless the metric type is <code>ALBRequestCountPerTarget</code> and there is
        /// a target group attached to the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// The format is <code>app/<i>load-balancer-name</i>/<i>load-balancer-id</i>/targetgroup/<i>target-group-name</i>/<i>target-group-id</i>
        /// </code>, where 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>app/<i>load-balancer-name</i>/<i>load-balancer-id</i> </code> is the final
        /// portion of the load balancer ARN, and
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>targetgroup/<i>target-group-name</i>/<i>target-group-id</i> </code> is the
        /// final portion of the target group ARN.
        /// </para>
        ///  </li> </ul>
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