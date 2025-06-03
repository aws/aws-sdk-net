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
using System.Linq;
using System.Text;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketOwnershipControls operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates or modifies <code>OwnershipControls</code> for an Amazon S3 bucket. To use
    /// this operation, you must have the <code>s3:PutBucketOwnershipControls</code> permission.
    /// For more information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/user-guide/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information about Amazon S3 Object Ownership, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/user-guide/about-object-ownership.html">Using
    /// object ownership</a>. 
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketOwnershipControls</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetBucketOwnershipControls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBucketOwnershipControls</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketOwnershipControlsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;
        private OwnershipControls ownershipControls;
        private ChecksumAlgorithm _checksumAlgorithm;

        /// <summary>
        /// The name of the Amazon S3 bucket whose OwnershipControls you want to set
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }


        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// <p>The account ID of the expected bucket owner. If the bucket is owned by a different account, 
        /// the request will fail with an HTTP <code>403 (Access Denied)</code> error.</p>
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

        /// <summary>
        /// Gets and sets the property OwnershipControls. 
        /// <para>
        /// The <code>OwnershipControls</code> (BucketOwnerEnforced, BucketOwnerPreferred, or
        /// ObjectWriter) that you want to apply to this Amazon S3 bucket.
        /// </para>
        /// </summary>
        public OwnershipControls OwnershipControls
        {
            get { return this.ownershipControls; }
            set { this.ownershipControls = value; }
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum-<i>algorithm</i>
        /// </c> or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the
        /// request with the HTTP status code <c>400 Bad Request</c>.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c> parameter.
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
    }
}
