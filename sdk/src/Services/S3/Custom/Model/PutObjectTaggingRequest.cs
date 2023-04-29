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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObjectTagging operation.
    /// Sets the supplied tag-set to an object that already exists in a bucket.
    /// 
    ///  
    /// <para>
    /// A tag is a key-value pair. You can associate tags with an object by sending a PUT
    /// request against the tagging subresource that is associated with the object. You can
    /// retrieve tags by sending a GET request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>.
    /// </para>
    ///  
    /// <para>
    /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">Tag
    /// Restrictions</a>. Note that Amazon S3 limits the maximum number of tags to 10 tags
    /// per object.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have permission to perform the <code>s3:PutObjectTagging</code>
    /// action. By default, the bucket owner has this permission and can grant this permission
    /// to others.
    /// </para>
    ///  
    /// <para>
    /// To put tags of any other version, use the <code>versionId</code> query parameter.
    /// You also need permission for the <code>s3:PutObjectVersionTagging</code> action.
    /// </para>
    ///  
    /// <para>
    /// For information about the Amazon S3 object tagging feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">Object
    /// Tagging</a>.
    /// </para>
    ///  <p class="title"> <b>Special Errors</b> 
    /// </para>
    ///  <ul> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: InvalidTagError </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: The tag provided was not a valid tag. This error can occur if the tag did
    /// not pass input validation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">Object
    /// Tagging</a>.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: MalformedXMLError </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: The XML provided does not match the schema.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: OperationAbortedError </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: A conflicting conditional action is currently in progress against this
    /// resource. Please try again.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: InternalError</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: The service was unable to apply the provided tag to the object.</i> 
    /// </para>
    ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
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
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string md5Digest;
        private string expectedBucketOwner;
        private string key;
        private RequestPayer requestPayer;
        private Tagging tagging = new Tagging();
        private string versionId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object. 
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Check to see if Bucket property is set 
        /// </summary>
        internal bool IsSetBucket()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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

        /// <summary>
        /// Gets and sets Key property. This key is used to identify the object in S3.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Check to see if Key property is set
        /// </summary>
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// <para>Confirms that the requester knows that they will be charged for the request. 
        /// Bucket owners need not specify this parameter in their requests</para>.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters
        /// </summary>
        public Tagging Tagging
        {
            get { return this.tagging; }
            set { this.tagging = value; }
        }

        /// <summary>
        /// Checks if Tagging property is set.
        /// </summary>
        internal bool IsSetTagging()
        {
            return this.tagging != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The versionId of the object that the tag-set will be added to.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this.versionId);
        }

    }
}
    
