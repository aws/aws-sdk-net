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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBucketEncryption operation.
    /// This implementation of the DELETE action resets the default encryption for the bucket
    /// as server-side encryption with Amazon S3 managed keys (SSE-S3).
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets</b> - For information about the bucket default encryption
    /// feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
    /// S3 Bucket Default Encryption</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, there are only two supported options
    /// for server-side encryption: SSE-S3 and SSE-KMS. For information about the default
    /// encryption configuration in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-bucket-encryption.html">Setting
    /// default server-side encryption behavior for directory buckets</a>.
    /// </para>
    ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The <c>s3:PutEncryptionConfiguration</c>
    /// permission is required in a policy. The bucket owner has this permission by default.
    /// The bucket owner can grant this permission to others. For more information about permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation, you
    /// must have the <c>s3express:PutEncryptionConfiguration</c> permission in an IAM identity-based
    /// policy instead of a bucket policy. Cross-account access to this API operation isn't
    /// supported. This operation can only be performed by the Amazon Web Services account
    /// that owns the resource. For more information about directory bucket policies and permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>DeleteBucketEncryption</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketEncryption.html">PutBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketEncryption.html">GetBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketEncryptionRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket containing the server-side encryption configuration to delete.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - When you use this operation with a directory bucket,
        /// you must use path-style requests in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
        /// </c>. Virtual-hosted-style requests aren't supported. Directory bucket names must
        /// be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must
        /// also follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for
        /// example, <c> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az1</i>--x-s3</c>). For information
        /// about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, this header is not supported in this API operation. If you
        /// specify this header, the request fails with the HTTP status code <c>501 Not Implemented</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

    }
}