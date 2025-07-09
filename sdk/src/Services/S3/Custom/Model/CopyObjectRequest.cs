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
    /// Container for the parameters to the CopyObject operation.
    /// Creates a copy of an object that is already stored in Amazon S3.
    /// 
    ///  <note> 
    /// <para>
    /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
    /// your object up to 5 GB in size in a single atomic action using this API. However,
    /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
    /// - Copy (UploadPartCopy) API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
    /// Object Using the REST Multipart Upload API</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can copy individual objects between general purpose buckets, between directory
    /// buckets, and between general purpose buckets and directory buckets.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Both the Region that you want to copy the object from and the Region that you want
    /// to copy the object to must be enabled for your account.
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
    /// a cross-Region copy using a transfer acceleration endpoint, you get a <c>400 Bad
    /// Request</c> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
    /// Acceleration</a>.
    /// </para>
    ///  </important> <dl> <dt>Authentication and authorization</dt> <dd> 
    /// <para>
    /// All <c>CopyObject</c> requests must be authenticated and signed by using IAM
    /// credentials (access key ID and secret access key for the IAM identities). All headers
    /// with the <c>x-amz-</c> prefix, including <c>x-amz-copy-source</c>, must
    /// be signed. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - You must use the IAM credentials to authenticate and authorize
    /// your access to the <c>CopyObject</c> API operation, instead of using the temporary
    /// security credentials through the <c>CreateSession</c> API operation.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services CLI or SDKs handles authentication and authorization on your behalf.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have <i>read</i> access to the source object and <i>write</i> access to the
    /// destination bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have permissions in an IAM policy
    /// based on the source and destination bucket types in a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object is in a general purpose bucket, you must have <b> <c>s3:GetObject</c>
    /// </b> permission to read the source object that is being copied. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the destination bucket is a general purpose bucket, you must have <b> <c>s3:PutObject</c>
    /// </b> permission to write the object copy to the destination bucket. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have permissions in a bucket policy
    /// or an IAM identity-based policy based on the source and destination bucket types in
    /// a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object that you want to copy is in a directory bucket, you must have
    /// the <b> <c>s3express:CreateSession</c> </b> permission in the <c>Action</c>
    /// element of a policy to read the object. By default, the session is in the <c>ReadWrite</c>
    /// mode. If you want to restrict the access, you can explicitly set the <c>s3express:SessionMode</c>
    /// condition key to <c>ReadOnly</c> on the copy source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the copy destination is a directory bucket, you must have the <b> <c>s3express:CreateSession</c>
    /// </b> permission in the <c>Action</c> element of a policy to write the object
    /// to the destination. The <c>s3express:SessionMode</c> condition key can't be
    /// set to <c>ReadOnly</c> on the copy destination bucket. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-identity-policies.html">Amazon
    /// Web Services Identity and Access Management (IAM) identity-based policies for S3 Express
    /// One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Response and special errors</dt> <dd> 
    /// <para>
    /// When the request is an HTTP 1.1 request, the response is chunk encoded. When the request
    /// is not an HTTP 1.1 request, the response would not contain the <c>Content-Length</c>.
    /// You always need to read the entire response body to check if the copy succeeds. to
    /// keep the connection alive while we copy the data. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the copy is successful, you receive a response with information about the copied
    /// object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A copy request might return an error when Amazon S3 receives the copy request or while
    /// Amazon S3 is copying the files. A <c>200 OK</c> response can contain either
    /// a success or an error.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the error occurs before the copy action starts, you receive a standard Amazon S3
    /// error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the error occurs during the copy operation, the error response is embedded in the
    /// <c>200 OK</c> response. For example, in a cross-region copy, you may encounter
    /// throttling and receive a <c>200 OK</c> response. For more information, see <a
    /// href="https://repost.aws/knowledge-center/s3-resolve-200-internalerror">Resolve the
    /// Error 200 response when copying objects to Amazon S3</a>. The <c>200 OK</c>
    /// status code means the copy was accepted, but it doesn't mean the copy is complete.
    /// Another example is when you disconnect from Amazon S3 before the copy is complete,
    /// Amazon S3 might cancel the copy and you may receive a <c>200 OK</c> response.
    /// You must stay connected to Amazon S3 until the entire response is successfully received
    /// and processed.
    /// </para>
    ///  
    /// <para>
    /// If you call this API operation directly, make sure to design your application to parse
    /// the content of the response and handle it appropriately. If you use Amazon Web Services
    /// SDKs, SDKs handle this condition. The SDKs detect the embedded error and apply error
    /// handling per your configuration settings (including automatically retrying the request
    /// as appropriate). If the condition persists, the SDKs throw an exception (or, for the
    /// SDKs that don't use exceptions, they return an error).
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>Charge</dt> <dd> 
    /// <para>
    /// The copy request charge is based on the storage class and Region that you specify
    /// for the destination object. The request can also result in a data retrieval charge
    /// for the source if the source storage class bills for data retrieval. If the copy source
    /// is in a different region, the data transfer is billed to the copy source account.
    /// For pricing information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon S3
    /// pricing</a>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CopyObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CopyObjectRequest : PutWithACLRequest
    {
        private S3CannedACL cannedACL;
        private bool? bucketKeyEnabled;

        private string srcBucket;
        private string srcKey;
        private string srcVersionId;
        private string dstBucket;
        private string dstKey;
        private RequestPayer requestPayer;
        private string expectedBucketOwner;
        private string expectedSourceBucketOwner;
        private ChecksumAlgorithm _checksumAlgorithm;

        private string etagToMatch;
        private string etagToNotMatch;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        
        private List<Tag> tagset = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        private S3MetadataDirective metadataDirective;
        private S3StorageClass storageClass;
		private ObjectLockLegalHoldStatus objectLockLegalHoldStatus;
        private ObjectLockMode objectLockMode;
        private DateTime? objectLockRetainUntilDate;
        private string websiteRedirectLocation;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private string serverSideEncryptionKeyManagementServiceEncryptionContext;

        private ServerSideEncryptionCustomerMethod copySourceServerSideCustomerEncryption;
        private string copySourceServerSideEncryptionCustomerProvidedKey;
        private string copySourceServerSideEncryptionCustomerProvidedKeyMD5;
        private TaggingDirective taggingDirective;


        /// <summary>
        /// A canned access control list (CACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
        /// <para>This action is not supported by Amazon S3 on Outposts.</para>
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return cannedACL != null && cannedACL != S3CannedACL.NoACL;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using AWS KMS (SSE-KMS). Setting this header to <c>true</c>
        /// causes Amazon S3 to use an S3 Bucket Key for object encryption with SSE-KMS. 
        /// </para>
        ///  
        /// <para>
        /// Specifying this header with a COPY action doesn't affect bucket-level settings for
        /// S3 Bucket Key.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon S3 Bucket Keys</a> 
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets</b> - S3 Bucket Keys aren't supported, when you copy SSE-KMS encrypted objects from general purpose buckets to directory buckets, 
        /// from directory buckets to general purpose buckets, or between directory buckets, through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>. 
        /// In this case, Amazon S3 makes a call to KMS every time a copy request is made for a KMS-encrypted object.
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled; }
            set { this.bucketKeyEnabled = value; }
        }

        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }

        /// <summary>
        /// This is a convenience property for Headers.ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this.Headers.ContentType; }
            set { this.Headers.ContentType = value; }
        }

        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
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

        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDate property is set.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
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

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod
        {
            get { return this.copySourceServerSideCustomerEncryption; }
            set { this.copySourceServerSideCustomerEncryption = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerMethod property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
        {
            return this.copySourceServerSideCustomerEncryption != null && this.copySourceServerSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The customer provided encryption key for the source object of the copy.
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CopySourceServerSideEncryptionCustomerProvidedKey
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKey; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the CopySourceServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKeyMD5; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property DestinationBucket. 
        /// <para>
        /// The name of the destination bucket.
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests 
        /// in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests 
        /// are not supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names 
        /// must follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Copying objects across different Amazon Web Services Regions isn't supported when 
        /// the source or destination bucket is in Amazon Web Services Local Zones. The source and destination buckets must have the same parent 
        /// Amazon Web Services Region. Otherwise, you get an HTTP <c>400 Bad Request</c> error with the error code <c>InvalidRequest</c>.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of the 
        /// access point in place of the bucket name or specify the access point ARN. When you use this action with an access point for directory 
        /// buckets, you must provide the access point name in place of the bucket name. When using the access point ARN, you must direct requests 
        /// to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. For 
        /// more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must use the Outpost bucket access point ARN or the access point alias 
        /// for the destination bucket. You can only copy objects within the same Outpost bucket. It's not supported to copy objects across different Amazon Web 
        /// Services Outposts, between buckets on the same Outposts, or between Outposts buckets and any other bucket types. For more information about 
        /// S3 on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>S3 on Outposts guide</i>. When 
        /// you use this action with S3 on Outposts through the REST API, you must direct requests to the S3 on Outposts hostname, in the 
        /// format <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. The hostname isn't required when you 
        /// use the Amazon Web Services CLI or SDKs. 
        /// </para>
        /// </summary>
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Checks if DestinationBucket property is set.
        /// </summary>
        /// <returns>true if DestinationBucket property is set.</returns>
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this.dstBucket);
        }

        /// <summary>
        /// The key to be given to the copy of the source object.
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
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }
        /// <summary>
        /// Checks if DestinationKey property is set.
        /// </summary>
        /// <returns>true if DestinationKey property is set.</returns>
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this.dstKey);
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected destination bucket owner. If the destination bucket
        /// is owned by a different account, the request will fail with an HTTP <c>403 (Access
        /// Denied)</c> error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property ExpectedSourceBucketOwner. 
        /// <para>
        /// The account ID of the expected source bucket owner. If the source bucket is owned
        /// by a different account, the request will fail with an HTTP <c>403 (Access Denied)</c>
        /// error.
        /// </para>
        /// </summary>
        public string ExpectedSourceBucketOwner
        {
            get { return this.expectedSourceBucketOwner; }
            set { this.expectedSourceBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedSourceBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedSourceBucketOwner property is set.</returns>
        internal bool IsSetExpectedSourceBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedSourceBucketOwner);
        }
        
        /// <summary>
        /// The collection of meta data for the request.
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                if (this.metadataCollection == null)
                    this.metadataCollection = new MetadataCollection();
                return this.metadataCollection;
            }
        }

        /// <summary>
        /// Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request.
        ///  
        /// </summary>
        public S3MetadataDirective MetadataDirective
        {
            get { return this.metadataDirective; }
            set { this.metadataDirective = value; }
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether you want to apply a Legal Hold to the copied object.
        /// </para>
        /// </summary>
        public ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus
        {
            get { return this.objectLockLegalHoldStatus; }
            set { this.objectLockLegalHoldStatus = value; }
        }

        // Check to see if ObjectLockLegalHoldStatus property is set
        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this.objectLockLegalHoldStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockMode. 
        /// <para>
        /// The Object Lock mode that you want to apply to the copied object.
        /// </para>
        /// </summary>
        public ObjectLockMode ObjectLockMode
        {
            get { return this.objectLockMode; }
            set { this.objectLockMode = value; }
        }

        // Check to see if ObjectLockMode property is set
        internal bool IsSetObjectLockMode()
        {
            return this.objectLockMode != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate. 
        /// <para>
        /// The date and time when you want the copied object's Object Lock to expire.
        /// </para>
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate
        {
            get { return this.objectLockRetainUntilDate; }
            set { this.objectLockRetainUntilDate = value; }
        }

        // Check to see if ObjectLockRetainUntilDate property is set
        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this.objectLockRetainUntilDate.HasValue; 
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
        /// The name of the bucket containing the object to copy.
        /// </summary>
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }
        
        /// <summary>
        /// Checks if SourceBucket property is set.
        /// </summary>
        /// <returns>true if SourceBucket property is set.</returns>

        // Check to see if SourceBucket property is set
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this.srcBucket);
        }

        /// <summary>
        /// The key of the object to copy.
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
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Checks if SourceKey property is set.
        /// </summary>
        /// <returns>true if SourceKey property is set.</returns>
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this.srcKey);
        }

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Checks if SourceVersionId property is set.
        /// </summary>
        /// <returns>true if SourceVersionId property is set.</returns>
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this.srcVersionId);
        }

        /// <summary>
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3. 
        /// Unrecognized or unsupported values won't write a destination object and will receive a <c>400 Bad Request</c> response. 
        /// </para>
        /// 
        /// <para>
        /// Amazon S3 automatically encrypts all new objects that are copied to an S3 bucket. 
        /// When copying an object, if you don't specify encryption information in your copy request, the encryption setting of the target 
        /// object is set to the default encryption configuration of the destination bucket. 
        /// 
        /// By default, all buckets have a base level of encryption configuration that uses server-side encryption with Amazon S3 managed keys (SSE-S3).
        /// If the destination bucket has a different default encryption configuration, Amazon S3 uses the corresponding encryption key to encrypt the 
        /// target object copy.
        /// </para>
        /// 
        /// <para>
        /// With server-side encryption, Amazon S3 encrypts your data as it writes your data to disks in its data centers and decrypts the data when you access it. 
        /// For more information about server-side encryption, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using Server-Side Encryption</a> 
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// 
        /// <para>
        /// <b>General purpose buckets</b>
        /// </para>
        /// 
        /// <ul>
        /// <li>
        /// <para>
        /// For general purpose buckets, there are the following supported options for server-side encryption: server-side encryption with Key Management Service (KMS) keys (SSE-KMS), 
        /// dual-layer server-side encryption with Amazon Web Services KMS keys (DSSE-KMS), and server-side encryption with customer-provided encryption keys (SSE-C). 
        /// 
        /// Amazon S3 uses the corresponding KMS key, or a customer-provided key to encrypt the target object copy.
        /// </para>
        /// </li>
        /// 
        /// <li>
        /// <para>
        /// When you perform a <c>CopyObject</c> operation, if you want to use a different type of encryption setting for the target object, you can specify appropriate 
        /// encryption-related headers to encrypt the target object with an Amazon S3 managed key, a KMS key, or a customer-provided key. 
        /// If the encryption setting in your request is different from the default encryption configuration of the destination bucket, the encryption setting in your request takes precedence.
        /// </para>
        /// </li>
        /// </ul>
        /// 
        /// <para>
        /// <b>Directory buckets</b>
        /// </para>
        /// 
        /// <ul>
        /// <li>
        /// <para>
        /// For directory buckets, there are only two supported options for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). 
        /// 
        /// We recommend that the bucket's default encryption uses the desired encryption configuration and you don't override the bucket default encryption in 
        /// your <c>CreateSession</c> requests or <c>PUT</c> object requests. Then, new objects are automatically encrypted with the desired encryption settings. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting data with server-side encryption</a> in 
        /// the <i>Amazon S3 User Guide</i>. 
        /// 
        /// For more information about the encryption overriding behaviors in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying server-side encryption with KMS for new object uploads</a>.
        /// </para>
        /// </li>
        /// 
        /// <li>
        /// <para>
        /// To encrypt new object copies to a directory bucket with SSE-KMS, we recommend you specify SSE-KMS as the directory bucket's default encryption configuration with a 
        /// KMS key (specifically, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a>). 
        /// 
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a> (<c>aws/s3</c>) isn't supported. 
        /// 
        /// Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> per directory 
        /// bucket for the lifetime of the bucket. After you specify a customer managed key for SSE-KMS, you can't override the customer managed key for the bucket's SSE-KMS configuration. 
        /// Then, when you perform a <c>CopyObject</c> operation and want to specify server-side encryption settings for new object copies with SSE-KMS in the
        /// encryption-related request headers, you must ensure the encryption key is the same customer managed key that you specified for the directory bucket's default encryption configuration. 
        /// </para>
        /// </li>
        /// <li> 
        /// <para>
        /// <b>S3 access points for Amazon FSx </b> - When accessing data stored in Amazon FSx
        /// file systems using S3 access points, the only valid server side encryption option
        /// is <c>aws:fsx</c>. All Amazon FSx file systems have encryption configured by default
        /// and are encrypted at rest. Data is automatically encrypted before being written to
        /// the file system, and automatically decrypted as it is read. These processes are handled
        /// transparently by Amazon FSx.
        /// </para>
        /// </li>
        /// </ul>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null && this.serverSideEncryption != ServerSideEncryptionMethod.None;
        }
         /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
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
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
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
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext. 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context as an additional encryption context to use for the destination object encryption. 
        /// The value of this header is a Base64 encoded UTF-8 string holding JSON with the encryption context key-value pairs.
        /// </para> 
        /// 
        /// <para>
        /// <b>General purpose buckets</b> - This value must be explicitly added to specify encryption context for <c>CopyObject</c> requests if you want an additional encryption 
        /// context for your destination object. 
        /// 
        /// The additional encryption context of the source object won't be copied to the destination object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html#encryption-context">Encryption context</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets</b> - You can optionally provide an explicit encryption context value.
        /// The value must match the default encryption context - the bucket Amazon Resource Name (ARN). 
        /// An additional encryption context value is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this.serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this.serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceEncryptionContext);
        }

        /// <summary>
        /// Gets and sets the property SSEKMSKeyId. 
        /// <para>
        /// Specifies the KMS key ID (Key ID, Key ARN, or Key Alias) to use for object encryption. 
        /// All GET and PUT requests for an object protected by KMS will fail if they're not made via SSL or using SigV4. 
        /// 
        /// For information about configuring any of the officially supported Amazon Web Services SDKs and Amazon Web Services CLI, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version">Specifying the Signature Version in Request Authentication</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///
        /// <para> 
        /// <b>Directory buckets</b> - If you specify <c>x-amz-server-side-encryption</c> with <c>aws:kms</c>, you must specify the <c>x-amz-server-side-encryption-aws-kms-key-id</c> header 
        /// with the ID (Key ID or Key ARN) of the KMS symmetric encryption customer managed key to use. 
        /// Otherwise, you get an HTTP <c>400 Bad Request</c> error. 
        /// Only use the key ID or key ARN. The key alias format of the KMS key isn't supported. 
        /// Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> per directory bucket
        /// for the lifetime of the bucket. 
        /// 
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a> (<c>aws/s3</c>) isn't supported. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// By default, Amazon S3 uses the STANDARD Storage Class to store newly created objects.
        /// The STANDARD storage class provides high durability and high availability. Depending
        /// on performance needs, you can specify a different Storage Class. Amazon S3 on Outposts
        /// only uses the OUTPOSTS Storage Class. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// The tag-set for the object destination object this value must be used in conjunction with the TaggingDirective. The tag-set must be encoded as URL Query parameters.
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this.tagset; }
            set { this.tagset = value; }
        }

        /// <summary>
        /// Checks if Tagging property is set
        /// </summary>
        /// <returns>true if Tagging is set.</returns>
        internal bool IsSetTagSet()
        {
            return (this.tagset != null) && (this.tagset.Count > 0 || !AWSConfigs.InitializeCollections);
        }
        
        /// <summary>
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata. This value is unique to each object and is not copied
        /// when using the <c>x-amz-metadata-directive</c> header. Instead, you may opt
        /// to provide this header in combination with the directive.
        /// </para>
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        // Check to see if WebsiteRedirectLocation property is set
        internal bool IsSetWebsiteRedirectLocation()
        {
            return this.websiteRedirectLocation != null;
        }

        /// <summary>
        /// ETag to be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches 
        /// the specified tag; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        /// <summary>
        /// Checks if ETagToMatch property is set.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) is different
        /// than the specified Etag; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToMatch);
        }

        /// <summary>
        /// ETag that must not be matched as a pre-condition for copying the source object,
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToNotMatch);
        }
        
        /// <summary>
        /// The collection of headers for the request.
        /// </summary>
        public HeadersCollection Headers
        {
            get
            {
                if (this.headersCollection == null)
                    this.headersCollection = new HeadersCollection();
                return this.headersCollection;
            }
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm you want Amazon S3 to use to create the checksum for the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Specifies whether the object tag-set is copied from the source object or replaced with the tag-set that's provided in the request.
        /// <para>
        /// The default value is COPY. You can change the value and decide not to send this header at all if you are working with a service that doesn't 
        /// have an implementation for this header yet.
        /// </para>
        /// <para>
        /// For directory buckets in a CopyObject operation, only the empty tag-set is supported. 
        /// Any requests that attempt to write non-empty tags into directory buckets will receive a 501 Not Implemented status code.
        /// </para>
        /// </summary>
        public TaggingDirective TaggingDirective
        {
            get { return this.taggingDirective; }
            set { this.taggingDirective = value; }
        }
        
        // Check to see if TaggingDirective property is set
        internal bool IsSetTaggingDirective()
        {
            return this.taggingDirective != null; 
        }
    }
}