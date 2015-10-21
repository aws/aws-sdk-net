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
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  HeadObject response and response metadata.
    /// </summary>
    public class GetObjectMetadataResponse : AmazonWebServiceResponse
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
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private ReplicationStatus replicationStatus;
        private S3StorageClass storageClass;

        /// <summary>
        /// Flag which returns true if the Expires property has been unmarshalled
        /// from the raw value or set by user code.
        /// </summary>
        private bool isExpiresUnmarshalled;
        internal string RawExpires { get; set; }

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
            get 
            {
                if (this.serverSideEncryption == null)
                    return ServerSideEncryptionMethod.None;

                return this.serverSideEncryption; 
            }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
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


        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
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
    }
}
    
