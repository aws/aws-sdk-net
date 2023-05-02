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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketEncryption operation.
    /// This action uses the <code>encryption</code> subresource to configure default encryption
    /// and Amazon S3 Bucket Key for an existing bucket.
    /// 
    ///  
    /// <para>
    /// Default encryption for a bucket can use server-side encryption with Amazon S3-managed
    /// keys (SSE-S3) or customer managed keys (SSE-KMS). If you specify default encryption
    /// using SSE-KMS, you can also configure Amazon S3 Bucket Key. For information about
    /// default encryption, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
    /// S3 default bucket encryption</a> in the <i>Amazon S3 User Guide</i>. For more information
    /// about S3 Bucket Keys, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
    /// S3 Bucket Keys</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// This action requires Amazon Web Services Signature Version 4. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">
    /// Authenticating Requests (Amazon Web Services Signature Version 4)</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:PutEncryptionConfiguration</code>
    /// action. The bucket owner has this permission by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the Amazon S3 User Guide. 
    /// </para>
    ///  <p class="title"> <b>Related Resources</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketEncryption.html">GetBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketEncryption.html">DeleteBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public class PutBucketEncryptionRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string contentMD5;
        private ServerSideEncryptionConfiguration serverSideEncryptionConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Specifies default encryption for a bucket using server-side encryption with different
        /// key options. By default, all buckets have a default encryption configuration that
        /// uses server-side encryption with Amazon S3 managed keys (SSE-S3). You can optionally
        /// configure default encryption for a bucket by using server-side encryption with an
        /// Amazon Web Services KMS key (SSE-KMS) or a customer-provided key (SSE-C). For information
        /// about the bucket default encryption feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
        /// S3 Bucket Default Encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The base64-encoded 128-bit MD5 digest of the server-side encryption configuration.
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this.contentMD5; }
            set { this.contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.contentMD5 != null;
        }

        /// <summary>
        /// Container for server-side encryption configuration rules. Currently S3 supports one rule only.
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this.serverSideEncryptionConfiguration; }
            set { this.serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this.serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
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