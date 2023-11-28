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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketAccelerateConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the accelerate configuration of an existing bucket. Amazon S3 Transfer Acceleration
    /// is a bucket-level feature that enables you to perform faster data transfers to Amazon
    /// S3.
    /// </para>
    ///  
    /// <para>
    ///  To use this operation, you must have permission to perform the <code>s3:PutAccelerateConfiguration</code>
    /// action. The bucket owner has this permission by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  The Transfer Acceleration state of a bucket can be set to one of the following two
    /// values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Enabled � Enables accelerated data transfers to the bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Suspended � Disables accelerated data transfers to the bucket.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketAccelerateConfiguration.html">GetBucketAccelerateConfiguration</a>
    /// action returns the transfer acceleration state of a bucket.
    /// </para>
    ///  
    /// <para>
    /// After setting the Transfer Acceleration state of a bucket to Enabled, it might take
    /// up to thirty minutes before the data transfer rates to the bucket increase.
    /// </para>
    ///  
    /// <para>
    ///  The name of the bucket used for Transfer Acceleration must be DNS-compliant and must
    /// not contain periods (".").
    /// </para>
    ///  
    /// <para>
    ///  For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
    /// Acceleration</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketAccelerateConfiguration</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketAccelerateConfiguration.html">GetBucketAccelerateConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketAccelerateConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private AccelerateConfiguration accelerateConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>The name of the bucket for which the accelerate configuration is set.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <code>x-amz-checksum</code>
        /// or <code>x-amz-trailer</code> header sent. Otherwise, Amazon S3 fails the request
        /// with the HTTP status code <code>400 Bad Request</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <code>ChecksumAlgorithm</code>
        /// parameter.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Accelerate configuration for the bucket.
        /// </summary>
        public AccelerateConfiguration AccelerateConfiguration
        {
            get { return this.accelerateConfiguration; }
            set { this.accelerateConfiguration = value; }
        }

        // Check to see if AccelerateConfiguration property is set
        internal bool IsSetAccelerateConfiguration()
        {
            return this.AccelerateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

    }
}
    
