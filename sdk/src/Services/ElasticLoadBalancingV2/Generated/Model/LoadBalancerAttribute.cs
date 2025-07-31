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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a load balancer attribute.
    /// </summary>
    public partial class LoadBalancerAttribute
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        ///  
        /// <para>
        /// The following attributes are supported by all load balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>deletion_protection.enabled</c> - Indicates whether deletion protection is enabled.
        /// The value is <c>true</c> or <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>load_balancing.cross_zone.enabled</c> - Indicates whether cross-zone load balancing
        /// is enabled. The possible values are <c>true</c> and <c>false</c>. The default for
        /// Network Load Balancers and Gateway Load Balancers is <c>false</c>. The default for
        /// Application Load Balancers is <c>true</c>, and can't be changed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by both Application Load Balancers and Network
        /// Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>access_logs.s3.enabled</c> - Indicates whether access logs are enabled. The value
        /// is <c>true</c> or <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>access_logs.s3.bucket</c> - The name of the S3 bucket for the access logs. This
        /// attribute is required if access logs are enabled. The bucket must exist in the same
        /// region as the load balancer and have a bucket policy that grants Elastic Load Balancing
        /// permissions to write to the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>access_logs.s3.prefix</c> - The prefix for the location in the S3 bucket for the
        /// access logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6.deny_all_igw_traffic</c> - Blocks internet gateway (IGW) access to the load
        /// balancer. It is set to <c>false</c> for internet-facing load balancers and <c>true</c>
        /// for internal load balancers, preventing unintended access to your internal load balancer
        /// through an internet gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zonal_shift.config.enabled</c> - Indicates whether zonal shift is enabled. The
        /// possible values are <c>true</c> and <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Application Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>idle_timeout.timeout_seconds</c> - The idle timeout value, in seconds. The valid
        /// range is 1-4000 seconds. The default is 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client_keep_alive.seconds</c> - The client keep alive value, in seconds. The valid
        /// range is 60-604800 seconds. The default is 3600 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection_logs.s3.enabled</c> - Indicates whether connection logs are enabled.
        /// The value is <c>true</c> or <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection_logs.s3.bucket</c> - The name of the S3 bucket for the connection logs.
        /// This attribute is required if connection logs are enabled. The bucket must exist in
        /// the same region as the load balancer and have a bucket policy that grants Elastic
        /// Load Balancing permissions to write to the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection_logs.s3.prefix</c> - The prefix for the location in the S3 bucket for
        /// the connection logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.desync_mitigation_mode</c> - Determines how the load balancer handles
        /// requests that might pose a security risk to your application. The possible values
        /// are <c>monitor</c>, <c>defensive</c>, and <c>strictest</c>. The default is <c>defensive</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.drop_invalid_header_fields.enabled</c> - Indicates whether HTTP headers
        /// with invalid header fields are removed by the load balancer (<c>true</c>) or routed
        /// to targets (<c>false</c>). The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.preserve_host_header.enabled</c> - Indicates whether the Application
        /// Load Balancer should preserve the <c>Host</c> header in the HTTP request and send
        /// it to the target without any change. The possible values are <c>true</c> and <c>false</c>.
        /// The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.x_amzn_tls_version_and_cipher_suite.enabled</c> - Indicates whether
        /// the two headers (<c>x-amzn-tls-version</c> and <c>x-amzn-tls-cipher-suite</c>), which
        /// contain information about the negotiated TLS version and cipher suite, are added to
        /// the client request before sending it to the target. The <c>x-amzn-tls-version</c>
        /// header has information about the TLS protocol version negotiated with the client,
        /// and the <c>x-amzn-tls-cipher-suite</c> header has information about the cipher suite
        /// negotiated with the client. Both headers are in OpenSSL format. The possible values
        /// for the attribute are <c>true</c> and <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.xff_client_port.enabled</c> - Indicates whether the <c>X-Forwarded-For</c>
        /// header should preserve the source port that the client used to connect to the load
        /// balancer. The possible values are <c>true</c> and <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.xff_header_processing.mode</c> - Enables you to modify, preserve,
        /// or remove the <c>X-Forwarded-For</c> header in the HTTP request before the Application
        /// Load Balancer sends the request to the target. The possible values are <c>append</c>,
        /// <c>preserve</c>, and <c>remove</c>. The default is <c>append</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>append</c>, the Application Load Balancer adds the client IP address
        /// (of the last hop) to the <c>X-Forwarded-For</c> header in the HTTP request before
        /// it sends it to targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>preserve</c> the Application Load Balancer preserves the <c>X-Forwarded-For</c>
        /// header in the HTTP request, and sends it to targets without any change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>remove</c>, the Application Load Balancer removes the <c>X-Forwarded-For</c>
        /// header in the HTTP request before it sends it to targets.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>routing.http2.enabled</c> - Indicates whether HTTP/2 is enabled. The possible
        /// values are <c>true</c> and <c>false</c>. The default is <c>true</c>. Elastic Load
        /// Balancing requires that message header names contain only alphanumeric characters
        /// and hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>waf.fail_open.enabled</c> - Indicates whether to allow a WAF-enabled load balancer
        /// to route requests to targets if it is unable to forward the request to Amazon Web
        /// Services WAF. The possible values are <c>true</c> and <c>false</c>. The default is
        /// <c>false</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Network Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>dns_record.client_routing_policy</c> - Indicates how traffic is distributed among
        /// the load balancer Availability Zones. The possible values are <c>availability_zone_affinity</c>
        /// with 100 percent zonal affinity, <c>partial_availability_zone_affinity</c> with 85
        /// percent zonal affinity, and <c>any_availability_zone</c> with 0 percent zonal affinity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary_ips.auto_assigned.per_subnet</c> - The number of secondary IP addresses
        /// to configure for your load balancer nodes. Use to address port allocation errors if
        /// you can't add targets. The valid range is 0 to 7. The default is 0. After you set
        /// this value, you can't decrease it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}