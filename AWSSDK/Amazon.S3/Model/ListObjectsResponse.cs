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

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The ListObjectsResponse contains the list of S3Objects in the bucket and
    /// any headers returned by S3.
    /// </summary>
    /// <seealso cref="T:Amazon.S3.Model.ListObjectsRequest"/>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class ListObjectsResponse : S3Response
    {
        #region Private Members

        private string name;
        private List<S3Object> objects = new List<S3Object>();
        private List<string> commonPrefixes;
        private string prefix;
        private bool fIsTruncated;
        private string nextMarker;
        private string maxKeys;
        private string delimiter;

        #endregion

        #region Name

        /// <summary>
        /// Gets and sets the Name property.
        /// The bucket's name.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        #endregion

        #region Prefix

        /// <summary>
        /// Gets and sets the Prefix property.
        /// Keys that begin with the indicated prefix are listed.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        #endregion

        #region S3Objects

        /// <summary>
        /// Gets the S3Objects property. This is a list of 
        /// objects in the bucket that match your search criteria.
        /// </summary>
        [XmlElementAttribute(ElementName = "S3Objects")]
        public List<S3Object> S3Objects
        {
            get { return this.objects; }
        }

        #endregion

        #region NextMarker

        /// <summary>
        /// Gets and sets the NextMarker property.
        /// NextMarker is set by S3 only if a Delimiter was specified
        /// in the original ListObjects request. If a delimiter was
        /// not specified, the AWS SDK for .NET returns the last Key
        /// of the List of Objects retrieved from S3 as the NextMarker.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextMarker")]
        public string NextMarker
        {
            get
            {
                // If the list is truncated and there is at least
                // one object in the list returned and nextMarker
                // has not been populated with a value, use the
                // last returned Key as the default value.
                if (System.String.IsNullOrEmpty(nextMarker) &&
                    fIsTruncated &&
                    (objects.Count > 0))
                {
                    int lastObjIdx = objects.Count - 1;
                    nextMarker = objects[lastObjIdx].Key;
                }

                return nextMarker;
            }
            set { this.nextMarker = value; }
        }

        #endregion

        #region MaxKeys

        /// <summary>
        /// Gets and sets the MaxKeys property.
        /// This is the maximum number of keys in the S3Objects collection.
        /// The value is derived from the MaxKeys parameter to ListObjectsRequest.
        /// </summary>
        /// <seealso cref="P:Amazon.S3.Model.ListObjectsRequest.MaxKeys"/>
        [XmlElementAttribute(ElementName = "MaxKeys")]
        public string MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
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

        #endregion

        #region CommonPrefixes

        /// <summary>
        /// Gets the CommonPrefixes property. 
        /// A response can contain CommonPrefixes only if you specify a delimiter. 
        /// When you do, CommonPrefixes contains all (if there are any) keys between 
        /// Prefix and the next occurrence of the string specified by delimiter. In effect, 
        /// CommonPrefixes lists keys that act like subdirectories in the directory specified 
        /// by Prefix. For example, if prefix is notes/ and delimiter is a slash (/), in 
        /// notes/summer/july, the common prefix is notes/summer/.
        /// </summary>
        [XmlElementAttribute(ElementName = "CommonPrefixes")]
        public List<string> CommonPrefixes
        {
            get
            {
                if (this.commonPrefixes == null)
                {
                    this.commonPrefixes = new List<string>();
                }
                return this.commonPrefixes;
            }
        }

        #endregion

        #region CommonPrefix

        /// <summary>
        /// Returns the list of common prefixes returned by S3.
        /// This property has been deprecated. Please use the 
        /// CommonPrefixes property instead.
        /// <see cref="P:Amazon.S3.Model.ListObjectsResponse.CommonPrefixes"/>
        /// </summary>
        [XmlIgnore]
        [System.Obsolete("Use the CommonPrefixes property instead")]
        public List<string> CommonPrefix
        {
            get { return this.CommonPrefixes; }
        }

        #endregion

        #region IsTruncated
        /// <summary>
        /// Gets and Sets the IsTruncated property. 
        /// This property governs whether
        /// this is the last set of items that match the
        /// specified criteria or whether you need to make
        /// another call to S3 to retrieve more keys.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsTruncated")]
        public bool IsTruncated
        {
            get { return this.fIsTruncated; }
            set { this.fIsTruncated = value; }
        }

        #endregion
    }
}