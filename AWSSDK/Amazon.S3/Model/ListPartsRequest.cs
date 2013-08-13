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
    /// The parameters to lists the parts that have been uploaded for a specific multipart upload. 
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
        /// The name of the bucket receiving the multipart upload.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket receiving the multipart upload.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The object key for which the multipart upload was initiated.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets object key for which the multipart upload was initiated.
        /// </summary>
        /// <param name="key">The object key</param>
        /// <returns>the request with the Key set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The upload ID identifying the multipart upload whose parts are being listed.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Sets the upload ID identifying the multipart upload whose parts are being listed.
        /// </summary>
        /// <param name="uploadId">The upload id</param>
        /// <returns>the request with the Key set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The maximum number of parts to return in the response.
        /// </summary>
        public int MaxParts
        {
            get { return this.maxParts.GetValueOrDefault(); }
            set { this.maxParts = value; }
        }

        /// <summary>
        /// Sets the maximum number of parts to return in the response.
        /// </summary>
        /// <param name="maxParts">Maximum parts to return</param>
        /// <returns>the request with the MaxParts set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Specifies the part after which listing should begin. 
        /// Only parts with higher part numbers will be listed.
        /// </summary>
        public string PartNumberMarker
        {
            get { return this.partNumberMarker; }
            set { this.partNumberMarker = value; }
        }

        /// <summary>
        /// Specifies the part after which listing should begin. 
        /// Only parts with higher part numbers will be listed.
        /// </summary>
        /// <param name="partNumberMarker">The part number to start listing from</param>
        /// <returns>the request with the PartNumberMarker set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
