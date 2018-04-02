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
    /// A complex type that describes the Amazon S3 bucket or the HTTP server (for example,
    /// a web server) from which CloudFront gets your files. You must create at least one
    /// origin.
    /// 
    ///  
    /// <para>
    /// For the current limit on the number of origins that you can create for a distribution,
    /// see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_cloudfront">Amazon
    /// CloudFront Limits</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial class Origin
    {
        private CustomHeaders _customHeaders;
        private CustomOriginConfig _customOriginConfig;
        private string _domainName;
        private string _id;
        private string _originPath;
        private S3OriginConfig _s3OriginConfig;

        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// A complex type that contains names and values for the custom headers that you want.
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
        /// A complex type that contains information about a custom origin. If the origin is an
        /// Amazon S3 bucket, use the <code>S3OriginConfig</code> element instead.
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
        ///  <b>Amazon S3 origins</b>: The DNS name of the Amazon S3 bucket from which you want
        /// CloudFront to get objects for this origin, for example, <code>myawsbucket.s3.amazonaws.com</code>.
        /// </para>
        ///  
        /// <para>
        /// Constraints for Amazon S3 origins: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you configured Amazon S3 Transfer Acceleration for your bucket, don't specify the
        /// <code>s3-accelerate</code> endpoint for <code>DomainName</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket name must be between 3 and 63 characters long (inclusive).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket name must contain only lowercase characters, numbers, periods, underscores,
        /// and dashes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket name must not contain adjacent periods.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Custom Origins</b>: The DNS domain name for the HTTP server from which you want
        /// CloudFront to get objects for this origin, for example, <code>www.example.com</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints for custom origins:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DomainName</code> must be a valid DNS name that contains only a-z, A-Z, 0-9,
        /// dot (.), hyphen (-), or underscore (_) characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name cannot exceed 128 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// A unique identifier for the origin. The value of <code>Id</code> must be unique within
        /// the distribution.
        /// </para>
        ///  
        /// <para>
        /// When you specify the value of <code>TargetOriginId</code> for the default cache behavior
        /// or for another cache behavior, you indicate the origin to which you want the cache
        /// behavior to route requests by specifying the value of the <code>Id</code> element
        /// for that origin. When a request matches the path pattern for that cache behavior,
        /// CloudFront routes the request to the specified origin. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesCacheBehavior">Cache
        /// Behavior Settings</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OriginPath. 
        /// <para>
        /// An optional element that causes CloudFront to request your content from a directory
        /// in your Amazon S3 bucket or your custom origin. When you include the <code>OriginPath</code>
        /// element, specify the directory name, beginning with a <code>/</code>. CloudFront appends
        /// the directory name to the value of <code>DomainName</code>, for example, <code>example.com/production</code>.
        /// Do not include a <code>/</code> at the end of the directory name.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you've specified the following values for your distribution:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DomainName</code>: An Amazon S3 bucket named <code>myawsbucket</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OriginPath</code>: <code>/production</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CNAME</code>: <code>example.com</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When a user enters <code>example.com/index.html</code> in a browser, CloudFront sends
        /// a request to Amazon S3 for <code>myawsbucket/production/index.html</code>.
        /// </para>
        ///  
        /// <para>
        /// When a user enters <code>example.com/acme/index.html</code> in a browser, CloudFront
        /// sends a request to Amazon S3 for <code>myawsbucket/production/acme/index.html</code>.
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
        /// Gets and sets the property S3OriginConfig. 
        /// <para>
        /// A complex type that contains information about the Amazon S3 origin. If the origin
        /// is a custom origin, use the <code>CustomOriginConfig</code> element instead.
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