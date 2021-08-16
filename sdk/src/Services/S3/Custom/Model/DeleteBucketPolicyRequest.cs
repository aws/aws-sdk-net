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
    /// Container for the parameters to the DeleteBucketPolicy operation.
    /// This implementation of the DELETE action uses the policy subresource to delete the
    /// policy of a specified bucket. If you are using an identity other than the root user
    /// of the Amazon Web Services account that owns the bucket, the calling identity must
    /// have the <code>DeleteBucketPolicy</code> permissions on the specified bucket and belong
    /// to the bucket owner's account to use this operation. 
    /// 
    ///  
    /// <para>
    /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
    /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
    /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
    /// a <code>405 Method Not Allowed</code> error. 
    /// </para>
    ///  <important> 
    /// <para>
    /// As a security precaution, the root user of the Amazon Web Services account that owns
    /// a bucket can always use this operation, even if the policy explicitly denies the root
    /// user the ability to perform this action.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies and UserPolicies</a>. 
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>DeleteBucketPolicy</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketPolicyRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;

        /// <summary>
        /// The bucket on which the policy is to be deleted.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
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
    
