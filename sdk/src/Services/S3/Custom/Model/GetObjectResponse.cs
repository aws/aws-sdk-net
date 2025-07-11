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
using System.IO;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.S3.Util;
using Amazon.Util;
using System.Globalization;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  GetObject response and response metadata.
    /// </summary>
    public partial class GetObjectResponse : StreamResponse
    {
        private string deleteMarker;
        private string acceptRanges;
        private string contentRange;
        private Expiration expiration;
        private DateTime? restoreExpiration;
        private bool? restoreInProgress;
        private DateTime? lastModified;
        private string eTag;
        private int? missingMeta;
        private string versionId;
        private ObjectLockLegalHoldStatus objectLockLegalHoldStatus;
        private ObjectLockMode objectLockMode;
        private DateTime? objectLockRetainUntilDate;
        private string websiteRedirectLocation;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private ReplicationStatus replicationStatus;
        private int? partsCount;
        private S3StorageClass storageClass;
        private RequestCharged requestCharged;
        private int? tagCount;

        private string bucketName;
        private string key;
        private bool? bucketKeyEnabled;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType _checksumType;

        /// <summary>
        /// The date and time at which the object is no longer cacheable.
        /// </summary>
        public string ExpiresString { get; set; }

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Specifies whether the object retrieved was (true) or was not (false) a Delete Marker. If false, this response header does not appear in the
        /// response.
        ///  
        /// </summary>
        public string DeleteMarker
        {
            get { return this.deleteMarker; }
            set { this.deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this.deleteMarker != null;
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
        /// Gets and sets the AcceptRanges.
        /// </summary>
        public string AcceptRanges
        {
            get { return this.acceptRanges; }
            set { this.acceptRanges = value; }
        }

        // Check to see if AcceptRanges property is set
        internal bool IsSetAcceptRanges()
        {
            return this.acceptRanges != null;
        }

        /// <summary>
        /// Gets and sets the ContentRange.
        /// </summary>
        public string ContentRange
        {
            get { return this.contentRange; }
            set { this.contentRange = value; }
        }

        // Check to see if ContentRange property is set
        internal bool IsSetContentRange()
        {
            return this.contentRange != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// If the object expiration is configured, this will contain the expiration date (<c>expiry-date</c>)
        /// and rule ID (<c>rule-id</c>). The value of <c>rule-id</c> is URL encoded.
        /// </para>
        /// <para>
        /// Object expiration information is not returned for directory buckets (for those, the
        /// response header will contain the value <c>"NotImplemented"</c>).
        /// </para>
        /// </summary>
        public Expiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this.expiration != null;
        }

        /// <summary>
        /// Gets and sets the RestoreExpiration property.
        /// <para>
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.
        /// It indicates for those objects how long the restored object will exist.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiration
        {
            get { return this.restoreExpiration; }
            set { this.restoreExpiration = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// <para>
        /// Will be <c>true</c> when the object is in the process of being restored from Amazon Glacier.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public bool? RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date and time when the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.lastModified; }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// An ETag is an opaque identifier assigned by a web server to a specific version of a resource found at a URL
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// Gets and sets the property MissingMeta. 
        /// <para>
        /// This is set to the number of metadata entries not returned in the headers that are
        /// prefixed with <code>x-amz-meta-</code>. This can happen if you create metadata using
        /// an API like SOAP that supports more flexible metadata than the REST API. For example,
        /// using SOAP, you can create metadata whose values are not legal HTTP headers.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public int? MissingMeta
        {
            get { return this.missingMeta; }
            set { this.missingMeta = value; }
        }

        // Check to see if MissingMeta property is set
        internal bool IsSetMissingMeta()
        {
            return this.missingMeta.HasValue;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the object.
        /// </para>
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
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Indicates whether this object has an active legal hold. This field is only returned
        /// if you have permission to view an object's legal hold status. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The Object Lock mode that's currently in place for this object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The date and time when this object's Object Lock will expire.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 or Amazon FSx.
        /// </para>
        /// <note>
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        /// </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryptionMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Provides storage class information of the object. Amazon S3 returns this header for
        /// all objects except for S3 Standard storage class objects.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets </b> - Only the S3 Express One Zone storage class is supported
        /// by directory buckets to store objects.
        /// </para>
        ///  </note>
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
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Amazon S3 can return this if your request involves a bucket that is either a source
        /// or destination in a replication rule.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this.replicationStatus; }
            set { this.replicationStatus = value; }
        }

        /// <summary>
        /// Checks if ReplicationStatus property is set.
        /// </summary>
        /// <returns>true if ReplicationStatus property is set.</returns>
        internal bool IsSetReplicationStatus()
        {
            return ReplicationStatus != null;
        }

        /// <summary>
        /// The number of parts this oject has.
        /// </summary>
        public int? PartsCount
        {
            get { return this.partsCount; }
            set { this.partsCount = value; }
        }

        /// <summary>
        /// Checks if PartsCount is set.
        /// </summary>
        /// <returns>true if PartsCount property is set.</returns>
        internal bool IsSetPartsCount()
        {
            return this.partsCount.HasValue;
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
            get
            {
                if (this.serverSideEncryptionCustomerMethod == null)
                    return ServerSideEncryptionCustomerMethod.None;

                return this.serverSideEncryptionCustomerMethod;
            }
            set { this.serverSideEncryptionCustomerMethod = value; }
        }

        /// <summary>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property TagCount. 
        /// <para>
        /// The number of tags, if any, on the object, when you have the relevant permission to
        /// read object tags.
        /// </para>
        ///  
        /// <para>
        /// You can use <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public int TagCount
        {
            get { return this.tagCount ?? 0; }
            set { this.tagCount = value; }
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the object uses an S3 Bucket Key for server-side encryption with
        /// Amazon Web Services KMS (SSE-KMS).
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
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32</c> checksum of the object. This checksum is only present
        /// if it was uploaded with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        // Check to see if ChecksumCRC32 property is set
        internal bool IsSetChecksumCRC32()
        {
            return this._checksumCRC32 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32C</c> checksum of the object. This checksum is only present
        /// if it was uploaded with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        // Check to see if ChecksumCRC32C property is set
        internal bool IsSetChecksumCRC32C()
        {
            return this._checksumCRC32C != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The Base64 encoded, 64-bit <c>CRC-64NVME</c> checksum of the object. This checksum is only present
        /// if it was uploaded with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        // Check to see if ChecksumCRC64NVME property is set
        internal bool IsSetChecksumCRC64NVME()
        {
            return this._checksumCRC64NVME != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// The Base64 encoded, 160-bit <c>SHA-1</c> digest of the object. This will only be present 
        /// if it was uploaded with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA1
        {
            get { return this._checksumSHA1; }
            set { this._checksumSHA1 = value; }
        }

        // Check to see if ChecksumSHA1 property is set
        internal bool IsSetChecksumSHA1()
        {
            return this._checksumSHA1 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256. 
        /// <para>
        /// The Base64 encoded, 256-bit <c>SHA-256</c> checksum of the object. This checksum is only present
        /// if it was uploaded with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA256
        {
            get { return this._checksumSHA256; }
            set { this._checksumSHA256 = value; }
        }

        // Check to see if ChecksumSHA256 property is set
        internal bool IsSetChecksumSHA256()
        {
            return this._checksumSHA256 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The checksum type, which determines how part-level checksums are combined to 
        /// create an object-level checksum for multipart objects. You can use this header 
        /// response to verify that the checksum type that is received is the same checksum 
        /// type that was specified in the <c>CreateMultipartUpload</c> request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        // Check to see if ChecksumType property is set
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }

#if BCL

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        public void WriteResponseStreamToFile(string filePath)
        {
            WriteResponseStreamToFile(filePath, false);
        }

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        /// <param name="append">Whether or not to append to the file if it exists</param>
        public void WriteResponseStreamToFile(string filePath, bool append)
        {
            CreateDirectory(filePath);
            Stream downloadStream = CreateDownloadStream(filePath, append);

            using (downloadStream)
            {
                long current = 0;

                byte[] buffer = new byte[S3Constants.DefaultBufferSize];
                int bytesRead = 0;

                long totalIncrementTransferred = 0;
                while ((bytesRead = this.ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    downloadStream.Write(buffer, 0, bytesRead);
                    current += bytesRead;
                    totalIncrementTransferred += bytesRead;

                    if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval)
                    {
                        this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:false);
                        totalIncrementTransferred = 0;
                    }
                }

                ValidateWrittenStreamSize(current);

                // Encrypted objects may have size smaller than the total amount of data transfered due to padding.
                // Instead of changing the file size or the total downloaded size, pass a flag that indicate that the transfer is complete.
                this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:true);
            }
        }

        private static Stream CreateDownloadStream(string filePath, bool append)
        {
            Stream downloadStream;
            if (append && File.Exists(filePath))
                downloadStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read, S3Constants.DefaultBufferSize);
            else
                downloadStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, S3Constants.DefaultBufferSize);
            return downloadStream;
        }

        private static void CreateDirectory(string filePath)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);
        }

#endif
        #region Progress Event

        /// <summary>
        /// The event for Write Object progress notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// put object progress notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, WriteObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the Put Object Progress Event delegate's invocation list
        /// <code>
        /// GetObjectResponse response = s3Client.GetObject(request);
        /// response.WriteObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<WriteObjectProgressArgs> WriteObjectProgressEvent;

        #endregion

        /// <summary>
        /// This method is called by a producer of write object progress
        /// notifications. When called, all the subscribers in the 
        /// invocation list will be called sequentially.
        /// </summary>
        /// <param name="file">The file being written.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if transfer is complete</param>
        internal void OnRaiseProgressEvent(string file, long incrementTransferred, long transferred, long total, bool completed)
        {
            AWSSDKUtils.InvokeInBackground(WriteObjectProgressEvent, new WriteObjectProgressArgs(this.BucketName, this.Key, file, this.VersionId, incrementTransferred, transferred, total, completed), this);
        }


        private void ValidateWrittenStreamSize(long bytesWritten)
        {
            // Check if response stream or it's base stream is a AESDecryptionStream
            var stream = Runtime.Internal.Util.WrapperStream.SearchWrappedStream(this.ResponseStream,
                (s => s is Runtime.Internal.Util.DecryptStream));

            // Don't validate length if response is an encrypted object. 
            if (stream!=null)
               return;
               
            if (bytesWritten != this.ContentLength)
            {
                string amzId2;                
                if(!this.ResponseMetadata.Metadata.TryGetValue(HeaderKeys.XAmzId2Header, out amzId2))
                    amzId2 = string.Empty;

                string amzCfId;
                if(!this.ResponseMetadata.Metadata.TryGetValue(HeaderKeys.XAmzCloudFrontIdHeader, out amzCfId))
                    amzCfId = string.Empty;

                string message = null;
                if (string.IsNullOrEmpty(amzCfId))
                {
                    message = string.Format(CultureInfo.InvariantCulture,
                    "The total bytes read {0} from response stream is not equal to the Content-Length {1} for the object {2} in bucket {3}." +
                    " Request ID = {4} , AmzId2 = {5}.",
                    bytesWritten, this.ContentLength, this.Key, this.BucketName, this.ResponseMetadata.RequestId, amzId2);
                }
                else
                {
                    message = string.Format(CultureInfo.InvariantCulture,
                    "The total bytes read {0} from response stream is not equal to the Content-Length {1} for the object {2} in bucket {3}." +
                    " Request ID = {4} , AmzId2 = {5} , AmzCfId = {6}.",
                    bytesWritten, this.ContentLength, this.Key, this.BucketName, this.ResponseMetadata.RequestId, amzId2, amzCfId);
                }
                

                throw new StreamSizeMismatchException(message, this.ContentLength, bytesWritten, this.ResponseMetadata.RequestId, amzId2, amzCfId);
            }
        }

#if BCL || NETSTANDARD
        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        /// <param name="append">Whether or not to append to the file if it exists</param>
        /// <param name="cancellationToken">Cancellation token which can be used to cancel this operation.</param>
        public async System.Threading.Tasks.Task WriteResponseStreamToFileAsync(string filePath, bool append, System.Threading.CancellationToken cancellationToken)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);

            Stream downloadStream;
            if (append && File.Exists(filePath))
                downloadStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read, S3Constants.DefaultBufferSize);
            else
                downloadStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, S3Constants.DefaultBufferSize);

            try
            {
                long current = 0;
#if NETSTANDARD
                Stream stream = this.ResponseStream;
#else
                Stream stream = new BufferedStream(this.ResponseStream);
#endif
                byte[] buffer = new byte[S3Constants.DefaultBufferSize];
                int bytesRead = 0;
                long totalIncrementTransferred = 0;
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false)) > 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    await downloadStream.WriteAsync(buffer, 0, bytesRead, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);
                    current += bytesRead;
                    totalIncrementTransferred += bytesRead;

                    if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval)
                    {
                        this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:false);
                        totalIncrementTransferred = 0;
                    }
                }

                ValidateWrittenStreamSize(current);

                // Encrypted objects may have size smaller than the total amount of data trasnfered due to padding.
                // Instead of changing the file size or the total downloaded size, pass a flag that indicate that the transfer is complete.
                this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:true);
            }
            finally
            {
                downloadStream.Dispose();
            }
        }
