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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Edge attributes promoted out of the flat attribute map onto typed members. Which members
    /// are present depends entirely on what produced the edge, so most edges carry only a
    /// few of them.
    /// </summary>
    public partial class EdgeProperties
    {
        private bool? _blocked;
        private string _destinationPort;
        private string _errorCode;
        private string _httpMethod;
        private string _httpStatusCode;
        private string _protocol;
        private bool? _serviceInitiated;
        private string _sourcePort;
        private EdgeTrafficStats _trafficStats;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Whether the observed network flow was denied. Absent means the edge was not derived
        /// from network flow data, which is not the same as allowed.
        /// </para>
        /// </summary>
        public bool? Blocked
        {
            get { return this._blocked; }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port of the observed traffic. May be a placeholder when the port is
        /// unknown.
        /// </para>
        /// </summary>
        public string DestinationPort
        {
            get { return this._destinationPort; }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when the call was attempted and refused. Its presence means
        /// the edge exists but the dependency is failing.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method observed on the request.
        /// </para>
        /// </summary>
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property HttpStatusCode. 
        /// <para>
        /// The HTTP status code observed on the request. Distinct from errorCode.
        /// </para>
        /// </summary>
        public string HttpStatusCode
        {
            get { return this._httpStatusCode; }
            set { this._httpStatusCode = value; }
        }

        // Check to see if HttpStatusCode property is set
        internal bool IsSetHttpStatusCode()
        {
            return this._httpStatusCode != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IANA protocol name for the observed network traffic, such as &quot;tcp&quot;.
        /// </para>
        /// </summary>
        public string Protocol
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
        /// Gets and sets the property ServiceInitiated. 
        /// <para>
        /// Whether the caller was an AWS service principal rather than a user or role. Absent
        /// means the edge was not derived from a source that reports it.
        /// </para>
        /// </summary>
        public bool? ServiceInitiated
        {
            get { return this._serviceInitiated; }
            set { this._serviceInitiated = value; }
        }

        // Check to see if ServiceInitiated property is set
        internal bool IsSetServiceInitiated()
        {
            return this._serviceInitiated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port of the observed traffic. May be a placeholder when the port is unknown.
        /// </para>
        /// </summary>
        public string SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficStats. 
        /// <para>
        /// Traffic counters accumulated over the edge's observation window.
        /// </para>
        /// </summary>
        public EdgeTrafficStats TrafficStats
        {
            get { return this._trafficStats; }
            set { this._trafficStats = value; }
        }

        // Check to see if TrafficStats property is set
        internal bool IsSetTrafficStats()
        {
            return this._trafficStats != null;
        }

    }
}