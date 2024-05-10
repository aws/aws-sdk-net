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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the health check policy for a virtual gateway's listener.
    /// </summary>
    public partial class VirtualGatewayHealthCheckPolicy
    {
        private int? _healthyThreshold;
        private long? _intervalMillis;
        private string _path;
        private int? _port;
        private VirtualGatewayPortProtocol _protocol;
        private long? _timeoutMillis;
        private int? _unhealthyThreshold;

        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive successful health checks that must occur before declaring
        /// the listener healthy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
        public int? HealthyThreshold
        {
            get { return this._healthyThreshold; }
            set { this._healthyThreshold = value; }
        }

        // Check to see if HealthyThreshold property is set
        internal bool IsSetHealthyThreshold()
        {
            return this._healthyThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalMillis. 
        /// <para>
        /// The time period in milliseconds between each health check execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5000, Max=300000)]
        public long? IntervalMillis
        {
            get { return this._intervalMillis; }
            set { this._intervalMillis = value; }
        }

        // Check to see if IntervalMillis property is set
        internal bool IsSetIntervalMillis()
        {
            return this._intervalMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The destination path for the health check request. This value is only used if the
        /// specified protocol is HTTP or HTTP/2. For any other protocol, this value is ignored.
        /// </para>
        /// </summary>
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
        /// The destination port for the health check request. This port must match the port defined
        /// in the <a>PortMapping</a> for the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// The protocol for the health check request. If you specify <c>grpc</c>, then your service
        /// must conform to the <a href="https://github.com/grpc/grpc/blob/master/doc/health-checking.md">GRPC
        /// Health Checking Protocol</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualGatewayPortProtocol Protocol
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
        /// Gets and sets the property TimeoutMillis. 
        /// <para>
        /// The amount of time to wait when receiving a response from the health check, in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2000, Max=60000)]
        public long? TimeoutMillis
        {
            get { return this._timeoutMillis; }
            set { this._timeoutMillis = value; }
        }

        // Check to see if TimeoutMillis property is set
        internal bool IsSetTimeoutMillis()
        {
            return this._timeoutMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive failed health checks that must occur before declaring a
        /// virtual gateway unhealthy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
        public int? UnhealthyThreshold
        {
            get { return this._unhealthyThreshold; }
            set { this._unhealthyThreshold = value; }
        }

        // Check to see if UnhealthyThreshold property is set
        internal bool IsSetUnhealthyThreshold()
        {
            return this._unhealthyThreshold.HasValue; 
        }

    }
}