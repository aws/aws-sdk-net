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
    /// Container for the parameters to the GetLifecycleConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
    /// key name prefix, one or more object tags, object size, or any combination of these.
    /// Accordingly, this section describes the latest API. The previous version of the API
    /// supported filtering based only on an object key name prefix, which is supported for
    /// backward compatibility. For the related API description, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycle.html">GetBucketLifecycle</a>.
    /// Accordingly, this section describes the latest API. The response describes the new
    /// filter element that you can use to specify a filter to select a subset of objects
    /// to which the rule applies. If you are using a previous version of the lifecycle configuration,
    /// it still works. For the earlier action, 
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns the lifecycle configuration information set on the bucket. For information
    /// about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
    /// Lifecycle Management</a>.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have permission to perform the <c>s3:GetLifecycleConfiguration</c>
    /// action. The bucket owner has this permission, by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetBucketLifecycleConfiguration</c> has the following special error:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Error code: <c>NoSuchLifecycleConfiguration</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The lifecycle configuration does not exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 404 Not Found
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SOAP Fault Code Prefix: Client
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// The following operations are related to <c>GetBucketLifecycleConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycle.html">GetBucketLifecycle</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetLifecycleConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;


        /// <summary>
        /// Gets and sets the BucketName.
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
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
    
