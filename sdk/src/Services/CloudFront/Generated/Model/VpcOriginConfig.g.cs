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
    /// An Amazon CloudFront VPC origin configuration.
    /// </summary>
    public partial class VpcOriginConfig
    {
        /// <summary>
        /// Gets and sets the property OriginHttpVersion. 
        /// <para>
        /// The HTTP version that CloudFront uses for requests to the VPC origin for this distribution.
        /// Valid values are <c>http1.1</c> and <c>http2</c>. If you don't specify a value, CloudFront
        /// uses HTTP/1.1.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>http2</c>, CloudFront offers HTTP/2 to the origin by using ALPN.
        /// If the origin doesn't negotiate HTTP/2, CloudFront uses HTTP/1.1. CloudFront uses
        /// HTTP/2 only over Transport Layer Security (TLS) 1.2 or later. Otherwise, it uses HTTP/1.1.
        /// </para>
        ///  
        /// <para>
        /// If you use a version of an AWS SDK or the AWS CLI that doesn't support this field,
        /// an update that sends back a configuration you got from CloudFront removes the value,
        /// and CloudFront then uses HTTP/1.1.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginHttpVersion">Origin
        /// HTTP version</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public OriginHttpVersion OriginHttpVersion { get; set; }

        /// <summary>
        /// Checks to see if the OriginHttpVersion property is set.
        /// </summary>
        internal bool IsSetOriginHttpVersion() => this.OriginHttpVersion != null;

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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The account ID of the Amazon Web Services account that owns the VPC origin.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property VpcOriginId. 
        /// <para>
        /// The VPC origin ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcOriginId { get; set; }

        /// <summary>
        /// Checks to see if the VpcOriginId property is set.
        /// </summary>
        internal bool IsSetVpcOriginId() => this.VpcOriginId != null;
    }
}
