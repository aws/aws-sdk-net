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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the port probe details.
    /// </summary>
    public partial class PortProbeDetail
    {
        private LocalIpDetails _localIpDetails;
        private LocalPortDetails _localPortDetails;
        private RemoteIpDetails _remoteIpDetails;

        /// <summary>
        /// Gets and sets the property LocalIpDetails. 
        /// <para>
        /// The local IP information of the connection.
        /// </para>
        /// </summary>
        public LocalIpDetails LocalIpDetails
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
        /// The local port information of the connection.
        /// </para>
        /// </summary>
        public LocalPortDetails LocalPortDetails
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
        /// The remote IP information of the connection.
        /// </para>
        /// </summary>
        public RemoteIpDetails RemoteIpDetails
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