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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
        private LicenseServerHealthStatus _healthStatus;
        private string _ipv4Address;
        private LicenseServerEndpointProvisioningStatus _provisioningStatus;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the RDS license server.
        /// </para>
        /// </summary>
        public LicenseServerHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// A list of domain IPv4 addresses that are used for the RDS license server.
        /// </para>
        /// </summary>
        public string Ipv4Address
        {
            get { return this._ipv4Address; }
            set { this._ipv4Address = value; }
        }

        // Check to see if Ipv4Address property is set
        internal bool IsSetIpv4Address()
        {
            return this._ipv4Address != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The current state of the provisioning process for the RDS license server.
        /// </para>
        /// </summary>
        public LicenseServerEndpointProvisioningStatus ProvisioningStatus
        {
            get { return this._provisioningStatus; }
            set { this._provisioningStatus = value; }
        }

        // Check to see if ProvisioningStatus property is set
        internal bool IsSetProvisioningStatus()
        {
            return this._provisioningStatus != null;
        }

    }
}