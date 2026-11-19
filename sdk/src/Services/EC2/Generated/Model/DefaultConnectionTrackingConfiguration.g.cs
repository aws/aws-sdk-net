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
    /// Indicates default conntrack information for the instance type. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">
    /// Connection tracking timeouts </a> in the Amazon EC2 User Guide.
    /// </summary>
    public partial class DefaultConnectionTrackingConfiguration
    {
        /// <summary>
        /// Gets and sets the property DefaultTcpEstablishedTimeout. 
        /// <para>
        /// Default timeout (in seconds) for idle TCP connections in an established state.
        /// </para>
        /// </summary>
        public int? DefaultTcpEstablishedTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTcpEstablishedTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultTcpEstablishedTimeout() => this.DefaultTcpEstablishedTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultUdpStreamTimeout. 
        /// <para>
        /// Default timeout (in seconds) for idle UDP flows classified as streams which have seen
        /// more than one request-response transaction.
        /// </para>
        /// </summary>
        public int? DefaultUdpStreamTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultUdpStreamTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultUdpStreamTimeout() => this.DefaultUdpStreamTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultUdpTimeout. 
        /// <para>
        /// Default timeout (in seconds) for idle UDP flows that have seen traffic only in a single
        /// direction or a single request-response transaction.
        /// </para>
        /// </summary>
        public int? DefaultUdpTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultUdpTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultUdpTimeout() => this.DefaultUdpTimeout.HasValue;
    }
}
