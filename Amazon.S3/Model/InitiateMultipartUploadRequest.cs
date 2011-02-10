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
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The InitiateMultipartUploadRequest contains the parameters used for the InitiateMultipartUpload method.
    /// <br />Required Parameters: BucketName, Key
    /// </summary>
    public class InitiateMultipartUploadRequest : S3Request
    {

        private string bucketName;
        private string key;
        private S3CannedACL cannedACL;
        private string contentType;
        internal NameValueCollection metaData;
        private S3StorageClass storageClass;

        

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket where the S3 Object you are
        /// creating gets put.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>The request with the BucketName set</returns>
        public InitiateMultipartUploadRequest WithBucketName(string bucketName)
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
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property for this request.
        /// This is the Key for the S3 Object you create.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public InitiateMultipartUploadRequest WithKey(string key)
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
        /// If set, the S3 Object will have this CannedACL
        /// permission. Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Sets the CannedACL property for this request.
        /// If set, the S3 Object will have this CannedACL
        /// permission. Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
        public InitiateMultipartUploadRequest WithCannedACL(S3CannedACL acl)
        {
            this.cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// Resets the CannedACL
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region ContentType
        /// <summary>
        /// Gets and sets the ContentType property.
        /// </summary>
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Sets the ContentType property for this request.
        /// This property defaults to "binary/octet-stream",
        /// but if you require something else you can set this property.
        /// </summary>
        /// <param name="contentType">the value the ContentType to be set to</param>
        /// <returns>The request with the ContentType set</returns>
        public InitiateMultipartUploadRequest WithContentType(string contentType)
        {
            this.contentType = contentType;
            return this;
        }

        /// <summary>
        /// Checks if ContentType property is set.
        /// </summary>
        /// <returns>true if ContentType property is set.</returns>
        internal bool IsSetContentType()
        {
            return !System.String.IsNullOrEmpty(this.contentType);
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Adds a key/value pair to the Metadata property for this request.
        /// The S3 Object that you create will have this metadata associated
        /// with it.
        /// </summary>
        /// <param name="key">The key to associate with the object</param>
        /// <param name="value">The value for the key</param>
        /// <returns>The response with Metadata set.</returns>
        public InitiateMultipartUploadRequest WithMetaData(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(5);
            }

            metaData.Add(key, value);

            return this;
        }

        /// <summary>
        /// Adds a set of key-value pairs to the request
        /// </summary>
        /// <param name="metaInfo">The set of key-value pairs that will eventually be
        /// associated with the S3 Object</param>
        /// <returns></returns>
        public InitiateMultipartUploadRequest WithMetaData(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(metaInfo.Count);
            }

            metaData.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetaData()
        {
            return (metaData != null && metaData.Count > 0);
        }

        /// <summary>
        /// Removes a key from the Metadata list if it was
        /// added previously
        /// </summary>
        /// <param name="key">The key to remove</param>
        public void RemoveMetaData(string key)
        {
            if (metaData == null || metaData.Count == 0)
            {
                return;
            }

            metaData.Remove(key);
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// Gets and sets the StorageClass property.
        /// Default: S3StorageClass.Standard. Set this property
        /// only if you want reduced redundancy for this object.
        /// Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set
            {
                if (value >= S3StorageClass.Standard &&
                    value <= S3StorageClass.ReducedRedundancy)
                {
                    this.storageClass = value;
                }
            }
        }

        /// <summary>
        /// Sets the StorageClass property for this request.
        /// Default: S3StorageClass.Standard. Set this property
        /// only if you want reduced redundancy for this object.
        /// Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </summary>
        /// <param name="sClass">The Storage Class to be set on the object</param>
        /// <returns>The request with the StorageClass set</returns>
        public InitiateMultipartUploadRequest WithStorageClass(S3StorageClass sClass)
        {
            this.storageClass = sClass;
            return this;
        }

        #endregion

    }
}
