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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the optimized EBS performance for supported instance types.
    /// </summary>
    public partial class EbsOptimizedInfo
    {
        /// <summary>
        /// Gets and sets the property BaselineBandwidthInMbps. 
        /// <para>
        /// The baseline bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        /// </summary>
        public int? BaselineBandwidthInMbps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineBandwidthInMbps property is set.
        /// </summary>
        internal bool IsSetBaselineBandwidthInMbps() => this.BaselineBandwidthInMbps.HasValue;

        /// <summary>
        /// Gets and sets the property BaselineIops. 
        /// <para>
        /// The baseline input/output storage operations per seconds for an EBS-optimized instance
        /// type.
        /// </para>
        /// </summary>
        public int? BaselineIops { get; set; }

        /// <summary>
        /// Checks to see if the BaselineIops property is set.
        /// </summary>
        internal bool IsSetBaselineIops() => this.BaselineIops.HasValue;

        /// <summary>
        /// Gets and sets the property BaselineThroughputInMBps. 
        /// <para>
        /// The baseline throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        /// </summary>
        public double? BaselineThroughputInMBps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineThroughputInMBps property is set.
        /// </summary>
        internal bool IsSetBaselineThroughputInMBps() => this.BaselineThroughputInMBps.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumBandwidthInMbps. 
        /// <para>
        /// The maximum bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        /// </summary>
        public int? MaximumBandwidthInMbps { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBandwidthInMbps property is set.
        /// </summary>
        internal bool IsSetMaximumBandwidthInMbps() => this.MaximumBandwidthInMbps.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumIops. 
        /// <para>
        /// The maximum input/output storage operations per second for an EBS-optimized instance
        /// type.
        /// </para>
        /// </summary>
        public int? MaximumIops { get; set; }

        /// <summary>
        /// Checks to see if the MaximumIops property is set.
        /// </summary>
        internal bool IsSetMaximumIops() => this.MaximumIops.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumThroughputInMBps. 
        /// <para>
        /// The maximum throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        /// </summary>
        public double? MaximumThroughputInMBps { get; set; }

        /// <summary>
        /// Checks to see if the MaximumThroughputInMBps property is set.
        /// </summary>
        internal bool IsSetMaximumThroughputInMBps() => this.MaximumThroughputInMBps.HasValue;
    }
}
