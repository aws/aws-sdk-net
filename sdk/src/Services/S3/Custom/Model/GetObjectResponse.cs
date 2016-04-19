/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  GetObject response and response metadata.
    /// </summary>
    public partial class GetObjectResponse : StreamResponse
    {
        private string deleteMarker;
        private string acceptRanges;
        private Expiration expiration;
        private DateTime? restoreExpiration;
        private bool restoreInProgress;
        private DateTime? lastModified;
        private string eTag;
        private int? missingMeta;
        private string versionId;
        private DateTime? expires;
        private string websiteRedirectLocation;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private ReplicationStatus replicationStatus;
        private S3StorageClass storageClass;

        private string bucketName;
        private string key;
                
        /// <summary>
        /// Flag which returns true if the Expires property has been unmarshalled
        /// from the raw value or set by user code.
        /// </summary>
        private bool isExpiresUnmarshalled;
        internal string RawExpires { get; set; }

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
        /// Gets and sets the Expiration property.
        /// Specifies the expiration date for the object and the
        /// rule governing the expiration.
        /// Is null if expiration is not applicable.
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
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.  
        /// It indiciates for those objects how long the restored object will exist.
        /// </summary>
        public DateTime? RestoreExpiration
        {
            get { return this.restoreExpiration; }
            set { this.restoreExpiration = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// Will be true when the object is in the process of being restored from Amazon Glacier.
        /// </summary>
        public bool RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        /// <summary>
        /// Last modified date of the object
        ///  
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified ?? default(DateTime); }
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
        /// This is set to the number of metadata entries not returned in x-amz-meta headers. This can happen if you create metadata using an API like
        /// SOAP that supports more flexible metadata than the REST API. For example, using SOAP, you can create metadata whose values are not legal
        /// HTTP headers.
        ///  
        /// </summary>
        public int MissingMeta
        {
            get { return this.missingMeta ?? default(int); }
            set { this.missingMeta = value; }
        }

        // Check to see if MissingMeta property is set
        internal bool IsSetMissingMeta()
        {
            return this.missingMeta.HasValue;
        }

        /// <summary>
        /// Version of the object.
        ///  
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
        /// The date and time at which the object is no longer cacheable.
        ///  
        /// </summary>
        public DateTime Expires
        {
            get
            {
                if (this.isExpiresUnmarshalled)
                {
                    return this.expires.Value;
                }
                else
                {
                    this.expires = AmazonS3Util.ParseExpiresHeader(this.RawExpires, this.ResponseMetadata.RequestId);
                    this.isExpiresUnmarshalled = true;
                    return this.expires.Value;
                }
            }
            set { this.expires = value; this.isExpiresUnmarshalled = true; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this.expires.HasValue;
        }

        /// <summary>
        /// If the bucket is configured as a website, redirects requests for this object to another object in the same bucket or to an external URL.
        /// Amazon S3 stores the value of this header in the object metadata.
        ///  
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
        /// The Server-side encryption algorithm used when storing this object in S3.
        ///  
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
        /// The class of storage used to store the object.
        ///  
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
        /// The id of the AWS Key Management Service key that Amazon S3 uses to encrypt and decrypt the object.
        /// </summary>
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
        /// The status of the replication job associated with this source object.
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
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
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

                    if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval ||
                        current == this.ContentLength)
                    {
                        this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength);
                        totalIncrementTransferred = 0;
                    }
                }

                ValidateWrittenStreamSize(current);
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
#if !UNITY
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
        internal void OnRaiseProgressEvent(string file, long incrementTransferred, long transferred, long total)
        {
            AWSSDKUtils.InvokeInBackground(WriteObjectProgressEvent, new WriteObjectProgressArgs(this.BucketName, this.Key, file, this.VersionId, incrementTransferred, transferred, total), this);
        }


        private void ValidateWrittenStreamSize(long bytesWritten)
        {
#if !PCL
            // Check if response stream or it's base stream is a AESDecryptionStream
            var stream = Runtime.Internal.Util.WrapperStream.SearchWrappedStream(this.ResponseStream,
                (s => s is Runtime.Internal.Util.DecryptStream));

            // Don't validate length if response is an encrypted object. 
            if (stream!=null)
               return;
#endif
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
#endif
    }

#if !UNITY
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
        internal WriteObjectProgressArgs(string bucketName, string key, string versionId, long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
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
        internal WriteObjectProgressArgs(string bucketName, string key, string filePath, string versionId, long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
            this.FilePath = filePath;
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
    }
#endif
}
    
