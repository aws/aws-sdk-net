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
    /// The parameters to set an access control list (ACL) on a bucket or S3 object.
    /// You can use either CannedACLs or provide an S3AccessControlList for custom ACLs.
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
        /// The name of the bucket.
        /// If an object key is not specified, the ACLs are applied to the bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// The name of the bucket.
        /// If an object key is not specified, the ACLs are applied to the bucket.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The key of an S3 object.
        /// If not specified, the ACLs are applied to the bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of an S3 object.
        /// If not specified, the ACLs are applied to the bucket.
        /// </summary>
        /// <param name="key">The object key</param>
        /// <returns>the request with the Key set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Canned ACL to apply to the bucket or object.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Sets a canned ACL to apply to the bucket or object.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set</param>
        /// <returns>The request with the CannedACL set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
                cannedACL <= S3CannedACL.LogDeliveryWrite);
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
        /// Custom ACLs to be applied to the bucket or object.
        /// </summary>
        [XmlElementAttribute(ElementName = "ACL")]
        public S3AccessControlList ACL
        {
            get { return this.acl; }
            set { this.acl = value; }
        }

        /// <summary>
        /// Sets the custom ACLs to be applied to the bucket or object.
        /// </summary>
        /// <param name="acl">The custom ACLs to be</param>
        /// <returns>The request with the ACL set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// If set and an object key has been specified, the ACLs are applied
        /// to the specific version of the object.
        /// This property is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// If set and an object key has been specified, the ACLs are applied
        /// to the specific version of the object.
        /// This property is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        /// <param name="versionId">The object version identifier</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
