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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
        private UDPEndpoint _udpEndpoint;

        /// <summary>
        /// Gets and sets the property UDPEndpoint. 
        /// <para>
        /// The domain name and port of the UDP ping beacon. 
        /// </para>
        /// </summary>
        public UDPEndpoint UDPEndpoint
        {
            get { return this._udpEndpoint; }
            set { this._udpEndpoint = value; }
        }

        // Check to see if UDPEndpoint property is set
        internal bool IsSetUDPEndpoint()
        {
            return this._udpEndpoint != null;
        }

    }
}