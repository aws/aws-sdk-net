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
    /// The parameters to request deletion of an object in a bucket. 
    /// The operation removes the null version (if there is one) of an object and inserts a delete marker, which 
    /// becomes the latest version of the object.
    /// </summary>
    /// <remarks>
    /// <para>
    /// To remove a specific version, you must be the bucket owner and you must use the versionId subresource. 
    /// Using this subresource permanently deletes the version.
    /// </para>
    /// <para>
    /// If the object you want to delete is in a bucket where the bucket versioning configuration is MFA Delete enabled, 
    /// you must include specify the MFA serial number and value in the request.
    /// </para>
    /// <para>
    /// If there isn't a null version, Amazon S3 does not remove any objects.     
    /// </para>
    /// </remarks>
    public class DeleteObjectRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string key;
        private string versionId;
        private Tuple<string, string> mfaCodes;

        #endregion

        #region BucketName
        /// <summary>
        /// The name of the bucket containing the object to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the object to delete.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        public DeleteObjectRequest WithBucketName(string bucketName)
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
        /// The key identifying the object to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key identifying the object to delete.
        /// </summary>
        /// <param name="key">Object key</param>
        /// <returns>the request with the Key set</returns>
        public DeleteObjectRequest WithKey(string key)
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
        /// The identifier for the specific version of the object to be deleted, if required.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the identifier for the specific version of the object to be deleted, if required.
        /// </summary>
        /// <param name="versionId">Version ID</param>
        /// <returns>this instance</returns>
        public DeleteObjectRequest WithVersionId(string versionId)
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

        #region MfaCodes

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        [XmlIgnore]
        public Tuple<string, string> MfaCodes
        {
            get
            {
                if (this.mfaCodes == null)
                {
                    this.mfaCodes = new Tuple<string, string>("", "");
                }
                return this.mfaCodes;
            }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        /// <param name="serial">Serial number of the authentication device</param>
        /// <param name="token">Token displayed on the authentication device</param>
        /// <returns>this instance</returns>
        public DeleteObjectRequest WithMfaCodes(string serial, string token)
        {
            mfaCodes = new Tuple<string, string>(serial, token);
            return this;
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.First)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.Second));
        }

        #endregion
    }
}