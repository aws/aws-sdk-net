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
    /// A complex type that contains information about the Amazon Route 53 DNS records that
    /// you want Cloud Map to create when you register an instance.
    /// </summary>
    public partial class DnsConfig
    {
        private List<DnsRecord> _dnsRecords = AWSConfigs.InitializeCollections ? new List<DnsRecord>() : null;
        private string _namespaceId;
        private RoutingPolicy _routingPolicy;

        /// <summary>
        /// Gets and sets the property DnsRecords. 
        /// <para>
        /// An array that contains one <c>DnsRecord</c> object for each Route 53 DNS record that
        /// you want Cloud Map to create when you register an instance.
        /// </para>
        ///  <important> 
        /// <para>
        /// The record type of a service specified in a <c>DnsRecord</c> object can't be updated.
        /// To change a record type, you need to delete the service and recreate it with a new
        /// <c>DnsConfig</c>.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DnsRecord> DnsRecords
        {
            get { return this._dnsRecords; }
            set { this._dnsRecords = value; }
        }

        // Check to see if DnsRecords property is set
        internal bool IsSetDnsRecords()
        {
            return this._dnsRecords != null && (this._dnsRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        ///  <i>Use NamespaceId in <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_Service.html">Service</a>
        /// instead.</i> 
        /// </para>
        ///  
        /// <para>
        /// The ID of the namespace to use for DNS configuration.
        /// </para>
        /// </summary>
        [Obsolete("Top level attribute in request should be used to reference namespace-id")]
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
        /// Gets and sets the property RoutingPolicy. 
        /// <para>
        /// The routing policy that you want to apply to all Route 53 DNS records that Cloud Map
        /// creates when you register an instance and specify this service.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to use this service to register instances that create alias records, specify
        /// <c>WEIGHTED</c> for the routing policy.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify the following values:
        /// </para>
        ///  <dl> <dt>MULTIVALUE</dt> <dd> 
        /// <para>
        /// If you define a health check for the service and the health check is healthy, Route 53
        /// returns the applicable value for up to eight instances.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that the service includes configurations for one <c>A</c> record
        /// and a health check. You use the service to register 10 instances. Route 53 responds
        /// to DNS queries with IP addresses for up to eight healthy instances. If fewer than
        /// eight instances are healthy, Route 53 responds to every DNS query with the IP addresses
        /// for all of the healthy instances.
        /// </para>
        ///  
        /// <para>
        /// If you don't define a health check for the service, Route 53 assumes that all instances
        /// are healthy and returns the values for up to eight instances.
        /// </para>
        ///  
        /// <para>
        /// For more information about the multivalue routing policy, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-multivalue">Multivalue
        /// Answer Routing</a> in the <i>Route 53 Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>WEIGHTED</dt> <dd> 
        /// <para>
        /// Route 53 returns the applicable value from one randomly selected instance from among
        /// the instances that you registered using the same service. Currently, all records have
        /// the same weight, so you can't route more or less traffic to any instances.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that the service includes configurations for one <c>A</c> record
        /// and a health check. You use the service to register 10 instances. Route 53 responds
        /// to DNS queries with the IP address for one randomly selected instance from among the
        /// healthy instances. If no instances are healthy, Route 53 responds to DNS queries as
        /// if all of the instances were healthy.
        /// </para>
        ///  
        /// <para>
        /// If you don't define a health check for the service, Route 53 assumes that all instances
        /// are healthy and returns the applicable value for one randomly selected instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about the weighted routing policy, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted">Weighted
        /// Routing</a> in the <i>Route 53 Developer Guide</i>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public RoutingPolicy RoutingPolicy
        {
            get { return this._routingPolicy; }
            set { this._routingPolicy = value; }
        }

        // Check to see if RoutingPolicy property is set
        internal bool IsSetRoutingPolicy()
        {
            return this._routingPolicy != null;
        }

    }
}