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
    /// The performance data that DataSync Discovery collects about an on-premises storage
    /// system resource.
    /// </summary>
    public partial class MaxP95Performance
    {
        private double? _iopsOther;
        private double? _iopsRead;
        private double? _iopsTotal;
        private double? _iopsWrite;
        private double? _latencyOther;
        private double? _latencyRead;
        private double? _latencyWrite;
        private double? _throughputOther;
        private double? _throughputRead;
        private double? _throughputTotal;
        private double? _throughputWrite;

        /// <summary>
        /// Gets and sets the property IopsOther. 
        /// <para>
        /// Peak IOPS unrelated to read and write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double IopsOther
        {
            get { return this._iopsOther.GetValueOrDefault(); }
            set { this._iopsOther = value; }
        }

        // Check to see if IopsOther property is set
        internal bool IsSetIopsOther()
        {
            return this._iopsOther.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IopsRead. 
        /// <para>
        /// Peak IOPS related to read operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double IopsRead
        {
            get { return this._iopsRead.GetValueOrDefault(); }
            set { this._iopsRead = value; }
        }

        // Check to see if IopsRead property is set
        internal bool IsSetIopsRead()
        {
            return this._iopsRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IopsTotal. 
        /// <para>
        /// Peak total IOPS on your on-premises storage system resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double IopsTotal
        {
            get { return this._iopsTotal.GetValueOrDefault(); }
            set { this._iopsTotal = value; }
        }

        // Check to see if IopsTotal property is set
        internal bool IsSetIopsTotal()
        {
            return this._iopsTotal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IopsWrite. 
        /// <para>
        /// Peak IOPS related to write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double IopsWrite
        {
            get { return this._iopsWrite.GetValueOrDefault(); }
            set { this._iopsWrite = value; }
        }

        // Check to see if IopsWrite property is set
        internal bool IsSetIopsWrite()
        {
            return this._iopsWrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyOther. 
        /// <para>
        /// Peak latency for operations unrelated to read and write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double LatencyOther
        {
            get { return this._latencyOther.GetValueOrDefault(); }
            set { this._latencyOther = value; }
        }

        // Check to see if LatencyOther property is set
        internal bool IsSetLatencyOther()
        {
            return this._latencyOther.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyRead. 
        /// <para>
        /// Peak latency for read operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double LatencyRead
        {
            get { return this._latencyRead.GetValueOrDefault(); }
            set { this._latencyRead = value; }
        }

        // Check to see if LatencyRead property is set
        internal bool IsSetLatencyRead()
        {
            return this._latencyRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyWrite. 
        /// <para>
        /// Peak latency for write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double LatencyWrite
        {
            get { return this._latencyWrite.GetValueOrDefault(); }
            set { this._latencyWrite = value; }
        }

        // Check to see if LatencyWrite property is set
        internal bool IsSetLatencyWrite()
        {
            return this._latencyWrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputOther. 
        /// <para>
        /// Peak throughput unrelated to read and write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double ThroughputOther
        {
            get { return this._throughputOther.GetValueOrDefault(); }
            set { this._throughputOther = value; }
        }

        // Check to see if ThroughputOther property is set
        internal bool IsSetThroughputOther()
        {
            return this._throughputOther.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputRead. 
        /// <para>
        /// Peak throughput related to read operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double ThroughputRead
        {
            get { return this._throughputRead.GetValueOrDefault(); }
            set { this._throughputRead = value; }
        }

        // Check to see if ThroughputRead property is set
        internal bool IsSetThroughputRead()
        {
            return this._throughputRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputTotal. 
        /// <para>
        /// Peak total throughput on your on-premises storage system resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double ThroughputTotal
        {
            get { return this._throughputTotal.GetValueOrDefault(); }
            set { this._throughputTotal = value; }
        }

        // Check to see if ThroughputTotal property is set
        internal bool IsSetThroughputTotal()
        {
            return this._throughputTotal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputWrite. 
        /// <para>
        /// Peak throughput related to write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double ThroughputWrite
        {
            get { return this._throughputWrite.GetValueOrDefault(); }
            set { this._throughputWrite = value; }
        }

        // Check to see if ThroughputWrite property is set
        internal bool IsSetThroughputWrite()
        {
            return this._throughputWrite.HasValue; 
        }

    }
}