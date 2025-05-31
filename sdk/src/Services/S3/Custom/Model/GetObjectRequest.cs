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
using System.Collections.ObjectModel;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// Retrieves an object from Amazon S3.
    /// 
    ///  
    /// <para>
    /// In the <c>GetObject</c> request, specify the full key name for the object.
    /// </para>
    ///  
    /// <para>
    ///  <b>General purpose buckets</b> - Both the virtual-hosted-style requests and the path-style
    /// requests are supported. For a virtual hosted-style request example, if you have the
    /// object <c>photos/2006/February/sample.jpg</c>, specify the object key name as <c>/photos/2006/February/sample.jpg</c>.
    /// For a path-style request example, if you have the object <c>photos/2006/February/sample.jpg</c>
    /// in the bucket named <c>amzn-s3-demo-bucket</c>, specify the object key name as <c>/amzn-s3-demo-bucket/photos/2006/February/sample.jpg</c>.
    /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
    /// Host Header Bucket Specification</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - Only virtual-hosted-style requests are supported. For
    /// a virtual hosted-style request example, if you have the object <c>photos/2006/February/sample.jpg</c>
    /// in the bucket named <c>amzn-s3-demo-bucket--use1-az5--x-s3</c>, specify the object key name
    /// as <c>/photos/2006/February/sample.jpg</c>. Also, when you make requests to this API
    /// operation, your requests are sent to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the required permissions
    /// in a policy. To use <c>GetObject</c>, you must have the <c>READ</c> access to the
    /// object (or version). If you grant <c>READ</c> access to the anonymous user, the <c>GetObject</c>
    /// operation returns the object without using an authorization header. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you include a <c>versionId</c> in your request header, you must have the <c>s3:GetObjectVersion</c>
    /// permission to access a specific version of an object. The <c>s3:GetObject</c> permission
    /// is not required in this scenario.
    /// </para>
    ///  
    /// <para>
    /// If you request the current version of an object without a specific <c>versionId</c>
    /// in the request header, only the <c>s3:GetObject</c> permission is required. The <c>s3:GetObjectVersion</c>
    /// permission is not required in this scenario. 
    /// </para>
    ///  
    /// <para>
    /// If the object that you request doesn’t exist, the error that Amazon S3 returns depends
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
    /// code <c>403 Access Denied</c> error.
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
    ///  </li> </ul> </dd> <dt>Storage classes</dt> <dd> 
    /// <para>
    /// If the object you are retrieving is stored in the S3 Glacier Flexible Retrieval storage
    /// class, the S3 Glacier Deep Archive storage class, the S3 Intelligent-Tiering Archive
    /// Access tier, or the S3 Intelligent-Tiering Deep Archive Access tier, before you can
    /// retrieve the object you must first restore a copy using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>.
    /// Otherwise, this operation returns an <c>InvalidObjectState</c> error. For information
    /// about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, only the S3 Express One Zone storage
    /// class is supported to store newly created objects. Unsupported storage class values
    /// won't write a destination object and will respond with the HTTP status code <c>400
    /// Bad Request</c>.
    /// </para>
    ///  </dd> <dt>Encryption</dt> <dd> 
    /// <para>
    /// Encryption request headers, like <c>x-amz-server-side-encryption</c>, should not be
    /// sent for the <c>GetObject</c> requests, if your object uses server-side encryption
    /// with Amazon S3 managed encryption keys (SSE-S3), server-side encryption with Key Management
    /// Service (KMS) keys (SSE-KMS), or dual-layer server-side encryption with Amazon Web
    /// Services KMS keys (DSSE-KMS). If you include the header in your <c>GetObject</c> requests
    /// for the object that uses these types of keys, you’ll get an HTTP <c>400 Bad Request</c>
    /// error.
    /// </para>
    ///  </dd> <dt>Overriding response header values through the request</dt> <dd> 
    /// <para>
    /// There are times when you want to override certain response header values of a <c>GetObject</c>
    /// response. For example, you might override the <c>Content-Disposition</c> response
    /// header value through your <c>GetObject</c> request.
    /// </para>
    ///  
    /// <para>
    /// You can override values for a set of response headers. These modified response header
    /// values are included only in a successful response, that is, when the HTTP status code
    /// <c>200 OK</c> is returned. The headers you can override using the following query
    /// parameters in the request are a subset of the headers that Amazon S3 accepts when
    /// you create an object. 
    /// </para>
    ///  
    /// <para>
    /// The response headers that you can override for the <c>GetObject</c> response are <c>Cache-Control</c>,
    /// <c>Content-Disposition</c>, <c>Content-Encoding</c>, <c>Content-Language</c>, <c>Content-Type</c>,
    /// and <c>Expires</c>.
    /// </para>
    ///  
    /// <para>
    /// To override values for a set of response headers in the <c>GetObject</c> response,
    /// you can use the following query parameters in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>response-cache-control</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-disposition</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-encoding</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-language</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-type</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-expires</c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// When you use these parameters, you must sign the request by using either an Authorization
    /// header or a presigned URL. These parameters cannot be used with an unsigned (anonymous)
    /// request.
    /// </para>
    ///  </note> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>GetObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBuckets.html">ListBuckets</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        string etagToMatch;
        string etagToNotMatch;
        private string key;
        private int? partNumber;
        private ByteRange byteRange;
        private RequestPayer requestPayer;
        private DateTime? responseExpires;
        private ResponseHeaderOverrides responseHeaders;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string versionId;
        private ChecksumMode _checksumMode;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object. 
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests 
        /// in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests are 
        /// not supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must 
        /// follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of the access 
        /// point in place of the bucket name or specify the access point ARN. When you use this action with an access point for directory 
        /// buckets, you must provide the access point name in place of the bucket name. When using the access point ARN, you must direct requests to 
        /// the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket 
        /// name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Object Lambda access points</b> - When you use this action with an Object Lambda access point, you must direct requests to the Object 
        /// Lambda access point hostname. The Object Lambda access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-object-lambda.<i>Region</i>.amazonaws.com.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 on Outposts 
        /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When you use 
        /// this action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more information 
        /// about S3 on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Gets and sets the Key property. This is the user defined key that identifies the object in the bucket.
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
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' GET request for the part specified. Useful for downloading just a part of an object.
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
        /// Checks if PartNumber property is set.
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
        /// Sets the Expires header of the response.
        /// </summary>
        public DateTime? ResponseExpires
        {
            get { return this.responseExpires; }
            set
            {
                if (value == null)
                {
                    this.responseExpires = null;                    
                }
                else
                {
                    this.responseExpires = value;
                }
            }
        }

        // Check to see if ResponseExpires property is set
        internal bool IsSetResponseExpires()
        {
            return this.responseExpires.HasValue;
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
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
        /// <para>
        /// Downloads the specified range bytes of an object. For more information about the HTTP
        /// Range header, see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-range">https://www.rfc-editor.org/rfc/rfc9110.html#name-range</a>.
        /// </para>
        /// <note> 
        /// <para>
        /// Amazon S3 doesn't support retrieving multiple ranges of data per <c>GET</c>
        /// request.
        /// </para>
        /// </note>
        /// </summary>
        public ByteRange ByteRange
        {
            get { return this.byteRange; }
            set { this.byteRange = value; }
        }

        // Check to see if ByteRange property is set
        internal bool IsSetByteRange()
        {
            return this.byteRange != null && this.byteRange.FormattedByteRange != null;
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// To retrieve the checksum, this mode must be enabled.
        /// </para>
        /// 
        /// <para>
        /// <b>General purpose buckets</b> - In addition, if you enable checksum mode and the object is uploaded with a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_Checksum.html">checksum</a> 
        /// and encrypted with an Key Management Service (KMS) key, you must have permission to use the <c>kms:Decrypt</c> action to retrieve the checksum.
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
        /// This must be enabled to retrieve the checksum
        /// </summary>
        protected override CoreChecksumResponseBehavior CoreChecksumMode
        {
            get
            {
                if (IsSetChecksumMode())
                {
                    return (CoreChecksumResponseBehavior)Enum.Parse(typeof(CoreChecksumResponseBehavior), this.ChecksumMode);
                }

                return CoreChecksumResponseBehavior.DISABLED;
            }
            set { this.ChecksumMode = value.ToString(); }
        }

        private static List<CoreChecksumAlgorithm> _supportedChecksumAlgorithms = new List<CoreChecksumAlgorithm>
        {
            CoreChecksumAlgorithm.CRC64NVME,
            CoreChecksumAlgorithm.CRC32C,
            CoreChecksumAlgorithm.CRC32,
            CoreChecksumAlgorithm.SHA256,
            CoreChecksumAlgorithm.SHA1
        };

        /// <summary>
        /// Checksum algorithms supported by this operation for response validation
        /// </summary>
        protected override ReadOnlyCollection<CoreChecksumAlgorithm> ChecksumResponseAlgorithms => _supportedChecksumAlgorithms.AsReadOnly();
    }
}
