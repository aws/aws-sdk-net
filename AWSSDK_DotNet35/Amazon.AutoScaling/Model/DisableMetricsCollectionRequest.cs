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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DisableMetricsCollection operation.
    /// Disables monitoring of group metrics for the Auto Scaling group specified in <code>AutoScalingGroupName</code>.
    /// You can specify the list of affected metrics with the <code>Metrics</code> parameter.
    /// </summary>
    public partial class DisableMetricsCollectionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _metrics = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or ARN of the Auto Scaling Group. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Metrics. 
        /// <para>
        ///  The list of metrics to disable. If no metrics are specified, all metrics are disabled.
        /// The following metrics are supported: 
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// GroupMinSize
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupMaxSize
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupDesiredCapacity
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupInServiceInstances
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupPendingInstances
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupStandbyInstances
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupTerminatingInstances
        /// </para>
        /// </li> <li>
        /// <para>
        /// GroupTotalInstances
        /// </para>
        /// </li> </ul>
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

    }
}