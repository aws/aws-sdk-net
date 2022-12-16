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
    /// An origin.
    /// 
    ///  
    /// <para>
    /// An origin is the location where content is stored, and from which CloudFront gets
    /// content to serve to viewers. To specify an origin:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <code>S3OriginConfig</code> to specify an Amazon S3 bucket that is not configured
    /// with static website hosting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>CustomOriginConfig</code> to specify all other kinds of origins, including:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon S3 bucket that is configured with static website hosting
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Elastic Load Balancing load balancer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An AWS Elemental MediaPackage endpoint
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An AWS Elemental MediaStore container
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any other HTTP server, running on an Amazon EC2 instance or any other kind of host
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For the current maximum number of origins that you can specify per distribution, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html#limits-web-distributions">General
    /// Quotas on Web Distributions</a> in the <i>Amazon CloudFront Developer Guide</i> (quotas
    /// were formerly referred to as limits).
    /// </para>
    /// </summary>
    public partial class Origin
    {
        private int? _connectionAttempts;
        private int? _connectionTimeout;
        private CustomHeaders _customHeaders;
        private CustomOriginConfig _customOriginConfig;
        private string _domainName;
        private string _id;
        private string _originAccessControlId;
        private string _originPath;
        private OriginShield _originShield;
        private S3OriginConfig _s3OriginConfig;

        /// <summary>
        /// Gets and sets the property ConnectionAttempts. 
        /// <para>
        /// The number of times that CloudFront attempts to connect to the origin. The minimum
        /// number is 1, the maximum is 3, and the default (if you don't specify otherwise) is
        /// 3.
        /// </para>
        ///  
        /// <para>
        /// For a custom origin (including an Amazon S3 bucket that's configured with static website
        /// hosting), this value also specifies the number of times that CloudFront attempts to
        /// get a response from the origin, in the case of an <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesOriginResponseTimeout">Origin
        /// Response Timeout</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#origin-connection-attempts">Origin
        /// Connection Attempts</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int ConnectionAttempts
        {
            get { return this._connectionAttempts.GetValueOrDefault(); }
            set { this._connectionAttempts = value; }
        }

        // Check to see if ConnectionAttempts property is set
        internal bool IsSetConnectionAttempts()
        {
            return this._connectionAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionTimeout. 
        /// <para>
        /// The number of seconds that CloudFront waits when trying to establish a connection
        /// to the origin. The minimum timeout is 1 second, the maximum is 10 seconds, and the
        /// default (if you don't specify otherwise) is 10 seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#origin-connection-timeout">Origin
        /// Connection Timeout</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int ConnectionTimeout
        {
            get { return this._connectionTimeout.GetValueOrDefault(); }
            set { this._connectionTimeout = value; }
        }

        // Check to see if ConnectionTimeout property is set
        internal bool IsSetConnectionTimeout()
        {
            return this._connectionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// A list of HTTP header names and values that CloudFront adds to the requests that it
        /// sends to the origin.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/add-origin-custom-headers.html">Adding
        /// Custom Headers to Origin Requests</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public CustomHeaders CustomHeaders
        {
            get { return this._customHeaders; }
            set { this._customHeaders = value; }
        }

        // Check to see if CustomHeaders property is set
        internal bool IsSetCustomHeaders()
        {
            return this._customHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property CustomOriginConfig. 
        /// <para>
        /// Use this type to specify an origin that is not an Amazon S3 bucket, with one exception.
        /// If the Amazon S3 bucket is configured with static website hosting, use this type.
        /// If the Amazon S3 bucket is not configured with static website hosting, use the <code>S3OriginConfig</code>
        /// type instead.
        /// </para>
        /// </summary>
        public CustomOriginConfig CustomOriginConfig
        {
            get { return this._customOriginConfig; }
            set { this._customOriginConfig = value; }
        }

        // Check to see if CustomOriginConfig property is set
        internal bool IsSetCustomOriginConfig()
        {
            return this._customOriginConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for the origin.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesDomainName">Origin
        /// Domain Name</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the origin. This value must be unique within the distribution.
        /// </para>
        ///  
        /// <para>
        /// Use this value to specify the <code>TargetOriginId</code> in a <code>CacheBehavior</code>
        /// or <code>DefaultCacheBehavior</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OriginAccessControlId. 
        /// <para>
        /// The unique identifier of an origin access control for this origin.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-s3.html">Restricting
        /// access to an Amazon S3 origin</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string OriginAccessControlId
        {
            get { return this._originAccessControlId; }
            set { this._originAccessControlId = value; }
        }

        // Check to see if OriginAccessControlId property is set
        internal bool IsSetOriginAccessControlId()
        {
            return this._originAccessControlId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginPath. 
        /// <para>
        /// An optional path that CloudFront appends to the origin domain name when CloudFront
        /// requests content from the origin.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesOriginPath">Origin
        /// Path</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string OriginPath
        {
            get { return this._originPath; }
            set { this._originPath = value; }
        }

        // Check to see if OriginPath property is set
        internal bool IsSetOriginPath()
        {
            return this._originPath != null;
        }

        /// <summary>
        /// Gets and sets the property OriginShield. 
        /// <para>
        /// CloudFront Origin Shield. Using Origin Shield can help reduce the load on your origin.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/origin-shield.html">Using
        /// Origin Shield</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public OriginShield OriginShield
        {
            get { return this._originShield; }
            set { this._originShield = value; }
        }

        // Check to see if OriginShield property is set
        internal bool IsSetOriginShield()
        {
            return this._originShield != null;
        }

        /// <summary>
        /// Gets and sets the property S3OriginConfig. 
        /// <para>
        /// Use this type to specify an origin that is an Amazon S3 bucket that is not configured
        /// with static website hosting. To specify any other type of origin, including an Amazon
        /// S3 bucket that is configured with static website hosting, use the <code>CustomOriginConfig</code>
        /// type instead.
        /// </para>
        /// </summary>
        public S3OriginConfig S3OriginConfig
        {
            get { return this._s3OriginConfig; }
            set { this._s3OriginConfig = value; }
        }

        // Check to see if S3OriginConfig property is set
        internal bool IsSetS3OriginConfig()
        {
            return this._s3OriginConfig != null;
        }

    }
}