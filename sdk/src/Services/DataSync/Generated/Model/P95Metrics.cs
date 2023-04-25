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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The types of performance data that DataSync Discovery collects about an on-premises
    /// storage system resource.
    /// </summary>
    public partial class P95Metrics
    {
        private IOPS _iops;
        private Latency _latency;
        private Throughput _throughput;

        /// <summary>
        /// Gets and sets the property IOPS. 
        /// <para>
        /// The IOPS peaks for an on-premises storage system resource. Each data point represents
        /// the 95th percentile peak value during a 1-hour interval.
        /// </para>
        /// </summary>
        public IOPS IOPS
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if IOPS property is set
        internal bool IsSetIOPS()
        {
            return this._iops != null;
        }

        /// <summary>
        /// Gets and sets the property Latency. 
        /// <para>
        /// The latency peaks for an on-premises storage system resource. Each data point represents
        /// the 95th percentile peak value during a 1-hour interval.
        /// </para>
        /// </summary>
        public Latency Latency
        {
            get { return this._latency; }
            set { this._latency = value; }
        }

        // Check to see if Latency property is set
        internal bool IsSetLatency()
        {
            return this._latency != null;
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput peaks for an on-premises storage system resource. Each data point represents
        /// the 95th percentile peak value during a 1-hour interval.
        /// </para>
        /// </summary>
        public Throughput Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput != null;
        }

    }
}