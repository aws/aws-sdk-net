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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The preference to control the resource’s CPU utilization threshold, CPU utilization
    /// headroom, and memory utilization headroom. 
    /// 
    ///  <note> 
    /// <para>
    /// This preference is only available for the Amazon EC2 instance resource type.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UtilizationPreference
    {
        private CustomizableMetricName _metricName;
        private CustomizableMetricParameters _metricParameters;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the resource utilization metric name to customize. 
        /// </para>
        /// </summary>
        public CustomizableMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricParameters. 
        /// <para>
        ///  The parameters to set when customizing the resource utilization thresholds. 
        /// </para>
        /// </summary>
        public CustomizableMetricParameters MetricParameters
        {
            get { return this._metricParameters; }
            set { this._metricParameters = value; }
        }

        // Check to see if MetricParameters property is set
        internal bool IsSetMetricParameters()
        {
            return this._metricParameters != null;
        }

    }
}