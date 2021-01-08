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
    /// Container for the parameters to the EnableMetricsCollection operation.
    /// Enables group metrics for the specified Auto Scaling group. For more information,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-monitoring.html">Monitoring
    /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// </summary>
    public partial class EnableMetricsCollectionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _granularity;
        private List<string> _metrics = new List<string>();

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
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity to associate with the metrics to collect. The only valid value is
        /// <code>1Minute</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Specifies which group-level metrics to start collecting. You can specify one or more
        /// of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>GroupMinSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupMaxSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupDesiredCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupInServiceInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupPendingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupStandbyInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTerminatingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTotalInstances</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The instance weighting feature supports the following additional metrics: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>GroupInServiceCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupPendingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupStandbyCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTerminatingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTotalCapacity</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you omit this parameter, all metrics are enabled. 
        /// </para>
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