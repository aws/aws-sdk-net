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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains changes to an existing service.
    /// </summary>
    public partial class ServiceChange
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsConfig. 
        /// <para>
        /// Information about the Route 53 DNS records that you want Cloud Map to create when
        /// you register an instance.
        /// </para>
        /// </summary>
        public DnsConfigChange DnsConfig { get; set; }

        /// <summary>
        /// Checks to see if the DnsConfig property is set.
        /// </summary>
        internal bool IsSetDnsConfig() => this.DnsConfig != null;

        /// <summary>
        /// Gets and sets the property HealthCheckConfig. 
        /// <para>
        ///  <i>Public DNS and HTTP namespaces only.</i> Settings for an optional health check.
        /// If you specify settings for a health check, Cloud Map associates the health check
        /// with the records that you specify in <c>DnsConfig</c>.
        /// </para>
        /// </summary>
        public HealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckConfig property is set.
        /// </summary>
        internal bool IsSetHealthCheckConfig() => this.HealthCheckConfig != null;
    }
}
