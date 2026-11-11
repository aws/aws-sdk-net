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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Information about a UDP ping beacon that can be used to measure network latency between
    /// a player device and an Amazon GameLift Servers hosting location.
    /// </summary>
    public partial class PingBeacon
    {
        /// <summary>
        /// Gets and sets the property UDPEndpoint. 
        /// <para>
        /// The domain name and port of the UDP ping beacon. Your game client can send UDP messages
        /// to this endpoint and receive responses to measure network latency.
        /// </para>
        /// </summary>
        public UDPEndpoint UDPEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UDPEndpoint property is set.
        /// </summary>
        internal bool IsSetUDPEndpoint() => this.UDPEndpoint != null;
    }
}
