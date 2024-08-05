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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private bool? _blocked;
        private string _connectionDirection;
        private ActionLocalPortDetails _localPortDetails;
        private string _protocol;
        private ActionRemoteIpDetails _remoteIpDetails;
        private ActionRemotePortDetails _remotePortDetails;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the network connection attempt was blocked.
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
        /// Gets and sets the property ConnectionDirection. 
        /// <para>
        /// The direction of the network connection request (<c>IN</c> or <c>OUT</c>).
        /// </para>
        /// </summary>
        public string ConnectionDirection
        {
            get { return this._connectionDirection; }
            set { this._connectionDirection = value; }
        }

        // Check to see if ConnectionDirection property is set
        internal bool IsSetConnectionDirection()
        {
            return this._connectionDirection != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPortDetails. 
        /// <para>
        /// Information about the port on the EC2 instance.
        /// </para>
        /// </summary>
        public ActionLocalPortDetails LocalPortDetails
        {
            get { return this._localPortDetails; }
            set { this._localPortDetails = value; }
        }

        // Check to see if LocalPortDetails property is set
        internal bool IsSetLocalPortDetails()
        {
            return this._localPortDetails != null;
        }

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
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// Information about the remote IP address that issued the network connection request.
        /// </para>
        /// </summary>
        public ActionRemoteIpDetails RemoteIpDetails
        {
            get { return this._remoteIpDetails; }
            set { this._remoteIpDetails = value; }
        }

        // Check to see if RemoteIpDetails property is set
        internal bool IsSetRemoteIpDetails()
        {
            return this._remoteIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RemotePortDetails. 
        /// <para>
        /// Information about the port on the remote IP address.
        /// </para>
        /// </summary>
        public ActionRemotePortDetails RemotePortDetails
        {
            get { return this._remotePortDetails; }
            set { this._remotePortDetails = value; }
        }

        // Check to see if RemotePortDetails property is set
        internal bool IsSetRemotePortDetails()
        {
            return this._remotePortDetails != null;
        }

    }
}