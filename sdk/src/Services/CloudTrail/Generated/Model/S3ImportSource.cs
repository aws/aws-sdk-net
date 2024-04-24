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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The settings for the source S3 bucket.
    /// </summary>
    public partial class S3ImportSource
    {
        private string _s3BucketAccessRoleArn;
        private string _s3BucketRegion;
        private string _s3LocationUri;

        /// <summary>
        /// Gets and sets the property S3BucketAccessRoleArn. 
        /// <para>
        ///  The IAM ARN role used to access the source S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketAccessRoleArn
        {
            get { return this._s3BucketAccessRoleArn; }
            set { this._s3BucketAccessRoleArn = value; }
        }

        // Check to see if S3BucketAccessRoleArn property is set
        internal bool IsSetS3BucketAccessRoleArn()
        {
            return this._s3BucketAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketRegion. 
        /// <para>
        ///  The Region associated with the source S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketRegion
        {
            get { return this._s3BucketRegion; }
            set { this._s3BucketRegion = value; }
        }

        // Check to see if S3BucketRegion property is set
        internal bool IsSetS3BucketRegion()
        {
            return this._s3BucketRegion != null;
        }

        /// <summary>
        /// Gets and sets the property S3LocationUri. 
        /// <para>
        ///  The URI for the source S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3LocationUri
        {
            get { return this._s3LocationUri; }
            set { this._s3LocationUri = value; }
        }

        // Check to see if S3LocationUri property is set
        internal bool IsSetS3LocationUri()
        {
            return this._s3LocationUri != null;
        }

    }
}