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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-07.normal.json service model.
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
    /// a web server) from which CloudFront gets your files.You must create at least one origin.
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
        /// Gets and sets the property CustomHeaders. A complex type that contains information
        /// about the custom headers associated with this Origin.
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
        /// Gets and sets the property CustomOriginConfig. A complex type that contains information
        /// about a custom origin. If the origin is an Amazon S3 bucket, use the S3OriginConfig
        /// element instead.
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
        /// Gets and sets the property DomainName. Amazon S3 origins: The DNS name of the Amazon
        /// S3 bucket from which you want CloudFront to get objects for this origin, for example,
        /// myawsbucket.s3.amazonaws.com. Custom origins: The DNS domain name for the HTTP server
        /// from which you want CloudFront to get objects for this origin, for example, www.example.com.
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
        /// Gets and sets the property Id. A unique identifier for the origin. The value of Id
        /// must be unique within the distribution. You use the value of Id when you create a
        /// cache behavior. The Id identifies the origin that CloudFront routes a request to when
        /// the request matches the path pattern for that cache behavior.
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
        /// Gets and sets the property OriginPath. An optional element that causes CloudFront
        /// to request your content from a directory in your Amazon S3 bucket or your custom origin.
        /// When you include the OriginPath element, specify the directory name, beginning with
        /// a /. CloudFront appends the directory name to the value of DomainName.
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
        /// Gets and sets the property S3OriginConfig. A complex type that contains information
        /// about the Amazon S3 origin. If the origin is a custom origin, use the CustomOriginConfig
        /// element instead.
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