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
        ///  <code>deletion_protection.enabled</code> - Indicates whether deletion protection
        /// is enabled. The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>load_balancing.cross_zone.enabled</code> - Indicates whether cross-zone load
        /// balancing is enabled. The possible values are <code>true</code> and <code>false</code>.
        /// The default for Network Load Balancers and Gateway Load Balancers is <code>false</code>.
        /// The default for Application Load Balancers is <code>true</code>, and cannot be changed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by both Application Load Balancers and Network
        /// Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>access_logs.s3.enabled</code> - Indicates whether access logs are enabled.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>access_logs.s3.bucket</code> - The name of the S3 bucket for the access logs.
        /// This attribute is required if access logs are enabled. The bucket must exist in the
        /// same region as the load balancer and have a bucket policy that grants Elastic Load
        /// Balancing permissions to write to the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>access_logs.s3.prefix</code> - The prefix for the location in the S3 bucket
        /// for the access logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6.deny_all_igw_traffic</code> - Blocks internet gateway (IGW) access to
        /// the load balancer. It is set to <code>false</code> for internet-facing load balancers
        /// and <code>true</code> for internal load balancers, preventing unintended access to
        /// your internal load balancer through an internet gateway.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Application Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>idle_timeout.timeout_seconds</code> - The idle timeout value, in seconds. The
        /// valid range is 1-4000 seconds. The default is 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.desync_mitigation_mode</code> - Determines how the load balancer
        /// handles requests that might pose a security risk to your application. The possible
        /// values are <code>monitor</code>, <code>defensive</code>, and <code>strictest</code>.
        /// The default is <code>defensive</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.drop_invalid_header_fields.enabled</code> - Indicates whether
        /// HTTP headers with invalid header fields are removed by the load balancer (<code>true</code>)
        /// or routed to targets (<code>false</code>). The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.preserve_host_header.enabled</code> - Indicates whether the Application
        /// Load Balancer should preserve the <code>Host</code> header in the HTTP request and
        /// send it to the target without any change. The possible values are <code>true</code>
        /// and <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.x_amzn_tls_version_and_cipher_suite.enabled</code> - Indicates
        /// whether the two headers (<code>x-amzn-tls-version</code> and <code>x-amzn-tls-cipher-suite</code>),
        /// which contain information about the negotiated TLS version and cipher suite, are added
        /// to the client request before sending it to the target. The <code>x-amzn-tls-version</code>
        /// header has information about the TLS protocol version negotiated with the client,
        /// and the <code>x-amzn-tls-cipher-suite</code> header has information about the cipher
        /// suite negotiated with the client. Both headers are in OpenSSL format. The possible
        /// values for the attribute are <code>true</code> and <code>false</code>. The default
        /// is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.xff_client_port.enabled</code> - Indicates whether the <code>X-Forwarded-For</code>
        /// header should preserve the source port that the client used to connect to the load
        /// balancer. The possible values are <code>true</code> and <code>false</code>. The default
        /// is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.xff_header_processing.mode</code> - Enables you to modify, preserve,
        /// or remove the <code>X-Forwarded-For</code> header in the HTTP request before the Application
        /// Load Balancer sends the request to the target. The possible values are <code>append</code>,
        /// <code>preserve</code>, and <code>remove</code>. The default is <code>append</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <code>append</code>, the Application Load Balancer adds the client
        /// IP address (of the last hop) to the <code>X-Forwarded-For</code> header in the HTTP
        /// request before it sends it to targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <code>preserve</code> the Application Load Balancer preserves the
        /// <code>X-Forwarded-For</code> header in the HTTP request, and sends it to targets without
        /// any change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <code>remove</code>, the Application Load Balancer removes the <code>X-Forwarded-For</code>
        /// header in the HTTP request before it sends it to targets.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>routing.http2.enabled</code> - Indicates whether HTTP/2 is enabled. The possible
        /// values are <code>true</code> and <code>false</code>. The default is <code>true</code>.
        /// Elastic Load Balancing requires that message header names contain only alphanumeric
        /// characters and hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>waf.fail_open.enabled</code> - Indicates whether to allow a WAF-enabled load
        /// balancer to route requests to targets if it is unable to forward the request to Amazon
        /// Web Services WAF. The possible values are <code>true</code> and <code>false</code>.
        /// The default is <code>false</code>.
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