#endif
    }
    /// <summary>
    /// Encapsulates the information needed to provide
    /// download progress for the Write Object Event.
    /// </summary>
    public class WriteObjectProgressArgs : TransferProgressArgs
    {
        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="bucketName">The bucket name for the S3 object being written.</param>
        /// <param name="key">The object key for the S3 object being written.</param>
        /// <param name="versionId">The version-id of the S3 object.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if finished writing</param>
        internal WriteObjectProgressArgs(string bucketName, string key, string versionId, long incrementTransferred, long transferred, long total, bool completed)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
            this.IsCompleted = completed;
        }

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="bucketName">The bucket name for the S3 object being written.</param>
        /// <param name="key">The object key for the S3 object being written.</param>
        /// <param name="filePath">The file for the S3 object being written.</param>
        /// <param name="versionId">The version-id of the S3 object.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if finished writing</param>
        internal WriteObjectProgressArgs(string bucketName, string key, string filePath, string versionId, long incrementTransferred, long transferred, long total, bool completed)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
            this.FilePath = filePath;
            this.IsCompleted = completed;
        }

        /// <summary>
        /// Gets the bucket name for the S3 object being written.
        /// </summary>
        public string BucketName { get; private set; }

        /// <summary>
        /// Gets the object key for the S3 object being written.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Gets the version-id of the S3 object.
        /// </summary>
        public string VersionId { get; private set; }

        /// <summary>
        /// The file for the S3 object being written.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// True if writing is complete
        /// </summary>
        public bool IsCompleted { get; private set; }
    }  
}
    
