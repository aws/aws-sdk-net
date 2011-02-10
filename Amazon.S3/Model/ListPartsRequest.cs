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
    /// The ListPartsRequest contains the parameters used for the ListParts method.
    /// <br />Required Parameters: BucketName, Key, UploadId
    /// </summary>
    public class ListPartsRequest : S3Request
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private int? maxParts;
        private string partNumberMarker;

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
        public ListPartsRequest WithBucketName(string bucketName)
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
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public ListPartsRequest WithKey(string key)
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
        /// <param name="uploadId">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public ListPartsRequest WithUploadId(string uploadId)
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

        #region MaxParts

        /// <summary>
        /// Gets and sets the MaxParts property.
        /// </summary>
        public int MaxParts
        {
            get { return this.maxParts.GetValueOrDefault(); }
            set { this.maxParts = value; }
        }

        /// <summary>
        /// Sets the MaxParts property for this request.
        /// </summary>
        /// <param name="maxParts">The value that MaxParts is set to</param>
        /// <returns>the request with the MaxParts set</returns>
        public ListPartsRequest WithMaxParts(int maxParts)
        {
            this.maxParts = maxParts;
            return this;
        }

        /// <summary>
        /// Checks if MaxParts property is set.
        /// </summary>
        /// <returns>true if MaxParts property is set.</returns>
        internal bool IsSetMaxParts()
        {
            return maxParts.HasValue;
        }

        #endregion

        #region PartNumberMarker

        /// <summary>
        /// Gets and sets the PartNumberMarker property.
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher
        /// part numbers will be listed.
        /// </para>
        /// </summary>
        public string PartNumberMarker
        {
            get { return this.partNumberMarker; }
            set { this.partNumberMarker = value; }
        }

        /// <summary>
        /// Sets the Key property for this request.
        /// </summary>
        /// <param name="partNumberMarker">The value that PartNumberMarker is set to</param>
        /// <returns>the request with the PartNumberMarker set</returns>
        public ListPartsRequest WithPartNumberMarker(string partNumberMarker)
        {
            this.partNumberMarker = partNumberMarker;
            return this;
        }

        /// <summary>
        /// Checks if PartNumberMarker property is set.
        /// </summary>
        /// <returns>true if PartNumberMarker property is set.</returns>
        internal bool IsSetPartNumberMarker()
        {
            return !System.String.IsNullOrEmpty(this.partNumberMarker);
        }

        #endregion
    }
}
