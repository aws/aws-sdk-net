/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the EnableMetricsCollection operation.
    /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
    /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto Scaling metrics collection
    /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
    /// </para>
    /// </summary>
    public partial class EnableMetricsCollectionRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private List<string> metrics = new List<string>();
        private string granularity;


        /// <summary>
        /// The name or ARN of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The list of metrics to collect. If no metrics are specified, all metrics are enabled. The following metrics are supported: <ul>
        /// <li>GroupMinSize</li> <li>GroupMaxSize</li> <li>GroupDesiredCapacity</li> <li>GroupInServiceInstances</li> <li>GroupPendingInstances</li>
        /// <li>GroupTerminatingInstances</li> <li>GroupTotalInstances</li> </ul>
        ///  
        /// </summary>
        public List<string> Metrics
        {
            get { return this.metrics; }
            set { this.metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this.metrics.Count > 0;
        }

        /// <summary>
        /// The granularity to associate with the metrics to collect. Currently, the only legal granularity is "1Minute".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Granularity
        {
            get { return this.granularity; }
            set { this.granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this.granularity != null;
        }

    }
}
    
