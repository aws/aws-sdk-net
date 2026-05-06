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
 * Do not modify this file. This file is generated from the restjsondataplane-1999-12-31.normal.json service model.
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
namespace Amazon.RestJsonDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the CopyObject operation.
    /// <pre><c>From Amazon S3. CopyObject serializes a large set of headers. </c></pre>
    /// </summary>
    public partial class CopyObjectRequest : AmazonRestJsonDataPlaneRequest
    {
        private string _acl;
        private string _bucket;
        private bool? _bucketKeyEnabled;
        private string _cacheControl;
        private string _checksumAlgorithm;
        private string _contentDisposition;
        private string _contentEncoding;
        private string _contentLanguage;
        private string _contentType;
        private string _copySource;
        private string _copySourceIfMatch;
        private DateTime? _copySourceIfModifiedSince;
        private string _copySourceIfNoneMatch;
        private DateTime? _copySourceIfUnmodifiedSince;
        private string _copySourceSSECustomerAlgorithm;
        private string _copySourceSSECustomerKey;
        private string _copySourceSSECustomerKeyMD5;
        private string _expectedBucketOwner;
        private string _expectedSourceBucketOwner;
        private DateTime? _expires;
        private string _grantFullControl;
        private string _grantRead;
        private string _grantReadACP;
        private string _grantWriteACP;
        private string _ifMatch;
        private string _ifNoneMatch;
        private string _key;
        private string _metadataDirective;
        private string _objectLockLegalHoldStatus;
        private string _objectLockMode;
        private DateTime? _objectLockRetainUntilDate;
        private string _requestPayer;
        private string _serverSideEncryption;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
        private string _ssekmsEncryptionContext;
        private string _ssekmsKeyId;
        private string _storageClass;
        private string _tagging;
        private string _taggingDirective;
        private string _websiteRedirectLocation;

        /// <summary>
        /// Gets and sets the property ACL.
        /// </summary>
        public string ACL
        {
            get { return this._acl; }
            set { this._acl = value; }
        }

        // Check to see if ACL property is set
        internal bool IsSetACL()
        {
            return this._acl != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled.
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheControl.
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm.
        /// </summary>
        public string ChecksumAlgorithm
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
        /// Gets and sets the property ContentDisposition.
        /// </summary>
        public string ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        // Check to see if ContentDisposition property is set
        internal bool IsSetContentDisposition()
        {
            return this._contentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ContentEncoding.
        /// </summary>
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        // Check to see if ContentEncoding property is set
        internal bool IsSetContentEncoding()
        {
            return this._contentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLanguage.
        /// </summary>
        public string ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        // Check to see if ContentLanguage property is set
        internal bool IsSetContentLanguage()
        {
            return this._contentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property CopySource.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CopySource
        {
            get { return this._copySource; }
            set { this._copySource = value; }
        }

        // Check to see if CopySource property is set
        internal bool IsSetCopySource()
        {
            return this._copySource != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceIfMatch.
        /// </summary>
        public string CopySourceIfMatch
        {
            get { return this._copySourceIfMatch; }
            set { this._copySourceIfMatch = value; }
        }

        // Check to see if CopySourceIfMatch property is set
        internal bool IsSetCopySourceIfMatch()
        {
            return this._copySourceIfMatch != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceIfModifiedSince.
        /// </summary>
        public DateTime? CopySourceIfModifiedSince
        {
            get { return this._copySourceIfModifiedSince; }
            set { this._copySourceIfModifiedSince = value; }
        }

        // Check to see if CopySourceIfModifiedSince property is set
        internal bool IsSetCopySourceIfModifiedSince()
        {
            return this._copySourceIfModifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopySourceIfNoneMatch.
        /// </summary>
        public string CopySourceIfNoneMatch
        {
            get { return this._copySourceIfNoneMatch; }
            set { this._copySourceIfNoneMatch = value; }
        }

        // Check to see if CopySourceIfNoneMatch property is set
        internal bool IsSetCopySourceIfNoneMatch()
        {
            return this._copySourceIfNoneMatch != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceIfUnmodifiedSince.
        /// </summary>
        public DateTime? CopySourceIfUnmodifiedSince
        {
            get { return this._copySourceIfUnmodifiedSince; }
            set { this._copySourceIfUnmodifiedSince = value; }
        }

        // Check to see if CopySourceIfUnmodifiedSince property is set
        internal bool IsSetCopySourceIfUnmodifiedSince()
        {
            return this._copySourceIfUnmodifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopySourceSSECustomerAlgorithm.
        /// </summary>
        public string CopySourceSSECustomerAlgorithm
        {
            get { return this._copySourceSSECustomerAlgorithm; }
            set { this._copySourceSSECustomerAlgorithm = value; }
        }

        // Check to see if CopySourceSSECustomerAlgorithm property is set
        internal bool IsSetCopySourceSSECustomerAlgorithm()
        {
            return this._copySourceSSECustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceSSECustomerKey.
        /// </summary>
        public string CopySourceSSECustomerKey
        {
            get { return this._copySourceSSECustomerKey; }
            set { this._copySourceSSECustomerKey = value; }
        }

        // Check to see if CopySourceSSECustomerKey property is set
        internal bool IsSetCopySourceSSECustomerKey()
        {
            return this._copySourceSSECustomerKey != null;
        }

        /// <summary>
        /// Gets and sets the property CopySourceSSECustomerKeyMD5.
        /// </summary>
        public string CopySourceSSECustomerKeyMD5
        {
            get { return this._copySourceSSECustomerKeyMD5; }
            set { this._copySourceSSECustomerKeyMD5 = value; }
        }

        // Check to see if CopySourceSSECustomerKeyMD5 property is set
        internal bool IsSetCopySourceSSECustomerKeyMD5()
        {
            return this._copySourceSSECustomerKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner.
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
        /// Gets and sets the property Expires.
        /// </summary>
        public DateTime? Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this._expires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrantFullControl.
        /// </summary>
        public string GrantFullControl
        {
            get { return this._grantFullControl; }
            set { this._grantFullControl = value; }
        }

        // Check to see if GrantFullControl property is set
        internal bool IsSetGrantFullControl()
        {
            return this._grantFullControl != null;
        }

        /// <summary>
        /// Gets and sets the property GrantRead.
        /// </summary>
        public string GrantRead
        {
            get { return this._grantRead; }
            set { this._grantRead = value; }
        }

        // Check to see if GrantRead property is set
        internal bool IsSetGrantRead()
        {
            return this._grantRead != null;
        }

        /// <summary>
        /// Gets and sets the property GrantReadACP.
        /// </summary>
        public string GrantReadACP
        {
            get { return this._grantReadACP; }
            set { this._grantReadACP = value; }
        }

        // Check to see if GrantReadACP property is set
        internal bool IsSetGrantReadACP()
        {
            return this._grantReadACP != null;
        }

        /// <summary>
        /// Gets and sets the property GrantWriteACP.
        /// </summary>
        public string GrantWriteACP
        {
            get { return this._grantWriteACP; }
            set { this._grantWriteACP = value; }
        }

        // Check to see if GrantWriteACP property is set
        internal bool IsSetGrantWriteACP()
        {
            return this._grantWriteACP != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch.
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch.
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        // Check to see if IfNoneMatch property is set
        internal bool IsSetIfNoneMatch()
        {
            return this._ifNoneMatch != null;
        }

        /// <summary>
        /// Gets and sets the property Key.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataDirective.
        /// </summary>
        public string MetadataDirective
        {
            get { return this._metadataDirective; }
            set { this._metadataDirective = value; }
        }

        // Check to see if MetadataDirective property is set
        internal bool IsSetMetadataDirective()
        {
            return this._metadataDirective != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus.
        /// </summary>
        public string ObjectLockLegalHoldStatus
        {
            get { return this._objectLockLegalHoldStatus; }
            set { this._objectLockLegalHoldStatus = value; }
        }

        // Check to see if ObjectLockLegalHoldStatus property is set
        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this._objectLockLegalHoldStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockMode.
        /// </summary>
        public string ObjectLockMode
        {
            get { return this._objectLockMode; }
            set { this._objectLockMode = value; }
        }

        // Check to see if ObjectLockMode property is set
        internal bool IsSetObjectLockMode()
        {
            return this._objectLockMode != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate.
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate
        {
            get { return this._objectLockRetainUntilDate; }
            set { this._objectLockRetainUntilDate = value; }
        }

        // Check to see if ObjectLockRetainUntilDate property is set
        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this._objectLockRetainUntilDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public string RequestPayer
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
        /// Gets and sets the property ServerSideEncryption.
        /// </summary>
        public string ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryption()
        {
            return this._serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm.
        /// </summary>
        public string SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKey.
        /// </summary>
        public string SSECustomerKey
        {
            get { return this._sseCustomerKey; }
            set { this._sseCustomerKey = value; }
        }

        // Check to see if SSECustomerKey property is set
        internal bool IsSetSSECustomerKey()
        {
            return this._sseCustomerKey != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5.
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return this._sseCustomerKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property SSEKMSEncryptionContext.
        /// </summary>
        public string SSEKMSEncryptionContext
        {
            get { return this._ssekmsEncryptionContext; }
            set { this._ssekmsEncryptionContext = value; }
        }

        // Check to see if SSEKMSEncryptionContext property is set
        internal bool IsSetSSEKMSEncryptionContext()
        {
            return this._ssekmsEncryptionContext != null;
        }

        /// <summary>
        /// Gets and sets the property SSEKMSKeyId.
        /// </summary>
        public string SSEKMSKeyId
        {
            get { return this._ssekmsKeyId; }
            set { this._ssekmsKeyId = value; }
        }

        // Check to see if SSEKMSKeyId property is set
        internal bool IsSetSSEKMSKeyId()
        {
            return this._ssekmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass.
        /// </summary>
        public string StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Tagging.
        /// </summary>
        public string Tagging
        {
            get { return this._tagging; }
            set { this._tagging = value; }
        }

        // Check to see if Tagging property is set
        internal bool IsSetTagging()
        {
            return this._tagging != null;
        }

        /// <summary>
        /// Gets and sets the property TaggingDirective.
        /// </summary>
        public string TaggingDirective
        {
            get { return this._taggingDirective; }
            set { this._taggingDirective = value; }
        }

        // Check to see if TaggingDirective property is set
        internal bool IsSetTaggingDirective()
        {
            return this._taggingDirective != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation.
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this._websiteRedirectLocation; }
            set { this._websiteRedirectLocation = value; }
        }

        // Check to see if WebsiteRedirectLocation property is set
        internal bool IsSetWebsiteRedirectLocation()
        {
            return this._websiteRedirectLocation != null;
        }

    }
}