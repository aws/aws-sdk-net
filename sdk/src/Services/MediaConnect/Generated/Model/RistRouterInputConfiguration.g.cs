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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The configuration settings for a router input using the RIST (Reliable Internet Stream
    /// Transport) protocol, including the port and recovery latency.
    /// </summary>
    public partial class RistRouterInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number used for the RIST protocol in the router input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3000, Max = 30000)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryLatencyMilliseconds. 
        /// <para>
        /// The recovery latency in milliseconds for the RIST protocol in the router input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10000)]
        public long? RecoveryLatencyMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryLatencyMilliseconds property is set.
        /// </summary>
        internal bool IsSetRecoveryLatencyMilliseconds() => this.RecoveryLatencyMilliseconds.HasValue;
    }
}
