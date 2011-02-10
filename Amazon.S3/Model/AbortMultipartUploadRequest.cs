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
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The AbortMultipartUploadRequest contains the parameters used for the AbortMultipartUpload method.
    /// <br />Required Parameters: BucketName, Key, UploadId
    /// </summary>
    public class AbortMultipartUploadRequest : S3Request
    {

        private string bucketName;
        private string key;
        private string uploadId;
    
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
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public AbortMultipartUploadRequest WithBucketName(string bucketName)
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
        /// This is the Key for the S3 Object.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public AbortMultipartUploadRequest WithKey(string key)
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

        #region UploadId
        /// <summary>
        /// Gets and sets the UploadId property.
        /// This is the upload id for the multipart upload in process.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Sets the UploadId property for this request.
        /// This is the upload id for the multipart upload in process.
        /// </summary>
        /// <param name="uploadId">The value that UploadId is set to</param>
        /// <returns>the request with the UploadId set</returns>
        public AbortMultipartUploadRequest WithUploadId(string uploadId)
        {
            this.uploadId = uploadId;
            return this;
        }

        /// <summary>
        /// Checks if UploadId property is set.
        /// </summary>
        /// <returns>true if UploadId property is set.</returns>
        internal bool IsSetUploadId()
        {
            return !System.String.IsNullOrEmpty(this.uploadId);
        }

        #endregion
    }
}
