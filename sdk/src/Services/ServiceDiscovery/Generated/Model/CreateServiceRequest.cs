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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the CreateService operation.
    /// Creates a service. This action defines the configuration for the following entities:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For public and private DNS namespaces, one of the following combinations of DNS records
    /// in Amazon Route 53:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>A</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AAAA</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>A</c> and <c>AAAA</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SRV</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CNAME</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Optionally, a health check
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you create the service, you can submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
    /// request, and Cloud Map uses the values in the configuration to create the specified
    /// entities.
    /// </para>
    ///  
    /// <para>
    /// For the current quota on the number of instances that you can register using the same
    /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
    /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ServiceTypeOption _type;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <c>CreateService</c>
        /// requests to be retried without the risk of running the operation twice. <c>CreatorRequestId</c>
        /// can be any unique string (for example, a date/timestamp).
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
        /// want Cloud Map to create when you register an instance. 
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
        /// Cloud Map associates the health check with all the Route 53 DNS records that you specify
        /// in <c>DnsConfig</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <c>HealthCheckCustomConfig</c>
        /// or <c>HealthCheckConfig</c> but not both.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about the charges for health checks, see <a href="http://aws.amazon.com/cloud-map/pricing/">Cloud
        /// Map Pricing</a>.
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
        /// If you specify a health check configuration, you can specify either <c>HealthCheckCustomConfig</c>
        /// or <c>HealthCheckConfig</c> but not both.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can't add, update, or delete a <c>HealthCheckCustomConfig</c> configuration from
        /// an existing service.
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
        ///  <note> 
        /// <para>
        /// Do not include sensitive information in the name if the namespace is discoverable
        /// by public DNS queries.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want Cloud Map to create an <c>SRV</c> record when you register an instance
        /// and you're using a system that requires a specific <c>SRV</c> format, such as <a href="http://www.haproxy.org/">HAProxy</a>,
        /// specify the following for <c>Name</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start the name with an underscore (_), such as <c>_exampleservice</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// End the name with <i>._protocol</i>, such as <c>._tcp</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you register an instance, Cloud Map creates an <c>SRV</c> record and assigns
        /// a name to the record by concatenating the service name and the namespace name (for
        /// example,
        /// </para>
        ///  
        /// <para>
        ///  <c>_exampleservice._tcp.example.com</c>).
        /// </para>
        ///  <note> 
        /// <para>
        /// For services that are accessible by DNS queries, you can't create multiple services
        /// with names that differ only by case (such as EXAMPLE and example). Otherwise, these
        /// services have the same DNS name and can't be distinguished. However, if you use a
        /// namespace that's only accessible by API calls, then you can create services that with
        /// names that differ only by case.
        /// </para>
        ///  </note>
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
        /// The ID or Amazon Resource Name (ARN) of the namespace that you want to use to create
        /// the service. For namespaces shared with your Amazon Web Services account, specify
        /// the namespace ARN. For more information about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// The tags to add to the service. Each tag consists of a key and an optional value that
        /// you define. Tags keys can be up to 128 characters in length, and tag values can be
        /// up to 256 characters in length.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// If present, specifies that the service instances are only discoverable using the <c>DiscoverInstances</c>
        /// API operation. No DNS records is registered for the service instances. The only valid
        /// value is <c>HTTP</c>.
        /// </para>
        /// </summary>
        public ServiceTypeOption Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}