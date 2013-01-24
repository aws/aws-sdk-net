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
    /// The parameters to request the access control list (ACL) for a bucket or object.
    /// </summary>
    public class GetACLRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string key;
        private string versionId;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to be queried or containing the object to be queried.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to be queried or containing the object to be queried.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>this instance</returns>
        public GetACLRequest WithBucketName(string bucketName)
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
        /// Optional, the key of the S3 object to be queried.
        /// </summary>
        /// <remarks>
        /// If not set, the ACLs returned are those of the bucket.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of the S3 object to be queried (optional).
        /// </summary>
        /// <remarks>
        /// If not set, the ACLs returned are those of the bucket.
        /// </remarks>
        /// <param name="key">S3 object key</param>
        /// <returns>this instance</returns>
        public GetACLRequest WithKey(string key)
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

        #region VersionId

        /// <summary>
        /// The id of a specific version of the S3 object to query.
        /// </summary>
        /// <remarks>
        /// This field is ignored if the query is for bucket ACLs.
        /// </remarks>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the id of a specific version of the S3 object to query.
        /// </summary>
        /// <remarks>
        /// This field is ignored if the query is for bucket ACLs.
        /// </remarks>
        /// <param name="versionId">The id of the S3 object version</param>
        /// <returns>this instance</returns>
        public GetACLRequest WithVersionId(string versionId)
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