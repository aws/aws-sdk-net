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
    /// The DeleteObjectRequest contains the parameters used for the DeleteObject operation.
    /// <br />Required Parameters: BucketName, Key
    /// <br />The MfaCodes property is required if the bucket containing this object has been
    /// configured with the EnableMfaDelete property. For more information, please see:
    /// <see cref="P:Amazon.S3.Model.S3BucketVersioningConfig.EnableMfaDelete"/>.
    /// </summary>
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
        /// This is the S3 Bucket that contains the S3 Object
        /// you want to delete.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
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
        /// This is the Key for the S3 Object you want to delete.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
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
        /// Gets and sets the VersionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the VersionId property for this request.
        /// This is the VersionId for the S3 Object you want to Delete.
        /// </summary>
        /// <param name="versionId">The value that VersionId is set to</param>
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
        /// Gets and Sets the MfaCodes property.
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account. This is a required property for this
        /// request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </summary>
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
        /// Sets the MfaCodes property.
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account. This is a required property for this
        /// request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </summary>
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