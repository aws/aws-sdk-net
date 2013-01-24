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

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to list object versions in a bucket.
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
        /// The name of the bucket containing the objects.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the objects.
       /// </summary>
        /// <param name="bucketName">The bucket name</param>
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
        /// Selects only those keys that begin with the specified prefix. 
        /// </summary>
        /// <remarks>
        /// Prefixes can be used to separate a bucket into different groupings of keys. 
        /// You can think of using prefix to make groups in the same way you'd use 
        /// a folder in a file system.) You can use prefix with delimiter to roll 
        /// up numerous objects into a single result under CommonPrefixes.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix=value; }
        }

        /// <summary>
        /// Selects only those keys that begin with the specified prefix. 
        /// </summary>
        /// <remarks>
        /// Prefixes can be used to separate a bucket into different groupings of keys. 
        /// You can think of using prefix to make groups in the same way you'd use 
        /// a folder in a file system.) You can use prefix with delimiter to roll 
        /// up numerous objects into a single result under CommonPrefixes.
        /// </remarks>
        /// <param name="prefix">The prefix value</param>
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
        /// Specifies the key in the bucket that you want to start listing from.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyMarker")]
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        /// <summary>
        /// Specifies the key in the bucket that you want to start listing from.
        /// </summary>
        /// <param name="marker">The key marker value</param>
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
        /// Specifies the object version you want to start listing from.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionIdMarker")]
        public string VersionIdMarker
        {
            get { return this.versionIdMarker; }
            set { this.versionIdMarker = value; }
        }

        /// <summary>
        /// Specifies the object version you want to start listing from.
        /// </summary>
        /// <param name="marker">The version id marker</param>
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
        /// Sets the maximum number of keys returned in the response body.
        /// Default: 1000. 
        /// </summary>
        /// <remarks>
        /// The response might contain fewer keys, but will never contain more. 
        /// If additional keys satisfy the search criteria, but were not returned 
        /// because max-keys was exceeded, the response object's IsTruncated
        /// property will be set to True.To return the additional keys, use the
        /// key-marker and version-id-marker properties on a subsequent request.
        /// </remarks>
        [XmlElementAttribute(ElementName = "MaxKeys")]
        public int MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        /// <summary>
        /// Sets the maximum number of keys returned in the response body.
        /// Default: 1000. 
        /// </summary>
        /// <remarks>
        /// The response might contain fewer keys, but will never contain more. 
        /// If additional keys satisfy the search criteria, but were not returned 
        /// because max-keys was exceeded, the response object's IsTruncated
        /// property will be set to True.To return the additional keys, use the
        /// key-marker and version-id-marker properties on a subsequent request.
        /// </remarks>
        /// <param name="maxKeys">The maximum keys to return</param>
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
        /// A character to group keys by. 
        /// </summary>
        /// <remarks>
        /// All keys that contain the same string between 
        /// the prefix and the first occurrence of the delimiter are grouped under a 
        /// single result element in CommonPrefixes. These groups are counted as one result 
        /// against the max-keys limitation. These keys are not returned elsewhere in the 
        /// response. 
        /// </remarks>
        [XmlElementAttribute(ElementName = "Delimiter")]
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// A character to group keys by. 
        /// </summary>
        /// <remarks>
        /// All keys that contain the same string between 
        /// the prefix and the first occurrence of the delimiter are grouped under a 
        /// single result element in CommonPrefixes. These groups are counted as one result 
        /// against the max-keys limitation. These keys are not returned elsewhere in the 
        /// response. 
        /// </remarks>
        /// <param name="delimiter">The delimiter value</param>
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