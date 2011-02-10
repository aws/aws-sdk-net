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

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetObjectMetadataRequest contains the parameters used for the GetObjectMetadata operation.
    /// For more information about the optional parameters, 
    /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTObjectGET.html"/>
    /// <br />Required Parameters: BucketName, Key
    /// <br />Optional Parameters: ModifiedSinceDate, UnmodifiedSinceDate, ETagToMatch, ETagToNotMatch
    /// </summary>
    public class GetObjectMetadataRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string key;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private string etagToMatch;
        private string etagToNotMatch;
        private string versionId;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket that contains the S3 Object with
        /// the metadata you want.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region Key

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property for this request.
        /// This is the Key for the S3 Object's metadata you want.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithKey(string key)
        {
            this.key = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !System.String.IsNullOrEmpty(this.key);
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
        /// When this is set the S3 object metadata is returned 
        /// only if it has been modified since the specified time, 
        /// otherwise returns a 304 (not modified).
        /// </summary>
        /// <param name="modifiedSinceDate">The value that ModifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
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
        /// When this is set the S3 object metadata is returned only 
        /// if it has not been modified since the specified time, 
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="unmodifiedSinceDate">The value that UnmodifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
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
        /// When this is set the S3 object metadatais returned 
        /// only if its entity tag (ETag) is the same as the one 
        /// specified, otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="etagToMatch">The value that ETagToMatch is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithETagToMatch(string etagToMatch)
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
        /// When this is set the S3 object metadata is returned 
        /// only if its entity tag (ETag) is different from the one 
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="etagToNotMatch">The value that ETagToNotMatch is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithETagToNotMatch(string etagToNotMatch)
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

        #region VersionId

        /// <summary>
        /// Gets and sets the VersionId property.
        /// This is the VersionId for the S3 Object you want to Get Metatdata for.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the VersionId property for this request.
        /// This is the VersionId for the S3 Object you want to Get Metatdata for.
        /// </summary>
        /// <param name="versionId">The value that VersionId is set to</param>
        /// <returns>this instance</returns>
        public GetObjectMetadataRequest WithVersionId(string versionId)
        {
            this.versionId = versionId;
            return this;
        }

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return !System.String.IsNullOrEmpty(this.versionId);
        }

        #endregion
    }
}