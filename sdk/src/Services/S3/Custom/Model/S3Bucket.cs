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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// In terms of implementation, a Bucket is a resource. An Amazon S3 bucket name is globally
    /// unique, and the namespace is shared by all Amazon Web Services accounts.
    /// </summary>
    public class S3Bucket
    {
        private string _bucketArn;
        private DateTime? creationDate;
        private string bucketName;
        private string _bucketRegion;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket. ARNs uniquely identify Amazon Web
        /// Services resources across all of Amazon Web Services.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for S3 directory buckets. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Using
        /// tags with directory buckets</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// <para>Date the bucket was created. This date can change when making changes to your bucket, such as editing its bucket policy.</para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;
        }

        /// <summary>
        /// The name of the bucket.
        ///  
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// <para> <c>BucketRegion</c> indicates the Amazon Web Services region where the bucket is located. If the request contains at least one valid parameter, it is included in the response.</para>
        /// </summary>
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }
    }
}
