/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Xml.Serialization;
using System.Collections.Specialized;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request a copy an existing S3 object to another, possibly new, S3 object. The source object
    /// may be copied to another object in the same or a different bucket.
    /// </summary>
    public class CopyObjectRequest : S3PutWithACLRequest
    {
        #region Private Members

        private string srcBucket;
        private string srcKey;
        private string srcVersionId;
        private string dstBucket;
        private string dstKey;
        private string contentType;
        private string etagToMatch;
        private string etagToNotMatch;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private S3MetadataDirective directive;
        internal NameValueCollection metaData;
        private S3CannedACL cannedACL;
        private S3StorageClass storageClass;
        private ServerSideEncryptionMethod encryption;
        private string websiteRedirectLocation;

        #endregion

        #region SourceBucket

        /// <summary>
        /// The name of the bucket containing the object to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceBucket")]
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the object to copy.
        /// </summary>
        /// <param name="srcBucket">Name of the bucket containing the object to copy</param>
        /// <returns>the request with the SourceBucket set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithSourceBucket(string srcBucket)
        {
            this.srcBucket = srcBucket;
            return this;
        }

        /// <summary>
        /// Checks if SourceBucket property is set.
        /// </summary>
        /// <returns>true if SourceBucket property is set.</returns>
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this.srcBucket);
        }

        #endregion

        #region SourceKey
        /// <summary>
        /// The key of the object to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceKey")]
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Sets the key of the object to copy.
        /// </summary>
        /// <param name="srcKey">Key of the S3 object to copy</param>
        /// <returns>the request with the SourceKey set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithSourceKey(string srcKey)
        {
            this.srcKey = srcKey;
            return this;
        }

        /// <summary>
        /// Checks if SourceKey property is set.
        /// </summary>
        /// <returns>true if SourceKey property is set.</returns>
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this.srcKey);
        }

        #endregion

        #region DestinationBucket
        /// <summary>
        /// The name of the bucket to contain the copy of the source object.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationBucket")]
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to contain the copy of the source object.
        /// </summary>
        /// <param name="dstBucket">Name of the bucket to contain the copy</param>
        /// <returns>the request with the DestinationBucket set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithDestinationBucket(string dstBucket)
        {
            this.dstBucket = dstBucket;
            return this;
        }

        /// <summary>
        /// Checks if DestinationBucket property is set.
        /// </summary>
        /// <returns>true if DestinationBucket property is set.</returns>
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this.dstBucket);
        }
        #endregion

        #region DestinationKey
        /// <summary>
        /// The key to be given to the copy of the source object.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationKey")]
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }

        /// <summary>
        /// Sets the key to be given to the copy of the source object.
        /// </summary>
        /// <param name="dstKey">Key of the copy of the source object</param>
        /// <returns>the response with the Destinationkey set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithDestinationKey(string dstKey)
        {
            this.dstKey = dstKey;
            return this;
        }

        /// <summary>
        /// Checks if DestinationKey property is set.
        /// </summary>
        /// <returns>true if DestinationKey property is set.</returns>
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this.dstKey);
        }

        #endregion

        #region ContentType

        /// <summary>
        /// A standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// This property is passed on to S3 only if the metadata
        /// directive is REPLACE.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ContentType")]
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Sets a standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        /// This property is passed on to S3 only if the metadata
        /// directive is REPLACE.
        /// <param name="contentType">Content type to be set</param>
        /// <returns>The request with the ContentType set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithContentType(string contentType)
        {
            this.contentType = contentType;
            return this;
        }

        /// <summary>
        /// Checks if ContentType property is set.
        /// </summary>
        /// <returns>true if ContentType property is set.</returns>
        internal bool IsSetContentType()
        {
            return !System.String.IsNullOrEmpty(this.contentType);
        }

        #endregion

        #region ETagToMatch

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
        [XmlElementAttribute(ElementName = "ETagToMatch")]
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        /// <summary>
        /// Sets an ETag to be matched as a pre-condition for copying the source object,
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches 
        /// the specified tag; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagToMatch">The ETag value to be matched</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithETagToMatch(string etagToMatch)
        {
            this.etagToMatch = etagToMatch;
            return this;
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

        #endregion

        #region ETagToNotMatch
        /// <summary>
        /// ETag that must not be matched as a pre-condition for copying the source object,
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToNotMatch")]
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Sets an ETag that must not be matched as a pre-condition for copying the source object,
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) is different
        /// than the specified Etag; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagToNotMatch">The value that ETagToNotMatch is set to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithETagToNotMatch(string etagToNotMatch)
        {
            this.etagToNotMatch = etagToNotMatch;
            return this;
        }

        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToNotMatch);
        }

        #endregion

        #region ModifiedSinceDate
        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ModifiedSinceDate")]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
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
        /// <param name="modifiedSinceDate">The date/time to check the modification timestamp against</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
        {
            this.modifiedSinceDate = modifiedSinceDate;
            return this;
        }

        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDate property is set.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        #endregion

        #region UnmodifiedSinceDate

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "UnmodifiedSinceDate")]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
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
        /// <param name="unmodifiedSinceDate">The date/time to check the modification timestamp against</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
        {
            this.unmodifiedSinceDate = unmodifiedSinceDate;
            return this;
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        #endregion

        #region Directive

        /// <summary>
        /// <para>
        /// Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request.
        /// </para>
        /// <para>
        /// Valid values: COPY | REPLACE. Default: COPY.
        /// </para>
        /// </summary>
        /// <remarks>
        /// If Directive is set to COPY, the metadata remains unchanged, otherwise, all original metadata is
        /// replaced by the metadata you specify. You cannot copy an object to itself unless the Directive 
        /// property is specified and its value set to REPLACE.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Directive")]
        public S3MetadataDirective Directive
        {
            get { return this.directive; }
            set { this.directive = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request.
        /// </para>
        /// <para>
        /// Valid values: COPY | REPLACE. Default: COPY.
        /// </para>
        /// </summary>
        /// <remarks>
        /// If Directive is set to COPY, the metadata remains unchanged, otherwise, all original metadata is
        /// replaced by the metadata you specify. You cannot copy an object to itself unless the Directive 
        /// property is specified and its value set to REPLACE.
        /// </remarks>
        /// <param name="directive">Metadata directive</param>
        /// <returns>the request with the Directive set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithDirective(S3MetadataDirective directive)
        {
            this.directive = directive;
            return this;
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Specifies a metadata name-value pair to set for the object. If MetadataDirective is set to COPY, all metadata is ignored.
        /// </summary>
        /// <param name="key">The key to associate with the object</param>
        /// <param name="value">The value for the key</param>
        /// <returns>The request with Metadata set.</returns>
        public CopyObjectRequest WithMetaData(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(5);
            }

            metaData.Add(key, value);

            return this;
        }

        /// <summary>
        /// Specifies a set of metadata name-value pairs to set for the object. If MetadataDirective is set to COPY, all metadata is ignored.
        /// </summary>
        /// <param name="metaInfo">The set of key-value pairs that will be associated with the S3 Object</param>
        /// <returns>The request with Metadata set.</returns>
        public CopyObjectRequest WithMetaData(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(metaInfo.Count);
            }

            metaData.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetaData()
        {
            return (metaData != null && metaData.Count > 0);
        }

        /// <summary>
        /// Removes a key from the Metadata list if it was added previously
        /// </summary>
        /// <param name="key">The key to remove</param>
        public void RemoveMetaData(string key)
        {
            if (metaData == null || metaData.Count == 0)
            {
                return;
            }

            metaData.Remove(key);
        }

        #endregion

        #region CannedACL

        /// <summary>
        /// An S3 canned access control list to apply to the new copy of the object.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// An S3 canned access control list to apply to the new copy of the object.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithCannedACL(S3CannedACL acl)
        {
            this.cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the S3CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the S3CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// Resets the S3CannedACL to 'none' (S3CannedACL.NoACL).
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Custom timeout value (in milliseconds) to set in the HttpWebRequest object used for the request.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// <para>
        /// You should only set a custom timeout if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </para>
        /// </remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public CopyObjectRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        #endregion

        #region ReadWriteTimeout

        /// <summary>
        /// Custom read-write timeout value (in milliseconds) to set in the HttpWebRequest object used for the request.
        /// </summary>
        /// <param name="readWriteTimeout">ReadWriteTimeout property</param>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public CopyObjectRequest WithReadWriteTimeout(int readWriteTimeout)
        {
            ReadWriteTimeout = readWriteTimeout;
            return this;
        }

        #endregion

        #region SourceVersionId

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceVersionId")]
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        /// <param name="srcVersionId">Id of the version of the source object to be copied</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithSourceVersionId(string srcVersionId)
        {
            this.srcVersionId = srcVersionId;
            return this;
        }

        /// <summary>
        /// Checks if SourceVersionId property is set.
        /// </summary>
        /// <returns>true if SourceVersionId property is set.</returns>
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this.srcVersionId);
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// S3 storage class for the copy of the source object. By default the new object uses the same storage class as the source object.
        /// </summary>
        /// <remarks>
        /// Set this property only if you want to change the storage 
        /// class of the destination object. Please refer
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set
            {
                if (value >= S3StorageClass.Standard &&
                    value <= S3StorageClass.ReducedRedundancy)
                {
                    this.storageClass = value;
                }
            }
        }

        /// <summary>
        /// S3 storage class for the copy of the source object. By default the new object uses the same storage class as the source object.
        /// </summary>
        /// <remarks>
        /// Set this property only if you want to change the storage 
        /// class of the destination object. Please refer
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        /// <param name="sClass">The storage class to be set on the new object</param>
        /// <returns>The request with the StorageClass set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithStorageClass(S3StorageClass sClass)
        {
            this.StorageClass = sClass;
            return this;
        }

        #endregion

        #region Grants

        /// <summary>
        /// Adds a set of Custom Access Control Lists to be applied to the new object.
        /// </summary>
        /// <remarks>
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </remarks>
        /// <param name="grants">One or more S3 Grants.</param>
        /// <returns>The request with the Grants set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithGrants(params S3Grant[] grants)
        {
            this.Grants.AddRange(grants);
            return this;
        }

        #endregion

        #region ServerSideEncryption

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        /// <param name="encryption">ServerSideEncryptionMethod for the new object</param>
        /// <returns>The response with the ServerSideEncryptionMethod set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
        }

        #endregion

        #region Website Redirect Location
        /// <summary>
        /// Sets the WebsiteRedirectLocation property on the new object so that when a GET request 
        /// is made from the S3 website endpoint a 301 HTTP status code will be returned indicating 
        /// a redirect with the specified value as the redirect location.
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        /// <summary>
        /// Sets the WebsiteRedirectLocation property on the new object so that when a GET request 
        /// is made from the S3 website endpoint a 301 HTTP status code will be returned indicating 
        /// a redirect with the specified value as the redirect location.
        /// </summary>
        /// <param name="websiteRedirectLocation">The redirect value to be returned on a GET request</param>
        /// <returns>the request with the WebsiteRedirectLocation set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyObjectRequest WithWebsiteRedirectLocation(string websiteRedirectLocation)
        {
            this.websiteRedirectLocation = websiteRedirectLocation;
            return this;
        }

        /// <summary>
        /// Checks if WebsiteRedirectLocation property is set.
        /// </summary>
        /// <returns>true if WebsiteRedirectLocation property is set.</returns>
        internal bool IsSetWebsiteRedirectLocation()
        {
            return !System.String.IsNullOrEmpty(this.websiteRedirectLocation);
        }

        #endregion

    }
}
