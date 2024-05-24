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
    /// A port scan that was part of the port probe. For each scan, PortProbeDetails provides
    /// information about the local IP address and port that were scanned, and the remote
    /// IP address that the scan originated from.
    /// </summary>
    public partial class PortProbeDetail
    {
        private ActionLocalIpDetails _localIpDetails;
        private ActionLocalPortDetails _localPortDetails;
        private ActionRemoteIpDetails _remoteIpDetails;

        /// <summary>
        /// Gets and sets the property LocalIpDetails. 
        /// <para>
        /// Provides information about the IP address where the scanned port is located.
        /// </para>
        /// </summary>
        public ActionLocalIpDetails LocalIpDetails
        {
            get { return this._localIpDetails; }
            set { this._localIpDetails = value; }
        }

        // Check to see if LocalIpDetails property is set
        internal bool IsSetLocalIpDetails()
        {
            return this._localIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPortDetails. 
        /// <para>
        /// Provides information about the port that was scanned.
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
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// Provides information about the remote IP address that performed the scan.
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

    }
}