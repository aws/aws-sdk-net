/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The CopyObjectRequest contains the parameters used for the CopyObject operation.
    /// For more information about the optional parameters, refer: 
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTObjectCOPY.html"/>
    /// <br />Required Parameters: SourceBucket, SourceKey, DestinationBucket 
    /// <br />Optional Parameters: DestinationKey, ETagToMatch, ETagToNotMatch, ModifiedSinceDate,
    /// UnmodifiedSinceDate, Directive, Metadata, CannedACL, Timeout, SourceVersionId,
    /// StorageClass
    /// </summary>
    public class CopyObjectRequest : S3Request
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
        private int timeout = 0;
        private S3StorageClass storageClass;

        #endregion

        #region SourceBucket

        /// <summary>
        /// Gets and sets the SourceBucket property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceBucket")]
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }

        /// <summary>
        /// Sets the SourceBucket property for this request.
        /// This is the S3Bucket that contains the S3 Object you
        /// want to copy.
        /// </summary>
        /// <param name="srcBucket">The value that SourceBucket is set to</param>
        /// <returns>the response with the SourceBucket set</returns>
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
        /// Gets and sets the SourceKey property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceKey")]
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Sets the SourceKey property for this request.
        /// This is the S3Object you want to copy.
        /// </summary>
        /// <param name="srcKey">The value that SourceKey is set to</param>
        /// <returns>the response with the SourceKey set</returns>
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
        /// Gets and sets the DestinationBucket property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationBucket")]
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Sets the DestinationBucket property for this request.
        /// This is the S3 Bucket where the copied S3 Object is put.
        /// </summary>
        /// <param name="dstBucket">The value that DestinationBucket is set to</param>
        /// <returns>the response with the DestinationBucket set</returns>
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
        /// Gets and sets the DestinationKey property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationKey")]
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }

        /// <summary>
        /// Sets the DestinationKey property for this request.
        /// This is the key for the new S3 Object that is copied.
        /// </summary>
        /// <param name="dstKey">The value that DestinationKey is set to</param>
        /// <returns>the response with the Destinationkey set</returns>
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
        /// Gets and sets the ContentType property.
        /// </summary>
        /// <remarks>
        /// This property defaults to "binary/octet-stream",
        /// but if you require something else you can set this property.
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
        /// Sets the ContentType property for this request.
        /// </summary>
        /// <param name="contentType">the value the ContentType to be set to</param>
        /// <returns>The request with the ContentType set</returns>
        /// <remarks>
        /// This property defaults to "binary/octet-stream",
        /// but if you require something else you can set this property.
        /// This property is passed on to S3 only if the metadata
        /// directive is REPLACE.
        /// </remarks>
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
        /// Gets and sets the ETagToMatch property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToMatch")]
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        /// <summary>
        /// Sets the ETagToMatch property for this request.
        /// Copies the object if its entity tag (ETag) matches
        /// the specified tag; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </summary>
        /// <param name="etagToMatch">The value that ETagToMatch is set to</param>
        /// <returns>this instance</returns>
        public CopyObjectRequest WithETagToMatch(string etagToMatch)
        {
            this.etagToMatch = etagToMatch;
            return this;
        }

        /// <summary>
        /// Checks if ETagToMatch property is set.
        /// </summary>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToMatch);
        }

        #endregion

        #region ETagToNotMatch
        /// <summary>
        /// Gets and sets the ETagToNotMatch property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToNotMatch")]
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Sets the ETagToNotMatch property for this request.
        /// Copies the object if its entity tag (ETag) is different
        /// than the specified Etag; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </summary>
        /// <param name="etagToNotMatch">The value that ETagToNotMatch is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the ModifiedSinceDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ModifiedSinceDate")]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Sets the ModifiedSinceDate property for this request.
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </summary>
        /// <param name="modifiedSinceDate">The value that ModifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the UnmodifiedSinceDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "UnmodifiedSinceDate")]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Sets the UnmodifiedSinceDate property for this request.
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </summary>
        /// <param name="unmodifiedSinceDate">The value that UnmodifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Directive property. Default is COPY.
        /// </summary>
        /// <remarks>
        /// Specifies whether the metadata is copied from
        /// the source object or replaced with metadata
        /// provided in the request. If COPY, the metadata remains
        /// unchanged, otherwise, all original metadata is
        /// replaced by the metadata you specify.
        /// You cannot copy an object to itself unless the Directive
        /// property is specified and its value set to REPLACE.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Directive")]
        public S3MetadataDirective Directive
        {
            get { return this.directive; }
            set { this.directive = value; }
        }

        /// <summary>
        /// Sets the Directive property for this request. The
        /// default value for the directive is COPY.
        /// </summary>
        /// <param name="directive">The value that Directive is set to</param>
        /// <returns>the response with the Directive set</returns>
        /// <remarks>
        /// Specifies whether the metadata is copied from
        /// the source object or replaced with metadata
        /// provided in the request. If COPY, the metadata remains
        /// unchanged, otherwise, all original metadata is
        /// replaced by the metadata you specify.
        /// You cannot copy an object to itself unless the Directive
        /// property is specified and its value set to REPLACE.
        /// </remarks>
        public CopyObjectRequest WithDirective(S3MetadataDirective directive)
        {
            this.directive = directive;
            return this;
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Adds a key/value pair to the Metadata property for this request.
        /// The S3 Object that you copy will have this metadata associated
        /// with it.
        /// </summary>
        /// <param name="key">The key to associate with the object</param>
        /// <param name="value">The value for the key</param>
        /// <returns>The response with Metadata set.</returns>
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
        /// Adds a set of key-value pairs to the request
        /// </summary>
        /// <param name="metaInfo">The set of key-value pairs that will eventually be
        /// associated with the S3 Object</param>
        /// <returns></returns>
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
        /// Removes a key from the Metadata list if it was
        /// added previously
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
        /// Gets and sets the CannedACL property.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Sets the CannedACL property for this request.
        /// If set the S3 Object will have this CannedACL
        /// permission.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
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
        /// Resets the S3CannedACL
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Gets and sets of the Timeout property (in milliseconds).
        /// The value of this property is assigned to the
        /// ReadWriteTimeout and Timeout properties of the
        /// HTTPWebRequest object used for S3 COPY requests.
        /// </summary>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this.timeout; }
            set
            {
                if (value > 0)
                {
                    this.timeout = value;
                }
            }
        }

        /// <summary>
        /// Sets the Timeout property (in milliseconds).
        /// Please set the timeout only if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public CopyObjectRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        internal override bool SupportTimeout
        {
            get { return true; }
        }

        #endregion

        #region SourceVersionId

        /// <summary>
        /// Gets and sets the SourceVersionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceVersionId")]
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Sets the SourceVersionId property for this request.
        /// This is the SourceVersionId for the S3 Object you want to Get.
        /// </summary>
        /// <param name="srcVersionId">The value that SourceVersionId is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the StorageClass property.
        /// Default: The S3StorageClass of the source object.
        /// Set this property only if you want to change the storage 
        /// class of the destination object. Please refer
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </summary>
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
        /// Sets the StorageClass property for the destination object.
        /// Default: The S3StorageClass of the source object.
        /// Set this property only if you want to change the storage 
        /// class of the destination object. Please refer
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </summary>
        /// <param name="sClass">The Storage Class to be set on the object</param>
        /// <returns>The request with the StorageClass set</returns>
        public CopyObjectRequest WithStorageClass(S3StorageClass sClass)
        {
            this.StorageClass = sClass;
            return this;
        }

        #endregion

    }
}