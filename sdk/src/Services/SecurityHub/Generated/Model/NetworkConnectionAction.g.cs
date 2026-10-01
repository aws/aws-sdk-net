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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provided if <c>ActionType</c> is <c>NETWORK_CONNECTION</c>. It provides details about
    /// the attempted network connection that was detected.
    /// </summary>
    public partial class NetworkConnectionAction
    {
        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the network connection attempt was blocked.
        /// </para>
        /// </summary>
        public bool? Blocked { get; set; }

        /// <summary>
        /// Checks to see if the Blocked property is set.
        /// </summary>
        internal bool IsSetBlocked() => this.Blocked.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionDirection. 
        /// <para>
        /// The direction of the network connection request (<c>IN</c> or <c>OUT</c>).
        /// </para>
        /// </summary>
        public string ConnectionDirection { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionDirection property is set.
        /// </summary>
        internal bool IsSetConnectionDirection() => this.ConnectionDirection != null;

        /// <summary>
        /// Gets and sets the property LocalPortDetails. 
        /// <para>
        /// Information about the port on the EC2 instance.
        /// </para>
        /// </summary>
        public ActionLocalPortDetails LocalPortDetails { get; set; }

        /// <summary>
        /// Checks to see if the LocalPortDetails property is set.
        /// </summary>
        internal bool IsSetLocalPortDetails() => this.LocalPortDetails != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used to make the network connection request.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 64.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// Information about the remote IP address that issued the network connection request.
        /// </para>
        /// </summary>
        public ActionRemoteIpDetails RemoteIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpDetails property is set.
        /// </summary>
        internal bool IsSetRemoteIpDetails() => this.RemoteIpDetails != null;

        /// <summary>
        /// Gets and sets the property RemotePortDetails. 
        /// <para>
        /// Information about the port on the remote IP address.
        /// </para>
        /// </summary>
        public ActionRemotePortDetails RemotePortDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemotePortDetails property is set.
        /// </summary>
        internal bool IsSetRemotePortDetails() => this.RemotePortDetails != null;
    }
}
