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
    /// Container for the parameters to the GetBucketOwnershipControls operation.
    /// Retrieves <code>OwnershipControls</code> for an Amazon S3 bucket. To use this operation,
    /// you must have the <code>s3:GetBucketOwnershipControls</code> permission. For more
    /// information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a>. 
    /// 
    ///  
    /// <para>
    /// For information about Amazon S3 Object Ownership, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Using
    /// Object Ownership</a>. 
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>GetBucketOwnershipControls</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutBucketOwnershipControls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBucketOwnershipControls</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketOwnershipControlsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the Amazon S3 bucket whose OwnershipControls you want to retrieve
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
    }
}
