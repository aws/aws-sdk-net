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
    /// Container for the parameters to the PutObjectTagging operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the supplied tag-set to an object that already exists in a bucket. A tag is a
    /// key-value pair. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-tagging.html">Object
    /// Tagging</a>.
    /// </para>
    ///  
    /// <para>
    /// You can associate tags with an object by sending a PUT request against the tagging
    /// subresource that is associated with the object. You can retrieve tags by sending a
    /// GET request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>.
    /// </para>
    ///  
    /// <para>
    /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">Tag
    /// Restrictions</a>. Note that Amazon S3 limits the maximum number of tags to 10 tags
    /// per object.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have permission to perform the <c>s3:PutObjectTagging</c>
    /// action. By default, the bucket owner has this permission and can grant this permission
    /// to others.
    /// </para>
    ///  
    /// <para>
    /// To put tags of any other version, use the <c>versionId</c> query parameter. You also
    /// need permission for the <c>s3:PutObjectVersionTagging</c> action.
    /// </para>
    ///  
    /// <para>
    ///  <c>PutObjectTagging</c> has the following special errors. For more Amazon S3 errors
    /// see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error
    /// Responses</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>InvalidTag</c> - The tag provided was not a valid tag. This error can occur if
    /// the tag did not pass input validation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-tagging.html">Object
    /// Tagging</a>.
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
    ///  <c>InternalError</c> - The service was unable to apply the provided tag to the object.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following operations are related to <c>PutObjectTagging</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObjectTagging.html">DeleteObjectTagging</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutObjectTaggingRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private string _key;
        private RequestPayer _requestPayer;
        private Tagging _tagging;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point for general
        /// purpose buckets, you must provide the alias of the access point in place of the bucket
        /// name or specify the access point ARN. When you use this action with an access point
        /// for directory buckets, you must provide the access point name in place of the bucket
        /// name. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct
        /// requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes the form
        /// <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
        /// When you use this action with S3 on Outposts, the destination bucket must be the Outposts
        /// access point ARN or the access point alias. For more information about S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The MD5 hash for the request body.
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
        /// Gets and sets the property Key. 
        /// <para>
        /// Name of the object key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property Tagging. 
        /// <para>
        /// Container for the <c>TagSet</c> and <c>Tag</c> elements
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Tagging Tagging
        {
            get { return this._tagging; }
            set { this._tagging = value; }
        }

        // Check to see if Tagging property is set
        internal bool IsSetTagging()
        {
            return this._tagging != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The versionId of the object that the tag-set will be added to.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}