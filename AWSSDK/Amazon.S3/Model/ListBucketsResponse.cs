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
    /// The ListBucketsResponse contains the ListBucketsResult and
    /// any headers or metadata returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class ListBucketsResponse : S3Response
    {
        #region Private Members

        private List<S3Bucket> buckets = new List<S3Bucket>();
        private Owner owner;

        #endregion

        #region Bucket

        /// <summary>
        /// Gets the Bucket property. This property has been deprecated -
        /// please use the Buckets property of ListBucketsResponse.
        /// <see cref="P:Amazon.S3.Model.ListBucketsResponse.Buckets"/>
        /// </summary>
        [XmlIgnore]
        [System.Obsolete("Use the Buckets property instead")]
        public List<S3Bucket> Bucket
        {
            get { return this.Buckets; }
        }

        #endregion

        #region Buckets

        /// <summary>
        /// Gets the Buckets property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Buckets")]
        public List<S3Bucket> Buckets
        {
            get { return this.buckets; }
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

        #endregion
    }
}