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
    /// <i>Public DNS namespaces only.</i> A complex type that contains settings for an optional
    /// health check. If you specify settings for a health check, Amazon Route 53 associates
    /// the health check with all the records that you specify in <code>DnsConfig</code>.
    /// 
    ///  
    /// <para>
    ///  <b>A and AAAA records</b> 
    /// </para>
    ///  
    /// <para>
    /// If <code>DnsConfig</code> includes configurations for both A and AAAA records, Route
    /// 53 creates a health check that uses the IPv4 address to check the health of the resource.
    /// If the endpoint that is specified by the IPv4 address is unhealthy, Route 53 considers
    /// both the A and AAAA records to be unhealthy. 
    /// </para>
    ///  
    /// <para>
    ///  <b>CNAME records</b> 
    /// </para>
    ///  
    /// <para>
    /// You can't specify settings for <code>HealthCheckConfig</code> when the <code>DNSConfig</code>
    /// includes <code>CNAME</code> for the value of <code>Type</code>. If you do, the <code>CreateService</code>
    /// request will fail with an <code>InvalidInput</code> error.
    /// </para>
    ///  
    /// <para>
    ///  <b>Request interval</b> 
    /// </para>
    ///  
    /// <para>
    /// The health check uses 30 seconds as the request interval. This is the number of seconds
    /// between the time that each Route 53 health checker gets a response from your endpoint
    /// and the time that it sends the next health check request. A health checker in each
    /// data center around the world sends your endpoint a health check request every 30 seconds.
    /// On average, your endpoint receives a health check request about every two seconds.
    /// Health checkers in different data centers don't coordinate with one another, so you'll
    /// sometimes see several requests per second followed by a few seconds with no health
    /// checks at all.
    /// </para>
    ///  
    /// <para>
    ///  <b>Health checking regions</b> 
    /// </para>
    ///  
    /// <para>
    /// Health checkers perform checks from all Route 53 health-checking regions. For a list
    /// of the current regions, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_HealthCheckConfig.html#Route53-Type-HealthCheckConfig-Regions">Regions</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Alias records</b> 
    /// </para>
    ///  
    /// <para>
    /// When you register an instance, if you include the <code>AWS_ALIAS_DNS_NAME</code>
    /// attribute, Route 53 creates an alias record. Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Route 53 automatically sets <code>EvaluateTargetHealth</code> to true for alias records.
    /// When <code>EvaluateTargetHealth</code> is true, the alias record inherits the health
    /// of the referenced AWS resource. such as an ELB load balancer. For more information,
    /// see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_AliasTarget.html#Route53-Type-AliasTarget-EvaluateTargetHealth">EvaluateTargetHealth</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you include <code>HealthCheckConfig</code> and then use the service to register
    /// an instance that creates an alias record, Route 53 doesn't create the health check.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about the charges for health checks, see <a href="http://aws.amazon.com/route53/pricing">Route
    /// 53 Pricing</a>.
    /// </para>
    /// </summary>
    public partial class HealthCheckConfig
    {
        private int? _failureThreshold;
        private string _resourcePath;
        private HealthCheckType _type;

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of consecutive health checks that an endpoint must pass or fail for Route
        /// 53 to change the current status of the endpoint from unhealthy to healthy or vice
        /// versa. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Route 53 Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
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
        /// The path that you want Route 53 to request when performing health checks. The path
        /// can be any value for which your endpoint will return an HTTP status code of 2xx or
        /// 3xx when the endpoint is healthy, such as the file <code>/docs/route53-health-check.html</code>.
        /// Route 53 automatically adds the DNS name for the service and a leading forward slash
        /// (<code>/</code>) character. 
        /// </para>
        /// </summary>
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
        /// The type of health check that you want to create, which indicates how Route 53 determines
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
        ///  <b>HTTP</b>: Route 53 tries to establish a TCP connection. If successful, Route 53
        /// submits an HTTP request and waits for an HTTP status code of 200 or greater and less
        /// than 400.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HTTPS</b>: Route 53 tries to establish a TCP connection. If successful, Route
        /// 53 submits an HTTPS request and waits for an HTTP status code of 200 or greater and
        /// less than 400.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify HTTPS for the value of <code>Type</code>, the endpoint must support
        /// TLS v1.0 or later.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>TCP</b>: Route 53 tries to establish a TCP connection.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Route 53 Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
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