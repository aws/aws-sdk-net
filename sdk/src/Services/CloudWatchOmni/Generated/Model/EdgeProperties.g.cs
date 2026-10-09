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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Edge attributes promoted out of the flat attribute map onto typed members. Which members
    /// are present depends entirely on what produced the edge, so most edges carry only a
    /// few of them.
    /// </summary>
    public partial class EdgeProperties
    {
        /// <summary>
        /// Gets and sets the property Blocked. Whether the observed network flow was denied.
        /// Absent means the edge was not derived from network flow data, which is not the same
        /// as allowed.
        /// </summary>
        public bool? Blocked { get; set; }

        /// <summary>
        /// Checks to see if the Blocked property is set.
        /// </summary>
        internal bool IsSetBlocked() => this.Blocked.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationPort. The destination port of the observed traffic.
        /// May be a placeholder when the port is unknown.
        /// </summary>
        public string DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. The error code returned when the call was attempted
        /// and refused. Its presence means the edge exists but the dependency is failing.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. The HTTP method observed on the request.
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property HttpStatusCode. The HTTP status code observed on the request.
        /// Distinct from errorCode.
        /// </summary>
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// Checks to see if the HttpStatusCode property is set.
        /// </summary>
        internal bool IsSetHttpStatusCode() => this.HttpStatusCode != null;

        /// <summary>
        /// Gets and sets the property Protocol. The IANA protocol name for the observed network
        /// traffic, such as "tcp".
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ServiceInitiated. Whether the caller was an AWS service
        /// principal rather than a user or role. Absent means the edge was not derived from a
        /// source that reports it.
        /// </summary>
        public bool? ServiceInitiated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInitiated property is set.
        /// </summary>
        internal bool IsSetServiceInitiated() => this.ServiceInitiated.HasValue;

        /// <summary>
        /// Gets and sets the property SourcePort. The source port of the observed traffic. May
        /// be a placeholder when the port is unknown.
        /// </summary>
        public string SourcePort { get; set; }

        /// <summary>
        /// Checks to see if the SourcePort property is set.
        /// </summary>
        internal bool IsSetSourcePort() => this.SourcePort != null;

        /// <summary>
        /// Gets and sets the property TrafficStats. Traffic counters accumulated over the edge's
        /// observation window.
        /// </summary>
        public EdgeTrafficStats TrafficStats { get; set; }

        /// <summary>
        /// Checks to see if the TrafficStats property is set.
        /// </summary>
        internal bool IsSetTrafficStats() => this.TrafficStats != null;
    }
}
