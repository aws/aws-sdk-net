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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the CreateService operation.
    /// Creates a service, which defines the configuration for the following entities:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For public and private DNS namespaces, one of the following combinations of DNS records
    /// in Amazon Route 53:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>A</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AAAA</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>A</code> and <code>AAAA</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SRV</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CNAME</code> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Optionally, a health check
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you create the service, you can submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
    /// request, and AWS Cloud Map uses the values in the configuration to create the specified
    /// entities.
    /// </para>
    ///  
    /// <para>
    /// For the current quota on the number of instances that you can register using the same
    /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">AWS
    /// Cloud Map Limits</a> in the <i>AWS Cloud Map Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonServiceDiscoveryRequest
    {
        private string _creatorRequestId;
        private string _description;
        private DnsConfig _dnsConfig;
        private HealthCheckConfig _healthCheckConfig;
        private HealthCheckCustomConfig _healthCheckCustomConfig;
        private string _name;
        private string _namespaceId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <code>CreateService</code>
        /// requests to be retried without the risk of executing the operation twice. <code>CreatorRequestId</code>
        /// can be any unique string, for example, a date/time stamp.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        [AWSProperty(Max=1024)]
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
        /// A complex type that contains information about the Amazon Route 53 records that you
        /// want AWS Cloud Map to create when you register an instance. 
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
        ///  <i>Public DNS and HTTP namespaces only.</i> A complex type that contains settings
        /// for an optional Route 53 health check. If you specify settings for a health check,
        /// AWS Cloud Map associates the health check with all the Route 53 DNS records that you
        /// specify in <code>DnsConfig</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
        /// or <code>HealthCheckConfig</code> but not both.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about the charges for health checks, see <a href="http://aws.amazon.com/cloud-map/pricing/">AWS
        /// Cloud Map Pricing</a>.
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
        /// Gets and sets the property HealthCheckCustomConfig. 
        /// <para>
        /// A complex type that contains information about an optional custom health check.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
        /// or <code>HealthCheckConfig</code> but not both.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can't add, update, or delete a <code>HealthCheckCustomConfig</code> configuration
        /// from an existing service.
        /// </para>
        /// </summary>
        public HealthCheckCustomConfig HealthCheckCustomConfig
        {
            get { return this._healthCheckCustomConfig; }
            set { this._healthCheckCustomConfig = value; }
        }

        // Check to see if HealthCheckCustomConfig property is set
        internal bool IsSetHealthCheckCustomConfig()
        {
            return this._healthCheckCustomConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to assign to the service.
        /// </para>
        ///  
        /// <para>
        /// If you want AWS Cloud Map to create an <code>SRV</code> record when you register an
        /// instance, and if you're using a system that requires a specific <code>SRV</code> format,
        /// such as <a href="http://www.haproxy.org/">HAProxy</a>, specify the following for <code>Name</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start the name with an underscore (_), such as <code>_exampleservice</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// End the name with <i>._protocol</i>, such as <code>._tcp</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you register an instance, AWS Cloud Map creates an <code>SRV</code> record and
        /// assigns a name to the record by concatenating the service name and the namespace name,
        /// for example:
        /// </para>
        ///  
        /// <para>
        ///  <code>_exampleservice._tcp.example.com</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The ID of the namespace that you want to use to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the service. Each tag consists of a key and an optional value,
        /// both of which you define. Tag keys can have a maximum character length of 128 characters,
        /// and tag values can have a maximum length of 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}