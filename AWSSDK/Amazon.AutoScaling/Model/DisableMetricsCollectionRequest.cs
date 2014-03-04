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
    /// Container for the parameters to the DisableMetricsCollection operation.
    /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
    /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DisableMetricsCollection"/>
    public class DisableMetricsCollectionRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private List<string> metrics = new List<string>();

        /// <summary>
        /// The name or ARN of the Auto Scaling Group.
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

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisableMetricsCollectionRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
        }
            

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The list of metrics to disable. If no metrics are specified, all metrics are disabled. The following metrics are supported: <ul>
        /// <li>GroupMinSize</li> <li>GroupMaxSize</li> <li>GroupDesiredCapacity</li> <li>GroupInServiceInstances</li> <li>GroupPendingInstances</li>
        /// <li>GroupTerminatingInstances</li> <li>GroupTotalInstances</li> </ul>
        ///  
        /// </summary>
        public List<string> Metrics
        {
            get { return this.metrics; }
            set { this.metrics = value; }
        }
        /// <summary>
        /// Adds elements to the Metrics collection
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisableMetricsCollectionRequest WithMetrics(params string[] metrics)
        {
            foreach (string element in metrics)
            {
                this.metrics.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Metrics collection
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisableMetricsCollectionRequest WithMetrics(IEnumerable<string> metrics)
        {
            foreach (string element in metrics)
            {
                this.metrics.Add(element);
            }

            return this;
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this.metrics.Count > 0;
        }
    }
}
    
