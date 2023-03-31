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
    /// - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
    /// Object Using the REST Multipart Upload API</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
    /// to the source object and <i>write</i> access to the destination bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>. Both the Region that you want to copy the object from and the
    /// Region that you want to copy the object to must be enabled for your account.
    /// </para>
    ///  
    /// <para>
    /// A copy request might return an error when Amazon S3 receives the copy request or while
    /// Amazon S3 is copying the files. If the error occurs before the copy action starts,
    /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
    /// the error response is embedded in the <code>200 OK</code> response. This means that
    /// a <code>200 OK</code> response can contain either a success or an error. Design your
    /// application to parse the contents of the response and handle it appropriately.
    /// </para>
    ///  
    /// <para>
    /// If the copy is successful, you receive a response with information about the copied
    /// object.
    /// </para>
    ///  <note> 
    /// <para>
    /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
    /// it would not contain the content-length, and you would need to read the entire body.
    /// </para>
    ///  </note> 
    /// <para>
    /// The copy request charge is based on the storage class and Region that you specify
    /// for the destination object. For pricing information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon
    /// S3 pricing</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
    /// a cross-Region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
    /// Request</code> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
    /// Acceleration</a>.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Metadata</b> 
    /// </para>
    ///  
    /// <para>
    /// When copying an object, you can preserve all metadata (default) or specify new metadata.
    /// However, the ACL is not preserved and is set to private for the user making the request.
    /// To override the default ACL setting, specify a new ACL when generating a copy request.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
    /// ACLs</a>. 
    /// </para>
    ///  
    /// <para>
    /// To specify whether you want the object metadata copied from the source object or replaced
    /// with metadata provided in the request, you can optionally add the <code>x-amz-metadata-directive</code>
    /// header. When you grant permissions, you can use the <code>s3:x-amz-metadata-directive</code>
    /// condition key to enforce certain metadata behavior when objects are uploaded. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/amazon-s3-policy-keys.html">Specifying
    /// Conditions in a Policy</a> in the <i>Amazon S3 User Guide</i>. For a complete list
    /// of Amazon S3-specific condition keys, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
    /// Resources, and Condition Keys for Amazon S3</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b> <code>x-amz-copy-source-if</code> Headers</b> 
    /// </para>
    ///  
    /// <para>
    /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
    /// matches or whether the object was modified before or after a specified date, use the
    /// following request parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-match</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-none-match</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-unmodified-since</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-modified-since</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
    /// headers are present in the request and evaluate as follows, Amazon S3 returns <code>200
    /// OK</code> and copies the data:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If both the <code>x-amz-copy-source-if-none-match</code> and <code>x-amz-copy-source-if-modified-since</code>
    /// headers are present in the request and evaluate as follows, Amazon S3 returns the
    /// <code>412 Precondition Failed</code> response code:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
    /// must be signed.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Server-side encryption</b> 
    /// </para>
    ///  
    /// <para>
    /// When you perform a CopyObject operation, you can optionally use the appropriate encryption-related
    /// headers to encrypt the object using server-side encryption with Amazon Web Services
    /// managed encryption keys (SSE-S3 or SSE-KMS) or a customer-provided encryption key.
    /// With server-side encryption, Amazon S3 encrypts your data as it writes it to disks
    /// in its data centers and decrypts the data when you access it. For more information
    /// about server-side encryption, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using
    /// Server-Side Encryption</a>.
    /// </para>
    ///  
    /// <para>
    /// If a target object uses SSE-KMS, you can enable an S3 Bucket Key for the object. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
    /// S3 Bucket Keys</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Access Control List (ACL)-Specific Request Headers</b> 
    /// </para>
    ///  
    /// <para>
    /// When copying an object, you can optionally use headers to grant ACL-based permissions.
    /// By default, all objects are private. Only the owner has full access control. When
    /// adding a new object, you can grant permissions to individual Amazon Web Services accounts
    /// or to predefined groups defined by Amazon S3. These permissions are then added to
    /// the ACL on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
    /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
    /// ACLs Using the REST API</a>. 
    /// </para>
    ///  
    /// <para>
    /// If the bucket that you're copying objects to uses the bucket owner enforced setting
    /// for S3 Object Ownership, ACLs are disabled and no longer affect permissions. Buckets
    /// that use this setting only accept PUT requests that don't specify an ACL or PUT requests
    /// that specify bucket owner full control ACLs, such as the <code>bucket-owner-full-control</code>
    /// canned ACL or an equivalent form of this ACL expressed in the XML format.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
    /// Controlling ownership of objects and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If your bucket uses the bucket owner enforced setting for Object Ownership, all objects
    /// written to the bucket by any account will be owned by the bucket owner.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Storage Class Options</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>CopyObject</code> action to change the storage class of an object
    /// that is already stored in Amazon S3 using the <code>StorageClass</code> parameter.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
    /// Classes</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Versioning</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
    /// to copy. If the current version is a delete marker, Amazon S3 behaves as if the object
    /// was deleted. To copy a different version, use the <code>versionId</code> subresource.
    /// </para>
    ///  
    /// <para>
    /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
    /// ID for the object being copied. This version ID is different from the version ID of
    /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
    /// response header in the response.
    /// </para>
    ///  
    /// <para>
    /// If you do not enable versioning or suspend it on the target bucket, the version ID
    /// that Amazon S3 generates is always null.
    /// </para>
    ///  
    /// <para>
    /// If the source object's storage class is GLACIER, you must restore a copy of this object
    /// before you can use it as a source object for the copy operation. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>CopyObject</code>:
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
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
    /// Objects</a>.
    /// </para>
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
        private DateTime? modifiedSinceDateUtc;
        private DateTime? unmodifiedSinceDateUtc;

        private List<Tag> tagset = new List<Tag>();

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
        /// server-side encryption using AWS KMS (SSE-KMS). Setting this header to <code>true</code>
        /// causes Amazon S3 to use an S3 Bucket Key for object encryption with SSE-KMS. 
        /// </para>
        ///  
        /// <para>
        /// Specifying this header with a COPY action doesn't affect bucket-level settings for
        /// S3 Bucket Key.
        /// </para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
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
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or
        /// ModifiedSinceDateUtc results in both ModifiedSinceDate and ModifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// ModifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or ModifiedSinceDateUtc results in both ModifiedSinceDate and " +
            "ModifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. ModifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set
            {
                this.modifiedSinceDate = value;
                this.modifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
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
        public DateTime ModifiedSinceDateUtc
        {
            get { return this.modifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                this.modifiedSinceDateUtc = value;
                this.modifiedSinceDate = value;
            }
        }

        /// <summary>
        /// Checks if ModifiedSinceDateUtc property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDateUtc property is set.</returns>
        internal bool IsSetModifiedSinceDateUtc()
        {
            return this.modifiedSinceDateUtc.HasValue;
        }

        /// <summary>
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or
        /// UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and UnmodifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// UnmodifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and " +
            "UnmodifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. UnmodifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? default(DateTime); }
            set
            {
                this.unmodifiedSinceDate = value;
                this.unmodifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
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
        public DateTime UnmodifiedSinceDateUtc
        {
            get { return this.unmodifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                this.unmodifiedSinceDateUtc = value;
                this.unmodifiedSinceDate = value;
            }
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDateUtc property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDateUtc property is set.</returns>
        internal bool IsSetUnmodifiedSinceDateUtc()
        {
            return this.unmodifiedSinceDateUtc.HasValue;
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
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
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
        /// is owned by a different account, the request will fail with an HTTP <code>403 (Access
        /// Denied)</code> error.
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
        /// by a different account, the request will fail with an HTTP <code>403 (Access Denied)</code>
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
        public DateTime ObjectLockRetainUntilDate
        {
            get { return this.objectLockRetainUntilDate.GetValueOrDefault(); }
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
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
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
        /// The server-side encryption algorithm used when storing this object in Amazon S3 (for
        /// example, AES256, <code>aws:kms</code>).
        /// </para>
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
        /// Gets and sets the property SSEKMSEncryptionContext. 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context to use for object encryption.
        /// The value of this header is a base64-encoded UTF-8 string holding JSON with the encryption
        /// context key-value pairs.
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
        /// Specifies the Amazon Web Services KMS key ID to use for object encryption. All GET
        /// and PUT requests for an object protected by Amazon Web Services KMS will fail if not
        /// made via SSL or using SigV4. For information about configuring using any of the officially
        /// supported Amazon Web Services SDKs and Amazon Web Services CLI, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version">Specifying
        /// the Signature Version in Request Authentication</a> in the <i>Amazon S3 User Guide</i>.
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
            return (this.tagset != null) && (this.tagset.Count > 0);
        }
        
        /// <summary>
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata. This value is unique to each object and is not copied
        /// when using the <code>x-amz-metadata-directive</code> header. Instead, you may opt
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
    }
}