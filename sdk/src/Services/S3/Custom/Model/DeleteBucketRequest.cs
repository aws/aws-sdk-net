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
    /// Container for the parameters to the DeleteBucket operation.
    /// Deletes the S3 bucket. All objects (including all object versions and delete markers)
    /// in the bucket must be deleted before the bucket itself can be deleted.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - If multipart uploads in a directory bucket are in progress,
    /// you can't delete the bucket until all the in-progress multipart uploads are aborted
    /// or completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <c>https://s3express-control.<i>region_code</i>.amazonaws.com/<i>bucket-name</i>
    /// </c>. Virtual-hosted-style requests aren't supported. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the <c>s3:DeleteBucket</c>
    /// permission on the specified bucket in a policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have the <c>s3express:DeleteBucket</c>
    /// permission in an IAM identity-based policy instead of a bucket policy. Cross-account
    /// access to this API operation isn't supported. This operation can only be performed
    /// by the Amazon Web Services account that owns the resource. For more information about
    /// directory bucket policies and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>DeleteBucket</c>:
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
    public partial class DeleteBucketRequest : AmazonWebServiceRequest
    {
        private S3Region bucketRegion;
        private bool useClientRegion = true;

        /// <summary>
        /// The region locality for the bucket.
        /// </summary>
        /// <remarks>
        /// When set, this will determine the region the bucket exists in.
        /// Refer <see cref="T:Amazon.S3.S3Region"/>
        /// for a list of possible values.
        /// </remarks>
        public S3Region BucketRegion
        {
            get { return this.bucketRegion; }
            set { this.bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this.bucketRegion != null;
        }

        /// <summary>
        /// If set to true the bucket will be deleted in the same region as the configuration of the AmazonS3 client.
        /// DeleteBucketRequest.BucketRegion takes precedence over this property if both are set.
        /// Default: true.
        /// </summary>
        public bool UseClientRegion
        {
            get { return this.useClientRegion; }
            set
            {
                this.useClientRegion = value;
            }
        }
    }
}
    
