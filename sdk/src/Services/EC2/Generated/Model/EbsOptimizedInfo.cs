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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private int? _baselineBandwidthInMbps;
        private int? _baselineIops;
        private double? _baselineThroughputInMBps;
        private int? _maximumBandwidthInMbps;
        private int? _maximumIops;
        private double? _maximumThroughputInMBps;

        /// <summary>
        /// Gets and sets the property BaselineBandwidthInMbps. 
        /// <para>
        /// The baseline bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        /// </summary>
        public int? BaselineBandwidthInMbps
        {
            get { return this._baselineBandwidthInMbps; }
            set { this._baselineBandwidthInMbps = value; }
        }

        // Check to see if BaselineBandwidthInMbps property is set
        internal bool IsSetBaselineBandwidthInMbps()
        {
            return this._baselineBandwidthInMbps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaselineIops. 
        /// <para>
        /// The baseline input/output storage operations per seconds for an EBS-optimized instance
        /// type.
        /// </para>
        /// </summary>
        public int? BaselineIops
        {
            get { return this._baselineIops; }
            set { this._baselineIops = value; }
        }

        // Check to see if BaselineIops property is set
        internal bool IsSetBaselineIops()
        {
            return this._baselineIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaselineThroughputInMBps. 
        /// <para>
        /// The baseline throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        /// </summary>
        public double? BaselineThroughputInMBps
        {
            get { return this._baselineThroughputInMBps; }
            set { this._baselineThroughputInMBps = value; }
        }

        // Check to see if BaselineThroughputInMBps property is set
        internal bool IsSetBaselineThroughputInMBps()
        {
            return this._baselineThroughputInMBps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumBandwidthInMbps. 
        /// <para>
        /// The maximum bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        /// </summary>
        public int? MaximumBandwidthInMbps
        {
            get { return this._maximumBandwidthInMbps; }
            set { this._maximumBandwidthInMbps = value; }
        }

        // Check to see if MaximumBandwidthInMbps property is set
        internal bool IsSetMaximumBandwidthInMbps()
        {
            return this._maximumBandwidthInMbps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumIops. 
        /// <para>
        /// The maximum input/output storage operations per second for an EBS-optimized instance
        /// type.
        /// </para>
        /// </summary>
        public int? MaximumIops
        {
            get { return this._maximumIops; }
            set { this._maximumIops = value; }
        }

        // Check to see if MaximumIops property is set
        internal bool IsSetMaximumIops()
        {
            return this._maximumIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumThroughputInMBps. 
        /// <para>
        /// The maximum throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        /// </summary>
        public double? MaximumThroughputInMBps
        {
            get { return this._maximumThroughputInMBps; }
            set { this._maximumThroughputInMBps = value; }
        }

        // Check to see if MaximumThroughputInMBps property is set
        internal bool IsSetMaximumThroughputInMBps()
        {
            return this._maximumThroughputInMBps.HasValue; 
        }

    }
}