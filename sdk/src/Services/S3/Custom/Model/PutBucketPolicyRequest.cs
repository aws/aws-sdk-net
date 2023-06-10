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
    /// Container for the parameters to the PutBucketPolicy operation.
    /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
    /// other than the root user of the Amazon Web Services account that owns the bucket,
    /// the calling identity must have the <code>PutBucketPolicy</code> permissions on the
    /// specified bucket and belong to the bucket owner's account in order to use this operation.
    /// 
    ///  
    /// <para>
    /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
    /// Access Denied</code> error. If you have the correct permissions, but you're not using
    /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
    /// Method Not Allowed</code> error.
    /// </para>
    ///  <important> 
    /// <para>
    /// To ensure that bucket owners don't inadvertently lock themselves out of their own
    /// buckets, the root principal in a bucket owner's Amazon Web Services account can perform
    /// the <code>GetBucketPolicy</code>, <code>PutBucketPolicy</code>, and <code>DeleteBucketPolicy</code>
    /// API actions, even if their bucket policy explicitly denies the root principal's access.
    /// Bucket owner root principals can only be blocked from performing these API actions
    /// by VPC endpoint policies and Amazon Web Services Organizations policies.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/example-bucket-policies.html">Bucket
    /// policy examples</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketPolicy</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketPolicyRequest : AmazonWebServiceRequest
    {
        private ChecksumAlgorithm _checksumAlgorithm;
        private bool? confirmRemoveSelfBucketAccess;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket.
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
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
        /// The MD5 hash of the request body.
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// </summary>
        public string ContentMD5 { get; set; }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.ContentMD5 != null;
        }

        /// <summary>
        /// The bucket policy as a JSON document.
        /// </summary>
        public string Policy { get; set; }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.Policy != null;
        }
        /// <summary>
        /// Set this parameter to true to confirm that you want to remove your 
        /// permissions to change this bucket policy in the future.
        /// </summary>
        public bool ConfirmRemoveSelfBucketAccess
        {
            get
            {
                return this.confirmRemoveSelfBucketAccess.GetValueOrDefault();
            }
            set
            {
                this.confirmRemoveSelfBucketAccess = value;
            }
        }
        // Check to see if ConfirmRemoveSelfBucketAccess property is set
        internal bool IsSetConfirmRemoveSelfBucketAccess()
        {
            return this.confirmRemoveSelfBucketAccess.HasValue;
        }

        /// <summary>
        /// Overriden to turn off sending SHA256 header.
        /// </summary>
        protected override bool IncludeSHA256Header
        {
            get
            {
                return false;
            }
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
    
