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

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBucketPolicy operation.
    /// <note> 
    /// <para>
    /// This action deletes an Amazon S3 on Outposts bucket policy. To delete an S3 bucket
    /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// This implementation of the DELETE action uses the policy subresource to delete the
    /// policy of a specified Amazon S3 on Outposts bucket. If you are using an identity other
    /// than the root user of the Amazon Web Services account that owns the bucket, the calling
    /// identity must have the <code>s3-outposts:DeleteBucketPolicy</code> permissions on
    /// the specified Outposts bucket and belong to the bucket owner's account to use this
    /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
    /// </para>
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
    /// a bucket can always use this action, even if the policy explicitly denies the root
    /// user the ability to perform this action.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies and User Policies</a>. 
    /// </para>
    ///  
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <code>x-amz-outpost-id</code> to be passed with the request. In addition,
    /// you must use an S3 on Outposts endpoint hostname prefix instead of <code>s3-control</code>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <code>x-amz-outpost-id</code> derived by
    /// using the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html#API_control_DeleteBucketPolicy_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// The following actions are related to <code>DeleteBucketPolicy</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketPolicyRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the bucket.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the Amazon Web Services SDK and
        /// CLI, you must specify the ARN of the bucket accessed in the format <code>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</code>.
        /// For example, to access the bucket <code>reports</code> through Outpost <code>my-outpost</code>
        /// owned by account <code>123456789012</code> in Region <code>us-west-2</code>, use the
        /// URL encoding of <code>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</code>.
        /// The value must be URL encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

    }
}