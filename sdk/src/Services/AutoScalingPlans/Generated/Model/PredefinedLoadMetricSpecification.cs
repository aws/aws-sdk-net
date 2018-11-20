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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents a predefined metric that can be used for predictive scaling.
    /// </summary>
    public partial class PredefinedLoadMetricSpecification
    {
        private LoadMetricType _predefinedLoadMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricType. 
        /// <para>
        /// The metric type.
        /// </para>
        /// </summary>
        public LoadMetricType PredefinedLoadMetricType
        {
            get { return this._predefinedLoadMetricType; }
            set { this._predefinedLoadMetricType = value; }
        }

        // Check to see if PredefinedLoadMetricType property is set
        internal bool IsSetPredefinedLoadMetricType()
        {
            return this._predefinedLoadMetricType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLabel. 
        /// <para>
        /// Identifies the resource associated with the metric type. You can't specify a resource
        /// label unless the metric type is <code>ALBRequestCountPerTarget</code> and there is
        /// a target group for an Application Load Balancer attached to the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// The format is app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt;/targetgroup/&lt;target-group-name&gt;/&lt;target-group-id&gt;,
        /// where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt; is the final portion of the
        /// load balancer ARN.
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