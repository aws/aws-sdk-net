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
    /// The ListVersionsResponse contains the list of Versions in the bucket and
    /// any headers returned by S3.
    /// </summary>
    /// <seealso cref="T:Amazon.S3.Model.ListVersionsRequest"/>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class ListVersionsResponse : S3Response
    {
        #region Private Members

        private string name;
        private string prefix;
        private List<S3ObjectVersion> versions = new List<S3ObjectVersion>();
        private bool fIsTruncated;
        private string maxKeys;
        private string delimiter;
        private string keyMarker;
        private string versionIdMarker;
        private string nextKeyMarker;
        private string nextVersionIdMarker;

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

        #region Versions

        /// <summary>
        /// Gets and sets the Versions property. This is a list of 
        /// object versions in the bucket that match your search criteria.
        /// </summary>
        [XmlElementAttribute(ElementName = "Versions")]
        public List<S3ObjectVersion> Versions
        {
            get { return this.versions; }
        }

        #endregion

        #region MaxKeys

        /// <summary>
        /// Gets and sets the MaxKeys property.
        /// This is the maximum number of keys in the S3ObjectVersions collection.
        /// The value is derived from the MaxKeys parameter to ListVersionsRequest.
        /// </summary>
        /// <seealso cref="P:Amazon.S3.Model.ListVersionsRequest.MaxKeys"/>
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

        #region KeyMarker

        /// <summary>
        /// Gets and sets the KeyMarker property.
        /// Marks the last Key returned in a truncated response.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyMarker")]
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        #endregion

        #region VersionIdMarker

        /// <summary>
        /// Gets and sets the VersionIdMarker property.
        /// Marks the last Version-Id returned in a truncated response.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionIdMarker")]
        public string VersionIdMarker
        {
            get { return this.versionIdMarker; }
            set { this.versionIdMarker = value; }
        }

        #endregion

        #region NextKeyMarker

        /// <summary>
        /// Gets and sets the NextKeyMarker property.
        /// When the number of responses exceeds the value of MaxKeys, 
        /// NextKeyMarker specifies the first key not returned that 
        /// satisfies the search criteria. Use this value for the 
        /// KeyMarker request parameter in a subsequent request.
        /// </summary>
        /// <seealso cref="P:Amazon.S3.Model.ListVersionsRequest.KeyMarker"/>
        [XmlElementAttribute(ElementName = "NextKeyMarker")]
        public string NextKeyMarker
        {
            get { return this.nextKeyMarker; }
            set { this.nextKeyMarker = value; }
        }

        #endregion

        #region NextVersionIdMarker

        /// <summary>
        /// Gets and sets the NextVersionIdMarker property.
        /// When the number of responses exceeds the value of MaxKeys, 
        /// NextVersionIdMarker specifies the first version not returned that 
        /// satisfies the search criteria. Use this value for the 
        /// VersionIdMarker request parameter in a subsequent request.
        /// </summary>
        /// <seealso cref="P:Amazon.S3.Model.ListVersionsRequest.VersionIdMarker"/>
        [XmlElementAttribute(ElementName = "NextVersionIdMarker")]
        public string NextVersionIdMarker
        {
            get { return this.nextVersionIdMarker; }
            set { this.nextVersionIdMarker = value; }
        }

        #endregion
    }
}