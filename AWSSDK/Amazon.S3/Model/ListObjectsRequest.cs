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
    /// The parameters to list the object keys in a bucket.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class ListObjectsRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string prefix;
        private string marker;
        private int maxKeys = -1;
        private string delimiter;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket containing the objects whose keys are to be listed.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the objects whose keys are to be listed.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>this instance</returns>
        public ListObjectsRequest WithBucketName(string bucketName)
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
        /// Limits the response to keys which begin with the indicated prefix. You can 
        /// use prefixes to separate a bucket into different sets of keys in a way similar 
        /// to how a file system uses folders.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix=value; }
        }

        /// <summary>
        /// Limits the response to keys which begin with the indicated prefix. You can 
        /// use prefixes to separate a bucket into different sets of keys in a way similar 
        /// to how a file system uses folders.
        /// </summary>
        /// <param name="prefix">The prefix value</param>
        /// <returns>this instance</returns>
        public ListObjectsRequest WithPrefix(string prefix)
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

        #region Marker

        /// <summary>
        /// Indicates where in the bucket to begin listing. The list will only 
        /// include keys that occur lexicographically after marker. This is 
        /// convenient for pagination: to get the next page of results use the 
        /// last key of the current page as the marker.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Indicates where in the bucket to begin listing. The list will only 
        /// include keys that occur lexicographically after marker. This is 
        /// convenient for pagination: to get the next page of results use the 
        /// last key of the current page as the marker.
        /// </summary>
        /// <param name="marker">The marker value</param>
        /// <returns>this instance</returns>
        public ListObjectsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        internal bool IsSetMarker()
        {
            return !System.String.IsNullOrEmpty(this.marker);
        }

        #endregion

        #region MaxKeys

        /// <summary>
        /// The maximum number of keys you'd like to see in the response body. The 
        /// server might return fewer than this many keys, but will not return more.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxKeys")]
        public int MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        /// <summary>
        /// The maximum number of keys you'd like to see in the response body. The 
        /// server might return fewer than this many keys, but will not return more.
        /// </summary>
        /// <param name="maxKeys">The maximum keys value</param>
        /// <returns>this instance</returns>
        public ListObjectsRequest WithMaxKeys(int maxKeys)
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
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection. These rolled-up keys are not 
        /// returned elsewhere in the response.
        /// </summary>
        [XmlElementAttribute(ElementName = "Delimiter")]
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection. These rolled-up keys are not 
        /// returned elsewhere in the response.
        /// </summary>
        /// <param name="delimiter">The delimiter value</param>
        /// <returns>this instance</returns>
        public ListObjectsRequest WithDelimiter(string delimiter)
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