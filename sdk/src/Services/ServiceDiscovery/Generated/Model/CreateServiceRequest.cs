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
    /// Container for the parameters to the CreateService operation.
    /// Creates a service, which defines a template for the following entities:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// One to five resource record sets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optionally, a health check
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you create the service, you can submit a <a>RegisterInstance</a> request, and
    /// Amazon Route 53 uses the values in the template to create the specified entities.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonServiceDiscoveryRequest
    {
        private string _creatorRequestId;
        private string _description;
        private DnsConfig _dnsConfig;
        private HealthCheckConfig _healthCheckConfig;
        private string _name;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// An optional parameter that you can use to resolve concurrent creation requests. <code>CreatorRequestId</code>
        /// helps to determine if a specific client owns the namespace.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

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
        /// A complex type that contains information about the resource record sets that you want
        /// Amazon Route 53 to create when you register an instance. 
        /// </para>
        /// </summary>
        public DnsConfig DnsConfig
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
        /// <para>
        ///  <i>Public DNS namespaces only.</i> A complex type that contains settings for an optional
        /// health check. If you specify settings for a health check, Amazon Route 53 associates
        /// the health check with all the resource record sets that you specify in <code>DnsConfig</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The health check uses 30 seconds as the request interval. This is the number of seconds
        /// between the time that each Amazon Route 53 health checker gets a response from your
        /// endpoint and the time that it sends the next health check request. A health checker
        /// in each data center around the world sends your endpoint a health check request every
        /// 30 seconds. On average, your endpoint receives a health check request about every
        /// two seconds. Health checkers in different data centers don't coordinate with one another,
        /// so you'll sometimes see several requests per second followed by a few seconds with
        /// no health checks at all.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about the charges for health checks, see <a href="http://aws.amazon.com/route53/pricing">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to assign to the service.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}