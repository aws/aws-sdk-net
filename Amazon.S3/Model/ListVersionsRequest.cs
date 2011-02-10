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

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The ListVersionsRequest contains the parameters used for the ListVersions operation.
    /// <br />Required Parameters: BucketName
    /// <br />Optional Parameters: Prefix, KeyMarker, VersionIdMarker, MaxKeys, Delimiter
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class ListVersionsRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string prefix;
        private string keyMarker;
        private string versionIdMarker;
        private int maxKeys = -1;
        private string delimiter;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// This is the name of the S3 Bucket to list keys from.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the name of the S3 Bucket to list keys from.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set
        /// </summary>
        /// <returns>true if BucketName property is set</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region Prefix

        /// <summary>
        /// Gets and sets the Prefix property.
        /// All keys matched will have this prefix.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix=value; }
        }

        /// <summary>
        /// Sets the Prefix property for this request.
        /// All keys matched will have this prefix.
        /// </summary>
        /// <param name="prefix">The value that Prefix is set to</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithPrefix(string prefix)
        {
            this.prefix = prefix;
            return this;
        }

        /// <summary>
        /// Checks if Prefix property is set
        /// </summary>
        /// <returns>true if Prefix property is set</returns>
        internal bool IsSetPrefix()
        {
            return !System.String.IsNullOrEmpty(this.prefix);
        }

        #endregion

        #region KeyMarker

        /// <summary>
        /// Gets and sets the KeyMarker property.
        /// Specifies the key in the bucket you want to start
        /// listing from.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyMarker")]
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        /// <summary>
        /// Sets the KeyMarker property for this request.
        /// Specifies the key in the bucket you want to start
        /// listing from.
        /// </summary>
        /// <param name="marker">the value that KeyMarker is set to</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithKeyMarker(string marker)
        {
            this.keyMarker = marker;
            return this;
        }

        /// <summary>
        /// Checks if KeyMarker property is set
        /// </summary>
        /// <returns>true if KeyMarker property is set</returns>
        internal bool IsSetKeyMarker()
        {
            return !System.String.IsNullOrEmpty(KeyMarker);
        }

        #endregion

        #region VersionIdMarker

        /// <summary>
        /// Gets and sets the VersionIdMarker property.
        /// Specifies the object-version in the bucket you want to start
        /// listing from.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionIdMarker")]
        public string VersionIdMarker
        {
            get { return this.versionIdMarker; }
            set { this.versionIdMarker = value; }
        }

        /// <summary>
        /// Sets the VersionIdMarker property for this request.
        /// Specifies the objert-version in the bucket you want to start
        /// listing from.
        /// </summary>
        /// <param name="marker">the value that VersionIdMarker is set to</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithVersionIdMarker(string marker)
        {
            this.versionIdMarker = marker;
            return this;
        }

        /// <summary>
        /// Checks if VersionIdMarker property is set
        /// </summary>
        /// <returns>true if VersionIdMarker property is set</returns>
        internal bool IsSetVersionIdMarker()
        {
            return !System.String.IsNullOrEmpty(VersionIdMarker);
        }

        #endregion

        #region MaxKeys

        /// <summary>
        /// Gets and sets the MaxKeys property.
        /// Limits the result set of keys to MaxKeys.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxKeys")]
        public int MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        /// <summary>
        /// Sets the MaxKeys property for this request.
        /// Limits the result set of keys to MaxKeys.
        /// </summary>
        /// <param name="maxKeys">the value that MaxKeys is set to</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithMaxKeys(int maxKeys)
        {
            this.maxKeys = maxKeys;
            return this;
        }

        /// <summary>
        /// Checks if MaxKeys property is set
        /// </summary>
        /// <returns>true if MaxKeys property is set</returns>
        internal bool IsSetMaxKeys()
        {
            return this.maxKeys >= 0;
        }

        #endregion

        #region Delimiter

        /// <summary>
        /// Gets and sets the Delimiter property.
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection.
        /// </summary>
        /// <remarks>
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Delimiter")]
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Sets the Delimiter property for this request.
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection. 
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </summary>
        /// <param name="delimiter">the value that Delimiter is set to.</param>
        /// <returns>this instance</returns>
        public ListVersionsRequest WithDelimiter(string delimiter)
        {
            this.delimiter = delimiter;
            return this;
        }

        /// <summary>
        /// Checks if Delimiter property is set
        /// </summary>
        /// <returns>true if Delimiter property is set</returns>
        internal bool IsSetDelimiter()
        {
            return !System.String.IsNullOrEmpty(this.delimiter);
        }

        #endregion
    }
}