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
    /// Container for the parameters to the GetBucketNotification operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns the notification configuration of a bucket.
    /// </para>
    ///  
    /// <para>
    /// If notifications are not enabled on the bucket, the action returns an empty <code>NotificationConfiguration</code>
    /// element.
    /// </para>
    ///  
    /// <para>
    /// By default, you must be the bucket owner to read the notification configuration of
    /// a bucket. However, the bucket owner can use a bucket policy to grant permission to
    /// other users to read this configuration with the <code>s3:GetBucketNotification</code>
    /// permission.
    /// </para>
    ///  
    /// <para>
    /// When you use this API operation with an access point, provide the alias of the access
    /// point in place of the bucket name.
    /// </para>
    ///  
    /// <para>
    /// When you use this API operation with an Object Lambda access point, provide the alias
    /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
    /// access point alias in a request is not valid, the error code <code>InvalidAccessPointAliasError</code>
    /// is returned. For more information about <code>InvalidAccessPointAliasError</code>,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
    /// of Error Codes</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about setting and reading the notification configuration on a
    /// bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Setting
    /// Up Notification of Bucket Events</a>. For more information about bucket policies,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies</a>.
    /// </para>
    ///  
    /// <para>
    /// The following action is related to <code>GetBucketNotification</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketNotification.html">PutBucketNotification</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketNotificationRequest : AmazonWebServiceRequest
    {
        private string bucket;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to get the notification configuration.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <code>InvalidAccessPointAliasError</code>
        /// is returned. For more information about <code>InvalidAccessPointAliasError</code>,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucket != null;
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
    
