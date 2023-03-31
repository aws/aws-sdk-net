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
    /// Container for the parameters to the ListMultipartUploads operation.
    /// This action lists in-progress multipart uploads. An in-progress multipart upload is
    /// a multipart upload that has been initiated using the Initiate Multipart Upload request,
    /// but has not yet been completed or aborted.
    /// 
    ///  
    /// <para>
    /// This action returns at most 1,000 multipart uploads in the response. 1,000 multipart
    /// uploads is the maximum number of uploads a response can include, which is also the
    /// default value. You can further limit the number of uploads in a response by specifying
    /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
    /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
    /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
    /// and <code>upload-id-marker</code> request parameters.
    /// </para>
    ///  
    /// <para>
    /// In the response, the uploads are sorted by key. If your application has initiated
    /// more than one multipart upload using the same object key, then uploads in the response
    /// are first sorted by key. Additionally, uploads are sorted in ascending order within
    /// each key by the upload initiation time.
    /// </para>
    ///  
    /// <para>
    /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a>.
    /// </para>
    ///  
    /// <para>
    /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>ListMultipartUploads</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CompleteMultipartUpload.html">CompleteMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListMultipartUploadsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string delimiter;
        private EncodingType encoding;
        private string expectedBucketOwner;
        private string keyMarker;
        private int? maxUploads;
        private string prefix;
        private string uploadIdMarker;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. 
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

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Character you use to group keys.
        /// </para>
        ///  
        /// <para>
        /// All keys that contain the same string between the prefix, if specified, and the first
        /// occurrence of the delimiter after the prefix are grouped under a single result element,
        /// <code>CommonPrefixes</code>. If you don't specify the prefix parameter, then the substring
        /// starts at the beginning of the key. The keys that are grouped under <code>CommonPrefixes</code>
        /// result element are not returned elsewhere in the response.
        /// </para>
        /// </summary>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this.delimiter != null;
        }

        /// <summary>
        /// Requests Amazon S3 to encode the object keys in the response and specifies
        /// the encoding method to use. An object key may contain any Unicode character;
        /// however, XML 1.0 parser cannot parse some characters, such as characters
        /// with an ASCII value from 0 to 10. For characters that are not supported in
        /// XML 1.0, you can add this parameter to request that Amazon S3 encode the
        /// keys in the response.
        /// </summary>
        public EncodingType Encoding
        {
            get { return this.encoding; }
            set { this.encoding = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetEncoding()
        {
            return this.encoding != null;
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
        /// Gets and sets the property KeyMarker. 
        /// <para>
        /// Together with upload-id-marker, this parameter specifies the multipart upload after
        /// which listing should begin.
        /// </para>
        ///  
        /// <para>
        /// If <code>upload-id-marker</code> is not specified, only the keys lexicographically
        /// greater than the specified <code>key-marker</code> will be included in the list.
        /// </para>
        ///  
        /// <para>
        /// If <code>upload-id-marker</code> is specified, any multipart uploads for a key equal
        /// to the <code>key-marker</code> might also be included, provided those multipart uploads
        /// have upload IDs lexicographically greater than the specified <code>upload-id-marker</code>.
        /// </para>
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        // Check to see if KeyMarker property is set
        internal bool IsSetKeyMarker()
        {
            return this.keyMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxUploads. 
        /// <para>
        /// Sets the maximum number of multipart uploads, from 1 to 1,000, to return in the response
        /// body. 1,000 is the maximum number of uploads that can be returned in a response.
        /// </para>
        /// </summary>
        public int MaxUploads
        {
            get { return this.maxUploads ?? default(int); }
            set { this.maxUploads = value; }
        }

        // Check to see if MaxUploads property is set
        internal bool IsSetMaxUploads()
        {
            return this.maxUploads.HasValue;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Lists in-progress uploads only for those keys that begin with the specified prefix.
        /// You can use prefixes to separate a bucket into different grouping of keys. (You can
        /// think of using prefix to make groups in the same way you'd use a folder in a file
        /// system.)
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// Gets and sets the property UploadIdMarker. 
        /// <para>
        /// Together with key-marker, specifies the multipart upload after which listing should
        /// begin. If key-marker is not specified, the upload-id-marker parameter is ignored.
        /// Otherwise, any multipart uploads for a key equal to the key-marker might be included
        /// in the list only if they have an upload ID lexicographically greater than the specified
        /// <code>upload-id-marker</code>.
        /// </para>
        /// </summary>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this.uploadIdMarker != null;
        }
    }
}
    
