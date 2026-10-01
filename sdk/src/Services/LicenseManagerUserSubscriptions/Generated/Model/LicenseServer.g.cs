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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Information about a Remote Desktop Services (RDS) license server.
    /// </summary>
    public partial class LicenseServer
    {
        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the RDS license server.
        /// </para>
        /// </summary>
        public LicenseServerHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// A list of domain IPv4 addresses that are used for the RDS license server.
        /// </para>
        /// </summary>
        public string Ipv4Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4Address property is set.
        /// </summary>
        internal bool IsSetIpv4Address() => this.Ipv4Address != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// A list of domain IPv6 addresses that are used for the RDS license server.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The current state of the provisioning process for the RDS license server.
        /// </para>
        /// </summary>
        public LicenseServerEndpointProvisioningStatus ProvisioningStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatus property is set.
        /// </summary>
        internal bool IsSetProvisioningStatus() => this.ProvisioningStatus != null;
    }
}
