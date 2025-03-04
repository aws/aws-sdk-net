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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An Amazon CloudFront VPC origin endpoint configuration.
    /// </summary>
    public partial class VpcOriginEndpointConfig
    {
        private string _arn;
        private int? _httpPort;
        private int? _httpsPort;
        private string _name;
        private OriginProtocolPolicy _originProtocolPolicy;
        private OriginSslProtocols _originSslProtocols;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the CloudFront VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property HTTPPort. 
        /// <para>
        /// The HTTP port for the CloudFront VPC origin endpoint configuration. The default value
        /// is <c>80</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HTTPPort
        {
            get { return this._httpPort; }
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
        /// The HTTPS port of the CloudFront VPC origin endpoint configuration. The default value
        /// is <c>443</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HTTPSPort
        {
            get { return this._httpsPort; }
            set { this._httpsPort = value; }
        }

        // Check to see if HTTPSPort property is set
        internal bool IsSetHTTPSPort()
        {
            return this._httpsPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the CloudFront VPC origin endpoint configuration.
        /// </para>
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
        /// Gets and sets the property OriginProtocolPolicy. 
        /// <para>
        /// The origin protocol policy for the CloudFront VPC origin endpoint configuration.
        /// </para>
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
        /// Gets and sets the property OriginSslProtocols.
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