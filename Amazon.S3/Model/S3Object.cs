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
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

using Amazon.Util;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an S3 Object. Contains all attributes that an S3 Object has.
    ///
    /// For more information about S3 Objects refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/UsingObjects.html"/>
    /// </summary>
    public class S3Object
    {
        #region Private Members

        private string key;
        private DateTime? lastModified;
        private string eTag;
        private long size;
        private Owner owner;
        private string storageClass;
        private string bucketName;

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a System.String that represents the S3Object.
        /// </summary>
        /// <returns>A System.String representation of the S3Object.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Properties: {");
            if (IsSetKey())
            {
                sb.Append(String.Concat("Key:", Key));
            }
            sb.Append(String.Concat(", Bucket:", BucketName));
            sb.Append(String.Concat(", LastModified:", LastModified));
            sb.Append(String.Concat(", ETag:", ETag));
            sb.Append(String.Concat(", Size:", Size));
            sb.Append(String.Concat(", StorageClass:", StorageClass));
            sb.Append(", Owner Properties: {");
            sb.Append(String.Concat("Id:", Owner.Id));
            sb.Append(String.Concat(", DisplayName:", Owner.DisplayName));
            sb.Append("}}");

            return sb.ToString();
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
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !System.String.IsNullOrEmpty(this.key);
        }

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// This is the name of the S3 Bucket in which the
        /// key is stored.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
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

        #region LastModified

        /// <summary>
        /// Gets and sets the LastModified property.
        /// Date retrieved from S3 is in ISO8601 format.
        /// GMT formatted date is passed back to the user.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastModified")]
        public string LastModified
        {
            get
            {
                return this.lastModified.GetValueOrDefault().ToString(
                    AWSSDKUtils.GMTDateFormat
                    );
            }
            set
            {
                this.lastModified = DateTime.ParseExact(
                    value,
                    AWSSDKUtils.ISO8601DateFormat,
                    CultureInfo.InvariantCulture
                    );
            }
        }

        /// <summary>
        /// Checks if LastModified property is set.
        /// </summary>
        /// <returns>true if LastModified property is set.</returns>
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Checks if ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !System.String.IsNullOrEmpty(this.eTag);
        }

        #endregion

        #region Size

        /// <summary>
        /// Gets and sets the Size property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public long Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        #endregion

        #region Owner

        /// <summary>
        /// Gets and sets the Owner property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Owner")]
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        /// <summary>
        /// Checks if Owner property is set.
        /// </summary>
        /// <returns>true if Owner property is set.</returns>
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// Gets and sets the StorageClass property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StorageClass")]
        public string StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        /// <summary>
        /// Checks if StorageClass property is set.
        /// </summary>
        /// <returns>true if StorageClass property is set.</returns>
        internal bool IsSetStorageClass()
        {
            return !System.String.IsNullOrEmpty(this.storageClass);
        }

        #endregion
    }
}