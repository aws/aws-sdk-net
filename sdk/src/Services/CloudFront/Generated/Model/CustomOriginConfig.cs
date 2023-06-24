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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A custom origin. A custom origin is any origin that is <i>not</i> an Amazon S3 bucket,
    /// with one exception. An Amazon S3 bucket that is <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">configured
    /// with static website hosting</a> <i>is</i> a custom origin.
    /// </summary>
    public partial class CustomOriginConfig
    {
        private int? _httpPort;
        private int? _httpsPort;
        private int? _originKeepaliveTimeout;
        private OriginProtocolPolicy _originProtocolPolicy;
        private int? _originReadTimeout;
        private OriginSslProtocols _originSslProtocols;

        /// <summary>
        /// Gets and sets the property HTTPPort. 
        /// <para>
        /// The HTTP port that CloudFront uses to connect to the origin. Specify the HTTP port
        /// that the origin listens on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int HTTPPort
        {
            get { return this._httpPort.GetValueOrDefault(); }
            set { this._httpPort = value; }
        }

        // Check to see if HTTPPort property is set
        internal bool IsSetHTTPPort()
        {
            return this._httpPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HTTPSPort. 
        /// <para>
        /// The HTTPS port that CloudFront uses to connect to the origin. Specify the HTTPS port
        /// that the origin listens on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int HTTPSPort
        {
            get { return this._httpsPort.GetValueOrDefault(); }
            set { this._httpsPort = value; }
        }

        // Check to see if HTTPSPort property is set
        internal bool IsSetHTTPSPort()
        {
            return this._httpsPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginKeepaliveTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront persists its connection to the origin.
        /// The minimum timeout is 1 second, the maximum is 60 seconds, and the default (if you
        /// don't specify otherwise) is 5 seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesOriginKeepaliveTimeout">Origin
        /// Keep-alive Timeout</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int OriginKeepaliveTimeout
        {
            get { return this._originKeepaliveTimeout.GetValueOrDefault(); }
            set { this._originKeepaliveTimeout = value; }
        }

        // Check to see if OriginKeepaliveTimeout property is set
        internal bool IsSetOriginKeepaliveTimeout()
        {
            return this._originKeepaliveTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginProtocolPolicy. 
        /// <para>
        /// Specifies the protocol (HTTP or HTTPS) that CloudFront uses to connect to the origin.
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>http-only</code> – CloudFront always uses HTTP to connect to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>match-viewer</code> – CloudFront connects to the origin using the same protocol
        /// that the viewer used to connect to CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>https-only</code> – CloudFront always uses HTTPS to connect to the origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginProtocolPolicy OriginProtocolPolicy
        {
            get { return this._originProtocolPolicy; }
            set { this._originProtocolPolicy = value; }
        }

        // Check to see if OriginProtocolPolicy property is set
        internal bool IsSetOriginProtocolPolicy()
        {
            return this._originProtocolPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property OriginReadTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront waits for a response from the origin. This
        /// is also known as the <i>origin response timeout</i>. The minimum timeout is 1 second,
        /// the maximum is 60 seconds, and the default (if you don't specify otherwise) is 30
        /// seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesOriginResponseTimeout">Origin
        /// Response Timeout</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int OriginReadTimeout
        {
            get { return this._originReadTimeout.GetValueOrDefault(); }
            set { this._originReadTimeout = value; }
        }

        // Check to see if OriginReadTimeout property is set
        internal bool IsSetOriginReadTimeout()
        {
            return this._originReadTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginSslProtocols. 
        /// <para>
        /// Specifies the minimum SSL/TLS protocol that CloudFront uses when connecting to your
        /// origin over HTTPS. Valid values include <code>SSLv3</code>, <code>TLSv1</code>, <code>TLSv1.1</code>,
        /// and <code>TLSv1.2</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesOriginSSLProtocols">Minimum
        /// Origin SSL Protocol</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public OriginSslProtocols OriginSslProtocols
        {
            get { return this._originSslProtocols; }
            set { this._originSslProtocols = value; }
        }

        // Check to see if OriginSslProtocols property is set
        internal bool IsSetOriginSslProtocols()
        {
            return this._originSslProtocols != null;
        }

    }
}