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
    /// <i>Public DNS and HTTP namespaces only.</i> A complex type that contains settings
    /// for an optional health check. If you specify settings for a health check, Cloud Map
    /// associates the health check with the records that you specify in <code>DnsConfig</code>.
    /// 
    ///  <important> 
    /// <para>
    /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
    /// or <code>HealthCheckConfig</code> but not both.
    /// </para>
    ///  </important> 
    /// <para>
    /// Health checks are basic Route 53 health checks that monitor an Amazon Web Services
    /// endpoint. For information about pricing for health checks, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>.
    /// </para>
    ///  
    /// <para>
    /// Note the following about configuring health checks.
    /// </para>
    ///  <dl> <dt>A and AAAA records</dt> <dd> 
    /// <para>
    /// If <code>DnsConfig</code> includes configurations for both <code>A</code> and <code>AAAA</code>
    /// records, Cloud Map creates a health check that uses the IPv4 address to check the
    /// health of the resource. If the endpoint tthat's specified by the IPv4 address is unhealthy,
    /// Route 53 considers both the <code>A</code> and <code>AAAA</code> records to be unhealthy.
    /// 
    /// </para>
    ///  </dd> <dt>CNAME records</dt> <dd> 
    /// <para>
    /// You can't specify settings for <code>HealthCheckConfig</code> when the <code>DNSConfig</code>
    /// includes <code>CNAME</code> for the value of <code>Type</code>. If you do, the <code>CreateService</code>
    /// request will fail with an <code>InvalidInput</code> error.
    /// </para>
    ///  </dd> <dt>Request interval</dt> <dd> 
    /// <para>
    /// A Route 53 health checker in each health-checking Amazon Web Services Region sends
    /// a health check request to an endpoint every 30 seconds. On average, your endpoint
    /// receives a health check request about every two seconds. However, health checkers
    /// don't coordinate with one another. Therefore, you might sometimes see several requests
    /// in one second that's followed by a few seconds with no health checks at all.
    /// </para>
    ///  </dd> <dt>Health checking regions</dt> <dd> 
    /// <para>
    /// Health checkers perform checks from all Route 53 health-checking Regions. For a list
    /// of the current Regions, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_HealthCheckConfig.html#Route53-Type-HealthCheckConfig-Regions">Regions</a>.
    /// </para>
    ///  </dd> <dt>Alias records</dt> <dd> 
    /// <para>
    /// When you register an instance, if you include the <code>AWS_ALIAS_DNS_NAME</code>
    /// attribute, Cloud Map creates a Route 53 alias record. Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Route 53 automatically sets <code>EvaluateTargetHealth</code> to true for alias records.
    /// When <code>EvaluateTargetHealth</code> is true, the alias record inherits the health
    /// of the referenced Amazon Web Services resource. such as an ELB load balancer. For
    /// more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_AliasTarget.html#Route53-Type-AliasTarget-EvaluateTargetHealth">EvaluateTargetHealth</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you include <code>HealthCheckConfig</code> and then use the service to register
    /// an instance that creates an alias record, Route 53 doesn't create the health check.
    /// </para>
    ///  </li> </ul> </dd> <dt>Charges for health checks</dt> <dd> 
    /// <para>
    /// Health checks are basic Route 53 health checks that monitor an Amazon Web Services
    /// endpoint. For information about pricing for health checks, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class HealthCheckConfig
    {
        private int? _failureThreshold;
        private string _resourcePath;
        private HealthCheckType _type;

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of consecutive health checks that an endpoint must pass or fail for Route 53
        /// to change the current status of the endpoint from unhealthy to healthy or the other
        /// way around. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Route 53 Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int FailureThreshold
        {
            get { return this._failureThreshold.GetValueOrDefault(); }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcePath. 
        /// <para>
        /// The path that you want Route 53 to request when performing health checks. The path
        /// can be any value that your endpoint returns an HTTP status code of a 2xx or 3xx format
        /// for when the endpoint is healthy. An example file is <code>/docs/route53-health-check.html</code>.
        /// Route 53 automatically adds the DNS name for the service. If you don't specify a value
        /// for <code>ResourcePath</code>, the default value is <code>/</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>TCP</code> for <code>Type</code>, you must <i>not</i> specify
        /// a value for <code>ResourcePath</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string ResourcePath
        {
            get { return this._resourcePath; }
            set { this._resourcePath = value; }
        }

        // Check to see if ResourcePath property is set
        internal bool IsSetResourcePath()
        {
            return this._resourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of health check that you want to create, which indicates how Route 53 determines
        /// whether an endpoint is healthy.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't change the value of <code>Type</code> after you create a health check.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can create the following types of health checks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>HTTP</b>: Route 53 tries to establish a TCP connection. If successful, Route 53
        /// submits an HTTP request and waits for an HTTP status code of 200 or greater and less
        /// than 400.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HTTPS</b>: Route 53 tries to establish a TCP connection. If successful, Route 53
        /// submits an HTTPS request and waits for an HTTP status code of 200 or greater and less
        /// than 400.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify HTTPS for the value of <code>Type</code>, the endpoint must support
        /// TLS v1.0 or later.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>TCP</b>: Route 53 tries to establish a TCP connection.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>TCP</code> for <code>Type</code>, don't specify a value for <code>ResourcePath</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Route 53 Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthCheckType Type
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