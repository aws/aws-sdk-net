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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A customer origin.
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
        /// The HTTP port the custom origin listens on.
        /// </para>
        /// </summary>
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
        /// The HTTPS port the custom origin listens on.
        /// </para>
        /// </summary>
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
        /// You can create a custom keep-alive timeout. All timeout units are in seconds. The
        /// default keep-alive timeout is 5 seconds, but you can configure custom timeout lengths
        /// using the CloudFront API. The minimum timeout length is 1 second; the maximum is 60
        /// seconds.
        /// </para>
        ///  
        /// <para>
        /// If you need to increase the maximum time limit, contact the <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Support Center</a>.
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
        /// The origin protocol policy to apply to your origin.
        /// </para>
        /// </summary>
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
        /// You can create a custom origin read timeout. All timeout units are in seconds. The
        /// default origin read timeout is 30 seconds, but you can configure custom timeout lengths
        /// using the CloudFront API. The minimum timeout length is 4 seconds; the maximum is
        /// 60 seconds.
        /// </para>
        ///  
        /// <para>
        /// If you need to increase the maximum time limit, contact the <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Support Center</a>.
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
        /// The SSL/TLS protocols that you want CloudFront to use when communicating with your
        /// origin over HTTPS.
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