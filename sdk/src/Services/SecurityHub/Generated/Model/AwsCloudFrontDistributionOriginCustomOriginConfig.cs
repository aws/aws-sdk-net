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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A custom origin. A custom origin is any origin that is not an Amazon S3 bucket, with
    /// one exception. An Amazon S3 bucket that is <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">configured
    /// with static website hosting</a> is a custom origin.
    /// </summary>
    public partial class AwsCloudFrontDistributionOriginCustomOriginConfig
    {
        private int? _httpPort;
        private int? _httpsPort;
        private int? _originKeepaliveTimeout;
        private string _originProtocolPolicy;
        private int? _originReadTimeout;
        private AwsCloudFrontDistributionOriginSslProtocols _originSslProtocols;

        /// <summary>
        /// Gets and sets the property HttpPort. 
        /// <para>
        /// The HTTP port that CloudFront uses to connect to the origin. 
        /// </para>
        /// </summary>
        public int? HttpPort
        {
            get { return this._httpPort; }
            set { this._httpPort = value; }
        }

        // Check to see if HttpPort property is set
        internal bool IsSetHttpPort()
        {
            return this._httpPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpsPort. 
        /// <para>
        /// The HTTPS port that CloudFront uses to connect to the origin. 
        /// </para>
        /// </summary>
        public int? HttpsPort
        {
            get { return this._httpsPort; }
            set { this._httpsPort = value; }
        }

        // Check to see if HttpsPort property is set
        internal bool IsSetHttpsPort()
        {
            return this._httpsPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginKeepaliveTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront persists its connection to the origin.
        /// 
        /// </para>
        /// </summary>
        public int? OriginKeepaliveTimeout
        {
            get { return this._originKeepaliveTimeout; }
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
        /// 
        /// </para>
        /// </summary>
        public string OriginProtocolPolicy
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
        /// Specifies how long, in seconds, CloudFront waits for a response from the origin. 
        /// </para>
        /// </summary>
        public int? OriginReadTimeout
        {
            get { return this._originReadTimeout; }
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
        /// origin over HTTPS. 
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginSslProtocols OriginSslProtocols
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