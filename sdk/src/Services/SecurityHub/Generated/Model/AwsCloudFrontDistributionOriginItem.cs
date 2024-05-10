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
    /// A complex type that describes the Amazon S3 bucket, HTTP server (for example, a web
    /// server), Elemental MediaStore, or other server from which CloudFront gets your files.
    /// </summary>
    public partial class AwsCloudFrontDistributionOriginItem
    {
        private AwsCloudFrontDistributionOriginCustomOriginConfig _customOriginConfig;
        private string _domainName;
        private string _id;
        private string _originPath;
        private AwsCloudFrontDistributionOriginS3OriginConfig _s3OriginConfig;

        /// <summary>
        /// Gets and sets the property CustomOriginConfig. 
        /// <para>
        /// An origin that is not an Amazon S3 bucket, with one exception. If the Amazon S3 bucket
        /// is configured with static website hosting, use this attribute. If the Amazon S3 bucket
        /// is not configured with static website hosting, use the <c>S3OriginConfig</c> type
        /// instead. 
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginCustomOriginConfig CustomOriginConfig
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
        /// Amazon S3 origins: The DNS name of the S3 bucket from which you want CloudFront to
        /// get objects for this origin.
        /// </para>
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
        /// A unique identifier for the origin or origin group.
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
        /// in your Amazon S3 bucket or your custom origin.
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
        /// An origin that is an S3 bucket that is not configured with static website hosting.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginS3OriginConfig S3OriginConfig
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