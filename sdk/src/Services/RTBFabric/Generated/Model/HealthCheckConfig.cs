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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// The health check configuration for a managed endpoint. Defines how the service probes
    /// instances in the Auto Scaling group to determine their health status.
    /// </summary>
    public partial class HealthCheckConfig
    {
        private int? _healthyThresholdCount;
        private int? _intervalSeconds;
        private string _path;
        private int? _port;
        private Protocol _protocol;
        private string _statusCodeMatcher;
        private int? _timeoutMs;
        private int? _unhealthyThresholdCount;

        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive successful health checks required before an instance is
        /// considered healthy. Valid range is 2 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int? HealthyThresholdCount
        {
            get { return this._healthyThresholdCount; }
            set { this._healthyThresholdCount = value; }
        }

        // Check to see if HealthyThresholdCount property is set
        internal bool IsSetHealthyThresholdCount()
        {
            return this._healthyThresholdCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The interval between health check probes, in seconds. Valid range is 5 to 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=60)]
        public int? IntervalSeconds
        {
            get { return this._intervalSeconds; }
            set { this._intervalSeconds = value; }
        }

        // Check to see if IntervalSeconds property is set
        internal bool IsSetIntervalSeconds()
        {
            return this._intervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The destination path for the health check request. Must start with <c>/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port to use for health check probes. Valid range is 80 to 65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=80, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for health check probes.
        /// </para>
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCodeMatcher. 
        /// <para>
        /// The expected HTTP status code or status code pattern from healthy instances. Supports
        /// a single code (for example, <c>200</c>), a range (for example, <c>200-299</c>), or
        /// a comma-separated list (for example, <c>200,204</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string StatusCodeMatcher
        {
            get { return this._statusCodeMatcher; }
            set { this._statusCodeMatcher = value; }
        }

        // Check to see if StatusCodeMatcher property is set
        internal bool IsSetStatusCodeMatcher()
        {
            return this._statusCodeMatcher != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutMs. 
        /// <para>
        /// The timeout for each health check probe, in milliseconds. Valid range is 100 to 5000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=5000)]
        public int? TimeoutMs
        {
            get { return this._timeoutMs; }
            set { this._timeoutMs = value; }
        }

        // Check to see if TimeoutMs property is set
        internal bool IsSetTimeoutMs()
        {
            return this._timeoutMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive failed health checks required before an instance is considered
        /// unhealthy. Valid range is 2 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int? UnhealthyThresholdCount
        {
            get { return this._unhealthyThresholdCount; }
            set { this._unhealthyThresholdCount = value; }
        }

        // Check to see if UnhealthyThresholdCount property is set
        internal bool IsSetUnhealthyThresholdCount()
        {
            return this._unhealthyThresholdCount.HasValue; 
        }

    }
}