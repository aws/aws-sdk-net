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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A complex type that describes the Amazon S3 bucket, HTTP server (for example, a web
    /// server), or other server from which CloudFront gets your files.
    /// </summary>
    public partial class AwsCloudFrontDistributionOriginItem
    {
        /// <summary>
        /// Gets and sets the property CustomOriginConfig. 
        /// <para>
        /// An origin that is not an Amazon S3 bucket, with one exception. If the Amazon S3 bucket
        /// is configured with static website hosting, use this attribute. If the Amazon S3 bucket
        /// is not configured with static website hosting, use the <c>S3OriginConfig</c> type
        /// instead. 
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginCustomOriginConfig CustomOriginConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomOriginConfig property is set.
        /// </summary>
        internal bool IsSetCustomOriginConfig() => this.CustomOriginConfig != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Amazon S3 origins: The DNS name of the S3 bucket from which you want CloudFront to
        /// get objects for this origin.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the origin or origin group.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OriginPath. 
        /// <para>
        /// An optional element that causes CloudFront to request your content from a directory
        /// in your Amazon S3 bucket or your custom origin.
        /// </para>
        /// </summary>
        public string OriginPath { get; set; }

        /// <summary>
        /// Checks to see if the OriginPath property is set.
        /// </summary>
        internal bool IsSetOriginPath() => this.OriginPath != null;

        /// <summary>
        /// Gets and sets the property S3OriginConfig. 
        /// <para>
        /// An origin that is an S3 bucket that is not configured with static website hosting.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginS3OriginConfig S3OriginConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3OriginConfig property is set.
        /// </summary>
        internal bool IsSetS3OriginConfig() => this.S3OriginConfig != null;
    }
}
