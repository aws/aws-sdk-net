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
    /// Container for the parameters to the DeleteBucketReplication operation.
    /// Deletes the replication configuration from the bucket.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:PutReplicationConfiguration</code>
    /// action. The bucket owner has these permissions by default and can grant it to others.
    /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// It can take a while for the deletion of a replication configuration to fully propagate.
    /// </para>
    ///  </note> 
    /// <para>
    ///  For information about replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
    /// in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>DeleteBucketReplication</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketReplication.html">PutBucketReplication</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketReplication.html">GetBucketReplication</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketReplicationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName.
        /// <para>Deletes the replication subresource associated with the specified bucket.</para> 
        /// <note> <para>There is usually some time lag before
        /// replication configuration deletion is fully propagated to all the
        /// Amazon S3 systems.</para> </note> 
        /// <para> For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/crr.html">
        /// Cross-Region Replication (CRR)</a> in the Amazon S3 Developer
        /// Guide. </para>
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
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
