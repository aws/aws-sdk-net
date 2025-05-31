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
    /// Container for the parameters to the GetObjectMetadata operation.
    /// The <c>HEAD</c> operation retrieves metadata from an object without returning the
    /// object itself. This operation is useful if you're interested only in an object's metadata.
    /// 
    ///  
    /// <para>
    /// A <c>HEAD</c> request has the same options as a <c>GET</c> operation on an object.
    /// The response is identical to the <c>GET</c> response except that there is no response
    /// body. Because of this, if the <c>HEAD</c> request generates an error, it returns a
    /// generic code, such as <c>400 Bad Request</c>, <c>403 Forbidden</c>, <c>404 Not Found</c>,
    /// <c>405 Method Not Allowed</c>, <c>412 Precondition Failed</c>, or <c>304 Not Modified</c>.
    /// It's not possible to retrieve the exact exception of these error codes.
    /// </para>
    ///  
    /// <para>
    /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
    /// Request Headers</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd>  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - To use <c>HEAD</c>, you must have the
    /// <c>s3:GetObject</c> permission. You need the relevant read object (or version) permission
    /// for this operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
    /// resources, and condition keys for Amazon S3</a> in the <i>Amazon S3 User Guide</i>.
    /// For more information about the permissions to S3 API operations by S3 resource types,
    /// see <a href="/AmazonS3/latest/userguide/using-with-s3-policy-actions.html">Required
    /// permissions for Amazon S3 API operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the object you request doesn't exist, the error that Amazon S3 returns depends
    /// on whether you also have the <c>s3:ListBucket</c> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <c>s3:ListBucket</c> permission on the bucket, Amazon S3 returns an
    /// HTTP status code <c>404 Not Found</c> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don’t have the <c>s3:ListBucket</c> permission, Amazon S3 returns an HTTP status
    /// code <c>403 Forbidden</c> error.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token for
    /// use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <note> 
    /// <para>
    /// Encryption request headers, like <c>x-amz-server-side-encryption</c>, should not be
    /// sent for <c>HEAD</c> requests if your object uses server-side encryption with Key
    /// Management Service (KMS) keys (SSE-KMS), dual-layer server-side encryption with Amazon
    /// Web Services KMS keys (DSSE-KMS), or server-side encryption with Amazon S3 managed
    /// encryption keys (SSE-S3). The <c>x-amz-server-side-encryption</c> header is used when
    /// you <c>PUT</c> an object to S3 and want to specify the encryption method. If you include
    /// this header in a <c>HEAD</c> request for an object that uses these types of keys,
    /// you’ll get an HTTP <c>400 Bad Request</c> error. It's because the encryption method
    /// can't be changed when you retrieve the object.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you encrypt an object by using server-side encryption with customer-provided encryption
    /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
    /// from the object, you must use the following headers to provide the encryption key
    /// for the server to be able to retrieve the object's metadata. The headers are: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-algorithm</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-key</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-key-MD5</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
    /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - For directory buckets, only server-side encryption
    /// with Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) is supported.
    /// </para>
    ///  </note> </dd> <dt>Versioning</dt> <dd> <ul> <li> 
    /// <para>
    /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
    /// object was deleted and includes <c>x-amz-delete-marker: true</c> in the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the specified version is a delete marker, the response returns a <c>405 Method
    /// Not Allowed</c> error and the <c>Last-Modified: timestamp</c> response header.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - Delete marker is not supported by directory buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
    /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
    /// parameter in the request.
    /// </para>
    ///  </li> </ul> </note> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following actions are related to <c>HeadObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAttributes.html">GetObjectAttributes</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectMetadataRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumMode _checksumMode;
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        string etagToMatch;
        string etagToNotMatch;
        private string key;
        private string versionId;
        private int? partNumber;
        private RequestPayer requestPayer;
        private string expectedBucketOwner;
        private string _responseCacheControl;
        private string _responseContentDisposition;
        private string _responseContentEncoding;
        private string _responseContentLanguage;
        private string _responseContentType;
        private DateTime? _responseExpires;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;


        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <c> <i>bucket_base_name</i>--<i>az-id</i>--x-s3</c>
        /// (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For information
        /// about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
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
        /// the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
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
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// This must be enabled to retrieve the checksum.
        /// </para>
        ///  
        /// <para> 
        /// <b>General purpose buckets</b> - If you enable checksum mode and the object is uploaded with a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_Checksum.html">checksum</a> 
        /// and encrypted with an Key Management Service (KMS) key, you must have permission to use the <c>kms:Decrypt</c> action to retrieve the checksum.</para>
        /// 
        /// <para> 
        /// <b>Directory buckets</b> - If you enable <c>ChecksumMode</c> and the object is encrypted with Amazon Web Services Key Management Service (Amazon Web Services KMS), 
        /// you must also have the <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies for the KMS key to retrieve the 
        /// checksum of the object.
        /// </para>
        /// </summary>
        public ChecksumMode ChecksumMode
        {
            get { return this._checksumMode; }
            set { this._checksumMode = value; }
        }

        // Check to see if ChecksumMode property is set
        internal bool IsSetChecksumMode()
        {
            return this._checksumMode != null;
        }

        /// <summary>
        /// ETag to be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        public string EtagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        // Check to see if EtagToMatch property is set
        internal bool IsSetEtagToMatch()
        {
            return this.etagToMatch != null;
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? ModifiedSinceDate
        {
            get { return this.modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                if (value == null)
                {
                    this.modifiedSinceDate = null;                    
                }
                else
                {
                    this.modifiedSinceDate = value;
                }
            }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// ETag that should not be matched as a pre-condition for returning the object,
        /// otherwise a NotModified (304) signal is returned.
        /// </summary>
        public string EtagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        // Check to see if EtagToNotMatch property is set
        internal bool IsSetEtagToNotMatch()
        {
            return this.etagToNotMatch != null;
        }

        /// <summary>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                if (value == null)
                {
                    this.unmodifiedSinceDate = null;
                }
                else
                {
                    this.unmodifiedSinceDate = value;
                }
            }
        }

        // Check to see if IfUnmodifiedSince property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// The key of the object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". 
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory.
        /// </para>
        /// <para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// </para>
        /// <para>
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </para>
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID used to reference a specific version of the object.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets in this API operation, only the <c>null</c> value of the
        /// version ID is supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to decrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' HEAD request for the part specified.
        /// Useful querying about the size of the part and the number of parts in this object.
        /// </summary>
        public int? PartNumber
        {
            get { return this.partNumber; }
            set
            {
                if (value.HasValue)
                {
                    if (value < 1 || 10000 < value)
                    {
                        throw new ArgumentException("PartNumber must be a positve integer between 1 and 10,000.");
                    }
                }
                
                this.partNumber = value;
            }
       }

        /// <summary>
        /// Check if PartNumber property is set.
        /// </summary>
        /// <returns>true if PartNumber property is set.</returns>
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        /// <summary>
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
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
        /// Gets and sets the property ResponseCacheControl. 
        /// <para>
        /// Sets the <c>Cache-Control</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseCacheControl
        {
            get { return this._responseCacheControl; }
            set { this._responseCacheControl = value; }
        }

        // Check to see if ResponseCacheControl property is set
        internal bool IsSetResponseCacheControl()
        {
            return this._responseCacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentDisposition. 
        /// <para>
        /// Sets the <c>Content-Disposition</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentDisposition
        {
            get { return this._responseContentDisposition; }
            set { this._responseContentDisposition = value; }
        }

        // Check to see if ResponseContentDisposition property is set
        internal bool IsSetResponseContentDisposition()
        {
            return this._responseContentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentEncoding. 
        /// <para>
        /// Sets the <c>Content-Encoding</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentEncoding
        {
            get { return this._responseContentEncoding; }
            set { this._responseContentEncoding = value; }
        }

        // Check to see if ResponseContentEncoding property is set
        internal bool IsSetResponseContentEncoding()
        {
            return this._responseContentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentLanguage. 
        /// <para>
        /// Sets the <c>Content-Language</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentLanguage
        {
            get { return this._responseContentLanguage; }
            set { this._responseContentLanguage = value; }
        }

        // Check to see if ResponseContentLanguage property is set
        internal bool IsSetResponseContentLanguage()
        {
            return this._responseContentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType. 
        /// <para>
        /// Sets the <c>Content-Type</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseExpires. 
        /// <para>
        /// Sets the <c>Expires</c> header of the response.
        /// </para>
        /// </summary>
        public DateTime? ResponseExpires
        {
            get { return this._responseExpires; }
            set { this._responseExpires = value; }
        }

        // Check to see if ResponseExpires property is set
        internal bool IsSetResponseExpires()
        {
            return this._responseExpires.HasValue;
        }
    }
}