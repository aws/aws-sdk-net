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
    /// Container for the parameters to the PutBucketTagging operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the tags for a general purpose bucket if attribute based access control (ABAC)
    /// is not enabled for the bucket. When you <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/buckets-tagging-enable-abac.html">enable
    /// ABAC for a general purpose bucket</a>, you can no longer use this operation for that
    /// bucket and must use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_TagResource.html">TagResource</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UntagResource.html">UntagResource</a>
    /// operations instead.
    /// </para>
    ///  
    /// <para>
    /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
    /// To do this, sign up to get your Amazon Web Services account bill with tag key values
    /// included. Then, to see the cost of combined resources, organize your billing information
    /// according to resources with the same tag key values. For example, you can tag several
    /// resources with a specific application name, and then organize your billing information
    /// to see the total cost of that application across several services. For more information,
    /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
    /// Allocation and Tagging</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">Using
    /// Cost Allocation in Amazon S3 Bucket Tags</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  When this operation sets the tags for a bucket, it will overwrite any current tags
    /// the bucket already has. You cannot use this operation to add tags to an existing list
    /// of tags.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <c>s3:PutBucketTagging</c>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>PutBucketTagging</c> has the following special errors. For more Amazon S3 errors
    /// see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error
    /// Responses</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>InvalidTag</c> - The tag provided was not a valid tag. This error can occur if
    /// the tag did not pass input validation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">Using
    /// Cost Allocation in Amazon S3 Bucket Tags</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MalformedXML</c> - The XML provided does not match the schema.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OperationAborted</c> - A conflicting conditional action is currently in progress
    /// against this resource. Please try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>InternalError</c> - The service was unable to apply the provided tag to the bucket.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following operations are related to <c>PutBucketTagging</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketTagging.html">GetBucketTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutBucketTaggingRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private List<Tag> _tagSet = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
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
        /// Indicates the algorithm used to create the checksum for the request when you use the
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
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the data. You must use this header
        /// as a message integrity check to verify that the request body was not corrupted in
        /// transit. For more information, see <a href="http://www.ietf.org/rfc/rfc1864.txt">RFC
        /// 1864</a>.
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
            return !string.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property TagSet. 
        /// <para>
        /// A collection for a set of tags
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this._tagSet; }
            set { this._tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this._tagSet != null && (this._tagSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}