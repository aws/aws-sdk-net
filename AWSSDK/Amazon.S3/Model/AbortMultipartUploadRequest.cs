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
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request an abort of a multipart upload.
    /// </summary>
    /// <remarks>
    /// After a multipart upload is aborted, no additional parts can be uploaded using that upload ID. 
    /// The storage consumed by any previously uploaded parts will be freed. However, if any part uploads 
    /// are currently in progress, those part uploads might or might not succeed. As a result, it might be 
    /// necessary to abort a given multipart upload multiple times in order to completely free all storage 
    /// consumed by all parts.
    /// </remarks>
    public class AbortMultipartUploadRequest : S3Request
    {

        private string bucketName;
        private string key;
        private string uploadId;
    
        #region BucketName

        /// <summary>
        /// The name of the bucket containing the S3 object that was being uploaded in parts.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the S3 object that was being uploaded in parts.
        /// </summary>
        /// <param name="bucketName">S3 bucket name</param>
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
        /// The key of the S3 object that was being uploaded.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of the S3 object that was being uploaded.
        /// </summary>
        /// <param name="key">S3 object key</param>
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
        /// The upload id for the in-progress multipart upload that should be aborted.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Sets the upload id for the in-progress multipart upload that should be aborted.
        /// </summary>
        /// <param name="uploadId">Id of the multipart upload</param>
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
