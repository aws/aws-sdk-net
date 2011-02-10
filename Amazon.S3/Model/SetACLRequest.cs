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
    /// The SetACLRequest contains the parameters used for the SetACL operation.
    /// The BucketName is always required, the Key is optional and is to be set
    /// if you want the ACL for an object instead of a bucket.
    ///
    /// You can either set ACLs using CannedACLs or by providing an S3AccessControlList.
    /// <br />Required Parameters: BucketName
    /// <br />Optional Parameters: Key, CannedACL, ACL
    /// </summary>
    public class SetACLRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string key;
        private S3CannedACL cannedACL;
        private S3AccessControlList acl;
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
        /// This is either the S3 Bucket whose ACL you want to set,
        /// or the S3 Bucket that has the S3 Object whose ACL
        /// you want to set.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public SetACLRequest WithBucketName(string bucketName)
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
        /// This is the Key for the S3 Object whose ACL you
        /// want to set.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public SetACLRequest WithKey(string key)
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
        /// The S3 Object or S3 Bucket will be set to this
        /// CannedACL.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
        public SetACLRequest WithCannedACL(S3CannedACL acl)
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
            return (cannedACL > S3CannedACL.NoACL &&
                cannedACL <= S3CannedACL.BucketOwnerFullControl);
        }

        /// <summary>
        /// Resets the S3CannedACL associated with this request
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region ACL

        /// <summary>
        /// Gets and sets the ACL property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ACL")]
        public S3AccessControlList ACL
        {
            get { return this.acl; }
            set { this.acl = value; }
        }

        /// <summary>
        /// Sets the ACL property for this request.
        /// The S3 Object or S3 Bucket will be set to this
        /// S3AccessControlList.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the ACL set</returns>
        public SetACLRequest WithACL(S3AccessControlList acl)
        {
            this.acl = acl;
            return this;
        }

        /// <summary>
        /// Checks if the ACL property is set.
        /// </summary>
        /// <returns>true if ACL property is set.</returns>
        internal bool IsSetACL()
        {
            return this.acl != null;
        }

        #endregion

        #region VersionId

        /// <summary>
        /// Gets and sets the VersionId property.
        /// This is the Version Id of the S3 Object for 
        /// which the ACL will be set. This property
        /// is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the VersionId property for this request.
        /// This is the Version Id of the S3 Object for 
        /// which the ACL will be set. This property
        /// is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        /// <param name="versionId">The value that VersionId is set to</param>
        /// <returns>this instance</returns>
        public SetACLRequest WithVersionId(string versionId)
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