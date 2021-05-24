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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a filter that returns a more specific list of recommendations. Use this
    /// filter with the <code>GetAutoScalingGroupRecommendations</code> and <code>GetEC2InstanceRecommendations</code>
    /// actions.
    /// 
    ///  
    /// <para>
    /// You can use <code>EBSFilter</code> with the <code>GetEBSVolumeRecommendations</code>
    /// action, <code>LambdaFunctionRecommendationFilter</code> with the <code>GetLambdaFunctionRecommendations</code>
    /// action, and <code>JobFilter</code> with the <code>DescribeRecommendationExportJobs</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private FilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>Finding</code> to return recommendations with a specific finding classification
        /// (e.g., <code>Underprovisioned</code>).
        /// </para>
        ///  
        /// <para>
        /// Specify <code>RecommendationSourceType</code> to return recommendations of a specific
        /// resource type (e.g., <code>Ec2Instance</code>).
        /// </para>
        ///  
        /// <para>
        /// Specify <code>FindingReasonCodes</code> to return recommendations with a specific
        /// finding reason code (e.g., <code>CPUUnderprovisioned</code>).
        /// </para>
        /// </summary>
        public FilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value of the filter.
        /// </para>
        ///  
        /// <para>
        /// The valid values for this parameter are as follows, depending on what you specify
        /// for the <code>name</code> parameter and the resource type that you wish to filter
        /// results for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <code>Optimized</code> or <code>NotOptimized</code> if you specify the <code>name</code>
        /// parameter as <code>Finding</code> and you want to filter results for Auto Scaling
        /// groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>Underprovisioned</code>, <code>Overprovisioned</code>, or <code>Optimized</code>
        /// if you specify the <code>name</code> parameter as <code>Finding</code> and you want
        /// to filter results for EC2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>Ec2Instance</code> or <code>AutoScalingGroup</code> if you specify the
        /// <code>name</code> parameter as <code>RecommendationSourceType</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify one of the following options if you specify the <code>name</code> parameter
        /// as <code>FindingReasonCodes</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>CPUOverprovisioned</code> </b> — The instance’s CPU configuration can be
        /// sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CPUUnderprovisioned</code> </b> — The instance’s CPU configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better CPU performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryOverprovisioned</code> </b> — The instance’s memory configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryUnderprovisioned</code> </b> — The instance’s memory configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better memory performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSThroughputOverprovisioned</code> </b> — The instance’s EBS throughput
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSThroughputUnderprovisioned</code> </b> — The instance’s EBS throughput
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better EBS throughput performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSIOPSOverprovisioned</code> </b> — The instance’s EBS IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSIOPSUnderprovisioned</code> </b> — The instance’s EBS IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better EBS IOPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkBandwidthOverprovisioned</code> </b> — The instance’s network bandwidth
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkBandwidthUnderprovisioned</code> </b> — The instance’s network bandwidth
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better network bandwidth performance.
        /// This finding reason happens when the <code>NetworkIn</code> or <code>NetworkOut</code>
        /// performance of an instance is impacted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkPPSOverprovisioned</code> </b> — The instance’s network PPS (packets
        /// per second) configuration can be sized down while still meeting the performance requirements
        /// of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkPPSUnderprovisioned</code> </b> — The instance’s network PPS (packets
        /// per second) configuration doesn't meet the performance requirements of your workload
        /// and there is an alternative instance type that provides better network PPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskIOPSOverprovisioned</code> </b> — The instance’s disk IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskIOPSUnderprovisioned</code> </b> — The instance’s disk IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk IOPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskThroughputOverprovisioned</code> </b> — The instance’s disk throughput
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskThroughputUnderprovisioned</code> </b> — The instance’s disk throughput
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better disk throughput performance.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}