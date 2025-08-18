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
    /// Container for the parameters to the CopyPart operation.
    /// Uploads a part by copying data from an existing object as data source. To specify
    /// the data source, you add the request header <c>x-amz-copy-source</c> in your request.
    /// To specify a byte range, you add the request header <c>x-amz-copy-source-range</c>
    /// in your request. 
    /// 
    ///  
    /// <para>
    /// For information about maximum and minimum part sizes and other multipart upload specifications,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/qfacts.html">Multipart
    /// upload limits</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Instead of copying data from an existing object as part data, you might use the <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// action to upload new data as a part of an object in your request.
    /// </para>
    ///  </note> 
    /// <para>
    /// You must initiate a multipart upload before you can upload any part. In response to
    /// your initiate request, Amazon S3 returns the upload ID, a unique identifier that you
    /// must include in your upload part request.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a> in the <i>Amazon S3 User Guide</i>. For information
    /// about copying objects using a single atomic action vs. a multipart upload, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
    /// on Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Authentication and authorization</dt> <dd> 
    /// <para>
    /// All <c>UploadPartCopy</c> requests must be authenticated and signed by using IAM credentials
    /// (access key ID and secret access key for the IAM identities). All headers with the
    /// <c>x-amz-</c> prefix, including <c>x-amz-copy-source</c>, must be signed. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - You must use IAM credentials to authenticate and authorize
    /// your access to the <c>UploadPartCopy</c> API operation, instead of using the temporary
    /// security credentials through the <c>CreateSession</c> API operation.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services CLI or SDKs handles authentication and authorization on your behalf.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have <c>READ</c> access to the source object and <c>WRITE</c> access to the
    /// destination bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the permissions in a policy
    /// based on the bucket types of your source bucket and destination bucket in an <c>UploadPartCopy</c>
    /// operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object is in a general purpose bucket, you must have the <b> <c>s3:GetObject</c>
    /// </b> permission to read the source object that is being copied. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the destination bucket is a general purpose bucket, you must have the <b> <c>s3:PutObject</c>
    /// </b> permission to write the object copy to the destination bucket. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To perform a multipart upload with encryption using an Key Management Service key,
    /// the requester must have permission to the <c>kms:Decrypt</c> and <c>kms:GenerateDataKey</c>
    /// actions on the key. The requester must also have permissions for the <c>kms:GenerateDataKey</c>
    /// action for the <c>CreateMultipartUpload</c> API. Then, the requester needs permissions
    /// for the <c>kms:Decrypt</c> action on the <c>UploadPart</c> and <c>UploadPartCopy</c>
    /// APIs. These permissions are required because Amazon S3 must decrypt and read data
    /// from the encrypted file parts before it completes the multipart upload. For more information
    /// about KMS permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">Protecting
    /// data using server-side encryption with KMS</a> in the <i>Amazon S3 User Guide</i>.
    /// For information about the permissions required to use the multipart upload API, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// upload and permissions</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html#mpuAndPermissions">Multipart
    /// upload API and permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have permissions in a bucket policy
    /// or an IAM identity-based policy based on the source and destination bucket types in
    /// an <c>UploadPartCopy</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object that you want to copy is in a directory bucket, you must have
    /// the <b> <c>s3express:CreateSession</c> </b> permission in the <c>Action</c> element
    /// of a policy to read the object. By default, the session is in the <c>ReadWrite</c>
    /// mode. If you want to restrict the access, you can explicitly set the <c>s3express:SessionMode</c>
    /// condition key to <c>ReadOnly</c> on the copy source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the copy destination is a directory bucket, you must have the <b> <c>s3express:CreateSession</c>
    /// </b> permission in the <c>Action</c> element of a policy to write the object to the
    /// destination. The <c>s3express:SessionMode</c> condition key cannot be set to <c>ReadOnly</c>
    /// on the copy destination. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the object is encrypted with SSE-KMS, you must also have the <c>kms:GenerateDataKey</c>
    /// and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies
    /// for the KMS key.
    /// </para>
    ///  
    /// <para>
    /// For example policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-identity-policies.html">Amazon
    /// Web Services Identity and Access Management (IAM) identity-based policies for S3 Express
    /// One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets </b> - For information about using server-side encryption
    /// with customer-provided encryption keys with the <c>UploadPartCopy</c> operation, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, there are only two supported options
    /// for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3)
    /// (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>).
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
    /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// For directory buckets, when you perform a <c>CreateMultipartUpload</c> operation and
    /// an <c>UploadPartCopy</c> operation, the request headers you provide in the <c>CreateMultipartUpload</c>
    /// request must match the default encryption configuration of the destination bucket.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    /// S3 Bucket Keys aren't supported, when you copy SSE-KMS encrypted objects from general
    /// purpose buckets to directory buckets, from directory buckets to general purpose buckets,
    /// or between directory buckets, through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>.
    /// In this case, Amazon S3 makes a call to KMS every time a copy request is made for
    /// a KMS-encrypted object.
    /// </para>
    ///  </li> </ul> </dd> <dt>Special errors</dt> <dd> <ul> <li> 
    /// <para>
    /// Error Code: <c>NoSuchUpload</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The specified multipart upload does not exist. The upload ID might be
    /// invalid, or the multipart upload might have been aborted or completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 404 Not Found
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error Code: <c>InvalidRequest</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The specified copy source is not supported as a byte-range copy source.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>UploadPartCopy</c>:
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListMultipartUploads.html">ListMultipartUploads</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CopyPartRequest : AmazonWebServiceRequest
    {
        private ServerSideEncryptionCustomerMethod _copySourceServerSideEncryptionCustomerMethod;
        private string _copySourceServerSideEncryptionCustomerProvidedKey;
        private string _copySourceServerSideEncryptionCustomerProvidedKeyMD5;
        private string _destinationBucket;
        private string _destinationKey;
        private List<string> _eTagsToNotMatch = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eTagToMatch = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _expectedBucketOwner;
        private string _expectedSourceBucketOwner;
        private DateTime? _modifiedSinceDate;
        private int? _partNumber;
        private RequestPayer _requestPayer;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _serverSideEncryptionCustomerProvidedKey;
        private string _serverSideEncryptionCustomerProvidedKeyMD5;
        private string _sourceBucket;
        private string _sourceKey;
        private string _sourceVersionId;
        private DateTime? _unmodifiedSinceDate;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerMethod. 
        /// <para>
        /// Specifies the algorithm to use when decrypting the source object (for example, <c>AES256</c>).
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod
        {
            get { return this._copySourceServerSideEncryptionCustomerMethod; }
            set { this._copySourceServerSideEncryptionCustomerMethod = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerMethod property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
        {
            return this._copySourceServerSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the
        /// source object. The encryption key provided in this header must be one that was used
        /// when the source object was created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CopySourceServerSideEncryptionCustomerProvidedKey
        {
            get { return this._copySourceServerSideEncryptionCustomerProvidedKey; }
            set { this._copySourceServerSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
        {
            return this._copySourceServerSideEncryptionCustomerProvidedKey != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._copySourceServerSideEncryptionCustomerProvidedKeyMD5; }
            set { this._copySourceServerSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return this._copySourceServerSideEncryptionCustomerProvidedKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationBucket. 
        /// <para>
        /// The bucket name.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Zone (Availability Zone or Local Zone). Bucket names must follow the format
        /// <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>).
        /// For information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Copying objects across different Amazon Web Services Regions isn't supported when
        /// the source or destination bucket is in Amazon Web Services Local Zones. The source
        /// and destination buckets must have the same parent Amazon Web Services Region. Otherwise,
        /// you get an HTTP <c>400 Bad Request</c> error with the error code <c>InvalidRequest</c>.
        /// </para>
        ///  </note> 
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
        ///  <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
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
        public string DestinationBucket
        {
            get { return this._destinationBucket; }
            set { this._destinationBucket = value; }
        }

        // Check to see if DestinationBucket property is set
        internal bool IsSetDestinationBucket()
        {
            return this._destinationBucket != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationKey.
        /// </summary>
        [AWSProperty(Min=1)]
        public string DestinationKey
        {
            get { return this._destinationKey; }
            set { this._destinationKey = value; }
        }

        // Check to see if DestinationKey property is set
        internal bool IsSetDestinationKey()
        {
            return this._destinationKey != null;
        }

        /// <summary>
        /// Gets and sets the property ETagsToNotMatch. 
        /// <para>
        /// Copies the object if its entity tag (ETag) is different than the specified ETag.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>x-amz-copy-source-if-none-match</c> and <c>x-amz-copy-source-if-modified-since</c>
        /// headers are present in the request as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-none-match</c> condition evaluates to <c>false</c>, and;
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-modified-since</c> condition evaluates to <c>true</c>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <c>412 Precondition Failed</c> response code. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ETagsToNotMatch
        {
            get { return this._eTagsToNotMatch; }
            set { this._eTagsToNotMatch = value; }
        }

        // Check to see if ETagsToNotMatch property is set
        internal bool IsSetETagsToNotMatch()
        {
            return this._eTagsToNotMatch != null && (this._eTagsToNotMatch.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ETagToMatch. 
        /// <para>
        /// Copies the object if its entity tag (ETag) matches the specified tag.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>x-amz-copy-source-if-match</c> and <c>x-amz-copy-source-if-unmodified-since</c>
        /// headers are present in the request as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-match</c> condition evaluates to <c>true</c>, and;
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-unmodified-since</c> condition evaluates to <c>false</c>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <c>200 OK</c> and copies the data. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ETagToMatch
        {
            get { return this._eTagToMatch; }
            set { this._eTagToMatch = value; }
        }

        // Check to see if ETagToMatch property is set
        internal bool IsSetETagToMatch()
        {
            return this._eTagToMatch != null && (this._eTagToMatch.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected destination bucket owner. If the account ID that you
        /// provide does not match the actual owner of the destination bucket, the request fails
        /// with the HTTP status code <c>403 Forbidden</c> (access denied).
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
        /// Gets and sets the property ExpectedSourceBucketOwner. 
        /// <para>
        /// The account ID of the expected source bucket owner. If the account ID that you provide
        /// does not match the actual owner of the source bucket, the request fails with the HTTP
        /// status code <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedSourceBucketOwner
        {
            get { return this._expectedSourceBucketOwner; }
            set { this._expectedSourceBucketOwner = value; }
        }

        // Check to see if ExpectedSourceBucketOwner property is set
        internal bool IsSetExpectedSourceBucketOwner()
        {
            return this._expectedSourceBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedSinceDate. 
        /// <para>
        /// Copies the object if it has been modified since the specified time.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>x-amz-copy-source-if-none-match</c> and <c>x-amz-copy-source-if-modified-since</c>
        /// headers are present in the request as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-none-match</c> condition evaluates to <c>false</c>, and;
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-modified-since</c> condition evaluates to <c>true</c>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <c>412 Precondition Failed</c> response code. 
        /// </para>
        /// </summary>
        public DateTime? ModifiedSinceDate
        {
            get { return this._modifiedSinceDate; }
            set { this._modifiedSinceDate = value; }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this._modifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// Part number of part being copied. This is a positive integer between 1 and 10,000.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
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
        /// Gets and sets the property ServerSideEncryptionCustomerMethod. 
        /// <para>
        /// Specifies the algorithm to use when encrypting the object (for example, AES256).
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use in encrypting
        /// data. This value is used to store the object and then it is discarded; Amazon S3 does
        /// not store the encryption key. The key must be appropriate for use with the algorithm
        /// specified in the <c>x-amz-server-side-encryption-customer-algorithm</c> header. This
        /// must be the same encryption key specified in the initiate multipart upload request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this._serverSideEncryptionCustomerProvidedKey; }
            set { this._serverSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return this._serverSideEncryptionCustomerProvidedKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this._serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return this._serverSideEncryptionCustomerProvidedKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBucket.
        /// </summary>
        public string SourceBucket
        {
            get { return this._sourceBucket; }
            set { this._sourceBucket = value; }
        }

        // Check to see if SourceBucket property is set
        internal bool IsSetSourceBucket()
        {
            return this._sourceBucket != null;
        }

        /// <summary>
        /// Gets and sets the property SourceKey.
        /// </summary>
        [AWSProperty(Min=1)]
        public string SourceKey
        {
            get { return this._sourceKey; }
            set { this._sourceKey = value; }
        }

        // Check to see if SourceKey property is set
        internal bool IsSetSourceKey()
        {
            return this._sourceKey != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersionId.
        /// </summary>
        public string SourceVersionId
        {
            get { return this._sourceVersionId; }
            set { this._sourceVersionId = value; }
        }

        // Check to see if SourceVersionId property is set
        internal bool IsSetSourceVersionId()
        {
            return this._sourceVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property UnmodifiedSinceDate. 
        /// <para>
        /// Copies the object if it hasn't been modified since the specified time.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>x-amz-copy-source-if-match</c> and <c>x-amz-copy-source-if-unmodified-since</c>
        /// headers are present in the request as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-match</c> condition evaluates to <c>true</c>, and;
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-copy-source-if-unmodified-since</c> condition evaluates to <c>false</c>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <c>200 OK</c> and copies the data. 
        /// </para>
        /// </summary>
        public DateTime? UnmodifiedSinceDate
        {
            get { return this._unmodifiedSinceDate; }
            set { this._unmodifiedSinceDate = value; }
        }

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this._unmodifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// Upload ID identifying the multipart upload whose part is being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}