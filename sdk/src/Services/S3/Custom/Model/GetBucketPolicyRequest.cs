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
    /// Container for the parameters to the GetBucketPolicy operation.
    /// Returns the policy of a specified bucket. If you are using an identity other than
    /// the root user of the Amazon Web Services account that owns the bucket, the calling
    /// identity must have the <code>GetBucketPolicy</code> permissions on the specified bucket
    /// and belong to the bucket owner's account in order to use this operation.
    /// 
    ///  
    /// <para>
    /// If you don't have <code>GetBucketPolicy</code> permissions, Amazon S3 returns a <code>403
    /// Access Denied</code> error. If you have the correct permissions, but you're not using
    /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
    /// Method Not Allowed</code> error.
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
    /// Bucket Policies and User Policies</a>.
    /// </para>
    ///  
    /// <para>
    /// The following action is related to <code>GetBucketPolicy</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketPolicyRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        public string BucketName { get; set; }
        private string expectedBucketOwner;

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
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
    
