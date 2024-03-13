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
    /// This operation lists in-progress multipart uploads in a bucket. An in-progress multipart
    /// upload is a multipart upload that has been initiated by the <code>CreateMultipartUpload</code>
    /// request, but has not yet been completed or aborted.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - If multipart uploads in a directory bucket are in progress,
    /// you can't delete the bucket until all the in-progress multipart uploads are aborted
    /// or completed. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>ListMultipartUploads</code> operation returns a maximum of 1,000 multipart
    /// uploads in the response. The limit of 1,000 multipart uploads is also the default
    /// value. You can further limit the number of uploads in a response by specifying the
    /// <code>max-uploads</code> request parameter. If there are more than 1,000 multipart
    /// uploads that satisfy your <code>ListMultipartUploads</code> request, the response
    /// returns an <code>IsTruncated</code> element with the value of <code>true</code>, a
    /// <code>NextKeyMarker</code> element, and a <code>NextUploadIdMarker</code> element.
    /// To list the remaining multipart uploads, you need to make subsequent <code>ListMultipartUploads</code>
    /// requests. In these requests, include two query parameters: <code>key-marker</code>
    /// and <code>upload-id-marker</code>. Set the value of <code>key-marker</code> to the
    /// <code>NextKeyMarker</code> value from the previous response. Similarly, set the value
    /// of <code>upload-id-marker</code> to the <code>NextUploadIdMarker</code> value from
    /// the previous response.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - The <code>upload-id-marker</code> element and the <code>NextUploadIdMarker</code>
    /// element aren't supported by directory buckets. To list the additional multipart uploads,
    /// you only need to set the value of <code>key-marker</code> to the <code>NextKeyMarker</code>
    /// value from the previous response. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <code>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </code>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - For information about permissions required
    /// to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a> API operation for session-based authorization. Specifically,
    /// you grant the <code>s3express:CreateSession</code> permission to the directory bucket
    /// in a bucket policy or an IAM identity-based policy. Then, you make the <code>CreateSession</code>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <code>CreateSession</code> API call to generate a new session token
    /// for use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Sorting of multipart uploads in response</dt> <dd> <ul> <li>
    /// 
    /// <para>
    ///  <b>General purpose bucket</b> - In the <code>ListMultipartUploads</code> response,
    /// the multipart uploads are sorted based on two criteria:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Key-based sorting - Multipart uploads are initially sorted in ascending order based
    /// on their object keys.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Time-based sorting - For uploads that share the same object key, they are further
    /// sorted in ascending order based on the upload initiation time. Among uploads with
    /// the same key, the one that was initiated first will appear before the ones that were
    /// initiated later.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - In the <code>ListMultipartUploads</code> response, the
    /// multipart uploads aren't sorted lexicographically based on the object keys. 
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
    /// </para>
    ///  </dd> </dl> 
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
        private RequestPayer _requestPayer;
        private string uploadIdMarker;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <code> <i>bucket_base_name</i>--<i>az-id</i>--x-s3</code>
        /// (for example, <code> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az2</i>--x-s3</code>). For
        /// information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point, you must provide
        /// the alias of the access point in place of the bucket name or specify the access point
        /// ARN. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points and Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with Amazon S3 on Outposts, you
        /// must direct requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes
        /// the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, <code>/</code> is the only supported
        /// delimiter.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property KeyMarker. 
        /// <para>
        /// Specifies the multipart upload after which listing should begin.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets</b> - For general purpose buckets, <code>key-marker</code>
        /// is an object key. Together with <code>upload-id-marker</code>, this parameter specifies
        /// the multipart upload after which listing should begin.
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
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, <code>key-marker</code> is obfuscated
        /// and isn't a real object key. The <code>upload-id-marker</code> parameter isn't supported
        /// by directory buckets. To list the additional multipart uploads, you only need to set
        /// the value of <code>key-marker</code> to the <code>NextKeyMarker</code> value from
        /// the previous response. 
        /// </para>
        ///  
        /// <para>
        /// In the <code>ListMultipartUploads</code> response, the multipart uploads aren't sorted
        /// lexicographically based on the object keys. 
        /// </para>
        ///  </li> </ul> </note>
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
        public int? MaxUploads
        {
            get { return this.maxUploads; }
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
        /// think of using <code>prefix</code> to make groups in the same way that you'd use a
        /// folder in a file system.)
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, only prefixes that end in a delimiter
        /// (<code>/</code>) are supported.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property UploadIdMarker. 
        /// <para>
        /// Together with key-marker, specifies the multipart upload after which listing should
        /// begin. If key-marker is not specified, the upload-id-marker parameter is ignored.
        /// Otherwise, any multipart uploads for a key equal to the key-marker might be included
        /// in the list only if they have an upload ID lexicographically greater than the specified
        /// <code>upload-id-marker</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
    
