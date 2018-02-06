/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains changes to an existing service.
    /// </summary>
    public partial class ServiceChange
    {
        private string _description;
        private DnsConfigChange _dnsConfig;
        private HealthCheckConfig _healthCheckConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the service.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsConfig. 
        /// <para>
        /// A complex type that contains information about the records that you want Route 53
        /// to create when you register an instance.
        /// </para>
        /// </summary>
        public DnsConfigChange DnsConfig
        {
            get { return this._dnsConfig; }
            set { this._dnsConfig = value; }
        }

        // Check to see if DnsConfig property is set
        internal bool IsSetDnsConfig()
        {
            return this._dnsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckConfig.
        /// </summary>
        public HealthCheckConfig HealthCheckConfig
        {
            get { return this._healthCheckConfig; }
            set { this._healthCheckConfig = value; }
        }

        // Check to see if HealthCheckConfig property is set
        internal bool IsSetHealthCheckConfig()
        {
            return this._healthCheckConfig != null;
        }

    }
}