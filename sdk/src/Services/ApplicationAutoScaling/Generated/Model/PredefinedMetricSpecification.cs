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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a predefined metric for a target tracking scaling policy to use with Application
    /// Auto Scaling.
    /// </summary>
    public partial class PredefinedMetricSpecification
    {
        private MetricType _predefinedMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedMetricType. 
        /// <para>
        /// The metric type. The <code>ALBRequestCountPerTarget</code> metric type applies only
        /// to Spot fleet requests and ECS services.
        /// </para>
        /// </summary>
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
        /// a target group attached to the Spot fleet request or ECS service.
        /// </para>
        ///  
        /// <para>
        /// The format is app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt;/targetgroup/&lt;target-group-name&gt;/&lt;target-group-id&gt;,
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
        /// </summary>
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