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
    /// Describes a filter that returns a more specific list of recommendations. Use this
    /// filter with the <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
    /// actions.
    /// 
    ///  
    /// <para>
    /// You can use <c>EBSFilter</c> with the <a>GetEBSVolumeRecommendations</a> action, <c>LambdaFunctionRecommendationFilter</c>
    /// with the <a>GetLambdaFunctionRecommendations</a> action, and <c>JobFilter</c> with
    /// the <a>DescribeRecommendationExportJobs</a> action.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private FilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>Finding</c> to return recommendations with a specific finding classification.
        /// For example, <c>Underprovisioned</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>RecommendationSourceType</c> to return recommendations of a specific resource
        /// type. For example, <c>Ec2Instance</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>FindingReasonCodes</c> to return recommendations with a specific finding
        /// reason code. For example, <c>CPUUnderprovisioned</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>InferredWorkloadTypes</c> to return recommendations of a specific inferred
        /// workload. For example, <c>Redis</c>.
        /// </para>
        ///  
        /// <para>
        /// You can filter your EC2 instance recommendations by <c>tag:key</c> and <c>tag-key</c>
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// A <c>tag:key</c> is a key and value combination of a tag assigned to your recommendations.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all recommendations that have a tag with the key of <c>Owner</c> and the value
        /// of <c>TeamA</c>, specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for
        /// the filter value.
        /// </para>
        ///  
        /// <para>
        /// A <c>tag-key</c> is the key of a tag assigned to your recommendations. Use this filter
        /// to find all of your recommendations that have a tag with a specific key. This doesn’t
        /// consider the tag value. For example, you can find your recommendations with a tag
        /// key value of <c>Owner</c> or without any tag keys assigned.
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
        /// for the <c>name</c> parameter and the resource type that you wish to filter results
        /// for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <c>Optimized</c> or <c>NotOptimized</c> if you specify the <c>name</c> parameter
        /// as <c>Finding</c> and you want to filter results for Auto Scaling groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>Underprovisioned</c>, <c>Overprovisioned</c>, or <c>Optimized</c> if you
        /// specify the <c>name</c> parameter as <c>Finding</c> and you want to filter results
        /// for EC2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>Ec2Instance</c> or <c>AutoScalingGroup</c> if you specify the <c>name</c>
        /// parameter as <c>RecommendationSourceType</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify one of the following options if you specify the <c>name</c> parameter as <c>FindingReasonCodes</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>CPUOverprovisioned</c> </b> — The instance’s CPU configuration can be sized
        /// down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CPUUnderprovisioned</c> </b> — The instance’s CPU configuration doesn't meet
        /// the performance requirements of your workload and there is an alternative instance
        /// type that provides better CPU performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryOverprovisioned</c> </b> — The instance’s memory configuration can be
        /// sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryUnderprovisioned</c> </b> — The instance’s memory configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better memory performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSThroughputOverprovisioned</c> </b> — The instance’s EBS throughput configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSThroughputUnderprovisioned</c> </b> — The instance’s EBS throughput configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better EBS throughput performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSIOPSOverprovisioned</c> </b> — The instance’s EBS IOPS configuration can
        /// be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSIOPSUnderprovisioned</c> </b> — The instance’s EBS IOPS configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better EBS IOPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkBandwidthOverprovisioned</c> </b> — The instance’s network bandwidth
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkBandwidthUnderprovisioned</c> </b> — The instance’s network bandwidth
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better network bandwidth performance.
        /// This finding reason happens when the <c>NetworkIn</c> or <c>NetworkOut</c> performance
        /// of an instance is impacted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkPPSOverprovisioned</c> </b> — The instance’s network PPS (packets per
        /// second) configuration can be sized down while still meeting the performance requirements
        /// of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkPPSUnderprovisioned</c> </b> — The instance’s network PPS (packets
        /// per second) configuration doesn't meet the performance requirements of your workload
        /// and there is an alternative instance type that provides better network PPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskIOPSOverprovisioned</c> </b> — The instance’s disk IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskIOPSUnderprovisioned</c> </b> — The instance’s disk IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk IOPS performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskThroughputOverprovisioned</c> </b> — The instance’s disk throughput configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskThroughputUnderprovisioned</c> </b> — The instance’s disk throughput configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk throughput performance.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}