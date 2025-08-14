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
    /// Container for the parameters to the PutPublicAccessBlock operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates or modifies the <c>PublicAccessBlock</c> configuration for an Amazon S3 bucket.
    /// To use this operation, you must have the <c>s3:PutBucketPublicAccessBlock</c> permission.
    /// For more information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// When Amazon S3 evaluates the <c>PublicAccessBlock</c> configuration for a bucket or
    /// an object, it checks the <c>PublicAccessBlock</c> configuration for both the bucket
    /// (or the bucket that contains the object) and the bucket owner's account. If the <c>PublicAccessBlock</c>
    /// configurations are different between the bucket and the account, Amazon S3 uses the
    /// most restrictive combination of the bucket-level and account-level settings.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about when Amazon S3 considers a bucket or an object public,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
    /// Meaning of "Public"</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>PutPublicAccessBlock</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketPolicyStatus.html">GetBucketPolicyStatus</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">Using
    /// Amazon S3 Block Public Access</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutPublicAccessBlockRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private PublicAccessBlockConfiguration _publicAccessBlockConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket whose <c>PublicAccessBlock</c> configuration you
        /// want to set.
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
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

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The MD5 hash of the <c>PutPublicAccessBlock</c> request body. 
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
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
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration. 
        /// <para>
        /// The <c>PublicAccessBlock</c> configuration that you want to apply to this Amazon S3
        /// bucket. You can enable the configuration options in any combination. For more information
        /// about when Amazon S3 considers a bucket or object public, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
        /// Meaning of "Public"</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration
        {
            get { return this._publicAccessBlockConfiguration; }
            set { this._publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this._publicAccessBlockConfiguration != null;
        }

    }
}