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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A custom origin. A custom origin is any origin that is <i>not</i> an Amazon S3 bucket,
    /// with one exception. An Amazon S3 bucket that is <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">configured
    /// with static website hosting</a> <i>is</i> a custom origin.
    /// </summary>
    public partial class CustomOriginConfig
    {
        /// <summary>
        /// Gets and sets the property HTTPPort. 
        /// <para>
        /// The HTTP port that CloudFront uses to connect to the origin. Specify the HTTP port
        /// that the origin listens on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HTTPPort { get; set; }

        /// <summary>
        /// Checks to see if the HTTPPort property is set.
        /// </summary>
        internal bool IsSetHTTPPort() => this.HTTPPort.HasValue;

        /// <summary>
        /// Gets and sets the property HTTPSPort. 
        /// <para>
        /// The HTTPS port that CloudFront uses to connect to the origin. Specify the HTTPS port
        /// that the origin listens on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HTTPSPort { get; set; }

        /// <summary>
        /// Checks to see if the HTTPSPort property is set.
        /// </summary>
        internal bool IsSetHTTPSPort() => this.HTTPSPort.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// Specifies which IP protocol CloudFront uses when connecting to your origin. If your
        /// origin uses both IPv4 and IPv6 protocols, you can choose <c>dualstack</c> to help
        /// optimize reliability.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property OriginKeepaliveTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront persists its connection to the origin.
        /// The minimum timeout is 1 second, the maximum is 120 seconds, and the default (if you
        /// don't specify otherwise) is 5 seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginKeepaliveTimeout">Keep-alive
        /// timeout (custom origins only)</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int? OriginKeepaliveTimeout { get; set; }

        /// <summary>
        /// Checks to see if the OriginKeepaliveTimeout property is set.
        /// </summary>
        internal bool IsSetOriginKeepaliveTimeout() => this.OriginKeepaliveTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property OriginMtlsConfig. 
        /// <para>
        /// Configures mutual TLS authentication between CloudFront and your origin server.
        /// </para>
        /// </summary>
        public OriginMtlsConfig OriginMtlsConfig { get; set; }

        /// <summary>
        /// Checks to see if the OriginMtlsConfig property is set.
        /// </summary>
        internal bool IsSetOriginMtlsConfig() => this.OriginMtlsConfig != null;

        /// <summary>
        /// Gets and sets the property OriginProtocolPolicy. 
        /// <para>
        /// Specifies the protocol (HTTP or HTTPS) that CloudFront uses to connect to the origin.
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>http-only</c> – CloudFront always uses HTTP to connect to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>match-viewer</c> – CloudFront connects to the origin using the same protocol that
        /// the viewer used to connect to CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>https-only</c> – CloudFront always uses HTTPS to connect to the origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OriginProtocolPolicy OriginProtocolPolicy { get; set; }

        /// <summary>
        /// Checks to see if the OriginProtocolPolicy property is set.
        /// </summary>
        internal bool IsSetOriginProtocolPolicy() => this.OriginProtocolPolicy != null;

        /// <summary>
        /// Gets and sets the property OriginReadTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront waits for a response from the origin. This
        /// is also known as the <i>origin response timeout</i>. The minimum timeout is 1 second,
        /// the maximum is 120 seconds, and the default (if you don't specify otherwise) is 30
        /// seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginResponseTimeout">Response
        /// timeout</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int? OriginReadTimeout { get; set; }

        /// <summary>
        /// Checks to see if the OriginReadTimeout property is set.
        /// </summary>
        internal bool IsSetOriginReadTimeout() => this.OriginReadTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property OriginSslProtocols. 
        /// <para>
        /// Specifies the minimum SSL/TLS protocol that CloudFront uses when connecting to your
        /// origin over HTTPS. Valid values include <c>SSLv3</c>, <c>TLSv1</c>, <c>TLSv1.1</c>,
        /// and <c>TLSv1.2</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginSSLProtocols">Minimum
        /// Origin SSL Protocol</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public OriginSslProtocols OriginSslProtocols { get; set; }

        /// <summary>
        /// Checks to see if the OriginSslProtocols property is set.
        /// </summary>
        internal bool IsSetOriginSslProtocols() => this.OriginSslProtocols != null;
    }
}
