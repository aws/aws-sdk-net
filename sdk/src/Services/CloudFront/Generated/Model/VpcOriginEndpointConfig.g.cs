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
    /// An Amazon CloudFront VPC origin endpoint configuration.
    /// </summary>
    public partial class VpcOriginEndpointConfig
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the CloudFront VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property HTTPPort. 
        /// <para>
        /// The HTTP port for the CloudFront VPC origin endpoint configuration. The default value
        /// is <c>80</c>.
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
        /// The HTTPS port of the CloudFront VPC origin endpoint configuration. The default value
        /// is <c>443</c>.
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
        /// The IP address type of the CloudFront VPC origin endpoint configuration. Valid values
        /// are <c>ipv4</c> and <c>dualstack</c>. IPv6-only is not supported for VPC origins.
        /// </para>
        /// </summary>
        public VpcIpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the CloudFront VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OriginProtocolPolicy. 
        /// <para>
        /// The origin protocol policy for the CloudFront VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OriginProtocolPolicy OriginProtocolPolicy { get; set; }

        /// <summary>
        /// Checks to see if the OriginProtocolPolicy property is set.
        /// </summary>
        internal bool IsSetOriginProtocolPolicy() => this.OriginProtocolPolicy != null;

        /// <summary>
        /// Gets and sets the property OriginSslProtocols.
        /// </summary>
        public OriginSslProtocols OriginSslProtocols { get; set; }

        /// <summary>
        /// Checks to see if the OriginSslProtocols property is set.
        /// </summary>
        internal bool IsSetOriginSslProtocols() => this.OriginSslProtocols != null;
    }
}
